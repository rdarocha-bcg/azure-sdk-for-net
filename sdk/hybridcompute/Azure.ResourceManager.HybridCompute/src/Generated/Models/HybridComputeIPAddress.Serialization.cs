// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class HybridComputeIPAddress : IUtf8JsonSerializable, IJsonModel<HybridComputeIPAddress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridComputeIPAddress>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HybridComputeIPAddress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeIPAddress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeIPAddress)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address"u8);
                writer.WriteStringValue(Address);
            }
            if (Optional.IsDefined(IPAddressVersion))
            {
                writer.WritePropertyName("ipAddressVersion"u8);
                writer.WriteStringValue(IPAddressVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet"u8);
                writer.WriteObjectValue(Subnet);
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

        HybridComputeIPAddress IJsonModel<HybridComputeIPAddress>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeIPAddress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeIPAddress)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridComputeIPAddress(document.RootElement, options);
        }

        internal static HybridComputeIPAddress DeserializeHybridComputeIPAddress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> address = default;
            Optional<string> ipAddressVersion = default;
            Optional<HybridComputeSubnet> subnet = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddressVersion"u8))
                {
                    ipAddressVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnet = HybridComputeSubnet.DeserializeHybridComputeSubnet(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HybridComputeIPAddress(address.Value, ipAddressVersion.Value, subnet.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HybridComputeIPAddress>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeIPAddress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HybridComputeIPAddress)} does not support '{options.Format}' format.");
            }
        }

        HybridComputeIPAddress IPersistableModel<HybridComputeIPAddress>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeIPAddress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridComputeIPAddress(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridComputeIPAddress)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridComputeIPAddress>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
