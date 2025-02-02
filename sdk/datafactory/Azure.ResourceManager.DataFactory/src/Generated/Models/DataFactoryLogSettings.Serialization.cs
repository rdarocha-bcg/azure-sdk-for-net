// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryLogSettings : IUtf8JsonSerializable, IJsonModel<DataFactoryLogSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryLogSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFactoryLogSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryLogSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryLogSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EnableCopyActivityLog))
            {
                writer.WritePropertyName("enableCopyActivityLog"u8);
                JsonSerializer.Serialize(writer, EnableCopyActivityLog);
            }
            if (Optional.IsDefined(CopyActivityLogSettings))
            {
                writer.WritePropertyName("copyActivityLogSettings"u8);
                writer.WriteObjectValue<CopyActivityLogSettings>(CopyActivityLogSettings, options);
            }
            writer.WritePropertyName("logLocationSettings"u8);
            writer.WriteObjectValue<LogLocationSettings>(LogLocationSettings, options);
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

        DataFactoryLogSettings IJsonModel<DataFactoryLogSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryLogSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryLogSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryLogSettings(document.RootElement, options);
        }

        internal static DataFactoryLogSettings DeserializeDataFactoryLogSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<bool> enableCopyActivityLog = default;
            CopyActivityLogSettings copyActivityLogSettings = default;
            LogLocationSettings logLocationSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableCopyActivityLog"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableCopyActivityLog = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("copyActivityLogSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyActivityLogSettings = CopyActivityLogSettings.DeserializeCopyActivityLogSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("logLocationSettings"u8))
                {
                    logLocationSettings = LogLocationSettings.DeserializeLogLocationSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataFactoryLogSettings(enableCopyActivityLog, copyActivityLogSettings, logLocationSettings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataFactoryLogSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryLogSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryLogSettings)} does not support writing '{options.Format}' format.");
            }
        }

        DataFactoryLogSettings IPersistableModel<DataFactoryLogSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryLogSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryLogSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryLogSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryLogSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
