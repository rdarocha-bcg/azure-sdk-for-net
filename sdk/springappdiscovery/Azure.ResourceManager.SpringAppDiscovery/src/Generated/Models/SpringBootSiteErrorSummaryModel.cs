// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SpringAppDiscovery.Models
{
    /// <summary>
    /// ErrorSummary model.
    /// Serialized Name: ErrorSummaryModel
    /// </summary>
    public partial class SpringBootSiteErrorSummaryModel
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

        /// <summary> Initializes a new instance of <see cref="SpringBootSiteErrorSummaryModel"/>. </summary>
        public SpringBootSiteErrorSummaryModel()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SpringBootSiteErrorSummaryModel"/>. </summary>
        /// <param name="affectedResourceType">
        /// The type of Object.
        /// Serialized Name: ErrorSummaryModel.affectedResourceType
        /// </param>
        /// <param name="affectedObjectsCount">
        /// The count.
        /// Serialized Name: ErrorSummaryModel.affectedObjectsCount
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SpringBootSiteErrorSummaryModel(string affectedResourceType, long? affectedObjectsCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AffectedResourceType = affectedResourceType;
            AffectedObjectsCount = affectedObjectsCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The type of Object.
        /// Serialized Name: ErrorSummaryModel.affectedResourceType
        /// </summary>
        public string AffectedResourceType { get; set; }
        /// <summary>
        /// The count.
        /// Serialized Name: ErrorSummaryModel.affectedObjectsCount
        /// </summary>
        public long? AffectedObjectsCount { get; set; }
    }
}
