// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyHttpHeaderToInsert : IUtf8JsonSerializable, IJsonModel<FirewallPolicyHttpHeaderToInsert>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallPolicyHttpHeaderToInsert>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirewallPolicyHttpHeaderToInsert>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyHttpHeaderToInsert>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPolicyHttpHeaderToInsert)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(HeaderName))
            {
                writer.WritePropertyName("headerName"u8);
                writer.WriteStringValue(HeaderName);
            }
            if (Optional.IsDefined(HeaderValue))
            {
                writer.WritePropertyName("headerValue"u8);
                writer.WriteStringValue(HeaderValue);
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

        FirewallPolicyHttpHeaderToInsert IJsonModel<FirewallPolicyHttpHeaderToInsert>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyHttpHeaderToInsert>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPolicyHttpHeaderToInsert)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallPolicyHttpHeaderToInsert(document.RootElement, options);
        }

        internal static FirewallPolicyHttpHeaderToInsert DeserializeFirewallPolicyHttpHeaderToInsert(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> headerName = default;
            Optional<string> headerValue = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("headerName"u8))
                {
                    headerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("headerValue"u8))
                {
                    headerValue = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirewallPolicyHttpHeaderToInsert(headerName.Value, headerValue.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallPolicyHttpHeaderToInsert>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyHttpHeaderToInsert>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallPolicyHttpHeaderToInsert)} does not support '{options.Format}' format.");
            }
        }

        FirewallPolicyHttpHeaderToInsert IPersistableModel<FirewallPolicyHttpHeaderToInsert>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyHttpHeaderToInsert>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallPolicyHttpHeaderToInsert(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallPolicyHttpHeaderToInsert)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallPolicyHttpHeaderToInsert>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
