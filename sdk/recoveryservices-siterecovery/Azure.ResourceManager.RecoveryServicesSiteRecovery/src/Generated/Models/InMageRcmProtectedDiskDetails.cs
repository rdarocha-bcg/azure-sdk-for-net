// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm protected disk details. </summary>
    public partial class InMageRcmProtectedDiskDetails
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

        /// <summary> Initializes a new instance of <see cref="InMageRcmProtectedDiskDetails"/>. </summary>
        internal InMageRcmProtectedDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmProtectedDiskDetails"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <param name="diskName"> The disk name. </param>
        /// <param name="isOSDisk"> A value indicating whether the disk is the OS disk. </param>
        /// <param name="capacityInBytes"> The disk capacity in bytes. </param>
        /// <param name="logStorageAccountId"> The log storage account ARM Id. </param>
        /// <param name="diskEncryptionSetId"> The DiskEncryptionSet ARM Id. </param>
        /// <param name="seedManagedDiskId"> The ARM Id of the seed managed disk. </param>
        /// <param name="seedBlobUri"> The uri of the seed blob. </param>
        /// <param name="targetManagedDiskId"> The ARM Id of the target managed disk. </param>
        /// <param name="diskType"> The disk type. </param>
        /// <param name="dataPendingInLogDataStoreInMB"> The data pending in log data store in MB. </param>
        /// <param name="dataPendingAtSourceAgentInMB"> The data pending at source agent in MB. </param>
        /// <param name="isInitialReplicationComplete"> A value indicating whether initial replication is complete or not. </param>
        /// <param name="irDetails"> The initial replication details. </param>
        /// <param name="resyncDetails"> The resync details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageRcmProtectedDiskDetails(string diskId, string diskName, string isOSDisk, long? capacityInBytes, ResourceIdentifier logStorageAccountId, ResourceIdentifier diskEncryptionSetId, string seedManagedDiskId, Uri seedBlobUri, string targetManagedDiskId, SiteRecoveryDiskAccountType? diskType, double? dataPendingInLogDataStoreInMB, double? dataPendingAtSourceAgentInMB, string isInitialReplicationComplete, InMageRcmSyncDetails irDetails, InMageRcmSyncDetails resyncDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskId = diskId;
            DiskName = diskName;
            IsOSDisk = isOSDisk;
            CapacityInBytes = capacityInBytes;
            LogStorageAccountId = logStorageAccountId;
            DiskEncryptionSetId = diskEncryptionSetId;
            SeedManagedDiskId = seedManagedDiskId;
            SeedBlobUri = seedBlobUri;
            TargetManagedDiskId = targetManagedDiskId;
            DiskType = diskType;
            DataPendingInLogDataStoreInMB = dataPendingInLogDataStoreInMB;
            DataPendingAtSourceAgentInMB = dataPendingAtSourceAgentInMB;
            IsInitialReplicationComplete = isInitialReplicationComplete;
            IrDetails = irDetails;
            ResyncDetails = resyncDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; }
        /// <summary> The disk name. </summary>
        public string DiskName { get; }
        /// <summary> A value indicating whether the disk is the OS disk. </summary>
        public string IsOSDisk { get; }
        /// <summary> The disk capacity in bytes. </summary>
        public long? CapacityInBytes { get; }
        /// <summary> The log storage account ARM Id. </summary>
        public ResourceIdentifier LogStorageAccountId { get; }
        /// <summary> The DiskEncryptionSet ARM Id. </summary>
        public ResourceIdentifier DiskEncryptionSetId { get; }
        /// <summary> The ARM Id of the seed managed disk. </summary>
        public string SeedManagedDiskId { get; }
        /// <summary> The uri of the seed blob. </summary>
        public Uri SeedBlobUri { get; }
        /// <summary> The ARM Id of the target managed disk. </summary>
        public string TargetManagedDiskId { get; }
        /// <summary> The disk type. </summary>
        public SiteRecoveryDiskAccountType? DiskType { get; }
        /// <summary> The data pending in log data store in MB. </summary>
        public double? DataPendingInLogDataStoreInMB { get; }
        /// <summary> The data pending at source agent in MB. </summary>
        public double? DataPendingAtSourceAgentInMB { get; }
        /// <summary> A value indicating whether initial replication is complete or not. </summary>
        public string IsInitialReplicationComplete { get; }
        /// <summary> The initial replication details. </summary>
        public InMageRcmSyncDetails IrDetails { get; }
        /// <summary> The resync details. </summary>
        public InMageRcmSyncDetails ResyncDetails { get; }
    }
}
