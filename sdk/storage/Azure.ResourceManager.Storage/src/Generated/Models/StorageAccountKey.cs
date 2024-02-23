// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> An access key for the storage account. </summary>
    public partial class StorageAccountKey
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

        /// <summary> Initializes a new instance of <see cref="StorageAccountKey"/>. </summary>
        internal StorageAccountKey()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountKey"/>. </summary>
        /// <param name="keyName"> Name of the key. </param>
        /// <param name="value"> Base 64-encoded value of the key. </param>
        /// <param name="permissions"> Permissions for the key -- read-only or full permissions. </param>
        /// <param name="createdOn"> Creation time of the key, in round trip date format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountKey(string keyName, string value, StorageAccountKeyPermission? permissions, DateTimeOffset? createdOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyName = keyName;
            Value = value;
            Permissions = permissions;
            CreatedOn = createdOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the key. </summary>
        public string KeyName { get; }
        /// <summary> Base 64-encoded value of the key. </summary>
        public string Value { get; }
        /// <summary> Permissions for the key -- read-only or full permissions. </summary>
        public StorageAccountKeyPermission? Permissions { get; }
        /// <summary> Creation time of the key, in round trip date format. </summary>
        public DateTimeOffset? CreatedOn { get; }
    }
}
