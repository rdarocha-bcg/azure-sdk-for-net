// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The QueryTableStatusRequest. </summary>
    public partial class QueryTableStatusRequest
    {
        /// <summary> Initializes a new instance of <see cref="QueryTableStatusRequest"/>. </summary>
        public QueryTableStatusRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QueryTableStatusRequest"/>. </summary>
        /// <param name="maxSegmentCount"> Max segment count to query table status. </param>
        /// <param name="continuationToken"> Continuation token to query table status. </param>
        internal QueryTableStatusRequest(int? maxSegmentCount, object continuationToken)
        {
            MaxSegmentCount = maxSegmentCount;
            ContinuationToken = continuationToken;
        }

        /// <summary> Max segment count to query table status. </summary>
        public int? MaxSegmentCount { get; set; }
        /// <summary> Continuation token to query table status. </summary>
        public object ContinuationToken { get; set; }
    }
}
