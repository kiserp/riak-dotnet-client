// <copyright file="RiakConnection.cs" company="Basho Technologies, Inc.">
// Copyright (c) 2011 - OJ Reeves & Jeremiah Peschka
// Copyright (c) 2014 - Basho Technologies, Inc.
//
// This file is provided to you under the Apache License,
// Version 2.0 (the "License"); you may not use this file
// except in compliance with the License.  You may obtain
// a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
// </copyright>

namespace RiakClient.Comms
{
    using System;
    using System.Collections.Generic;
    using Config;
    using Exceptions;
    using Messages;

    internal class RiakConnection : IRiakConnection
    {
        private readonly RiakPbcSocket socket;

        public RiakConnection(IRiakNodeConfiguration nodeConfiguration, IRiakAuthenticationConfiguration authConfiguration)
        {
            socket = new RiakPbcSocket(nodeConfiguration, authConfiguration);
        }

        public RiakResult<TResult> PbcRead<TResult>()
            where TResult : class, new()
        {
            try
            {
                var result = socket.Read<TResult>();
                return RiakResult<TResult>.Success(result);
            }
            catch (RiakException ex)
            {
                if (ex.NodeOffline)
                {
                    Disconnect();
                }

                if (ex.Message.Contains("Bucket cannot be zero-length")
                    || ex.Message.Contains("Key cannot be zero-length"))
                {
                    return RiakResult<TResult>.Error(ResultCode.InvalidRequest, ex.Message, ex.NodeOffline);
                }

                return RiakResult<TResult>.Error(ResultCode.CommunicationError, ex.Message, ex.NodeOffline);
            }
            catch (Exception ex)
            {
                Disconnect();
                return RiakResult<TResult>.Error(ResultCode.CommunicationError, ex.Message, true);
            }
        }

        public RiakResult PbcRead(MessageCode expectedMessageCode)
        {
            try
            {
                socket.Read(expectedMessageCode);
                return RiakResult.Success();
            }
            catch (RiakException ex)
            {
                if (ex.NodeOffline)
                {
                    Disconnect();
                }

                return RiakResult.Error(ResultCode.CommunicationError, ex.Message, ex.NodeOffline);
            }
            catch (Exception ex)
            {
                Disconnect();
                return RiakResult.Error(ResultCode.CommunicationError, ex.Message, true);
            }
        }

        public RiakResult<IEnumerable<RiakResult<TResult>>> PbcRepeatRead<TResult>(Func<RiakResult<TResult>, bool> repeatRead)
            where TResult : class, new()
        {
            var results = new List<RiakResult<TResult>>();
            try
            {
                RiakResult<TResult> result;

                do
                {
                    result = RiakResult<TResult>.Success(socket.Read<TResult>());
                    results.Add(result);
                }
                while (repeatRead(result));

                return RiakResult<IEnumerable<RiakResult<TResult>>>.Success(results);
            }
            catch (RiakException ex)
            {
                if (ex.NodeOffline)
                {
                    Disconnect();
                }

                return RiakResult<IEnumerable<RiakResult<TResult>>>.Error(ResultCode.CommunicationError, ex.Message, ex.NodeOffline);
            }
            catch (Exception ex)
            {
                Disconnect();
                return RiakResult<IEnumerable<RiakResult<TResult>>>.Error(ResultCode.CommunicationError, ex.Message, true);
            }
        }

        public RiakResult PbcWrite<TRequest>(TRequest request)
            where TRequest : class
        {
            try
            {
                socket.Write(request);
                return RiakResult.Success();
            }
            catch (RiakException ex)
            {
                if (ex.NodeOffline)
                {
                    Disconnect();
                }

                return RiakResult.Error(ResultCode.CommunicationError, ex.Message, ex.NodeOffline);
            }
            catch (Exception ex)
            {
                Disconnect();
                return RiakResult.Error(ResultCode.CommunicationError, ex.Message, true);
            }
        }

        public RiakResult PbcWrite(MessageCode messageCode)
        {
            try
            {
                socket.Write(messageCode);
                return RiakResult.Success();
            }
            catch (RiakException ex)
            {
                if (ex.NodeOffline)
                {
                    Disconnect();
                }

                // TODO: we really should preserve the Exception object
                return RiakResult.Error(ResultCode.CommunicationError, ex.Message, ex.NodeOffline);
            }
            catch (Exception ex)
            {
                Disconnect();
                return RiakResult.Error(ResultCode.CommunicationError, ex.Message, true);
            }
        }

        public RiakResult<TResult> PbcWriteRead<TRequest, TResult>(TRequest request)
            where TRequest : class
            where TResult : class, new()
        {
            var writeResult = PbcWrite(request);

            if (writeResult.IsSuccess)
            {
                return PbcRead<TResult>();
            }

            return RiakResult<TResult>.Error(writeResult.ResultCode, writeResult.ErrorMessage, writeResult.NodeOffline);
        }

        public RiakResult PbcWriteRead<TRequest>(TRequest request, MessageCode expectedMessageCode)
            where TRequest : class
        {
            var writeResult = PbcWrite(request);

            if (writeResult.IsSuccess)
            {
                return PbcRead(expectedMessageCode);
            }

            return RiakResult.Error(writeResult.ResultCode, writeResult.ErrorMessage, writeResult.NodeOffline);
        }

