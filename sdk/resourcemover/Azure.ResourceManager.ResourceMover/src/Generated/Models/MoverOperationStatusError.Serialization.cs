// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverOperationStatusError : IUtf8JsonSerializable, IJsonModel<MoverOperationStatusError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoverOperationStatusError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MoverOperationStatusError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverOperationStatusError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverOperationStatusError)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (options.Format != "W" && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStartArray();
                foreach (var item in Details)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AdditionalInfo))
            {
                if (AdditionalInfo != null)
                {
                    writer.WritePropertyName("additionalInfo"u8);
                    writer.WriteStartArray();
                    foreach (var item in AdditionalInfo)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("additionalInfo");
                }
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

        MoverOperationStatusError IJsonModel<MoverOperationStatusError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverOperationStatusError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverOperationStatusError)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverOperationStatusError(document.RootElement, options);
        }

        internal static MoverOperationStatusError DeserializeMoverOperationStatusError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<IReadOnlyList<MoverOperationStatusError>> details = default;
            Optional<IReadOnlyList<MoverOperationErrorAdditionalInfo>> additionalInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MoverOperationStatusError> array = new List<MoverOperationStatusError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeMoverOperationStatusError(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("additionalInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        additionalInfo = null;
                        continue;
                    }
                    List<MoverOperationErrorAdditionalInfo> array = new List<MoverOperationErrorAdditionalInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MoverOperationErrorAdditionalInfo.DeserializeMoverOperationErrorAdditionalInfo(item));
                    }
                    additionalInfo = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MoverOperationStatusError(code.Value, message.Value, Optional.ToList(details), Optional.ToList(additionalInfo), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MoverOperationStatusError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverOperationStatusError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MoverOperationStatusError)} does not support '{options.Format}' format.");
            }
        }

        MoverOperationStatusError IPersistableModel<MoverOperationStatusError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverOperationStatusError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMoverOperationStatusError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MoverOperationStatusError)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MoverOperationStatusError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
