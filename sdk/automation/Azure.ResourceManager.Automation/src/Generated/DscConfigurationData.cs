// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing the DscConfiguration data model.
    /// Definition of the configuration type.
    /// </summary>
    public partial class DscConfigurationData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="DscConfigurationData"/>. </summary>
        /// <param name="location"> The location. </param>
        public DscConfigurationData(AzureLocation location) : base(location)
        {
            Parameters = new ChangeTrackingDictionary<string, DscConfigurationParameterDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="DscConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> Gets or sets the etag of the resource. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state of the configuration. </param>
        /// <param name="jobCount"> Gets or sets the job count of the configuration. </param>
        /// <param name="parameters"> Gets or sets the configuration parameters. </param>
        /// <param name="source"> Gets or sets the source. </param>
        /// <param name="state"> Gets or sets the state of the configuration. </param>
        /// <param name="isLogVerboseEnabled"> Gets or sets verbose log option. </param>
        /// <param name="createdOn"> Gets or sets the creation time. </param>
        /// <param name="lastModifiedOn"> Gets or sets the last modified time. </param>
        /// <param name="nodeConfigurationCount"> Gets the number of compiled node configurations. </param>
        /// <param name="description"> Gets or sets the description. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DscConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, DscConfigurationProvisioningState? provisioningState, int? jobCount, IDictionary<string, DscConfigurationParameterDefinition> parameters, AutomationContentSource source, DscConfigurationState? state, bool? isLogVerboseEnabled, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, int? nodeConfigurationCount, string description, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            ProvisioningState = provisioningState;
            JobCount = jobCount;
            Parameters = parameters;
            Source = source;
            State = state;
            IsLogVerboseEnabled = isLogVerboseEnabled;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            NodeConfigurationCount = nodeConfigurationCount;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DscConfigurationData"/> for deserialization. </summary>
        internal DscConfigurationData()
        {
        }

        /// <summary> Gets or sets the etag of the resource. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Gets or sets the provisioning state of the configuration. </summary>
        public DscConfigurationProvisioningState? ProvisioningState { get; set; }
        /// <summary> Gets or sets the job count of the configuration. </summary>
        public int? JobCount { get; set; }
        /// <summary> Gets or sets the configuration parameters. </summary>
        public IDictionary<string, DscConfigurationParameterDefinition> Parameters { get; }
        /// <summary> Gets or sets the source. </summary>
        public AutomationContentSource Source { get; set; }
        /// <summary> Gets or sets the state of the configuration. </summary>
        public DscConfigurationState? State { get; set; }
        /// <summary> Gets or sets verbose log option. </summary>
        public bool? IsLogVerboseEnabled { get; set; }
        /// <summary> Gets or sets the creation time. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> Gets or sets the last modified time. </summary>
        public DateTimeOffset? LastModifiedOn { get; set; }
        /// <summary> Gets the number of compiled node configurations. </summary>
        public int? NodeConfigurationCount { get; set; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
    }
}
