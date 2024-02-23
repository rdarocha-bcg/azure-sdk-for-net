// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> A header to add to the WebTest. </summary>
    public partial class HeaderField
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

        /// <summary> Initializes a new instance of <see cref="HeaderField"/>. </summary>
        public HeaderField()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HeaderField"/>. </summary>
        /// <param name="headerFieldName"> The name of the header. </param>
        /// <param name="headerFieldValue"> The value of the header. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HeaderField(string headerFieldName, string headerFieldValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HeaderFieldName = headerFieldName;
            HeaderFieldValue = headerFieldValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the header. </summary>
        public string HeaderFieldName { get; set; }
        /// <summary> The value of the header. </summary>
        public string HeaderFieldValue { get; set; }
    }
}
