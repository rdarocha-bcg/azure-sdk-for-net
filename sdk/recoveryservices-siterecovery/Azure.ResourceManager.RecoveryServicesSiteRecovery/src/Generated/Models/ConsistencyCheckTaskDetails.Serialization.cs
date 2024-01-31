// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ConsistencyCheckTaskDetails : IUtf8JsonSerializable, IJsonModel<ConsistencyCheckTaskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsistencyCheckTaskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConsistencyCheckTaskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsistencyCheckTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsistencyCheckTaskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(VmDetails))
            {
                writer.WritePropertyName("vmDetails"u8);
                writer.WriteStartArray();
                foreach (var item in VmDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        ConsistencyCheckTaskDetails IJsonModel<ConsistencyCheckTaskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsistencyCheckTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsistencyCheckTaskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsistencyCheckTaskDetails(document.RootElement, options);
        }

        internal static ConsistencyCheckTaskDetails DeserializeConsistencyCheckTaskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<InconsistentVmDetails>> vmDetails = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InconsistentVmDetails> array = new List<InconsistentVmDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InconsistentVmDetails.DeserializeInconsistentVmDetails(item));
                    }
                    vmDetails = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConsistencyCheckTaskDetails(instanceType, serializedAdditionalRawData, Optional.ToList(vmDetails));
        }

        BinaryData IPersistableModel<ConsistencyCheckTaskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsistencyCheckTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConsistencyCheckTaskDetails)} does not support '{options.Format}' format.");
            }
        }

        ConsistencyCheckTaskDetails IPersistableModel<ConsistencyCheckTaskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsistencyCheckTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsistencyCheckTaskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsistencyCheckTaskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsistencyCheckTaskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
