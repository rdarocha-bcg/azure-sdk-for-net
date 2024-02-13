// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class HelmMappingRuleProfileConfig : IUtf8JsonSerializable, IJsonModel<HelmMappingRuleProfileConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HelmMappingRuleProfileConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HelmMappingRuleProfileConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmMappingRuleProfileConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HelmMappingRuleProfileConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InstallOptions))
            {
                writer.WritePropertyName("installOptions"u8);
                writer.WriteObjectValue(InstallOptions);
            }
            if (Optional.IsDefined(UpgradeOptions))
            {
                writer.WritePropertyName("upgradeOptions"u8);
                writer.WriteObjectValue(UpgradeOptions);
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

        HelmMappingRuleProfileConfig IJsonModel<HelmMappingRuleProfileConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmMappingRuleProfileConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HelmMappingRuleProfileConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHelmMappingRuleProfileConfig(document.RootElement, options);
        }

        internal static HelmMappingRuleProfileConfig DeserializeHelmMappingRuleProfileConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HelmInstallConfig> installOptions = default;
            Optional<HelmUpgradeConfig> upgradeOptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("installOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    installOptions = HelmInstallConfig.DeserializeHelmInstallConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("upgradeOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeOptions = HelmUpgradeConfig.DeserializeHelmUpgradeConfig(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HelmMappingRuleProfileConfig(installOptions.Value, upgradeOptions.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HelmMappingRuleProfileConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmMappingRuleProfileConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HelmMappingRuleProfileConfig)} does not support '{options.Format}' format.");
            }
        }

        HelmMappingRuleProfileConfig IPersistableModel<HelmMappingRuleProfileConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HelmMappingRuleProfileConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHelmMappingRuleProfileConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HelmMappingRuleProfileConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HelmMappingRuleProfileConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
