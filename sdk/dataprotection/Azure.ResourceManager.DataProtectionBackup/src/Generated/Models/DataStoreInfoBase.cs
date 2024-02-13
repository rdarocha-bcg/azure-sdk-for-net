// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> DataStoreInfo base. </summary>
    public partial class DataStoreInfoBase
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataStoreInfoBase"/>. </summary>
        /// <param name="dataStoreType"> type of datastore; Operational/Vault/Archive. </param>
        /// <param name="objectType"> Type of Datasource object, used to initialize the right inherited type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="objectType"/> is null. </exception>
        public DataStoreInfoBase(DataStoreType dataStoreType, string objectType)
        {
            Argument.AssertNotNull(objectType, nameof(objectType));

            DataStoreType = dataStoreType;
            ObjectType = objectType;
        }

        /// <summary> Initializes a new instance of <see cref="DataStoreInfoBase"/>. </summary>
        /// <param name="dataStoreType"> type of datastore; Operational/Vault/Archive. </param>
        /// <param name="objectType"> Type of Datasource object, used to initialize the right inherited type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataStoreInfoBase(DataStoreType dataStoreType, string objectType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DataStoreType = dataStoreType;
            ObjectType = objectType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataStoreInfoBase"/> for deserialization. </summary>
        internal DataStoreInfoBase()
        {
        }

        /// <summary> type of datastore; Operational/Vault/Archive. </summary>
        public DataStoreType DataStoreType { get; set; }
        /// <summary> Type of Datasource object, used to initialize the right inherited type. </summary>
        public string ObjectType { get; set; }
    }
}
