// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DnsResolver.Models
{
    public partial class DnsForwardingRulesetPatch : IUtf8JsonSerializable, IJsonModel<DnsForwardingRulesetPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DnsForwardingRulesetPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DnsForwardingRulesetPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsForwardingRulesetPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DnsForwardingRulesetPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DnsResolverOutboundEndpoints))
            {
                writer.WritePropertyName("dnsResolverOutboundEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in DnsResolverOutboundEndpoints)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        DnsForwardingRulesetPatch IJsonModel<DnsForwardingRulesetPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsForwardingRulesetPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DnsForwardingRulesetPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDnsForwardingRulesetPatch(document.RootElement, options);
        }

        internal static DnsForwardingRulesetPatch DeserializeDnsForwardingRulesetPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<WritableSubResource>> dnsResolverOutboundEndpoints = default;
            Optional<IDictionary<string, string>> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dnsResolverOutboundEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    dnsResolverOutboundEndpoints = array;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DnsForwardingRulesetPatch(Optional.ToList(dnsResolverOutboundEndpoints), Optional.ToDictionary(tags), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DnsForwardingRulesetPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsForwardingRulesetPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DnsForwardingRulesetPatch)} does not support '{options.Format}' format.");
            }
        }

        DnsForwardingRulesetPatch IPersistableModel<DnsForwardingRulesetPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DnsForwardingRulesetPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDnsForwardingRulesetPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DnsForwardingRulesetPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DnsForwardingRulesetPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
