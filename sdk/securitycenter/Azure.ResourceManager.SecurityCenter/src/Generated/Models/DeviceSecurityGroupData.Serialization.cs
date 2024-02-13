// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class DeviceSecurityGroupData : IUtf8JsonSerializable, IJsonModel<DeviceSecurityGroupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceSecurityGroupData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeviceSecurityGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceSecurityGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceSecurityGroupData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Optional.IsCollectionDefined(ThresholdRules))
            {
                writer.WritePropertyName("thresholdRules"u8);
                writer.WriteStartArray();
                foreach (var item in ThresholdRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TimeWindowRules))
            {
                writer.WritePropertyName("timeWindowRules"u8);
                writer.WriteStartArray();
                foreach (var item in TimeWindowRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AllowlistRules))
            {
                writer.WritePropertyName("allowlistRules"u8);
                writer.WriteStartArray();
                foreach (var item in AllowlistRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DenylistRules))
            {
                writer.WritePropertyName("denylistRules"u8);
                writer.WriteStartArray();
                foreach (var item in DenylistRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        DeviceSecurityGroupData IJsonModel<DeviceSecurityGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceSecurityGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceSecurityGroupData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceSecurityGroupData(document.RootElement, options);
        }

        internal static DeviceSecurityGroupData DeserializeDeviceSecurityGroupData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IList<ThresholdCustomAlertRule>> thresholdRules = default;
            Optional<IList<TimeWindowCustomAlertRule>> timeWindowRules = default;
            Optional<IList<AllowlistCustomAlertRule>> allowlistRules = default;
            Optional<IList<DenylistCustomAlertRule>> denylistRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("thresholdRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ThresholdCustomAlertRule> array = new List<ThresholdCustomAlertRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ThresholdCustomAlertRule.DeserializeThresholdCustomAlertRule(item));
                            }
                            thresholdRules = array;
                            continue;
                        }
                        if (property0.NameEquals("timeWindowRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TimeWindowCustomAlertRule> array = new List<TimeWindowCustomAlertRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TimeWindowCustomAlertRule.DeserializeTimeWindowCustomAlertRule(item));
                            }
                            timeWindowRules = array;
                            continue;
                        }
                        if (property0.NameEquals("allowlistRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AllowlistCustomAlertRule> array = new List<AllowlistCustomAlertRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AllowlistCustomAlertRule.DeserializeAllowlistCustomAlertRule(item));
                            }
                            allowlistRules = array;
                            continue;
                        }
                        if (property0.NameEquals("denylistRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DenylistCustomAlertRule> array = new List<DenylistCustomAlertRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DenylistCustomAlertRule.DeserializeDenylistCustomAlertRule(item));
                            }
                            denylistRules = array;
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
            return new DeviceSecurityGroupData(id, name, type, systemData.Value, Optional.ToList(thresholdRules), Optional.ToList(timeWindowRules), Optional.ToList(allowlistRules), Optional.ToList(denylistRules), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceSecurityGroupData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceSecurityGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeviceSecurityGroupData)} does not support '{options.Format}' format.");
            }
        }

        DeviceSecurityGroupData IPersistableModel<DeviceSecurityGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceSecurityGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeviceSecurityGroupData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeviceSecurityGroupData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceSecurityGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
