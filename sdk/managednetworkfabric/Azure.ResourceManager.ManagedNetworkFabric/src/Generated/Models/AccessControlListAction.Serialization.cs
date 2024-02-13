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
    public partial class AccessControlListAction : IUtf8JsonSerializable, IJsonModel<AccessControlListAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AccessControlListAction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AccessControlListAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlListAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessControlListAction)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AclActionType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(AclActionType.Value.ToString());
            }
            if (Optional.IsDefined(CounterName))
            {
                writer.WritePropertyName("counterName"u8);
                writer.WriteStringValue(CounterName);
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

        AccessControlListAction IJsonModel<AccessControlListAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlListAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessControlListAction)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAccessControlListAction(document.RootElement, options);
        }

        internal static AccessControlListAction DeserializeAccessControlListAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AclActionType> type = default;
            Optional<string> counterName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new AclActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("counterName"u8))
                {
                    counterName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AccessControlListAction(Optional.ToNullable(type), counterName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AccessControlListAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlListAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AccessControlListAction)} does not support '{options.Format}' format.");
            }
        }

        AccessControlListAction IPersistableModel<AccessControlListAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessControlListAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAccessControlListAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AccessControlListAction)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AccessControlListAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
