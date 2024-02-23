// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing the ContainerAppConnectedEnvironment data model.
    /// An environment for Kubernetes cluster specialized for web workloads by Azure App Service
    /// </summary>
    public partial class ContainerAppConnectedEnvironmentData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppConnectedEnvironmentData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ContainerAppConnectedEnvironmentData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppConnectedEnvironmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The complex type of the extended location. </param>
        /// <param name="provisioningState"> Provisioning state of the Kubernetes Environment. </param>
        /// <param name="deploymentErrors"> Any errors that occurred during deployment or deployment validation. </param>
        /// <param name="defaultDomain"> Default Domain Name for the cluster. </param>
        /// <param name="staticIP"> Static IP of the connectedEnvironment. </param>
        /// <param name="daprAIConnectionString"> Application Insights connection string used by Dapr to export Service to Service communication telemetry. </param>
        /// <param name="customDomainConfiguration"> Custom domain configuration for the environment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppConnectedEnvironmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ContainerAppExtendedLocation extendedLocation, ContainerAppConnectedEnvironmentProvisioningState? provisioningState, string deploymentErrors, string defaultDomain, IPAddress staticIP, string daprAIConnectionString, ContainerAppCustomDomainConfiguration customDomainConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            ProvisioningState = provisioningState;
            DeploymentErrors = deploymentErrors;
            DefaultDomain = defaultDomain;
            StaticIP = staticIP;
            DaprAIConnectionString = daprAIConnectionString;
            CustomDomainConfiguration = customDomainConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppConnectedEnvironmentData"/> for deserialization. </summary>
        internal ContainerAppConnectedEnvironmentData()
        {
        }

        /// <summary> The complex type of the extended location. </summary>
        public ContainerAppExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Provisioning state of the Kubernetes Environment. </summary>
        public ContainerAppConnectedEnvironmentProvisioningState? ProvisioningState { get; }
        /// <summary> Any errors that occurred during deployment or deployment validation. </summary>
        public string DeploymentErrors { get; }
        /// <summary> Default Domain Name for the cluster. </summary>
        public string DefaultDomain { get; }
        /// <summary> Static IP of the connectedEnvironment. </summary>
        public IPAddress StaticIP { get; set; }
        /// <summary> Application Insights connection string used by Dapr to export Service to Service communication telemetry. </summary>
        public string DaprAIConnectionString { get; set; }
        /// <summary> Custom domain configuration for the environment. </summary>
        public ContainerAppCustomDomainConfiguration CustomDomainConfiguration { get; set; }
    }
}
