// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The CSPM monitoring for github offering. </summary>
    public partial class CspmMonitorGithubOffering : SecurityCenterCloudOffering
    {
        /// <summary> Initializes a new instance of <see cref="CspmMonitorGithubOffering"/>. </summary>
        public CspmMonitorGithubOffering()
        {
            OfferingType = OfferingType.CspmMonitorGithub;
        }

        /// <summary> Initializes a new instance of <see cref="CspmMonitorGithubOffering"/>. </summary>
        /// <param name="offeringType"> The type of the security offering. </param>
        /// <param name="description"> The offering description. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CspmMonitorGithubOffering(OfferingType offeringType, string description, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(offeringType, description, serializedAdditionalRawData)
        {
            OfferingType = offeringType;
        }
    }
}
