// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.FrontDoor.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.FrontDoor
{
    public partial class FrontDoorData : IUtf8JsonSerializable, IJsonModel<FrontDoorData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FrontDoorData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FrontDoorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsCollectionDefined(RoutingRules))
            {
                writer.WritePropertyName("routingRules"u8);
                writer.WriteStartArray();
                foreach (var item in RoutingRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LoadBalancingSettings))
            {
                writer.WritePropertyName("loadBalancingSettings"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancingSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(HealthProbeSettings))
            {
                writer.WritePropertyName("healthProbeSettings"u8);
                writer.WriteStartArray();
                foreach (var item in HealthProbeSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BackendPools))
            {
                writer.WritePropertyName("backendPools"u8);
                writer.WriteStartArray();
                foreach (var item in BackendPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FrontendEndpoints))
            {
                writer.WritePropertyName("frontendEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in FrontendEndpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BackendPoolsSettings))
            {
                writer.WritePropertyName("backendPoolsSettings"u8);
                writer.WriteObjectValue(BackendPoolsSettings);
            }
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceState))
            {
                writer.WritePropertyName("resourceState"u8);
                writer.WriteStringValue(ResourceState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(Cname))
            {
                writer.WritePropertyName("cname"u8);
                writer.WriteStringValue(Cname);
            }
            if (options.Format != "W" && Optional.IsDefined(FrontdoorId))
            {
                writer.WritePropertyName("frontdoorId"u8);
                writer.WriteStringValue(FrontdoorId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RulesEngines))
            {
                writer.WritePropertyName("rulesEngines"u8);
                writer.WriteStartArray();
                foreach (var item in RulesEngines)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExtendedProperties))
            {
                writer.WritePropertyName("extendedProperties"u8);
                writer.WriteStartObject();
                foreach (var item in ExtendedProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        FrontDoorData IJsonModel<FrontDoorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorData(document.RootElement, options);
        }

        internal static FrontDoorData DeserializeFrontDoorData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> friendlyName = default;
            Optional<IList<RoutingRuleData>> routingRules = default;
            Optional<IList<FrontDoorLoadBalancingSettingsData>> loadBalancingSettings = default;
            Optional<IList<FrontDoorHealthProbeSettingsData>> healthProbeSettings = default;
            Optional<IList<FrontDoorBackendPool>> backendPools = default;
            Optional<IList<FrontendEndpointData>> frontendEndpoints = default;
            Optional<BackendPoolsSettings> backendPoolsSettings = default;
            Optional<FrontDoorEnabledState> enabledState = default;
            Optional<FrontDoorResourceState> resourceState = default;
            Optional<string> provisioningState = default;
            Optional<string> cname = default;
            Optional<string> frontdoorId = default;
            Optional<IReadOnlyList<FrontDoorRulesEngineData>> rulesEngines = default;
            Optional<IReadOnlyDictionary<string, string>> extendedProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routingRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RoutingRuleData> array = new List<RoutingRuleData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RoutingRuleData.DeserializeRoutingRuleData(item, options));
                            }
                            routingRules = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancingSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FrontDoorLoadBalancingSettingsData> array = new List<FrontDoorLoadBalancingSettingsData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontDoorLoadBalancingSettingsData.DeserializeFrontDoorLoadBalancingSettingsData(item, options));
                            }
                            loadBalancingSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("healthProbeSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FrontDoorHealthProbeSettingsData> array = new List<FrontDoorHealthProbeSettingsData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontDoorHealthProbeSettingsData.DeserializeFrontDoorHealthProbeSettingsData(item, options));
                            }
                            healthProbeSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("backendPools"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FrontDoorBackendPool> array = new List<FrontDoorBackendPool>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontDoorBackendPool.DeserializeFrontDoorBackendPool(item, options));
                            }
                            backendPools = array;
                            continue;
                        }
                        if (property0.NameEquals("frontendEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FrontendEndpointData> array = new List<FrontendEndpointData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontendEndpointData.DeserializeFrontendEndpointData(item, options));
                            }
                            frontendEndpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("backendPoolsSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backendPoolsSettings = BackendPoolsSettings.DeserializeBackendPoolsSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("enabledState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabledState = new FrontDoorEnabledState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new FrontDoorResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cname"u8))
                        {
                            cname = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("frontdoorId"u8))
                        {
                            frontdoorId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("rulesEngines"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FrontDoorRulesEngineData> array = new List<FrontDoorRulesEngineData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FrontDoorRulesEngineData.DeserializeFrontDoorRulesEngineData(item, options));
                            }
                            rulesEngines = array;
                            continue;
                        }
                        if (property0.NameEquals("extendedProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            extendedProperties = dictionary;
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
            return new FrontDoorData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, friendlyName.Value, Optional.ToList(routingRules), Optional.ToList(loadBalancingSettings), Optional.ToList(healthProbeSettings), Optional.ToList(backendPools), Optional.ToList(frontendEndpoints), backendPoolsSettings.Value, Optional.ToNullable(enabledState), Optional.ToNullable(resourceState), provisioningState.Value, cname.Value, frontdoorId.Value, Optional.ToList(rulesEngines), Optional.ToDictionary(extendedProperties), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FrontDoorData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FrontDoorData)} does not support '{options.Format}' format.");
            }
        }

        FrontDoorData IPersistableModel<FrontDoorData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFrontDoorData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FrontDoorData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FrontDoorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
