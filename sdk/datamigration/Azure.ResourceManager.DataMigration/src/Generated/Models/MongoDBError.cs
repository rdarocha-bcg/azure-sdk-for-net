// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes an error or warning that occurred during a MongoDB migration. </summary>
    public partial class MongoDBError
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

        /// <summary> Initializes a new instance of <see cref="MongoDBError"/>. </summary>
        internal MongoDBError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBError"/>. </summary>
        /// <param name="code"> The non-localized, machine-readable code that describes the error or warning. </param>
        /// <param name="count"> The number of times the error or warning has occurred. </param>
        /// <param name="message"> The localized, human-readable message that describes the error or warning. </param>
        /// <param name="errorType"> The type of error or warning. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBError(string code, int? count, string message, MongoDBErrorType? errorType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Count = count;
            Message = message;
            ErrorType = errorType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The non-localized, machine-readable code that describes the error or warning. </summary>
        public string Code { get; }
        /// <summary> The number of times the error or warning has occurred. </summary>
        public int? Count { get; }
        /// <summary> The localized, human-readable message that describes the error or warning. </summary>
        public string Message { get; }
        /// <summary> The type of error or warning. </summary>
        public MongoDBErrorType? ErrorType { get; }
    }
}
