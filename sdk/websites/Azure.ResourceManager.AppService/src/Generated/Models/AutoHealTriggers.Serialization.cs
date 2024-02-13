// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AutoHealTriggers : IUtf8JsonSerializable, IJsonModel<AutoHealTriggers>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoHealTriggers>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutoHealTriggers>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoHealTriggers>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoHealTriggers)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Requests))
            {
                writer.WritePropertyName("requests"u8);
                writer.WriteObjectValue(Requests);
            }
            if (Optional.IsDefined(PrivateBytesInKB))
            {
                writer.WritePropertyName("privateBytesInKB"u8);
                writer.WriteNumberValue(PrivateBytesInKB.Value);
            }
            if (Optional.IsCollectionDefined(StatusCodes))
            {
                writer.WritePropertyName("statusCodes"u8);
                writer.WriteStartArray();
                foreach (var item in StatusCodes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SlowRequests))
            {
                writer.WritePropertyName("slowRequests"u8);
                writer.WriteObjectValue(SlowRequests);
            }
            if (Optional.IsCollectionDefined(SlowRequestsWithPath))
            {
                writer.WritePropertyName("slowRequestsWithPath"u8);
                writer.WriteStartArray();
                foreach (var item in SlowRequestsWithPath)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(StatusCodesRange))
            {
                writer.WritePropertyName("statusCodesRange"u8);
                writer.WriteStartArray();
                foreach (var item in StatusCodesRange)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        AutoHealTriggers IJsonModel<AutoHealTriggers>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoHealTriggers>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoHealTriggers)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoHealTriggers(document.RootElement, options);
        }

        internal static AutoHealTriggers DeserializeAutoHealTriggers(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RequestsBasedTrigger> requests = default;
            Optional<int> privateBytesInKB = default;
            Optional<IList<StatusCodesBasedTrigger>> statusCodes = default;
            Optional<SlowRequestsBasedTrigger> slowRequests = default;
            Optional<IList<SlowRequestsBasedTrigger>> slowRequestsWithPath = default;
            Optional<IList<StatusCodesRangeBasedTrigger>> statusCodesRange = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requests = RequestsBasedTrigger.DeserializeRequestsBasedTrigger(property.Value);
                    continue;
                }
                if (property.NameEquals("privateBytesInKB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateBytesInKB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("statusCodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StatusCodesBasedTrigger> array = new List<StatusCodesBasedTrigger>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StatusCodesBasedTrigger.DeserializeStatusCodesBasedTrigger(item));
                    }
                    statusCodes = array;
                    continue;
                }
                if (property.NameEquals("slowRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    slowRequests = SlowRequestsBasedTrigger.DeserializeSlowRequestsBasedTrigger(property.Value);
                    continue;
                }
                if (property.NameEquals("slowRequestsWithPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SlowRequestsBasedTrigger> array = new List<SlowRequestsBasedTrigger>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SlowRequestsBasedTrigger.DeserializeSlowRequestsBasedTrigger(item));
                    }
                    slowRequestsWithPath = array;
                    continue;
                }
                if (property.NameEquals("statusCodesRange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StatusCodesRangeBasedTrigger> array = new List<StatusCodesRangeBasedTrigger>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StatusCodesRangeBasedTrigger.DeserializeStatusCodesRangeBasedTrigger(item));
                    }
                    statusCodesRange = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutoHealTriggers(requests.Value, Optional.ToNullable(privateBytesInKB), Optional.ToList(statusCodes), slowRequests.Value, Optional.ToList(slowRequestsWithPath), Optional.ToList(statusCodesRange), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutoHealTriggers>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoHealTriggers>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutoHealTriggers)} does not support '{options.Format}' format.");
            }
        }

        AutoHealTriggers IPersistableModel<AutoHealTriggers>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoHealTriggers>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoHealTriggers(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoHealTriggers)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoHealTriggers>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
