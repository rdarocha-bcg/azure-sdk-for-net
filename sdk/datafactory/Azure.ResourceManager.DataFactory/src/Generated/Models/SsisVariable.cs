// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Ssis variable. </summary>
    public partial class SsisVariable
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

        /// <summary> Initializes a new instance of <see cref="SsisVariable"/>. </summary>
        internal SsisVariable()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SsisVariable"/>. </summary>
        /// <param name="id"> Variable id. </param>
        /// <param name="name"> Variable name. </param>
        /// <param name="description"> Variable description. </param>
        /// <param name="dataType"> Variable type. </param>
        /// <param name="isSensitive"> Whether variable is sensitive. </param>
        /// <param name="value"> Variable value. </param>
        /// <param name="sensitiveValue"> Variable sensitive value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SsisVariable(long? id, string name, string description, string dataType, bool? isSensitive, string value, string sensitiveValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            Description = description;
            DataType = dataType;
            IsSensitive = isSensitive;
            Value = value;
            SensitiveValue = sensitiveValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Variable id. </summary>
        public long? Id { get; }
        /// <summary> Variable name. </summary>
        public string Name { get; }
        /// <summary> Variable description. </summary>
        public string Description { get; }
        /// <summary> Variable type. </summary>
        public string DataType { get; }
        /// <summary> Whether variable is sensitive. </summary>
        public bool? IsSensitive { get; }
        /// <summary> Variable value. </summary>
        public string Value { get; }
        /// <summary> Variable sensitive value. </summary>
        public string SensitiveValue { get; }
    }
}
