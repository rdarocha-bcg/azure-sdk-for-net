// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    /// <summary>
    /// A class representing the SapMonitor data model.
    /// SAP monitor info on Azure (ARM properties and SAP monitor properties)
    /// </summary>
    public partial class SapMonitorData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="SapMonitorData"/>. </summary>
        /// <param name="location"> The location. </param>
        public SapMonitorData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="SapMonitorData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> [currently not in use] Managed service identity(user assigned identities). </param>
        /// <param name="provisioningState"> State of provisioning of the SAP monitor. </param>
        /// <param name="errors"> Defines the SAP monitor errors. </param>
        /// <param name="appLocation"> The SAP monitor resources will be deployed in the SAP monitoring region. The subnet region should be same as the SAP monitoring region. </param>
        /// <param name="routingPreference"> Sets the routing preference of the SAP monitor. By default only RFC1918 traffic is routed to the customer VNET. </param>
        /// <param name="zoneRedundancyPreference"> Sets the preference for zone redundancy on resources created for the SAP monitor. By default resources will be created which do not support zone redundancy. </param>
        /// <param name="managedResourceGroupConfiguration"> Managed resource group configuration. </param>
        /// <param name="logAnalyticsWorkspaceArmId"> The ARM ID of the Log Analytics Workspace that is used for SAP monitoring. </param>
        /// <param name="monitorSubnetId"> The subnet which the SAP monitor will be deployed in. </param>
        /// <param name="msiArmId"> The ARM ID of the MSI used for SAP monitoring. </param>
        /// <param name="storageAccountArmId"> The ARM ID of the Storage account used for SAP monitoring. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SapMonitorData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, UserAssignedServiceIdentity identity, WorkloadMonitorProvisioningState? provisioningState, ResponseError errors, AzureLocation? appLocation, SapRoutingPreference? routingPreference, string zoneRedundancyPreference, ManagedRGConfiguration managedResourceGroupConfiguration, ResourceIdentifier logAnalyticsWorkspaceArmId, ResourceIdentifier monitorSubnetId, ResourceIdentifier msiArmId, ResourceIdentifier storageAccountArmId, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            Errors = errors;
            AppLocation = appLocation;
            RoutingPreference = routingPreference;
            ZoneRedundancyPreference = zoneRedundancyPreference;
            ManagedResourceGroupConfiguration = managedResourceGroupConfiguration;
            LogAnalyticsWorkspaceArmId = logAnalyticsWorkspaceArmId;
            MonitorSubnetId = monitorSubnetId;
            MsiArmId = msiArmId;
            StorageAccountArmId = storageAccountArmId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SapMonitorData"/> for deserialization. </summary>
        internal SapMonitorData()
        {
        }

        /// <summary> [currently not in use] Managed service identity(user assigned identities). </summary>
        public UserAssignedServiceIdentity Identity { get; set; }
        /// <summary> State of provisioning of the SAP monitor. </summary>
        public WorkloadMonitorProvisioningState? ProvisioningState { get; }
        /// <summary> Defines the SAP monitor errors. </summary>
        public ResponseError Errors { get; }
        /// <summary> The SAP monitor resources will be deployed in the SAP monitoring region. The subnet region should be same as the SAP monitoring region. </summary>
        public AzureLocation? AppLocation { get; set; }
        /// <summary> Sets the routing preference of the SAP monitor. By default only RFC1918 traffic is routed to the customer VNET. </summary>
        public SapRoutingPreference? RoutingPreference { get; set; }
        /// <summary> Sets the preference for zone redundancy on resources created for the SAP monitor. By default resources will be created which do not support zone redundancy. </summary>
        public string ZoneRedundancyPreference { get; set; }
        /// <summary> Managed resource group configuration. </summary>
        internal ManagedRGConfiguration ManagedResourceGroupConfiguration { get; set; }
        /// <summary> Managed resource group name. </summary>
        public string ManagedResourceGroupName
        {
            get => ManagedResourceGroupConfiguration is null ? default : ManagedResourceGroupConfiguration.Name;
            set
            {
                if (ManagedResourceGroupConfiguration is null)
                    ManagedResourceGroupConfiguration = new ManagedRGConfiguration();
                ManagedResourceGroupConfiguration.Name = value;
            }
        }

        /// <summary> The ARM ID of the Log Analytics Workspace that is used for SAP monitoring. </summary>
        public ResourceIdentifier LogAnalyticsWorkspaceArmId { get; set; }
        /// <summary> The subnet which the SAP monitor will be deployed in. </summary>
        public ResourceIdentifier MonitorSubnetId { get; set; }
        /// <summary> The ARM ID of the MSI used for SAP monitoring. </summary>
        public ResourceIdentifier MsiArmId { get; }
        /// <summary> The ARM ID of the Storage account used for SAP monitoring. </summary>
        public ResourceIdentifier StorageAccountArmId { get; }
    }
}
