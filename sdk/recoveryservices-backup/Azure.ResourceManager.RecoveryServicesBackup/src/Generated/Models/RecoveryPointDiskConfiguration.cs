// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Disk configuration. </summary>
    public partial class RecoveryPointDiskConfiguration
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

        /// <summary> Initializes a new instance of <see cref="RecoveryPointDiskConfiguration"/>. </summary>
        public RecoveryPointDiskConfiguration()
        {
            IncludedDiskList = new ChangeTrackingList<DiskInformation>();
            ExcludedDiskList = new ChangeTrackingList<DiskInformation>();
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPointDiskConfiguration"/>. </summary>
        /// <param name="numberOfDisksIncludedInBackup"> Number of disks included in backup. </param>
        /// <param name="numberOfDisksAttachedToVm"> Number of disks attached to the VM. </param>
        /// <param name="includedDiskList"> Information of disks included in backup. </param>
        /// <param name="excludedDiskList"> Information of disks excluded from backup. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecoveryPointDiskConfiguration(int? numberOfDisksIncludedInBackup, int? numberOfDisksAttachedToVm, IList<DiskInformation> includedDiskList, IList<DiskInformation> excludedDiskList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NumberOfDisksIncludedInBackup = numberOfDisksIncludedInBackup;
            NumberOfDisksAttachedToVm = numberOfDisksAttachedToVm;
            IncludedDiskList = includedDiskList;
            ExcludedDiskList = excludedDiskList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Number of disks included in backup. </summary>
        public int? NumberOfDisksIncludedInBackup { get; set; }
        /// <summary> Number of disks attached to the VM. </summary>
        public int? NumberOfDisksAttachedToVm { get; set; }
        /// <summary> Information of disks included in backup. </summary>
        public IList<DiskInformation> IncludedDiskList { get; }
        /// <summary> Information of disks excluded from backup. </summary>
        public IList<DiskInformation> ExcludedDiskList { get; }
    }
}
