// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Grafana.Models
{
    internal partial class GrafanaIntegrations : IUtf8JsonSerializable, IJsonModel<GrafanaIntegrations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GrafanaIntegrations>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GrafanaIntegrations>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrafanaIntegrations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GrafanaIntegrations)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(MonitorWorkspaceIntegrations))
            {
                writer.WritePropertyName("azureMonitorWorkspaceIntegrations"u8);
                writer.WriteStartArray();
                foreach (var item in MonitorWorkspaceIntegrations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        GrafanaIntegrations IJsonModel<GrafanaIntegrations>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrafanaIntegrations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GrafanaIntegrations)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGrafanaIntegrations(document.RootElement, options);
        }

        internal static GrafanaIntegrations DeserializeGrafanaIntegrations(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<MonitorWorkspaceIntegration>> azureMonitorWorkspaceIntegrations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureMonitorWorkspaceIntegrations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorWorkspaceIntegration> array = new List<MonitorWorkspaceIntegration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorWorkspaceIntegration.DeserializeMonitorWorkspaceIntegration(item));
                    }
                    azureMonitorWorkspaceIntegrations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GrafanaIntegrations(Optional.ToList(azureMonitorWorkspaceIntegrations), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GrafanaIntegrations>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrafanaIntegrations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GrafanaIntegrations)} does not support '{options.Format}' format.");
            }
        }

        GrafanaIntegrations IPersistableModel<GrafanaIntegrations>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrafanaIntegrations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGrafanaIntegrations(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GrafanaIntegrations)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GrafanaIntegrations>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
