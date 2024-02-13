// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityCenterPublisherInfo : IUtf8JsonSerializable, IJsonModel<SecurityCenterPublisherInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityCenterPublisherInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityCenterPublisherInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterPublisherInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityCenterPublisherInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PublisherName))
            {
                writer.WritePropertyName("publisherName"u8);
                writer.WriteStringValue(PublisherName);
            }
            if (Optional.IsDefined(ProductName))
            {
                writer.WritePropertyName("productName"u8);
                writer.WriteStringValue(ProductName);
            }
            if (Optional.IsDefined(BinaryName))
            {
                writer.WritePropertyName("binaryName"u8);
                writer.WriteStringValue(BinaryName);
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

        SecurityCenterPublisherInfo IJsonModel<SecurityCenterPublisherInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterPublisherInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityCenterPublisherInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityCenterPublisherInfo(document.RootElement, options);
        }

        internal static SecurityCenterPublisherInfo DeserializeSecurityCenterPublisherInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> publisherName = default;
            Optional<string> productName = default;
            Optional<string> binaryName = default;
            Optional<string> version = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publisherName"u8))
                {
                    publisherName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productName"u8))
                {
                    productName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("binaryName"u8))
                {
                    binaryName = property.Value.GetString();
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
            return new SecurityCenterPublisherInfo(publisherName.Value, productName.Value, binaryName.Value, version.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityCenterPublisherInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterPublisherInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityCenterPublisherInfo)} does not support '{options.Format}' format.");
            }
        }

        SecurityCenterPublisherInfo IPersistableModel<SecurityCenterPublisherInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterPublisherInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityCenterPublisherInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityCenterPublisherInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityCenterPublisherInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
