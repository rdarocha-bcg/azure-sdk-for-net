// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Defines a unique Support Topic. </summary>
    public partial class DetectorSupportTopic
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

        /// <summary> Initializes a new instance of <see cref="DetectorSupportTopic"/>. </summary>
        internal DetectorSupportTopic()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DetectorSupportTopic"/>. </summary>
        /// <param name="id"> Support Topic Id. </param>
        /// <param name="pesId"> Unique resource Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DetectorSupportTopic(string id, ResourceIdentifier pesId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            PesId = pesId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Support Topic Id. </summary>
        public string Id { get; }
        /// <summary> Unique resource Id. </summary>
        public ResourceIdentifier PesId { get; }
    }
}
