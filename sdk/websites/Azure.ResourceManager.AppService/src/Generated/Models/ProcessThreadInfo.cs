// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Process Thread Information. </summary>
    public partial class ProcessThreadInfo : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ProcessThreadInfo"/>. </summary>
        public ProcessThreadInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProcessThreadInfo"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identifier"> Site extension ID. </param>
        /// <param name="href"> HRef URI. </param>
        /// <param name="process"> Process URI. </param>
        /// <param name="startAddress"> Start address. </param>
        /// <param name="currentPriority"> Current thread priority. </param>
        /// <param name="priorityLevel"> Thread priority level. </param>
        /// <param name="basePriority"> Base priority. </param>
        /// <param name="startOn"> Start time. </param>
        /// <param name="totalProcessorTime"> Total processor time. </param>
        /// <param name="userProcessorTime"> User processor time. </param>
        /// <param name="state"> Thread state. </param>
        /// <param name="waitReason"> Wait reason. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProcessThreadInfo(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? identifier, string href, string process, string startAddress, int? currentPriority, string priorityLevel, int? basePriority, DateTimeOffset? startOn, string totalProcessorTime, string userProcessorTime, string state, string waitReason, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Identifier = identifier;
            Href = href;
            Process = process;
            StartAddress = startAddress;
            CurrentPriority = currentPriority;
            PriorityLevel = priorityLevel;
            BasePriority = basePriority;
            StartOn = startOn;
            TotalProcessorTime = totalProcessorTime;
            UserProcessorTime = userProcessorTime;
            State = state;
            WaitReason = waitReason;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Site extension ID. </summary>
        public int? Identifier { get; }
        /// <summary> HRef URI. </summary>
        public string Href { get; set; }
        /// <summary> Process URI. </summary>
        public string Process { get; set; }
        /// <summary> Start address. </summary>
        public string StartAddress { get; set; }
        /// <summary> Current thread priority. </summary>
        public int? CurrentPriority { get; set; }
        /// <summary> Thread priority level. </summary>
        public string PriorityLevel { get; set; }
        /// <summary> Base priority. </summary>
        public int? BasePriority { get; set; }
        /// <summary> Start time. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> Total processor time. </summary>
        public string TotalProcessorTime { get; set; }
        /// <summary> User processor time. </summary>
        public string UserProcessorTime { get; set; }
        /// <summary> Thread state. </summary>
        public string State { get; set; }
        /// <summary> Wait reason. </summary>
        public string WaitReason { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
