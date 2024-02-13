// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The result returned from a AttachedDatabaseConfigurations check name availability request. </summary>
    public partial class KustoAttachedDatabaseConfigurationNameAvailabilityContent
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

        /// <summary> Initializes a new instance of <see cref="KustoAttachedDatabaseConfigurationNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Attached database resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public KustoAttachedDatabaseConfigurationNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = AttachedDatabaseType.MicrosoftKustoClustersAttachedDatabaseConfigurations;
        }

        /// <summary> Initializes a new instance of <see cref="KustoAttachedDatabaseConfigurationNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Attached database resource name. </param>
        /// <param name="resourceType"> The type of resource, for instance Microsoft.Kusto/clusters/attachedDatabaseConfigurations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KustoAttachedDatabaseConfigurationNameAvailabilityContent(string name, AttachedDatabaseType resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="KustoAttachedDatabaseConfigurationNameAvailabilityContent"/> for deserialization. </summary>
        internal KustoAttachedDatabaseConfigurationNameAvailabilityContent()
        {
        }

        /// <summary> Attached database resource name. </summary>
        public string Name { get; }
        /// <summary> The type of resource, for instance Microsoft.Kusto/clusters/attachedDatabaseConfigurations. </summary>
        public AttachedDatabaseType ResourceType { get; }
    }
}
