// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class GetBotServiceQnAMakerEndpointKeyResult : IUtf8JsonSerializable, IJsonModel<GetBotServiceQnAMakerEndpointKeyResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GetBotServiceQnAMakerEndpointKeyResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GetBotServiceQnAMakerEndpointKeyResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetBotServiceQnAMakerEndpointKeyResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetBotServiceQnAMakerEndpointKeyResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryEndpointKey))
            {
                writer.WritePropertyName("primaryEndpointKey"u8);
                writer.WriteStringValue(PrimaryEndpointKey);
            }
            if (Optional.IsDefined(SecondaryEndpointKey))
            {
                writer.WritePropertyName("secondaryEndpointKey"u8);
                writer.WriteStringValue(SecondaryEndpointKey);
            }
            if (Optional.IsDefined(InstalledVersion))
            {
                writer.WritePropertyName("installedVersion"u8);
                writer.WriteStringValue(InstalledVersion);
            }
            if (Optional.IsDefined(LastStableVersion))
            {
                writer.WritePropertyName("lastStableVersion"u8);
                writer.WriteStringValue(LastStableVersion);
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

        GetBotServiceQnAMakerEndpointKeyResult IJsonModel<GetBotServiceQnAMakerEndpointKeyResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetBotServiceQnAMakerEndpointKeyResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetBotServiceQnAMakerEndpointKeyResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGetBotServiceQnAMakerEndpointKeyResult(document.RootElement, options);
        }

        internal static GetBotServiceQnAMakerEndpointKeyResult DeserializeGetBotServiceQnAMakerEndpointKeyResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryEndpointKey = default;
            Optional<string> secondaryEndpointKey = default;
            Optional<string> installedVersion = default;
            Optional<string> lastStableVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryEndpointKey"u8))
                {
                    primaryEndpointKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryEndpointKey"u8))
                {
                    secondaryEndpointKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("installedVersion"u8))
                {
                    installedVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastStableVersion"u8))
                {
                    lastStableVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GetBotServiceQnAMakerEndpointKeyResult(primaryEndpointKey.Value, secondaryEndpointKey.Value, installedVersion.Value, lastStableVersion.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GetBotServiceQnAMakerEndpointKeyResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetBotServiceQnAMakerEndpointKeyResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GetBotServiceQnAMakerEndpointKeyResult)} does not support '{options.Format}' format.");
            }
        }

        GetBotServiceQnAMakerEndpointKeyResult IPersistableModel<GetBotServiceQnAMakerEndpointKeyResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetBotServiceQnAMakerEndpointKeyResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGetBotServiceQnAMakerEndpointKeyResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GetBotServiceQnAMakerEndpointKeyResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GetBotServiceQnAMakerEndpointKeyResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
