// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevSpaces.Models
{
    public partial class ControllerConnectionDetails : IUtf8JsonSerializable, IJsonModel<ControllerConnectionDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ControllerConnectionDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ControllerConnectionDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControllerConnectionDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ControllerConnectionDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OrchestratorSpecificConnectionDetails))
            {
                writer.WritePropertyName("orchestratorSpecificConnectionDetails"u8);
                writer.WriteObjectValue(OrchestratorSpecificConnectionDetails);
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

        ControllerConnectionDetails IJsonModel<ControllerConnectionDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControllerConnectionDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ControllerConnectionDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeControllerConnectionDetails(document.RootElement, options);
        }

        internal static ControllerConnectionDetails DeserializeControllerConnectionDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OrchestratorSpecificConnectionDetails> orchestratorSpecificConnectionDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("orchestratorSpecificConnectionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    orchestratorSpecificConnectionDetails = OrchestratorSpecificConnectionDetails.DeserializeOrchestratorSpecificConnectionDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ControllerConnectionDetails(orchestratorSpecificConnectionDetails.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ControllerConnectionDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControllerConnectionDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ControllerConnectionDetails)} does not support '{options.Format}' format.");
            }
        }

        ControllerConnectionDetails IPersistableModel<ControllerConnectionDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControllerConnectionDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeControllerConnectionDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ControllerConnectionDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ControllerConnectionDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
