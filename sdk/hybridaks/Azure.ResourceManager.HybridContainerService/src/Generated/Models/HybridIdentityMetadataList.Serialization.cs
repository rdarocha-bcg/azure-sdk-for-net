// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridContainerService;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    internal partial class HybridIdentityMetadataList : IUtf8JsonSerializable, IJsonModel<HybridIdentityMetadataList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridIdentityMetadataList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HybridIdentityMetadataList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridIdentityMetadataList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridIdentityMetadataList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        HybridIdentityMetadataList IJsonModel<HybridIdentityMetadataList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridIdentityMetadataList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridIdentityMetadataList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridIdentityMetadataList(document.RootElement, options);
        }

        internal static HybridIdentityMetadataList DeserializeHybridIdentityMetadataList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            IReadOnlyList<HybridIdentityMetadataData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<HybridIdentityMetadataData> array = new List<HybridIdentityMetadataData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HybridIdentityMetadataData.DeserializeHybridIdentityMetadataData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HybridIdentityMetadataList(nextLink.Value, value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HybridIdentityMetadataList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridIdentityMetadataList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HybridIdentityMetadataList)} does not support '{options.Format}' format.");
            }
        }

        HybridIdentityMetadataList IPersistableModel<HybridIdentityMetadataList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridIdentityMetadataList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridIdentityMetadataList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridIdentityMetadataList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridIdentityMetadataList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
