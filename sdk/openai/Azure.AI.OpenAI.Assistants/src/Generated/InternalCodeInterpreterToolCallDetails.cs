// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The detailed information about a code interpreter invocation by the model. </summary>
    internal partial class InternalCodeInterpreterToolCallDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InternalCodeInterpreterToolCallDetails"/>. </summary>
        /// <param name="input"> The input provided by the model to the code interpreter tool. </param>
        /// <param name="outputs"> The outputs produced by the code interpreter tool back to the model in response to the tool call. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> or <paramref name="outputs"/> is null. </exception>
        internal InternalCodeInterpreterToolCallDetails(string input, IEnumerable<RunStepCodeInterpreterToolCallOutput> outputs)
        {
            Argument.AssertNotNull(input, nameof(input));
            Argument.AssertNotNull(outputs, nameof(outputs));

            Input = input;
            Outputs = outputs.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="InternalCodeInterpreterToolCallDetails"/>. </summary>
        /// <param name="input"> The input provided by the model to the code interpreter tool. </param>
        /// <param name="outputs"> The outputs produced by the code interpreter tool back to the model in response to the tool call. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalCodeInterpreterToolCallDetails(string input, IReadOnlyList<RunStepCodeInterpreterToolCallOutput> outputs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Input = input;
            Outputs = outputs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InternalCodeInterpreterToolCallDetails"/> for deserialization. </summary>
        internal InternalCodeInterpreterToolCallDetails()
        {
        }

        /// <summary> The input provided by the model to the code interpreter tool. </summary>
        public string Input { get; }
        /// <summary>
        /// The outputs produced by the code interpreter tool back to the model in response to the tool call.
        /// Please note <see cref="RunStepCodeInterpreterToolCallOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RunStepCodeInterpreterLogOutput"/> and <see cref="RunStepCodeInterpreterImageOutput"/>.
        /// </summary>
        public IReadOnlyList<RunStepCodeInterpreterToolCallOutput> Outputs { get; }
    }
}
