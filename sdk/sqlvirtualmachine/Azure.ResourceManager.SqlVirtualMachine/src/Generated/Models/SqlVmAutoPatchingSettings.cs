// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Set a patching window during which Windows and SQL patches will be applied. </summary>
    public partial class SqlVmAutoPatchingSettings
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

        /// <summary> Initializes a new instance of <see cref="SqlVmAutoPatchingSettings"/>. </summary>
        public SqlVmAutoPatchingSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlVmAutoPatchingSettings"/>. </summary>
        /// <param name="isEnabled"> Enable or disable autopatching on SQL virtual machine. </param>
        /// <param name="dayOfWeek"> Day of week to apply the patch on. </param>
        /// <param name="maintenanceWindowStartingHour"> Hour of the day when patching is initiated. Local VM time. </param>
        /// <param name="maintenanceWindowDurationInMinutes"> Duration of patching. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlVmAutoPatchingSettings(bool? isEnabled, SqlVmAutoPatchingDayOfWeek? dayOfWeek, int? maintenanceWindowStartingHour, int? maintenanceWindowDurationInMinutes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            DayOfWeek = dayOfWeek;
            MaintenanceWindowStartingHour = maintenanceWindowStartingHour;
            MaintenanceWindowDurationInMinutes = maintenanceWindowDurationInMinutes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Enable or disable autopatching on SQL virtual machine. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Day of week to apply the patch on. </summary>
        public SqlVmAutoPatchingDayOfWeek? DayOfWeek { get; set; }
        /// <summary> Hour of the day when patching is initiated. Local VM time. </summary>
        public int? MaintenanceWindowStartingHour { get; set; }
        /// <summary> Duration of patching. </summary>
        public int? MaintenanceWindowDurationInMinutes { get; set; }
    }
}
