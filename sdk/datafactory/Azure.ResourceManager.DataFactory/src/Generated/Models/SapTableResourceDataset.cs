// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> SAP Table Resource properties. </summary>
    public partial class SapTableResourceDataset : DataFactoryDatasetProperties
    {
        /// <summary> Initializes a new instance of <see cref="SapTableResourceDataset"/>. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="tableName"> The name of the SAP Table. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="tableName"/> is null. </exception>
        public SapTableResourceDataset(DataFactoryLinkedServiceReference linkedServiceName, DataFactoryElement<string> tableName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            TableName = tableName;
            DatasetType = "SapTableResource";
        }

        /// <summary> Initializes a new instance of <see cref="SapTableResourceDataset"/>. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="tableName"> The name of the SAP Table. Type: string (or Expression with resultType string). </param>
        internal SapTableResourceDataset(string datasetType, string description, DataFactoryElement<IList<DatasetDataElement>> structure, DataFactoryElement<IList<DatasetSchemaDataElement>> schema, DataFactoryLinkedServiceReference linkedServiceName, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> tableName) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            TableName = tableName;
            DatasetType = datasetType ?? "SapTableResource";
        }

        /// <summary> Initializes a new instance of <see cref="SapTableResourceDataset"/> for deserialization. </summary>
        internal SapTableResourceDataset()
        {
        }

        /// <summary> The name of the SAP Table. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> TableName { get; set; }
    }
}
