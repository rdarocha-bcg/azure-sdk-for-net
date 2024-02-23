// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.GuestConfiguration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.GuestConfiguration
{
    public partial class GuestConfigurationAssignmentData : IUtf8JsonSerializable, IJsonModel<GuestConfigurationAssignmentData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GuestConfigurationAssignmentData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GuestConfigurationAssignmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestConfigurationAssignmentData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
            }
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
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

        GuestConfigurationAssignmentData IJsonModel<GuestConfigurationAssignmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestConfigurationAssignmentData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGuestConfigurationAssignmentData(document.RootElement, options);
        }

        internal static GuestConfigurationAssignmentData DeserializeGuestConfigurationAssignmentData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GuestConfigurationAssignmentProperties> properties = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<AzureLocation> location = default;
            Optional<ResourceType> type = default;
            Optional<SystemData> systemData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = GuestConfigurationAssignmentProperties.DeserializeGuestConfigurationAssignmentProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GuestConfigurationAssignmentData(id.Value, name.Value, Optional.ToNullable(location), Optional.ToNullable(type), systemData, serializedAdditionalRawData, properties.Value);
        }

        BinaryData IPersistableModel<GuestConfigurationAssignmentData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GuestConfigurationAssignmentData)} does not support '{options.Format}' format.");
            }
        }

        GuestConfigurationAssignmentData IPersistableModel<GuestConfigurationAssignmentData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestConfigurationAssignmentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGuestConfigurationAssignmentData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GuestConfigurationAssignmentData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GuestConfigurationAssignmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
