// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> Parameters for a schedule-based autoscale rule, consisting of an array of days + a time and capacity. </summary>
    public partial class HDInsightAutoScaleSchedule
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

        /// <summary> Initializes a new instance of <see cref="HDInsightAutoScaleSchedule"/>. </summary>
        public HDInsightAutoScaleSchedule()
        {
            Days = new ChangeTrackingList<HDInsightDayOfWeek>();
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightAutoScaleSchedule"/>. </summary>
        /// <param name="days"> Days of the week for a schedule-based autoscale rule. </param>
        /// <param name="timeAndCapacity"> Time and capacity for a schedule-based autoscale rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightAutoScaleSchedule(IList<HDInsightDayOfWeek> days, HDInsightAutoScaleTimeAndCapacity timeAndCapacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Days = days;
            TimeAndCapacity = timeAndCapacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Days of the week for a schedule-based autoscale rule. </summary>
        public IList<HDInsightDayOfWeek> Days { get; }
        /// <summary> Time and capacity for a schedule-based autoscale rule. </summary>
        public HDInsightAutoScaleTimeAndCapacity TimeAndCapacity { get; set; }
    }
}
