// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorTimeSeriesElement : IUtf8JsonSerializable, IJsonModel<MonitorTimeSeriesElement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorTimeSeriesElement>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorTimeSeriesElement>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorTimeSeriesElement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorTimeSeriesElement)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Metadatavalues))
            {
                writer.WritePropertyName("metadatavalues"u8);
                writer.WriteStartArray();
                foreach (var item in Metadatavalues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in Data)
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

        MonitorTimeSeriesElement IJsonModel<MonitorTimeSeriesElement>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorTimeSeriesElement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorTimeSeriesElement)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorTimeSeriesElement(document.RootElement, options);
        }

        internal static MonitorTimeSeriesElement DeserializeMonitorTimeSeriesElement(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MonitorMetadataValue>> metadatavalues = default;
            Optional<IReadOnlyList<MonitorMetricValue>> data = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadatavalues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorMetadataValue> array = new List<MonitorMetadataValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorMetadataValue.DeserializeMonitorMetadataValue(item, options));
                    }
                    metadatavalues = array;
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorMetricValue> array = new List<MonitorMetricValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorMetricValue.DeserializeMonitorMetricValue(item, options));
                    }
                    data = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorTimeSeriesElement(Optional.ToList(metadatavalues), Optional.ToList(data), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorTimeSeriesElement>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorTimeSeriesElement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorTimeSeriesElement)} does not support '{options.Format}' format.");
            }
        }

        MonitorTimeSeriesElement IPersistableModel<MonitorTimeSeriesElement>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorTimeSeriesElement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorTimeSeriesElement(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorTimeSeriesElement)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorTimeSeriesElement>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
