// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the VirtualMachineExtensionImage data model.
    /// Describes a Virtual Machine Extension Image.
    /// </summary>
    public partial class VirtualMachineExtensionImageData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineExtensionImageData"/>. </summary>
        /// <param name="location"> The location. </param>
        public VirtualMachineExtensionImageData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineExtensionImageData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="operatingSystem"> The operating system this extension supports. </param>
        /// <param name="computeRole"> The type of role (IaaS or PaaS) this extension supports. </param>
        /// <param name="handlerSchema"> The schema defined by publisher, where extension consumers should provide settings in a matching schema. </param>
        /// <param name="virtualMachineScaleSetEnabled"> Whether the extension can be used on xRP VMScaleSets. By default existing extensions are usable on scalesets, but there might be cases where a publisher wants to explicitly indicate the extension is only enabled for CRP VMs but not VMSS. </param>
        /// <param name="supportsMultipleExtensions"> Whether the handler can support multiple extensions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineExtensionImageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string operatingSystem, string computeRole, string handlerSchema, bool? virtualMachineScaleSetEnabled, bool? supportsMultipleExtensions, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            OperatingSystem = operatingSystem;
            ComputeRole = computeRole;
            HandlerSchema = handlerSchema;
            VirtualMachineScaleSetEnabled = virtualMachineScaleSetEnabled;
            SupportsMultipleExtensions = supportsMultipleExtensions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineExtensionImageData"/> for deserialization. </summary>
        internal VirtualMachineExtensionImageData()
        {
        }

        /// <summary> The operating system this extension supports. </summary>
        public string OperatingSystem { get; set; }
        /// <summary> The type of role (IaaS or PaaS) this extension supports. </summary>
        public string ComputeRole { get; set; }
        /// <summary> The schema defined by publisher, where extension consumers should provide settings in a matching schema. </summary>
        public string HandlerSchema { get; set; }
        /// <summary> Whether the extension can be used on xRP VMScaleSets. By default existing extensions are usable on scalesets, but there might be cases where a publisher wants to explicitly indicate the extension is only enabled for CRP VMs but not VMSS. </summary>
        public bool? VirtualMachineScaleSetEnabled { get; set; }
        /// <summary> Whether the handler can support multiple extensions. </summary>
        public bool? SupportsMultipleExtensions { get; set; }
    }
}
