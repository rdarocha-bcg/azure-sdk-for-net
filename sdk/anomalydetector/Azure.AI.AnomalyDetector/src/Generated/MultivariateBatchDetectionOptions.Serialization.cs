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

namespace Azure.AI.AnomalyDetector
{
    public partial class MultivariateBatchDetectionOptions : IUtf8JsonSerializable, IJsonModel<MultivariateBatchDetectionOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MultivariateBatchDetectionOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MultivariateBatchDetectionOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultivariateBatchDetectionOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MultivariateBatchDetectionOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("dataSource"u8);
            writer.WriteStringValue(DataSource.AbsoluteUri);
            if (Optional.IsDefined(TopContributorCount))
            {
                writer.WritePropertyName("topContributorCount"u8);
                writer.WriteNumberValue(TopContributorCount.Value);
            }
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartTime, "O");
            writer.WritePropertyName("endTime"u8);
            writer.WriteStringValue(EndTime, "O");
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

        MultivariateBatchDetectionOptions IJsonModel<MultivariateBatchDetectionOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultivariateBatchDetectionOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MultivariateBatchDetectionOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMultivariateBatchDetectionOptions(document.RootElement, options);
        }

        internal static MultivariateBatchDetectionOptions DeserializeMultivariateBatchDetectionOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri dataSource = default;
            Optional<int> topContributorCount = default;
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSource"u8))
                {
                    dataSource = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("topContributorCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    topContributorCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MultivariateBatchDetectionOptions(dataSource, Optional.ToNullable(topContributorCount), startTime, endTime, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MultivariateBatchDetectionOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultivariateBatchDetectionOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MultivariateBatchDetectionOptions)} does not support '{options.Format}' format.");
            }
        }

        MultivariateBatchDetectionOptions IPersistableModel<MultivariateBatchDetectionOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MultivariateBatchDetectionOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMultivariateBatchDetectionOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MultivariateBatchDetectionOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MultivariateBatchDetectionOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MultivariateBatchDetectionOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMultivariateBatchDetectionOptions(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
