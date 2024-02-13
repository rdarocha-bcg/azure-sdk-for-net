// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Response parameters for tiering cost info for savings. </summary>
    public partial class TieringCostSavingInfo : TieringCostInfo
    {
        /// <summary> Initializes a new instance of <see cref="TieringCostSavingInfo"/>. </summary>
        /// <param name="sourceTierSizeReductionInBytes"> Source tier size reduction in bytes after moving all the recommended backup points to target tier. </param>
        /// <param name="targetTierSizeIncreaseInBytes"> Target tier size increase in bytes after moving all the recommended backup points to target tier. </param>
        /// <param name="retailSourceTierCostPerGBPerMonth"> Source tier retail cost per GB per month. </param>
        /// <param name="retailTargetTierCostPerGBPerMonth"> Target tier retail cost per GB per month. </param>
        internal TieringCostSavingInfo(long sourceTierSizeReductionInBytes, long targetTierSizeIncreaseInBytes, double retailSourceTierCostPerGBPerMonth, double retailTargetTierCostPerGBPerMonth)
        {
            SourceTierSizeReductionInBytes = sourceTierSizeReductionInBytes;
            TargetTierSizeIncreaseInBytes = targetTierSizeIncreaseInBytes;
            RetailSourceTierCostPerGBPerMonth = retailSourceTierCostPerGBPerMonth;
            RetailTargetTierCostPerGBPerMonth = retailTargetTierCostPerGBPerMonth;
            ObjectType = "TieringCostSavingInfo";
        }

        /// <summary> Initializes a new instance of <see cref="TieringCostSavingInfo"/>. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="sourceTierSizeReductionInBytes"> Source tier size reduction in bytes after moving all the recommended backup points to target tier. </param>
        /// <param name="targetTierSizeIncreaseInBytes"> Target tier size increase in bytes after moving all the recommended backup points to target tier. </param>
        /// <param name="retailSourceTierCostPerGBPerMonth"> Source tier retail cost per GB per month. </param>
        /// <param name="retailTargetTierCostPerGBPerMonth"> Target tier retail cost per GB per month. </param>
        internal TieringCostSavingInfo(string objectType, IDictionary<string, BinaryData> serializedAdditionalRawData, long sourceTierSizeReductionInBytes, long targetTierSizeIncreaseInBytes, double retailSourceTierCostPerGBPerMonth, double retailTargetTierCostPerGBPerMonth) : base(objectType, serializedAdditionalRawData)
        {
            SourceTierSizeReductionInBytes = sourceTierSizeReductionInBytes;
            TargetTierSizeIncreaseInBytes = targetTierSizeIncreaseInBytes;
            RetailSourceTierCostPerGBPerMonth = retailSourceTierCostPerGBPerMonth;
            RetailTargetTierCostPerGBPerMonth = retailTargetTierCostPerGBPerMonth;
            ObjectType = objectType ?? "TieringCostSavingInfo";
        }

        /// <summary> Initializes a new instance of <see cref="TieringCostSavingInfo"/> for deserialization. </summary>
        internal TieringCostSavingInfo()
        {
        }

        /// <summary> Source tier size reduction in bytes after moving all the recommended backup points to target tier. </summary>
        public long SourceTierSizeReductionInBytes { get; }
        /// <summary> Target tier size increase in bytes after moving all the recommended backup points to target tier. </summary>
        public long TargetTierSizeIncreaseInBytes { get; }
        /// <summary> Source tier retail cost per GB per month. </summary>
        public double RetailSourceTierCostPerGBPerMonth { get; }
        /// <summary> Target tier retail cost per GB per month. </summary>
        public double RetailTargetTierCostPerGBPerMonth { get; }
    }
}
