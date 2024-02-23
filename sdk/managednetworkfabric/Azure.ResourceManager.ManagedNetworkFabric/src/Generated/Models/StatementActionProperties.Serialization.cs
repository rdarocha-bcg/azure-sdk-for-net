// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class StatementActionProperties : IUtf8JsonSerializable, IJsonModel<StatementActionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StatementActionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StatementActionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatementActionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StatementActionProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(LocalPreference))
            {
                writer.WritePropertyName("localPreference"u8);
                writer.WriteNumberValue(LocalPreference.Value);
            }
            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
            if (Optional.IsDefined(IPCommunityProperties))
            {
                writer.WritePropertyName("ipCommunityProperties"u8);
                writer.WriteObjectValue(IPCommunityProperties);
            }
            if (Optional.IsDefined(IPExtendedCommunityProperties))
            {
                writer.WritePropertyName("ipExtendedCommunityProperties"u8);
                writer.WriteObjectValue(IPExtendedCommunityProperties);
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

        StatementActionProperties IJsonModel<StatementActionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatementActionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StatementActionProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStatementActionProperties(document.RootElement, options);
        }

        internal static StatementActionProperties DeserializeStatementActionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> localPreference = default;
            RoutePolicyActionType actionType = default;
            Optional<ActionIPCommunityProperties> ipCommunityProperties = default;
            Optional<ActionIPExtendedCommunityProperties> ipExtendedCommunityProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("localPreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    localPreference = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new RoutePolicyActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipCommunityProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipCommunityProperties = ActionIPCommunityProperties.DeserializeActionIPCommunityProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("ipExtendedCommunityProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipExtendedCommunityProperties = ActionIPExtendedCommunityProperties.DeserializeActionIPExtendedCommunityProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StatementActionProperties(Optional.ToNullable(localPreference), actionType, ipCommunityProperties.Value, ipExtendedCommunityProperties.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StatementActionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatementActionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StatementActionProperties)} does not support '{options.Format}' format.");
            }
        }

        StatementActionProperties IPersistableModel<StatementActionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StatementActionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStatementActionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StatementActionProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StatementActionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
