// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing the SnapshotPolicy data model.
    /// Snapshot policy information
    /// </summary>
    public partial class SnapshotPolicyData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="SnapshotPolicyData"/>. </summary>
        /// <param name="location"> The location. </param>
        public SnapshotPolicyData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="hourlySchedule"> Schedule for hourly snapshots. </param>
        /// <param name="dailySchedule"> Schedule for daily snapshots. </param>
        /// <param name="weeklySchedule"> Schedule for weekly snapshots. </param>
        /// <param name="monthlySchedule"> Schedule for monthly snapshots. </param>
        /// <param name="isEnabled"> The property to decide policy is enabled or not. </param>
        /// <param name="provisioningState"> Azure lifecycle management. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SnapshotPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, SnapshotPolicyHourlySchedule hourlySchedule, SnapshotPolicyDailySchedule dailySchedule, SnapshotPolicyWeeklySchedule weeklySchedule, SnapshotPolicyMonthlySchedule monthlySchedule, bool? isEnabled, string provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            HourlySchedule = hourlySchedule;
            DailySchedule = dailySchedule;
            WeeklySchedule = weeklySchedule;
            MonthlySchedule = monthlySchedule;
            IsEnabled = isEnabled;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotPolicyData"/> for deserialization. </summary>
        internal SnapshotPolicyData()
        {
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Schedule for hourly snapshots. </summary>
        public SnapshotPolicyHourlySchedule HourlySchedule { get; set; }
        /// <summary> Schedule for daily snapshots. </summary>
        public SnapshotPolicyDailySchedule DailySchedule { get; set; }
        /// <summary> Schedule for weekly snapshots. </summary>
        public SnapshotPolicyWeeklySchedule WeeklySchedule { get; set; }
        /// <summary> Schedule for monthly snapshots. </summary>
        public SnapshotPolicyMonthlySchedule MonthlySchedule { get; set; }
        /// <summary> The property to decide policy is enabled or not. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Azure lifecycle management. </summary>
        public string ProvisioningState { get; }
    }
}
