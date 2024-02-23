// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A class representing the AppConfigurationKeyValue data model.
    /// The key-value resource along with all resource properties.
    /// </summary>
    public partial class AppConfigurationKeyValueData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="AppConfigurationKeyValueData"/>. </summary>
        public AppConfigurationKeyValueData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AppConfigurationKeyValueData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="key">
        /// The primary identifier of a key-value.
        /// The key is used in unison with the label to uniquely identify a key-value.
        /// </param>
        /// <param name="label">
        /// A value used to group key-values.
        /// The label is used in unison with the key to uniquely identify a key-value.
        /// </param>
        /// <param name="value"> The value of the key-value. </param>
        /// <param name="contentType">
        /// The content type of the key-value's value.
        /// Providing a proper content-type can enable transformations of values when they are retrieved by applications.
        /// </param>
        /// <param name="eTag"> An ETag indicating the state of a key-value within a configuration store. </param>
        /// <param name="lastModifiedOn"> The last time a modifying operation was performed on the given key-value. </param>
        /// <param name="isLocked">
        /// A value indicating whether the key-value is locked.
        /// A locked key-value may not be modified until it is unlocked.
        /// </param>
        /// <param name="tags"> A dictionary of tags that can help identify what a key-value may be applicable for. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppConfigurationKeyValueData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string key, string label, string value, string contentType, ETag? eTag, DateTimeOffset? lastModifiedOn, bool? isLocked, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Key = key;
            Label = label;
            Value = value;
            ContentType = contentType;
            ETag = eTag;
            LastModifiedOn = lastModifiedOn;
            IsLocked = isLocked;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The primary identifier of a key-value.
        /// The key is used in unison with the label to uniquely identify a key-value.
        /// </summary>
        public string Key { get; }
        /// <summary>
        /// A value used to group key-values.
        /// The label is used in unison with the key to uniquely identify a key-value.
        /// </summary>
        public string Label { get; }
        /// <summary> The value of the key-value. </summary>
        public string Value { get; set; }
        /// <summary>
        /// The content type of the key-value's value.
        /// Providing a proper content-type can enable transformations of values when they are retrieved by applications.
        /// </summary>
        public string ContentType { get; set; }
        /// <summary> An ETag indicating the state of a key-value within a configuration store. </summary>
        public ETag? ETag { get; }
        /// <summary> The last time a modifying operation was performed on the given key-value. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary>
        /// A value indicating whether the key-value is locked.
        /// A locked key-value may not be modified until it is unlocked.
        /// </summary>
        public bool? IsLocked { get; }
        /// <summary> A dictionary of tags that can help identify what a key-value may be applicable for. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
