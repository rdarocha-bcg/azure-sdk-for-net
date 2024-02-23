// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    public partial class ToolOutput : IUtf8JsonSerializable, IJsonModel<ToolOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ToolOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ToolOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ToolOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ToolOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ToolCallId))
            {
                writer.WritePropertyName("tool_call_id"u8);
                writer.WriteStringValue(ToolCallId);
            }
            if (Optional.IsDefined(Output))
            {
                writer.WritePropertyName("output"u8);
                writer.WriteStringValue(Output);
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

        ToolOutput IJsonModel<ToolOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ToolOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ToolOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeToolOutput(document.RootElement, options);
        }

        internal static ToolOutput DeserializeToolOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> toolCallId = default;
            Optional<string> output = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tool_call_id"u8))
                {
                    toolCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    output = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ToolOutput(toolCallId.Value, output.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ToolOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ToolOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ToolOutput)} does not support '{options.Format}' format.");
            }
        }

        ToolOutput IPersistableModel<ToolOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ToolOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeToolOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ToolOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ToolOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ToolOutput FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeToolOutput(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
