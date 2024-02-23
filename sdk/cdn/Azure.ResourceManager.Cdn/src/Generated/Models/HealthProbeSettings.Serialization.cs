// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class HealthProbeSettings : IUtf8JsonSerializable, IJsonModel<HealthProbeSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthProbeSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HealthProbeSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthProbeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthProbeSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProbePath))
            {
                writer.WritePropertyName("probePath"u8);
                writer.WriteStringValue(ProbePath);
            }
            if (Optional.IsDefined(ProbeRequestType))
            {
                writer.WritePropertyName("probeRequestType"u8);
                writer.WriteStringValue(ProbeRequestType.Value.ToSerialString());
            }
            if (Optional.IsDefined(ProbeProtocol))
            {
                writer.WritePropertyName("probeProtocol"u8);
                writer.WriteStringValue(ProbeProtocol.Value.ToSerialString());
            }
            if (Optional.IsDefined(ProbeIntervalInSeconds))
            {
                writer.WritePropertyName("probeIntervalInSeconds"u8);
                writer.WriteNumberValue(ProbeIntervalInSeconds.Value);
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

        HealthProbeSettings IJsonModel<HealthProbeSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthProbeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthProbeSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthProbeSettings(document.RootElement, options);
        }

        internal static HealthProbeSettings DeserializeHealthProbeSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> probePath = default;
            Optional<HealthProbeRequestType> probeRequestType = default;
            Optional<HealthProbeProtocol> probeProtocol = default;
            Optional<int> probeIntervalInSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("probePath"u8))
                {
                    probePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("probeRequestType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probeRequestType = property.Value.GetString().ToHealthProbeRequestType();
                    continue;
                }
                if (property.NameEquals("probeProtocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probeProtocol = property.Value.GetString().ToHealthProbeProtocol();
                    continue;
                }
                if (property.NameEquals("probeIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probeIntervalInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HealthProbeSettings(probePath.Value, Optional.ToNullable(probeRequestType), Optional.ToNullable(probeProtocol), Optional.ToNullable(probeIntervalInSeconds), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HealthProbeSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthProbeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HealthProbeSettings)} does not support '{options.Format}' format.");
            }
        }

        HealthProbeSettings IPersistableModel<HealthProbeSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthProbeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHealthProbeSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HealthProbeSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HealthProbeSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
