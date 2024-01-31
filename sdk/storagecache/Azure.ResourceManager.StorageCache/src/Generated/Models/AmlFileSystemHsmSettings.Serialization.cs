// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class AmlFileSystemHsmSettings : IUtf8JsonSerializable, IJsonModel<AmlFileSystemHsmSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AmlFileSystemHsmSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AmlFileSystemHsmSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemHsmSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlFileSystemHsmSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("container"u8);
            writer.WriteStringValue(Container);
            writer.WritePropertyName("loggingContainer"u8);
            writer.WriteStringValue(LoggingContainer);
            if (Optional.IsDefined(ImportPrefix))
            {
                writer.WritePropertyName("importPrefix"u8);
                writer.WriteStringValue(ImportPrefix);
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

        AmlFileSystemHsmSettings IJsonModel<AmlFileSystemHsmSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemHsmSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlFileSystemHsmSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlFileSystemHsmSettings(document.RootElement, options);
        }

        internal static AmlFileSystemHsmSettings DeserializeAmlFileSystemHsmSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string container = default;
            string loggingContainer = default;
            Optional<string> importPrefix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("container"u8))
                {
                    container = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loggingContainer"u8))
                {
                    loggingContainer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("importPrefix"u8))
                {
                    importPrefix = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AmlFileSystemHsmSettings(container, loggingContainer, importPrefix.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AmlFileSystemHsmSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemHsmSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AmlFileSystemHsmSettings)} does not support '{options.Format}' format.");
            }
        }

        AmlFileSystemHsmSettings IPersistableModel<AmlFileSystemHsmSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemHsmSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAmlFileSystemHsmSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AmlFileSystemHsmSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AmlFileSystemHsmSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
