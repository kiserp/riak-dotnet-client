// <copyright file="RiakKeyFilterToken.cs" company="Basho Technologies, Inc.">
// Copyright 2011 - OJ Reeves & Jeremiah Peschka
// Copyright 2014 - Basho Technologies, Inc.
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

namespace RiakClient.Models.MapReduce.KeyFilters
{
    using System;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    internal abstract class RiakKeyFilterToken : IRiakKeyFilterToken
    {
        private readonly Tuple<string, object, object> keyFilterDefinition;

        protected RiakKeyFilterToken()
        {
        }

        protected RiakKeyFilterToken(string functionName, params object[] args)
        {
            keyFilterDefinition = new Tuple<string, object, object>(functionName, args[0], args[1]);
        }

        public string FunctionName
        {
            get { return keyFilterDefinition.Item1; }
        }

        public object[] Arguments
        {
            get { return new[] { keyFilterDefinition.Item2, keyFilterDefinition.Item3 }; }
        }

        public override string ToString()
        {
            return ToJsonString();
        }

        public string ToJsonString()
        {
            /*
             * NB: JsonTextWriter is guaranteed to close the StringWriter
             * https://github.com/JamesNK/Newtonsoft.Json/blob/master/Src/Newtonsoft.Json/JsonTextWriter.cs#L150-L160
             */
            var sb = new StringBuilder();
            var sw = new StringWriter(sb);
            using (JsonWriter jw = new JsonTextWriter(sw))
            {
                jw.WriteStartArray();
                jw.WriteValue(FunctionName);

                WriteArguments(jw);

                jw.WriteEndArray();
            }

            return sb.ToString();
        }

        protected virtual void WriteArguments(JsonWriter writer)
        {
            writer.WriteValue(keyFilterDefinition.Item2);
            writer.WriteValue(keyFilterDefinition.Item3);
        }
    }
}