        public RiakResult<TResult> PbcWriteRead<TResult>(MessageCode messageCode)
            where TResult : class, new()
        {
            var writeResult = PbcWrite(messageCode);

            if (writeResult.IsSuccess)
            {
                return PbcRead<TResult>();
            }

            return RiakResult<TResult>.Error(writeResult.ResultCode, writeResult.ErrorMessage, writeResult.NodeOffline);
        }

        public RiakResult PbcWriteRead(MessageCode messageCode, MessageCode expectedMessageCode)
        {
            var writeResult = PbcWrite(messageCode);

            if (writeResult.IsSuccess)
            {
                return PbcRead(expectedMessageCode);
            }

            return RiakResult.Error(writeResult.ResultCode, writeResult.ErrorMessage, writeResult.NodeOffline);
        }

        public RiakResult<IEnumerable<RiakResult<TResult>>> PbcWriteRead<TRequest, TResult>(
            TRequest request,
            Func<RiakResult<TResult>, bool> repeatRead)
            where TRequest : class
            where TResult : class, new()
        {
            var writeResult = PbcWrite(request);

            if (writeResult.IsSuccess)
            {
                return PbcRepeatRead(repeatRead);
            }

            return RiakResult<IEnumerable<RiakResult<TResult>>>.Error(writeResult.ResultCode, writeResult.ErrorMessage, writeResult.NodeOffline);
        }

        public RiakResult<IEnumerable<RiakResult<TResult>>> PbcWriteRead<TResult>(
            MessageCode messageCode,
            Func<RiakResult<TResult>, bool> repeatRead)
            where TResult : class, new()
        {
            var writeResult = PbcWrite(messageCode);

            if (writeResult.IsSuccess)
            {
                return PbcRepeatRead(repeatRead);
            }

            return RiakResult<IEnumerable<RiakResult<TResult>>>.Error(writeResult.ResultCode, writeResult.ErrorMessage, writeResult.NodeOffline);
        }

        public RiakResult<IEnumerable<RiakResult<TResult>>> PbcStreamRead<TResult>(Func<RiakResult<TResult>, bool> repeatRead, Action onFinish)
            where TResult : class, new()
        {
            var streamer = PbcStreamReadIterator(repeatRead, onFinish);
            return RiakResult<IEnumerable<RiakResult<TResult>>>.Success(streamer);
        }

        public RiakResult<IEnumerable<RiakResult<TResult>>> PbcWriteStreamRead<TRequest, TResult>(
            TRequest request,
            Func<RiakResult<TResult>, bool> repeatRead,
            Action onFinish)
            where TRequest : class
            where TResult : class, new()
        {
            var streamer = PbcWriteStreamReadIterator(request, repeatRead, onFinish);
            return RiakResult<IEnumerable<RiakResult<TResult>>>.Success(streamer);
        }

        public RiakResult<IEnumerable<RiakResult<TResult>>> PbcWriteStreamRead<TResult>(
            MessageCode messageCode,
            Func<RiakResult<TResult>, bool> repeatRead,
            Action onFinish)
            where TResult : class, new()
        {
            var streamer = PbcWriteStreamReadIterator(messageCode, repeatRead, onFinish);
            return RiakResult<IEnumerable<RiakResult<TResult>>>.Success(streamer);
        }

        public void Dispose()
        {
            socket.Dispose();
            Disconnect();
        }

        public void Disconnect()
        {
            socket.Disconnect();
        }

        private IEnumerable<RiakResult<TResult>> PbcWriteStreamReadIterator<TResult>(
            MessageCode messageCode,
            Func<RiakResult<TResult>, bool> repeatRead,
            Action onFinish)
            where TResult : class, new()
        {
            var writeResult = PbcWrite(messageCode);

            if (writeResult.IsSuccess)
            {
                return PbcStreamReadIterator(repeatRead, onFinish);
            }

            onFinish();

            return new[] { RiakResult<TResult>.Error(writeResult.ResultCode, writeResult.ErrorMessage, writeResult.NodeOffline) };
        }

        private IEnumerable<RiakResult<TResult>> PbcStreamReadIterator<TResult>(Func<RiakResult<TResult>, bool> repeatRead, Action onFinish)
            where TResult : class, new()
        {
            RiakResult<TResult> result;

            do
            {
                result = PbcRead<TResult>();

                if (!result.IsSuccess)
                {
                    break;
                }

                yield return result;
            }
            while (repeatRead(result));

            // clean up first..
            onFinish();

            // then return the failure to the client to indicate failure
            yield return result;
        }

        private IEnumerable<RiakResult<TResult>> PbcWriteStreamReadIterator<TRequest, TResult>(
            TRequest request,
            Func<RiakResult<TResult>, bool> repeatRead,
            Action onFinish)
            where TRequest : class
            where TResult : class, new()
        {
            var writeResult = PbcWrite(request);

            if (writeResult.IsSuccess)
            {
                return PbcStreamReadIterator(repeatRead, onFinish);
            }

            onFinish();

            return new[] { RiakResult<TResult>.Error(writeResult.ResultCode, writeResult.ErrorMessage, writeResult.NodeOffline) };
        }
    }
}
