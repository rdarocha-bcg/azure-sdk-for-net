// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class RulesEngineRule : IUtf8JsonSerializable, IJsonModel<RulesEngineRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RulesEngineRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RulesEngineRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulesEngineRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RulesEngineRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("priority"u8);
            writer.WriteNumberValue(Priority);
            writer.WritePropertyName("action"u8);
            writer.WriteObjectValue(Action);
            if (Optional.IsCollectionDefined(MatchConditions))
            {
                if (MatchConditions != null)
                {
                    writer.WritePropertyName("matchConditions"u8);
                    writer.WriteStartArray();
                    foreach (var item in MatchConditions)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("matchConditions");
                }
            }
            if (Optional.IsDefined(MatchProcessingBehavior))
            {
                if (MatchProcessingBehavior != null)
                {
                    writer.WritePropertyName("matchProcessingBehavior"u8);
                    writer.WriteStringValue(MatchProcessingBehavior.Value.ToString());
                }
                else
                {
                    writer.WriteNull("matchProcessingBehavior");
                }
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

        RulesEngineRule IJsonModel<RulesEngineRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulesEngineRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RulesEngineRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRulesEngineRule(document.RootElement, options);
        }

        internal static RulesEngineRule DeserializeRulesEngineRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            int priority = default;
            RulesEngineAction action = default;
            Optional<IList<RulesEngineMatchCondition>> matchConditions = default;
            Optional<MatchProcessingBehavior?> matchProcessingBehavior = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = RulesEngineAction.DeserializeRulesEngineAction(property.Value, options);
                    continue;
                }
                if (property.NameEquals("matchConditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        matchConditions = null;
                        continue;
                    }
                    List<RulesEngineMatchCondition> array = new List<RulesEngineMatchCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RulesEngineMatchCondition.DeserializeRulesEngineMatchCondition(item, options));
                    }
                    matchConditions = array;
                    continue;
                }
                if (property.NameEquals("matchProcessingBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        matchProcessingBehavior = null;
                        continue;
                    }
                    matchProcessingBehavior = new MatchProcessingBehavior(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RulesEngineRule(name, priority, action, Optional.ToList(matchConditions), Optional.ToNullable(matchProcessingBehavior), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RulesEngineRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulesEngineRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RulesEngineRule)} does not support '{options.Format}' format.");
            }
        }

        RulesEngineRule IPersistableModel<RulesEngineRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RulesEngineRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRulesEngineRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RulesEngineRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RulesEngineRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
