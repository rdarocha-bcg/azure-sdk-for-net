// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerDelegatedSubnetUsage : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerDelegatedSubnetUsage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerDelegatedSubnetUsage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MySqlFlexibleServerDelegatedSubnetUsage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerDelegatedSubnetUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerDelegatedSubnetUsage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SubnetName))
            {
                writer.WritePropertyName("subnetName"u8);
                writer.WriteStringValue(SubnetName);
            }
            if (options.Format != "W" && Optional.IsDefined(Usage))
            {
                writer.WritePropertyName("usage"u8);
                writer.WriteNumberValue(Usage.Value);
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

        MySqlFlexibleServerDelegatedSubnetUsage IJsonModel<MySqlFlexibleServerDelegatedSubnetUsage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerDelegatedSubnetUsage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerDelegatedSubnetUsage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerDelegatedSubnetUsage(document.RootElement, options);
        }

        internal static MySqlFlexibleServerDelegatedSubnetUsage DeserializeMySqlFlexibleServerDelegatedSubnetUsage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> subnetName = default;
            Optional<long> usage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetName"u8))
                {
                    subnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("usage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usage = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlFlexibleServerDelegatedSubnetUsage(subnetName.Value, Optional.ToNullable(usage), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerDelegatedSubnetUsage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerDelegatedSubnetUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerDelegatedSubnetUsage)} does not support '{options.Format}' format.");
            }
        }

        MySqlFlexibleServerDelegatedSubnetUsage IPersistableModel<MySqlFlexibleServerDelegatedSubnetUsage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerDelegatedSubnetUsage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlFlexibleServerDelegatedSubnetUsage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlFlexibleServerDelegatedSubnetUsage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlFlexibleServerDelegatedSubnetUsage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
