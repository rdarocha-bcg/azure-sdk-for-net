// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Request parameters for tiering cost info for policy. </summary>
    public partial class FetchTieringCostSavingsInfoForPolicyContent : FetchTieringCostInfoContent
    {
        /// <summary> Initializes a new instance of <see cref="FetchTieringCostSavingsInfoForPolicyContent"/>. </summary>
        /// <param name="sourceTierType"> Source tier for the request. </param>
        /// <param name="targetTierType"> target tier for the request. </param>
        /// <param name="policyName"> Name of the backup policy for which the cost savings information is requested. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyName"/> is null. </exception>
        public FetchTieringCostSavingsInfoForPolicyContent(RecoveryPointTierType sourceTierType, RecoveryPointTierType targetTierType, string policyName) : base(sourceTierType, targetTierType)
        {
            Argument.AssertNotNull(policyName, nameof(policyName));

            PolicyName = policyName;
            ObjectType = "FetchTieringCostSavingsInfoForPolicyRequest";
        }

        /// <summary> Initializes a new instance of <see cref="FetchTieringCostSavingsInfoForPolicyContent"/>. </summary>
        /// <param name="sourceTierType"> Source tier for the request. </param>
        /// <param name="targetTierType"> target tier for the request. </param>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="policyName"> Name of the backup policy for which the cost savings information is requested. </param>
        internal FetchTieringCostSavingsInfoForPolicyContent(RecoveryPointTierType sourceTierType, RecoveryPointTierType targetTierType, string objectType, IDictionary<string, BinaryData> serializedAdditionalRawData, string policyName) : base(sourceTierType, targetTierType, objectType, serializedAdditionalRawData)
        {
            PolicyName = policyName;
            ObjectType = objectType ?? "FetchTieringCostSavingsInfoForPolicyRequest";
        }

        /// <summary> Initializes a new instance of <see cref="FetchTieringCostSavingsInfoForPolicyContent"/> for deserialization. </summary>
        internal FetchTieringCostSavingsInfoForPolicyContent()
        {
        }

        /// <summary> Name of the backup policy for which the cost savings information is requested. </summary>
        public string PolicyName { get; }
    }
}
