// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Specifies the operating system settings for the virtual machine. </summary>
    public partial class OSProfileForVmInstance
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

        /// <summary> Initializes a new instance of <see cref="OSProfileForVmInstance"/>. </summary>
        public OSProfileForVmInstance()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OSProfileForVmInstance"/>. </summary>
        /// <param name="computerName"> Gets or sets computer name. </param>
        /// <param name="adminUsername"> Gets or sets administrator username. </param>
        /// <param name="adminPassword"> Sets administrator password. </param>
        /// <param name="guestId"> Gets or sets the guestId. </param>
        /// <param name="osType"> Gets or sets the type of the os. </param>
        /// <param name="osSku"> Gets or sets os sku. </param>
        /// <param name="toolsRunningStatus"> Gets or sets the current running status of VMware Tools running in the guest operating system. </param>
        /// <param name="toolsVersionStatus"> Gets or sets the current version status of VMware Tools installed in the guest operating system. </param>
        /// <param name="toolsVersion"> Gets or sets the current version of VMware Tools. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OSProfileForVmInstance(string computerName, string adminUsername, string adminPassword, string guestId, VMwareOSType? osType, string osSku, string toolsRunningStatus, string toolsVersionStatus, string toolsVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ComputerName = computerName;
            AdminUsername = adminUsername;
            AdminPassword = adminPassword;
            GuestId = guestId;
            OSType = osType;
            OSSku = osSku;
            ToolsRunningStatus = toolsRunningStatus;
            ToolsVersionStatus = toolsVersionStatus;
            ToolsVersion = toolsVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets computer name. </summary>
        public string ComputerName { get; set; }
        /// <summary> Gets or sets administrator username. </summary>
        public string AdminUsername { get; set; }
        /// <summary> Sets administrator password. </summary>
        public string AdminPassword { get; set; }
        /// <summary> Gets or sets the guestId. </summary>
        public string GuestId { get; set; }
        /// <summary> Gets or sets the type of the os. </summary>
        public VMwareOSType? OSType { get; set; }
        /// <summary> Gets or sets os sku. </summary>
        public string OSSku { get; }
        /// <summary> Gets or sets the current running status of VMware Tools running in the guest operating system. </summary>
        public string ToolsRunningStatus { get; }
        /// <summary> Gets or sets the current version status of VMware Tools installed in the guest operating system. </summary>
        public string ToolsVersionStatus { get; }
        /// <summary> Gets or sets the current version of VMware Tools. </summary>
        public string ToolsVersion { get; }
    }
}
