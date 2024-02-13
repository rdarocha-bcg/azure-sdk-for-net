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
    public partial class PolybaseSettings : IUtf8JsonSerializable, IJsonModel<PolybaseSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolybaseSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolybaseSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolybaseSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolybaseSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RejectType))
            {
                writer.WritePropertyName("rejectType"u8);
                writer.WriteStringValue(RejectType.Value.ToString());
            }
            if (Optional.IsDefined(RejectValue))
            {
                writer.WritePropertyName("rejectValue"u8);
                JsonSerializer.Serialize(writer, RejectValue);
            }
            if (Optional.IsDefined(RejectSampleValue))
            {
                writer.WritePropertyName("rejectSampleValue"u8);
                JsonSerializer.Serialize(writer, RejectSampleValue);
            }
            if (Optional.IsDefined(UseTypeDefault))
            {
                writer.WritePropertyName("useTypeDefault"u8);
                JsonSerializer.Serialize(writer, UseTypeDefault);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        PolybaseSettings IJsonModel<PolybaseSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolybaseSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolybaseSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolybaseSettings(document.RootElement, options);
        }

        internal static PolybaseSettings DeserializePolybaseSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PolybaseSettingsRejectType> rejectType = default;
            Optional<DataFactoryElement<int>> rejectValue = default;
            Optional<DataFactoryElement<int>> rejectSampleValue = default;
            Optional<DataFactoryElement<bool>> useTypeDefault = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rejectType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rejectType = new PolybaseSettingsRejectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rejectValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rejectValue = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("rejectSampleValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rejectSampleValue = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("useTypeDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useTypeDefault = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PolybaseSettings(Optional.ToNullable(rejectType), rejectValue.Value, rejectSampleValue.Value, useTypeDefault.Value, additionalProperties);
        }

        BinaryData IPersistableModel<PolybaseSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolybaseSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolybaseSettings)} does not support '{options.Format}' format.");
            }
        }

        PolybaseSettings IPersistableModel<PolybaseSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolybaseSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolybaseSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolybaseSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolybaseSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
