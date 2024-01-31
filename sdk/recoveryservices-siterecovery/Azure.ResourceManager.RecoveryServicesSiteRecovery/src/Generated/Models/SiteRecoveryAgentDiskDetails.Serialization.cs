// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryAgentDiskDetails : IUtf8JsonSerializable, IJsonModel<SiteRecoveryAgentDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryAgentDiskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryAgentDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryAgentDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryAgentDiskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DiskId))
            {
                writer.WritePropertyName("diskId"u8);
                writer.WriteStringValue(DiskId);
            }
            if (options.Format != "W" && Optional.IsDefined(DiskName))
            {
                writer.WritePropertyName("diskName"u8);
                writer.WriteStringValue(DiskName);
            }
            if (options.Format != "W" && Optional.IsDefined(IsOSDisk))
            {
                writer.WritePropertyName("isOSDisk"u8);
                writer.WriteStringValue(IsOSDisk);
            }
            if (options.Format != "W" && Optional.IsDefined(CapacityInBytes))
            {
                writer.WritePropertyName("capacityInBytes"u8);
                writer.WriteNumberValue(CapacityInBytes.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LunId))
            {
                writer.WritePropertyName("lunId"u8);
                writer.WriteNumberValue(LunId.Value);
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

        SiteRecoveryAgentDiskDetails IJsonModel<SiteRecoveryAgentDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryAgentDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryAgentDiskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryAgentDiskDetails(document.RootElement, options);
        }

        internal static SiteRecoveryAgentDiskDetails DeserializeSiteRecoveryAgentDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> diskId = default;
            Optional<string> diskName = default;
            Optional<string> isOSDisk = default;
            Optional<long> capacityInBytes = default;
            Optional<int> lunId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskName"u8))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isOSDisk"u8))
                {
                    isOSDisk = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityInBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lunId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lunId = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryAgentDiskDetails(diskId.Value, diskName.Value, isOSDisk.Value, Optional.ToNullable(capacityInBytes), Optional.ToNullable(lunId), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryAgentDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryAgentDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryAgentDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryAgentDiskDetails IPersistableModel<SiteRecoveryAgentDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryAgentDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryAgentDiskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryAgentDiskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryAgentDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
