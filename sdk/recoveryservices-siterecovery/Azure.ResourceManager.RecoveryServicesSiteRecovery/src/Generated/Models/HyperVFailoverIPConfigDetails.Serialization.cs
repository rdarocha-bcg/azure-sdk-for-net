// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class HyperVFailoverIPConfigDetails : IUtf8JsonSerializable, IJsonModel<HyperVFailoverIPConfigDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVFailoverIPConfigDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HyperVFailoverIPConfigDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVFailoverIPConfigDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVFailoverIPConfigDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IPConfigName))
            {
                writer.WritePropertyName("ipConfigName"u8);
                writer.WriteStringValue(IPConfigName);
            }
            if (Optional.IsDefined(IsPrimary))
            {
                writer.WritePropertyName("isPrimary"u8);
                writer.WriteBooleanValue(IsPrimary.Value);
            }
            if (Optional.IsDefined(IsSeletedForFailover))
            {
                writer.WritePropertyName("isSeletedForFailover"u8);
                writer.WriteBooleanValue(IsSeletedForFailover.Value);
            }
            if (Optional.IsDefined(RecoverySubnetName))
            {
                writer.WritePropertyName("recoverySubnetName"u8);
                writer.WriteStringValue(RecoverySubnetName);
            }
            if (Optional.IsDefined(RecoveryStaticIPAddress))
            {
                writer.WritePropertyName("recoveryStaticIPAddress"u8);
                writer.WriteStringValue(RecoveryStaticIPAddress.ToString());
            }
            if (Optional.IsDefined(RecoveryPublicIPAddressId))
            {
                writer.WritePropertyName("recoveryPublicIPAddressId"u8);
                writer.WriteStringValue(RecoveryPublicIPAddressId);
            }
            if (Optional.IsCollectionDefined(RecoveryLBBackendAddressPoolIds))
            {
                writer.WritePropertyName("recoveryLBBackendAddressPoolIds"u8);
                writer.WriteStartArray();
                foreach (var item in RecoveryLBBackendAddressPoolIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TfoSubnetName))
            {
                writer.WritePropertyName("tfoSubnetName"u8);
                writer.WriteStringValue(TfoSubnetName);
            }
            if (Optional.IsDefined(TfoStaticIPAddress))
            {
                writer.WritePropertyName("tfoStaticIPAddress"u8);
                writer.WriteStringValue(TfoStaticIPAddress.ToString());
            }
            if (Optional.IsDefined(TfoPublicIPAddressId))
            {
                writer.WritePropertyName("tfoPublicIPAddressId"u8);
                writer.WriteStringValue(TfoPublicIPAddressId);
            }
            if (Optional.IsCollectionDefined(TfoLBBackendAddressPoolIds))
            {
                writer.WritePropertyName("tfoLBBackendAddressPoolIds"u8);
                writer.WriteStartArray();
                foreach (var item in TfoLBBackendAddressPoolIds)
                {
                    writer.WriteStringValue(item);
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

        HyperVFailoverIPConfigDetails IJsonModel<HyperVFailoverIPConfigDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVFailoverIPConfigDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVFailoverIPConfigDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVFailoverIPConfigDetails(document.RootElement, options);
        }

        internal static HyperVFailoverIPConfigDetails DeserializeHyperVFailoverIPConfigDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ipConfigName = default;
            Optional<bool> isPrimary = default;
            Optional<bool> isSeletedForFailover = default;
            Optional<string> recoverySubnetName = default;
            Optional<IPAddress> recoveryStaticIPAddress = default;
            Optional<ResourceIdentifier> recoveryPublicIPAddressId = default;
            Optional<IList<string>> recoveryLBBackendAddressPoolIds = default;
            Optional<string> tfoSubnetName = default;
            Optional<IPAddress> tfoStaticIPAddress = default;
            Optional<ResourceIdentifier> tfoPublicIPAddressId = default;
            Optional<IList<string>> tfoLBBackendAddressPoolIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipConfigName"u8))
                {
                    ipConfigName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPrimary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPrimary = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isSeletedForFailover"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSeletedForFailover = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("recoverySubnetName"u8))
                {
                    recoverySubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryStaticIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryStaticIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryPublicIPAddressId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPublicIPAddressId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryLBBackendAddressPoolIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    recoveryLBBackendAddressPoolIds = array;
                    continue;
                }
                if (property.NameEquals("tfoSubnetName"u8))
                {
                    tfoSubnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tfoStaticIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tfoStaticIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tfoPublicIPAddressId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tfoPublicIPAddressId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tfoLBBackendAddressPoolIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tfoLBBackendAddressPoolIds = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HyperVFailoverIPConfigDetails(ipConfigName.Value, Optional.ToNullable(isPrimary), Optional.ToNullable(isSeletedForFailover), recoverySubnetName.Value, recoveryStaticIPAddress.Value, recoveryPublicIPAddressId.Value, Optional.ToList(recoveryLBBackendAddressPoolIds), tfoSubnetName.Value, tfoStaticIPAddress.Value, tfoPublicIPAddressId.Value, Optional.ToList(tfoLBBackendAddressPoolIds), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HyperVFailoverIPConfigDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVFailoverIPConfigDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HyperVFailoverIPConfigDetails)} does not support '{options.Format}' format.");
            }
        }

        HyperVFailoverIPConfigDetails IPersistableModel<HyperVFailoverIPConfigDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVFailoverIPConfigDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHyperVFailoverIPConfigDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HyperVFailoverIPConfigDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVFailoverIPConfigDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
