// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The UnknownOSConfiguration. </summary>
    internal partial class UnknownOSConfiguration : SapOSConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="UnknownOSConfiguration"/>. </summary>
        /// <param name="osType"> The OS Type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownOSConfiguration(SapOSType osType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(osType, serializedAdditionalRawData)
        {
            OSType = osType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownOSConfiguration"/> for deserialization. </summary>
        internal UnknownOSConfiguration()
        {
        }
    }
}
