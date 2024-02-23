// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    public partial class VirtualMachineInstanceData : IUtf8JsonSerializable, IJsonModel<VirtualMachineInstanceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineInstanceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineInstanceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstanceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineInstanceData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                writer.WriteObjectValue(ExtendedLocation);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(HardwareProfile))
            {
                writer.WritePropertyName("hardwareProfile"u8);
                writer.WriteObjectValue(HardwareProfile);
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile);
            }
            if (Optional.IsDefined(OSProfile))
            {
                writer.WritePropertyName("osProfile"u8);
                writer.WriteObjectValue(OSProfile);
            }
            if (Optional.IsDefined(SecurityProfile))
            {
                writer.WritePropertyName("securityProfile"u8);
                writer.WriteObjectValue(SecurityProfile);
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile);
            }
            if (Optional.IsDefined(HttpProxyConfig))
            {
                writer.WritePropertyName("httpProxyConfig"u8);
                writer.WriteObjectValue(HttpProxyConfig);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceView))
            {
                writer.WritePropertyName("instanceView"u8);
                writer.WriteObjectValue(InstanceView);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
            }
            if (Optional.IsDefined(GuestAgentInstallStatus))
            {
                writer.WritePropertyName("guestAgentInstallStatus"u8);
                writer.WriteObjectValue(GuestAgentInstallStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(VmId))
            {
                writer.WritePropertyName("vmId"u8);
                writer.WriteStringValue(VmId);
            }
            if (Optional.IsDefined(ResourceUid))
            {
                writer.WritePropertyName("resourceUid"u8);
                writer.WriteStringValue(ResourceUid);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        VirtualMachineInstanceData IJsonModel<VirtualMachineInstanceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstanceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineInstanceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineInstanceData(document.RootElement, options);
        }

        internal static VirtualMachineInstanceData DeserializeVirtualMachineInstanceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ArcVmExtendedLocation> extendedLocation = default;
            Optional<ManagedServiceIdentity> identity = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<VirtualMachineInstancePropertiesHardwareProfile> hardwareProfile = default;
            Optional<VirtualMachineInstancePropertiesNetworkProfile> networkProfile = default;
            Optional<VirtualMachineInstancePropertiesOSProfile> osProfile = default;
            Optional<VirtualMachineInstancePropertiesSecurityProfile> securityProfile = default;
            Optional<VirtualMachineInstancePropertiesStorageProfile> storageProfile = default;
            Optional<HttpProxyConfiguration> httpProxyConfig = default;
            Optional<ProvisioningStateEnum> provisioningState = default;
            Optional<VirtualMachineInstanceView> instanceView = default;
            Optional<VirtualMachineInstanceStatus> status = default;
            Optional<GuestAgentInstallStatus> guestAgentInstallStatus = default;
            Optional<string> vmId = default;
            Optional<string> resourceUid = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = ArcVmExtendedLocation.DeserializeArcVmExtendedLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("hardwareProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hardwareProfile = VirtualMachineInstancePropertiesHardwareProfile.DeserializeVirtualMachineInstancePropertiesHardwareProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkProfile = VirtualMachineInstancePropertiesNetworkProfile.DeserializeVirtualMachineInstancePropertiesNetworkProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("osProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osProfile = VirtualMachineInstancePropertiesOSProfile.DeserializeVirtualMachineInstancePropertiesOSProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("securityProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityProfile = VirtualMachineInstancePropertiesSecurityProfile.DeserializeVirtualMachineInstancePropertiesSecurityProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("storageProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageProfile = VirtualMachineInstancePropertiesStorageProfile.DeserializeVirtualMachineInstancePropertiesStorageProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("httpProxyConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpProxyConfig = HttpProxyConfiguration.DeserializeHttpProxyConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningStateEnum(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("instanceView"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceView = VirtualMachineInstanceView.DeserializeVirtualMachineInstanceView(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = VirtualMachineInstanceStatus.DeserializeVirtualMachineInstanceStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("guestAgentInstallStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            guestAgentInstallStatus = GuestAgentInstallStatus.DeserializeGuestAgentInstallStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("vmId"u8))
                        {
                            vmId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceUid"u8))
                        {
                            resourceUid = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineInstanceData(id, name, type, systemData.Value, extendedLocation.Value, identity, hardwareProfile.Value, networkProfile.Value, osProfile.Value, securityProfile.Value, storageProfile.Value, httpProxyConfig.Value, Optional.ToNullable(provisioningState), instanceView.Value, status.Value, guestAgentInstallStatus.Value, vmId.Value, resourceUid.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineInstanceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstanceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineInstanceData)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineInstanceData IPersistableModel<VirtualMachineInstanceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstanceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineInstanceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineInstanceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineInstanceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
