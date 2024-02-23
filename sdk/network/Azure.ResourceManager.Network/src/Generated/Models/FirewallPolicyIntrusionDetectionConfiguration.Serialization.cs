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
    public partial class FirewallPolicyIntrusionDetectionConfiguration : IUtf8JsonSerializable, IJsonModel<FirewallPolicyIntrusionDetectionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallPolicyIntrusionDetectionConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirewallPolicyIntrusionDetectionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyIntrusionDetectionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPolicyIntrusionDetectionConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(SignatureOverrides))
            {
                writer.WritePropertyName("signatureOverrides"u8);
                writer.WriteStartArray();
                foreach (var item in SignatureOverrides)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(BypassTrafficSettings))
            {
                writer.WritePropertyName("bypassTrafficSettings"u8);
                writer.WriteStartArray();
                foreach (var item in BypassTrafficSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PrivateRanges))
            {
                writer.WritePropertyName("privateRanges"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateRanges)
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

        FirewallPolicyIntrusionDetectionConfiguration IJsonModel<FirewallPolicyIntrusionDetectionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyIntrusionDetectionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPolicyIntrusionDetectionConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallPolicyIntrusionDetectionConfiguration(document.RootElement, options);
        }

        internal static FirewallPolicyIntrusionDetectionConfiguration DeserializeFirewallPolicyIntrusionDetectionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<FirewallPolicyIntrusionDetectionSignatureSpecification>> signatureOverrides = default;
            Optional<IList<FirewallPolicyIntrusionDetectionBypassTrafficSpecifications>> bypassTrafficSettings = default;
            Optional<IList<string>> privateRanges = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("signatureOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FirewallPolicyIntrusionDetectionSignatureSpecification> array = new List<FirewallPolicyIntrusionDetectionSignatureSpecification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FirewallPolicyIntrusionDetectionSignatureSpecification.DeserializeFirewallPolicyIntrusionDetectionSignatureSpecification(item, options));
                    }
                    signatureOverrides = array;
                    continue;
                }
                if (property.NameEquals("bypassTrafficSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FirewallPolicyIntrusionDetectionBypassTrafficSpecifications> array = new List<FirewallPolicyIntrusionDetectionBypassTrafficSpecifications>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FirewallPolicyIntrusionDetectionBypassTrafficSpecifications.DeserializeFirewallPolicyIntrusionDetectionBypassTrafficSpecifications(item, options));
                    }
                    bypassTrafficSettings = array;
                    continue;
                }
                if (property.NameEquals("privateRanges"u8))
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
                    privateRanges = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirewallPolicyIntrusionDetectionConfiguration(Optional.ToList(signatureOverrides), Optional.ToList(bypassTrafficSettings), Optional.ToList(privateRanges), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallPolicyIntrusionDetectionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyIntrusionDetectionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallPolicyIntrusionDetectionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        FirewallPolicyIntrusionDetectionConfiguration IPersistableModel<FirewallPolicyIntrusionDetectionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyIntrusionDetectionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallPolicyIntrusionDetectionConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallPolicyIntrusionDetectionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallPolicyIntrusionDetectionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
