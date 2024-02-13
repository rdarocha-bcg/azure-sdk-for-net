// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm specific policy details. </summary>
    public partial class InMageRcmPolicyDetails : PolicyProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="InMageRcmPolicyDetails"/>. </summary>
        internal InMageRcmPolicyDetails()
        {
            InstanceType = "InMageRcm";
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmPolicyDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="recoveryPointHistoryInMinutes"> The duration in minutes until which the recovery points need to be stored. </param>
        /// <param name="appConsistentFrequencyInMinutes"> The app consistent snapshot frequency in minutes. </param>
        /// <param name="crashConsistentFrequencyInMinutes"> The crash consistent snapshot frequency in minutes. </param>
        /// <param name="enableMultiVmSync"> A value indicating whether multi-VM sync has to be enabled. </param>
        internal InMageRcmPolicyDetails(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, int? recoveryPointHistoryInMinutes, int? appConsistentFrequencyInMinutes, int? crashConsistentFrequencyInMinutes, string enableMultiVmSync) : base(instanceType, serializedAdditionalRawData)
        {
            RecoveryPointHistoryInMinutes = recoveryPointHistoryInMinutes;
            AppConsistentFrequencyInMinutes = appConsistentFrequencyInMinutes;
            CrashConsistentFrequencyInMinutes = crashConsistentFrequencyInMinutes;
            EnableMultiVmSync = enableMultiVmSync;
            InstanceType = instanceType ?? "InMageRcm";
        }

        /// <summary> The duration in minutes until which the recovery points need to be stored. </summary>
        public int? RecoveryPointHistoryInMinutes { get; }
        /// <summary> The app consistent snapshot frequency in minutes. </summary>
        public int? AppConsistentFrequencyInMinutes { get; }
        /// <summary> The crash consistent snapshot frequency in minutes. </summary>
        public int? CrashConsistentFrequencyInMinutes { get; }
        /// <summary> A value indicating whether multi-VM sync has to be enabled. </summary>
        public string EnableMultiVmSync { get; }
    }
}
