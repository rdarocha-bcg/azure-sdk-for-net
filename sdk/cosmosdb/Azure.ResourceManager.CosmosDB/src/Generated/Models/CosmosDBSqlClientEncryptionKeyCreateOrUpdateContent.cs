// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update ClientEncryptionKey. </summary>
    public partial class CosmosDBSqlClientEncryptionKeyCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlClientEncryptionKeyCreateOrUpdateContent"/>. </summary>
        /// <param name="resource"> The standard JSON format of a ClientEncryptionKey. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resource"/> is null. </exception>
        public CosmosDBSqlClientEncryptionKeyCreateOrUpdateContent(CosmosDBSqlClientEncryptionKeyResourceInfo resource)
        {
            if (resource == null)
            {
                throw new ArgumentNullException(nameof(resource));
            }

            Resource = resource;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlClientEncryptionKeyCreateOrUpdateContent"/>. </summary>
        /// <param name="resource"> The standard JSON format of a ClientEncryptionKey. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBSqlClientEncryptionKeyCreateOrUpdateContent(CosmosDBSqlClientEncryptionKeyResourceInfo resource, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Resource = resource;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlClientEncryptionKeyCreateOrUpdateContent"/> for deserialization. </summary>
        internal CosmosDBSqlClientEncryptionKeyCreateOrUpdateContent()
        {
        }

        /// <summary> The standard JSON format of a ClientEncryptionKey. </summary>
        public CosmosDBSqlClientEncryptionKeyResourceInfo Resource { get; }
    }
}
