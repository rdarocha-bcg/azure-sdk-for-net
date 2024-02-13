// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownSparkJobEntry))]
    public partial class SparkJobEntry : IUtf8JsonSerializable, IJsonModel<SparkJobEntry>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SparkJobEntry>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SparkJobEntry>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkJobEntry>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SparkJobEntry)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sparkJobEntryType"u8);
            writer.WriteStringValue(SparkJobEntryType.ToString());
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

        SparkJobEntry IJsonModel<SparkJobEntry>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkJobEntry>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SparkJobEntry)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkJobEntry(document.RootElement, options);
        }

        internal static SparkJobEntry DeserializeSparkJobEntry(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("sparkJobEntryType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "SparkJobPythonEntry": return SparkJobPythonEntry.DeserializeSparkJobPythonEntry(element);
                    case "SparkJobScalaEntry": return SparkJobScalaEntry.DeserializeSparkJobScalaEntry(element);
                }
            }
            return UnknownSparkJobEntry.DeserializeUnknownSparkJobEntry(element);
        }

        BinaryData IPersistableModel<SparkJobEntry>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkJobEntry>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SparkJobEntry)} does not support '{options.Format}' format.");
            }
        }

        SparkJobEntry IPersistableModel<SparkJobEntry>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SparkJobEntry>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSparkJobEntry(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SparkJobEntry)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SparkJobEntry>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
