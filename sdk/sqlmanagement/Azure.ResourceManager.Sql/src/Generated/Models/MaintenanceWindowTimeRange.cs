// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Maintenance window time range. </summary>
    public partial class MaintenanceWindowTimeRange
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

        /// <summary> Initializes a new instance of <see cref="MaintenanceWindowTimeRange"/>. </summary>
        public MaintenanceWindowTimeRange()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MaintenanceWindowTimeRange"/>. </summary>
        /// <param name="dayOfWeek"> Day of maintenance window. </param>
        /// <param name="startTime"> Start time minutes offset from 12am. </param>
        /// <param name="duration"> Duration of maintenance window in minutes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MaintenanceWindowTimeRange(SqlDayOfWeek? dayOfWeek, string startTime, TimeSpan? duration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DayOfWeek = dayOfWeek;
            StartTime = startTime;
            Duration = duration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Day of maintenance window. </summary>
        public SqlDayOfWeek? DayOfWeek { get; set; }
        /// <summary> Start time minutes offset from 12am. </summary>
        public string StartTime { get; set; }
        /// <summary> Duration of maintenance window in minutes. </summary>
        public TimeSpan? Duration { get; set; }
    }
}
