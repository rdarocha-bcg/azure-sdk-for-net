// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The ContainerCpuUsage. </summary>
    public partial class ContainerCpuUsage
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

        /// <summary> Initializes a new instance of <see cref="ContainerCpuUsage"/>. </summary>
        public ContainerCpuUsage()
        {
            PerCpuUsage = new ChangeTrackingList<long>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerCpuUsage"/>. </summary>
        /// <param name="totalUsage"></param>
        /// <param name="perCpuUsage"></param>
        /// <param name="kernelModeUsage"></param>
        /// <param name="userModeUsage"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerCpuUsage(long? totalUsage, IList<long> perCpuUsage, long? kernelModeUsage, long? userModeUsage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TotalUsage = totalUsage;
            PerCpuUsage = perCpuUsage;
            KernelModeUsage = kernelModeUsage;
            UserModeUsage = userModeUsage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the total usage. </summary>
        public long? TotalUsage { get; set; }
        /// <summary> Gets the per cpu usage. </summary>
        public IList<long> PerCpuUsage { get; }
        /// <summary> Gets or sets the kernel mode usage. </summary>
        public long? KernelModeUsage { get; set; }
        /// <summary> Gets or sets the user mode usage. </summary>
        public long? UserModeUsage { get; set; }
    }
}
