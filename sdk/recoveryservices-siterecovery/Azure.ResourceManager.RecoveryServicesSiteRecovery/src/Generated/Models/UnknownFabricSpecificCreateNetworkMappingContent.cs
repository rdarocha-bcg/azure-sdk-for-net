// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownFabricSpecificCreateNetworkMappingContent. </summary>
    internal partial class UnknownFabricSpecificCreateNetworkMappingContent : FabricSpecificCreateNetworkMappingContent
    {
        /// <summary> Initializes a new instance of <see cref="UnknownFabricSpecificCreateNetworkMappingContent"/>. </summary>
        /// <param name="instanceType"> The instance type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownFabricSpecificCreateNetworkMappingContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownFabricSpecificCreateNetworkMappingContent"/> for deserialization. </summary>
        internal UnknownFabricSpecificCreateNetworkMappingContent()
        {
        }
    }
}
