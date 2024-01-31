// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class AmlFileSystemRootSquashSettings : IUtf8JsonSerializable, IJsonModel<AmlFileSystemRootSquashSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AmlFileSystemRootSquashSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AmlFileSystemRootSquashSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemRootSquashSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlFileSystemRootSquashSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(NoSquashNidLists))
            {
                writer.WritePropertyName("noSquashNidLists"u8);
                writer.WriteStringValue(NoSquashNidLists);
            }
            if (Optional.IsDefined(SquashUID))
            {
                writer.WritePropertyName("squashUID"u8);
                writer.WriteNumberValue(SquashUID.Value);
            }
            if (Optional.IsDefined(SquashGID))
            {
                writer.WritePropertyName("squashGID"u8);
                writer.WriteNumberValue(SquashGID.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
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

        AmlFileSystemRootSquashSettings IJsonModel<AmlFileSystemRootSquashSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemRootSquashSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlFileSystemRootSquashSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlFileSystemRootSquashSettings(document.RootElement, options);
        }

        internal static AmlFileSystemRootSquashSettings DeserializeAmlFileSystemRootSquashSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AmlFileSystemSquashMode> mode = default;
            Optional<string> noSquashNidLists = default;
            Optional<long> squashUID = default;
            Optional<long> squashGID = default;
            Optional<string> status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new AmlFileSystemSquashMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("noSquashNidLists"u8))
                {
                    noSquashNidLists = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("squashUID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    squashUID = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("squashGID"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    squashGID = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AmlFileSystemRootSquashSettings(Optional.ToNullable(mode), noSquashNidLists.Value, Optional.ToNullable(squashUID), Optional.ToNullable(squashGID), status.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AmlFileSystemRootSquashSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemRootSquashSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AmlFileSystemRootSquashSettings)} does not support '{options.Format}' format.");
            }
        }

        AmlFileSystemRootSquashSettings IPersistableModel<AmlFileSystemRootSquashSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemRootSquashSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAmlFileSystemRootSquashSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AmlFileSystemRootSquashSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AmlFileSystemRootSquashSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
