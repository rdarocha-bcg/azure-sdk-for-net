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

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class AddressValidationResult : IUtf8JsonSerializable, IJsonModel<AddressValidationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AddressValidationResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AddressValidationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AddressValidationResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ValidationStatus))
            {
                writer.WritePropertyName("validationStatus"u8);
                writer.WriteStringValue(ValidationStatus.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AlternateAddresses))
            {
                writer.WritePropertyName("alternateAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateAddresses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("validationType"u8);
            writer.WriteStringValue(ValidationType.ToSerialString());
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, Error);
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

        AddressValidationResult IJsonModel<AddressValidationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AddressValidationResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAddressValidationResult(document.RootElement, options);
        }

        internal static AddressValidationResult DeserializeAddressValidationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AddressValidationStatus> validationStatus = default;
            Optional<IReadOnlyList<DataBoxShippingAddress>> alternateAddresses = default;
            DataBoxValidationInputDiscriminator validationType = default;
            Optional<ResponseError> error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationStatus = property.Value.GetString().ToAddressValidationStatus();
                    continue;
                }
                if (property.NameEquals("alternateAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxShippingAddress> array = new List<DataBoxShippingAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxShippingAddress.DeserializeDataBoxShippingAddress(item, options));
                    }
                    alternateAddresses = array;
                    continue;
                }
                if (property.NameEquals("validationType"u8))
                {
                    validationType = property.Value.GetString().ToDataBoxValidationInputDiscriminator();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AddressValidationResult(validationType, error.Value, serializedAdditionalRawData, Optional.ToNullable(validationStatus), Optional.ToList(alternateAddresses));
        }

        BinaryData IPersistableModel<AddressValidationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AddressValidationResult)} does not support '{options.Format}' format.");
            }
        }

        AddressValidationResult IPersistableModel<AddressValidationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAddressValidationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AddressValidationResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AddressValidationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
