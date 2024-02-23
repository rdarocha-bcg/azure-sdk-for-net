// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The EmailHookParameterPatch. </summary>
    internal partial class EmailHookParameterPatch
    {
        /// <summary> Initializes a new instance of <see cref="EmailHookParameterPatch"/>. </summary>
        public EmailHookParameterPatch()
        {
            ToList = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="EmailHookParameterPatch"/>. </summary>
        /// <param name="toList"> Email TO: list. </param>
        internal EmailHookParameterPatch(IList<string> toList)
        {
            ToList = toList;
        }
    }
}
