// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class QuotaCounterValueUpdateContent : IUtf8JsonSerializable, IJsonModel<QuotaCounterValueUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QuotaCounterValueUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QuotaCounterValueUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterValueUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaCounterValueUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CallsCount))
            {
                writer.WritePropertyName("callsCount"u8);
                writer.WriteNumberValue(CallsCount.Value);
            }
            if (Optional.IsDefined(KbTransferred))
            {
                writer.WritePropertyName("kbTransferred"u8);
                writer.WriteNumberValue(KbTransferred.Value);
            }
            writer.WriteEndObject();
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

        QuotaCounterValueUpdateContent IJsonModel<QuotaCounterValueUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterValueUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaCounterValueUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQuotaCounterValueUpdateContent(document.RootElement, options);
        }

        internal static QuotaCounterValueUpdateContent DeserializeQuotaCounterValueUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> callsCount = default;
            Optional<double> kbTransferred = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("callsCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            callsCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("kbTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            kbTransferred = property0.Value.GetDouble();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QuotaCounterValueUpdateContent(Optional.ToNullable(callsCount), Optional.ToNullable(kbTransferred), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QuotaCounterValueUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterValueUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QuotaCounterValueUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        QuotaCounterValueUpdateContent IPersistableModel<QuotaCounterValueUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterValueUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQuotaCounterValueUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QuotaCounterValueUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QuotaCounterValueUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
