// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaJobInputAsset : IUtf8JsonSerializable, IJsonModel<MediaJobInputAsset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaJobInputAsset>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaJobInputAsset>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobInputAsset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaJobInputAsset)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("assetName"u8);
            writer.WriteStringValue(AssetName);
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files"u8);
                writer.WriteStartArray();
                foreach (var item in Files)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Start))
            {
                writer.WritePropertyName("start"u8);
                writer.WriteObjectValue(Start);
            }
            if (Optional.IsDefined(End))
            {
                writer.WritePropertyName("end"u8);
                writer.WriteObjectValue(End);
            }
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            if (Optional.IsCollectionDefined(InputDefinitions))
            {
                writer.WritePropertyName("inputDefinitions"u8);
                writer.WriteStartArray();
                foreach (var item in InputDefinitions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        MediaJobInputAsset IJsonModel<MediaJobInputAsset>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobInputAsset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaJobInputAsset)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaJobInputAsset(document.RootElement, options);
        }

        internal static MediaJobInputAsset DeserializeMediaJobInputAsset(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string assetName = default;
            Optional<IList<string>> files = default;
            Optional<ClipTime> start = default;
            Optional<ClipTime> end = default;
            Optional<string> label = default;
            Optional<IList<MediaJobInputDefinition>> inputDefinitions = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assetName"u8))
                {
                    assetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("files"u8))
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
                    files = array;
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    start = ClipTime.DeserializeClipTime(property.Value, options);
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    end = ClipTime.DeserializeClipTime(property.Value, options);
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputDefinitions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaJobInputDefinition> array = new List<MediaJobInputDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaJobInputDefinition.DeserializeMediaJobInputDefinition(item, options));
                    }
                    inputDefinitions = array;
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MediaJobInputAsset(odataType, serializedAdditionalRawData, Optional.ToList(files), start.Value, end.Value, label.Value, Optional.ToList(inputDefinitions), assetName);
        }

        BinaryData IPersistableModel<MediaJobInputAsset>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobInputAsset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaJobInputAsset)} does not support '{options.Format}' format.");
            }
        }

        MediaJobInputAsset IPersistableModel<MediaJobInputAsset>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaJobInputAsset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaJobInputAsset(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaJobInputAsset)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaJobInputAsset>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
