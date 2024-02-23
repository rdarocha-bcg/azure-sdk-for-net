// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class TrinoProfile : IUtf8JsonSerializable, IJsonModel<TrinoProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrinoProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TrinoProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrinoProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrinoProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CatalogOptions))
            {
                writer.WritePropertyName("catalogOptions"u8);
                writer.WriteObjectValue(CatalogOptions);
            }
            if (Optional.IsDefined(Coordinator))
            {
                writer.WritePropertyName("coordinator"u8);
                writer.WriteObjectValue(Coordinator);
            }
            if (Optional.IsDefined(UserPluginsSpec))
            {
                writer.WritePropertyName("userPluginsSpec"u8);
                writer.WriteObjectValue(UserPluginsSpec);
            }
            if (Optional.IsDefined(UserTelemetrySpec))
            {
                writer.WritePropertyName("userTelemetrySpec"u8);
                writer.WriteObjectValue(UserTelemetrySpec);
            }
            if (Optional.IsDefined(Worker))
            {
                writer.WritePropertyName("worker"u8);
                writer.WriteObjectValue(Worker);
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

        TrinoProfile IJsonModel<TrinoProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrinoProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrinoProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrinoProfile(document.RootElement, options);
        }

        internal static TrinoProfile DeserializeTrinoProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CatalogOptions> catalogOptions = default;
            Optional<TrinoCoordinator> coordinator = default;
            Optional<TrinoUserPluginListResult> userPluginsSpec = default;
            Optional<TrinoUserTelemetry> userTelemetrySpec = default;
            Optional<TrinoWorker> worker = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalogOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catalogOptions = CatalogOptions.DeserializeCatalogOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("coordinator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coordinator = TrinoCoordinator.DeserializeTrinoCoordinator(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userPluginsSpec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userPluginsSpec = TrinoUserPluginListResult.DeserializeTrinoUserPluginListResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userTelemetrySpec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userTelemetrySpec = TrinoUserTelemetry.DeserializeTrinoUserTelemetry(property.Value, options);
                    continue;
                }
                if (property.NameEquals("worker"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    worker = TrinoWorker.DeserializeTrinoWorker(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TrinoProfile(catalogOptions.Value, coordinator.Value, userPluginsSpec.Value, userTelemetrySpec.Value, worker.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TrinoProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrinoProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrinoProfile)} does not support '{options.Format}' format.");
            }
        }

        TrinoProfile IPersistableModel<TrinoProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrinoProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrinoProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrinoProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrinoProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
