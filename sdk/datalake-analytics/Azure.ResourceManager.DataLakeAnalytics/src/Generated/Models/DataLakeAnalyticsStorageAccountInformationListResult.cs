// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataLakeAnalytics;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// Azure Storage account list information.
    /// Serialized Name: StorageAccountInformationListResult
    /// </summary>
    internal partial class DataLakeAnalyticsStorageAccountInformationListResult
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

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsStorageAccountInformationListResult"/>. </summary>
        internal DataLakeAnalyticsStorageAccountInformationListResult()
        {
            Value = new ChangeTrackingList<DataLakeAnalyticsStorageAccountInformationData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsStorageAccountInformationListResult"/>. </summary>
        /// <param name="value">
        /// The results of the list operation.
        /// Serialized Name: StorageAccountInformationListResult.value
        /// </param>
        /// <param name="nextLink">
        /// The link (url) to the next page of results.
        /// Serialized Name: StorageAccountInformationListResult.nextLink
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeAnalyticsStorageAccountInformationListResult(IReadOnlyList<DataLakeAnalyticsStorageAccountInformationData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The results of the list operation.
        /// Serialized Name: StorageAccountInformationListResult.value
        /// </summary>
        public IReadOnlyList<DataLakeAnalyticsStorageAccountInformationData> Value { get; }
        /// <summary>
        /// The link (url) to the next page of results.
        /// Serialized Name: StorageAccountInformationListResult.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
