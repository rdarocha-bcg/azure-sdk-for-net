// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The UnknownGranularCopyLogDetails. </summary>
    internal partial class UnknownGranularCopyLogDetails : GranularCopyLogDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownGranularCopyLogDetails"/>. </summary>
        /// <param name="copyLogDetailsType"> Indicates the type of job details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownGranularCopyLogDetails(DataBoxOrderType copyLogDetailsType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(copyLogDetailsType, serializedAdditionalRawData)
        {
            CopyLogDetailsType = copyLogDetailsType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownGranularCopyLogDetails"/> for deserialization. </summary>
        internal UnknownGranularCopyLogDetails()
        {
        }
    }
}
