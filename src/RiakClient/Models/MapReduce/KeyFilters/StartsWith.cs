// <copyright file="StartsWith.cs" company="Basho Technologies, Inc.">
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

namespace RiakClient.Models.MapReduce.KeyFilters
{
    using System;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Tests that the input begins with the argument (a string).
    /// </summary>
    internal class StartsWith : IRiakKeyFilterToken
    {
        private readonly Tuple<string, string> keyFilterDefinition;

        public StartsWith(string arg)
        {
            keyFilterDefinition = Tuple.Create("starts_with", arg);
        }

        public string FunctionName
        {
            get { return keyFilterDefinition.Item1; }
        }

        public string Argument
        {
            get { return keyFilterDefinition.Item2; }
        }

        public override string ToString()
        {
            return ToJsonString();
        }

        public string ToJsonString()
        {
            var sb = new StringBuilder();

            using (var sw = new StringWriter(sb))
            {
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    jw.WriteStartArray();

                    jw.WriteValue(FunctionName);
                    jw.WriteValue(Argument);

                    jw.WriteEndArray();
                }
            }

            return sb.ToString();
        }
    }
}
