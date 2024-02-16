// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The MongoDB database dataset. </summary>
    public partial class MongoDBCollectionDataset : DataFactoryDatasetProperties
    {
        /// <summary> Initializes a new instance of <see cref="MongoDBCollectionDataset"/>. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="collectionName"> The table name of the MongoDB database. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="collectionName"/> is null. </exception>
        public MongoDBCollectionDataset(DataFactoryLinkedServiceReference linkedServiceName, DataFactoryElement<string> collectionName) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));
            Argument.AssertNotNull(collectionName, nameof(collectionName));

            CollectionName = collectionName;
            DatasetType = "MongoDbCollection";
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBCollectionDataset"/>. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="collectionName"> The table name of the MongoDB database. Type: string (or Expression with resultType string). </param>
        internal MongoDBCollectionDataset(string datasetType, string description, DataFactoryElement<IList<DatasetDataElement>> structure, DataFactoryElement<IList<DatasetSchemaDataElement>> schema, DataFactoryLinkedServiceReference linkedServiceName, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> collectionName) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            CollectionName = collectionName;
            DatasetType = datasetType ?? "MongoDbCollection";
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBCollectionDataset"/> for deserialization. </summary>
        internal MongoDBCollectionDataset()
        {
        }

        /// <summary> The table name of the MongoDB database. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> CollectionName { get; set; }
    }
}
