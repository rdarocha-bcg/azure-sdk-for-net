// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapImageReference : IUtf8JsonSerializable, IJsonModel<SapImageReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapImageReference>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SapImageReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapImageReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapImageReference)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Publisher))
            {
                writer.WritePropertyName("publisher"u8);
                writer.WriteStringValue(Publisher);
            }
            if (Optional.IsDefined(Offer))
            {
                writer.WritePropertyName("offer"u8);
                writer.WriteStringValue(Offer);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
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

        SapImageReference IJsonModel<SapImageReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapImageReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SapImageReference)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapImageReference(document.RootElement, options);
        }

        internal static SapImageReference DeserializeSapImageReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> publisher = default;
            Optional<string> offer = default;
            Optional<string> sku = default;
            Optional<string> version = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publisher"u8))
                {
                    publisher = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offer"u8))
                {
                    offer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SapImageReference(publisher.Value, offer.Value, sku.Value, version.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SapImageReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapImageReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SapImageReference)} does not support '{options.Format}' format.");
            }
        }

        SapImageReference IPersistableModel<SapImageReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SapImageReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSapImageReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SapImageReference)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SapImageReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
