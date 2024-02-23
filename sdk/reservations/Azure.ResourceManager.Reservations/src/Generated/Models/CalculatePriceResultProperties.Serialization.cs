// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class CalculatePriceResultProperties : IUtf8JsonSerializable, IJsonModel<CalculatePriceResultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CalculatePriceResultProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CalculatePriceResultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculatePriceResultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CalculatePriceResultProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BillingCurrencyTotal))
            {
                writer.WritePropertyName("billingCurrencyTotal"u8);
                writer.WriteObjectValue(BillingCurrencyTotal);
            }
            if (Optional.IsDefined(NetTotal))
            {
                writer.WritePropertyName("netTotal"u8);
                writer.WriteNumberValue(NetTotal.Value);
            }
            if (Optional.IsDefined(TaxTotal))
            {
                writer.WritePropertyName("taxTotal"u8);
                writer.WriteNumberValue(TaxTotal.Value);
            }
            if (Optional.IsDefined(GrandTotal))
            {
                writer.WritePropertyName("grandTotal"u8);
                writer.WriteNumberValue(GrandTotal.Value);
            }
            if (Optional.IsDefined(IsTaxIncluded))
            {
                writer.WritePropertyName("isTaxIncluded"u8);
                writer.WriteBooleanValue(IsTaxIncluded.Value);
            }
            if (Optional.IsDefined(IsBillingPartnerManaged))
            {
                writer.WritePropertyName("isBillingPartnerManaged"u8);
                writer.WriteBooleanValue(IsBillingPartnerManaged.Value);
            }
            if (Optional.IsDefined(ReservationOrderId))
            {
                writer.WritePropertyName("reservationOrderId"u8);
                writer.WriteStringValue(ReservationOrderId.Value);
            }
            if (Optional.IsDefined(SkuTitle))
            {
                writer.WritePropertyName("skuTitle"u8);
                writer.WriteStringValue(SkuTitle);
            }
            if (Optional.IsDefined(SkuDescription))
            {
                writer.WritePropertyName("skuDescription"u8);
                writer.WriteStringValue(SkuDescription);
            }
            if (Optional.IsDefined(PricingCurrencyTotal))
            {
                writer.WritePropertyName("pricingCurrencyTotal"u8);
                writer.WriteObjectValue(PricingCurrencyTotal);
            }
            if (Optional.IsCollectionDefined(PaymentSchedule))
            {
                writer.WritePropertyName("paymentSchedule"u8);
                writer.WriteStartArray();
                foreach (var item in PaymentSchedule)
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

        CalculatePriceResultProperties IJsonModel<CalculatePriceResultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculatePriceResultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CalculatePriceResultProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCalculatePriceResultProperties(document.RootElement, options);
        }

        internal static CalculatePriceResultProperties DeserializeCalculatePriceResultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CalculatePriceResultPropertiesBillingCurrencyTotal> billingCurrencyTotal = default;
            Optional<double> netTotal = default;
            Optional<double> taxTotal = default;
            Optional<double> grandTotal = default;
            Optional<bool> isTaxIncluded = default;
            Optional<bool> isBillingPartnerManaged = default;
            Optional<Guid> reservationOrderId = default;
            Optional<string> skuTitle = default;
            Optional<string> skuDescription = default;
            Optional<CalculatePriceResultPropertiesPricingCurrencyTotal> pricingCurrencyTotal = default;
            Optional<IReadOnlyList<PaymentDetail>> paymentSchedule = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingCurrencyTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyTotal = CalculatePriceResultPropertiesBillingCurrencyTotal.DeserializeCalculatePriceResultPropertiesBillingCurrencyTotal(property.Value, options);
                    continue;
                }
                if (property.NameEquals("netTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    netTotal = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("taxTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    taxTotal = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("grandTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    grandTotal = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("isTaxIncluded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isTaxIncluded = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isBillingPartnerManaged"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isBillingPartnerManaged = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reservationOrderId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reservationOrderId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("skuTitle"u8))
                {
                    skuTitle = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skuDescription"u8))
                {
                    skuDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pricingCurrencyTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pricingCurrencyTotal = CalculatePriceResultPropertiesPricingCurrencyTotal.DeserializeCalculatePriceResultPropertiesPricingCurrencyTotal(property.Value, options);
                    continue;
                }
                if (property.NameEquals("paymentSchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PaymentDetail> array = new List<PaymentDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PaymentDetail.DeserializePaymentDetail(item, options));
                    }
                    paymentSchedule = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CalculatePriceResultProperties(billingCurrencyTotal.Value, Optional.ToNullable(netTotal), Optional.ToNullable(taxTotal), Optional.ToNullable(grandTotal), Optional.ToNullable(isTaxIncluded), Optional.ToNullable(isBillingPartnerManaged), Optional.ToNullable(reservationOrderId), skuTitle.Value, skuDescription.Value, pricingCurrencyTotal.Value, Optional.ToList(paymentSchedule), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CalculatePriceResultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculatePriceResultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CalculatePriceResultProperties)} does not support '{options.Format}' format.");
            }
        }

        CalculatePriceResultProperties IPersistableModel<CalculatePriceResultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculatePriceResultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCalculatePriceResultProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CalculatePriceResultProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CalculatePriceResultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
