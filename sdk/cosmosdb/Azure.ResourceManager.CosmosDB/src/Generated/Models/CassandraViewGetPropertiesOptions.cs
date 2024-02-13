// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The CassandraViewGetPropertiesOptions. </summary>
    public partial class CassandraViewGetPropertiesOptions : CosmosDBBaseConfig
    {
        /// <summary> Initializes a new instance of <see cref="CassandraViewGetPropertiesOptions"/>. </summary>
        public CassandraViewGetPropertiesOptions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CassandraViewGetPropertiesOptions"/>. </summary>
        /// <param name="throughput"> Value of the Cosmos DB resource throughput or autoscaleSettings. Use the ThroughputSetting resource when retrieving offer details. </param>
        /// <param name="autoscaleSettings"> Specifies the Autoscale settings. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CassandraViewGetPropertiesOptions(int? throughput, AutoscaleSettings autoscaleSettings, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(throughput, autoscaleSettings, serializedAdditionalRawData)
        {
        }
    }
}
