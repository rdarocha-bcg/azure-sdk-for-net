// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint : IUtf8JsonSerializable, IJsonModel<IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (Optional.IsCollectionDefined(Endpoints))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
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

        IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint IJsonModel<IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint(document.RootElement, options);
        }

        internal static IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint DeserializeIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> category = default;
            Optional<IReadOnlyList<IntegrationRuntimeOutboundNetworkDependenciesEndpoint>> endpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IntegrationRuntimeOutboundNetworkDependenciesEndpoint> array = new List<IntegrationRuntimeOutboundNetworkDependenciesEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntegrationRuntimeOutboundNetworkDependenciesEndpoint.DeserializeIntegrationRuntimeOutboundNetworkDependenciesEndpoint(item, options));
                    }
                    endpoints = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint(category.Value, Optional.ToList(endpoints), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint)} does not support '{options.Format}' format.");
            }
        }

        IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint IPersistableModel<IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
