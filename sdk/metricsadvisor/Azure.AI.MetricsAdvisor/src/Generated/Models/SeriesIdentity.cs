// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The SeriesIdentity. </summary>
    internal partial class SeriesIdentity
    {
        /// <summary> Initializes a new instance of <see cref="SeriesIdentity"/>. </summary>
        /// <param name="dimension"> dimension specified for series. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dimension"/> is null. </exception>
        public SeriesIdentity(IDictionary<string, string> dimension)
        {
            if (dimension == null)
            {
                throw new ArgumentNullException(nameof(dimension));
            }

            Dimension = dimension;
        }

        /// <summary> dimension specified for series. </summary>
        public IDictionary<string, string> Dimension { get; }
    }
}
