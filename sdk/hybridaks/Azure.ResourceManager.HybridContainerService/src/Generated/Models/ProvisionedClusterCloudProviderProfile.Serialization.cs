// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    internal partial class ProvisionedClusterCloudProviderProfile : IUtf8JsonSerializable, IJsonModel<ProvisionedClusterCloudProviderProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProvisionedClusterCloudProviderProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProvisionedClusterCloudProviderProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterCloudProviderProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProvisionedClusterCloudProviderProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InfraNetworkProfile))
            {
                writer.WritePropertyName("infraNetworkProfile"u8);
                writer.WriteObjectValue(InfraNetworkProfile);
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

        ProvisionedClusterCloudProviderProfile IJsonModel<ProvisionedClusterCloudProviderProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterCloudProviderProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProvisionedClusterCloudProviderProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProvisionedClusterCloudProviderProfile(document.RootElement, options);
        }

        internal static ProvisionedClusterCloudProviderProfile DeserializeProvisionedClusterCloudProviderProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisionedClusterInfraNetworkProfile> infraNetworkProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("infraNetworkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infraNetworkProfile = ProvisionedClusterInfraNetworkProfile.DeserializeProvisionedClusterInfraNetworkProfile(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProvisionedClusterCloudProviderProfile(infraNetworkProfile.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProvisionedClusterCloudProviderProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterCloudProviderProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProvisionedClusterCloudProviderProfile)} does not support '{options.Format}' format.");
            }
        }

        ProvisionedClusterCloudProviderProfile IPersistableModel<ProvisionedClusterCloudProviderProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProvisionedClusterCloudProviderProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProvisionedClusterCloudProviderProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProvisionedClusterCloudProviderProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProvisionedClusterCloudProviderProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
