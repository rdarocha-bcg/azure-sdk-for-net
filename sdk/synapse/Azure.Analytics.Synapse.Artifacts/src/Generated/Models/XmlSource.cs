// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Xml source. </summary>
    public partial class XmlSource : CopySource
    {
        /// <summary> Initializes a new instance of <see cref="XmlSource"/>. </summary>
        public XmlSource()
        {
            Type = "XmlSource";
        }

        /// <summary> Initializes a new instance of <see cref="XmlSource"/>. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="storeSettings">
        /// Xml store settings.
        /// Please note <see cref="StoreReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3ReadSettings"/>, <see cref="AzureBlobFSReadSettings"/>, <see cref="AzureBlobStorageReadSettings"/>, <see cref="AzureDataLakeStoreReadSettings"/>, <see cref="AzureFileStorageReadSettings"/>, <see cref="FileServerReadSettings"/>, <see cref="FtpReadSettings"/>, <see cref="GoogleCloudStorageReadSettings"/>, <see cref="HdfsReadSettings"/>, <see cref="HttpReadSettings"/> and <see cref="SftpReadSettings"/>.
        /// </param>
        /// <param name="formatSettings"> Xml format settings. </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        internal XmlSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, StoreReadSettings storeSettings, XmlReadSettings formatSettings, object additionalColumns) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties)
        {
            StoreSettings = storeSettings;
            FormatSettings = formatSettings;
            AdditionalColumns = additionalColumns;
            Type = type ?? "XmlSource";
        }

        /// <summary>
        /// Xml store settings.
        /// Please note <see cref="StoreReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3ReadSettings"/>, <see cref="AzureBlobFSReadSettings"/>, <see cref="AzureBlobStorageReadSettings"/>, <see cref="AzureDataLakeStoreReadSettings"/>, <see cref="AzureFileStorageReadSettings"/>, <see cref="FileServerReadSettings"/>, <see cref="FtpReadSettings"/>, <see cref="GoogleCloudStorageReadSettings"/>, <see cref="HdfsReadSettings"/>, <see cref="HttpReadSettings"/> and <see cref="SftpReadSettings"/>.
        /// </summary>
        public StoreReadSettings StoreSettings { get; set; }
        /// <summary> Xml format settings. </summary>
        public XmlReadSettings FormatSettings { get; set; }
        /// <summary> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </summary>
        public object AdditionalColumns { get; set; }
    }
}
