// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    [PersistableModelProxy(typeof(UnknownAzureResourcePropertiesBase))]
    public partial class AzureResourceBaseProperties : IUtf8JsonSerializable, IJsonModel<AzureResourceBaseProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureResourceBaseProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureResourceBaseProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureResourceBaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureResourceBaseProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(AzureResourceType.ToString());
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

        AzureResourceBaseProperties IJsonModel<AzureResourceBaseProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureResourceBaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureResourceBaseProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureResourceBaseProperties(document.RootElement, options);
        }

        internal static AzureResourceBaseProperties DeserializeAzureResourceBaseProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "KeyVault": return AzureKeyVaultProperties.DeserializeAzureKeyVaultProperties(element);
                }
            }
            return UnknownAzureResourcePropertiesBase.DeserializeUnknownAzureResourcePropertiesBase(element);
        }

        BinaryData IPersistableModel<AzureResourceBaseProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureResourceBaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureResourceBaseProperties)} does not support '{options.Format}' format.");
            }
        }

        AzureResourceBaseProperties IPersistableModel<AzureResourceBaseProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureResourceBaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureResourceBaseProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureResourceBaseProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureResourceBaseProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
