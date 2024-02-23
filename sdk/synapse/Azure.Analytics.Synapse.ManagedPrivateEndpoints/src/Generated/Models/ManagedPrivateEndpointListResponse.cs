// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.ManagedPrivateEndpoints.Models
{
    /// <summary> A list of managed private endpoints. </summary>
    internal partial class ManagedPrivateEndpointListResponse
    {
        /// <summary> Initializes a new instance of <see cref="ManagedPrivateEndpointListResponse"/>. </summary>
        internal ManagedPrivateEndpointListResponse()
        {
            Value = new ChangeTrackingList<ManagedPrivateEndpoint>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedPrivateEndpointListResponse"/>. </summary>
        /// <param name="value"> List of managed private endpoints. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        internal ManagedPrivateEndpointListResponse(IReadOnlyList<ManagedPrivateEndpoint> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of managed private endpoints. </summary>
        public IReadOnlyList<ManagedPrivateEndpoint> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}
