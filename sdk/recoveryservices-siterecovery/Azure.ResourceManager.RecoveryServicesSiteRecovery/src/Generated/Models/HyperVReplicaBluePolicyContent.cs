// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> HyperV Replica Blue policy input. </summary>
    public partial class HyperVReplicaBluePolicyContent : HyperVReplicaPolicyContent
    {
        /// <summary> Initializes a new instance of <see cref="HyperVReplicaBluePolicyContent"/>. </summary>
        public HyperVReplicaBluePolicyContent()
        {
            InstanceType = "HyperVReplica2012R2";
        }

        /// <summary> Initializes a new instance of <see cref="HyperVReplicaBluePolicyContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="recoveryPoints"> A value indicating the number of recovery points. </param>
        /// <param name="applicationConsistentSnapshotFrequencyInHours"> A value indicating the application consistent frequency. </param>
        /// <param name="compression"> A value indicating whether compression has to be enabled. </param>
        /// <param name="initialReplicationMethod"> A value indicating whether IR is online. </param>
        /// <param name="onlineReplicationStartTime"> A value indicating the online IR start time. </param>
        /// <param name="offlineReplicationImportPath"> A value indicating the offline IR import path. </param>
        /// <param name="offlineReplicationExportPath"> A value indicating the offline IR export path. </param>
        /// <param name="replicationPort"> A value indicating the recovery HTTPS port. </param>
        /// <param name="allowedAuthenticationType"> A value indicating the authentication type. </param>
        /// <param name="replicaDeletion"> A value indicating whether the VM has to be auto deleted. </param>
        /// <param name="replicationFrequencyInSeconds"> A value indicating the replication interval. </param>
        internal HyperVReplicaBluePolicyContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, int? recoveryPoints, int? applicationConsistentSnapshotFrequencyInHours, string compression, string initialReplicationMethod, string onlineReplicationStartTime, string offlineReplicationImportPath, string offlineReplicationExportPath, int? replicationPort, int? allowedAuthenticationType, string replicaDeletion, int? replicationFrequencyInSeconds) : base(instanceType, serializedAdditionalRawData, recoveryPoints, applicationConsistentSnapshotFrequencyInHours, compression, initialReplicationMethod, onlineReplicationStartTime, offlineReplicationImportPath, offlineReplicationExportPath, replicationPort, allowedAuthenticationType, replicaDeletion)
        {
            ReplicationFrequencyInSeconds = replicationFrequencyInSeconds;
            InstanceType = instanceType ?? "HyperVReplica2012R2";
        }

        /// <summary> A value indicating the replication interval. </summary>
        public int? ReplicationFrequencyInSeconds { get; set; }
    }
}
