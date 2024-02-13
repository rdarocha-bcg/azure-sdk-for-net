// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    internal partial class MoveResourceError : IUtf8JsonSerializable, IJsonModel<MoveResourceError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoveResourceError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MoveResourceError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoveResourceError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoveResourceError)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                JsonSerializer.Serialize(writer, Properties);
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

        MoveResourceError IJsonModel<MoveResourceError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoveResourceError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoveResourceError)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoveResourceError(document.RootElement, options);
        }

        internal static MoveResourceError DeserializeMoveResourceError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResponseError> properties = default;
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
                    properties = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MoveResourceError(properties.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MoveResourceError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoveResourceError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MoveResourceError)} does not support '{options.Format}' format.");
            }
        }

        MoveResourceError IPersistableModel<MoveResourceError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoveResourceError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMoveResourceError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MoveResourceError)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MoveResourceError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
