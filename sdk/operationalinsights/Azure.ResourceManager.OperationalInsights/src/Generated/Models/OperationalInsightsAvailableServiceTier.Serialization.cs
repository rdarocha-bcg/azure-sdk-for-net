// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsAvailableServiceTier : IUtf8JsonSerializable, IJsonModel<OperationalInsightsAvailableServiceTier>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsAvailableServiceTier>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OperationalInsightsAvailableServiceTier>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsAvailableServiceTier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsAvailableServiceTier)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ServiceTier))
            {
                writer.WritePropertyName("serviceTier"u8);
                writer.WriteStringValue(ServiceTier.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MinimumRetention))
            {
                writer.WritePropertyName("minimumRetention"u8);
                writer.WriteNumberValue(MinimumRetention.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaximumRetention))
            {
                writer.WritePropertyName("maximumRetention"u8);
                writer.WriteNumberValue(MaximumRetention.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultRetention))
            {
                writer.WritePropertyName("defaultRetention"u8);
                writer.WriteNumberValue(DefaultRetention.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CapacityReservationLevel))
            {
                writer.WritePropertyName("capacityReservationLevel"u8);
                writer.WriteNumberValue(CapacityReservationLevel.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastSkuUpdatedOn))
            {
                writer.WritePropertyName("lastSkuUpdate"u8);
                writer.WriteStringValue(LastSkuUpdatedOn.Value, "O");
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

        OperationalInsightsAvailableServiceTier IJsonModel<OperationalInsightsAvailableServiceTier>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsAvailableServiceTier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsAvailableServiceTier)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsAvailableServiceTier(document.RootElement, options);
        }

        internal static OperationalInsightsAvailableServiceTier DeserializeOperationalInsightsAvailableServiceTier(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OperationalInsightsSkuName> serviceTier = default;
            Optional<bool> enabled = default;
            Optional<long> minimumRetention = default;
            Optional<long> maximumRetention = default;
            Optional<long> defaultRetention = default;
            Optional<long> capacityReservationLevel = default;
            Optional<DateTimeOffset> lastSkuUpdate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceTier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceTier = new OperationalInsightsSkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minimumRetention"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumRetention = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maximumRetention"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumRetention = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("defaultRetention"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultRetention = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("capacityReservationLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityReservationLevel = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastSkuUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSkuUpdate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OperationalInsightsAvailableServiceTier(Optional.ToNullable(serviceTier), Optional.ToNullable(enabled), Optional.ToNullable(minimumRetention), Optional.ToNullable(maximumRetention), Optional.ToNullable(defaultRetention), Optional.ToNullable(capacityReservationLevel), Optional.ToNullable(lastSkuUpdate), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OperationalInsightsAvailableServiceTier>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsAvailableServiceTier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsAvailableServiceTier)} does not support '{options.Format}' format.");
            }
        }

        OperationalInsightsAvailableServiceTier IPersistableModel<OperationalInsightsAvailableServiceTier>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsAvailableServiceTier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOperationalInsightsAvailableServiceTier(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsAvailableServiceTier)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OperationalInsightsAvailableServiceTier>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
