// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ExtendedRestorableTableResourceInfo : IUtf8JsonSerializable, IJsonModel<ExtendedRestorableTableResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtendedRestorableTableResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExtendedRestorableTableResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableTableResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedRestorableTableResourceInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Rid))
            {
                writer.WritePropertyName("_rid"u8);
                writer.WriteStringValue(Rid);
            }
            if (options.Format != "W" && Optional.IsDefined(OperationType))
            {
                writer.WritePropertyName("operationType"u8);
                writer.WriteStringValue(OperationType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CanUndelete))
            {
                writer.WritePropertyName("canUndelete"u8);
                writer.WriteStringValue(CanUndelete);
            }
            if (options.Format != "W" && Optional.IsDefined(CanUndeleteReason))
            {
                writer.WritePropertyName("canUndeleteReason"u8);
                writer.WriteStringValue(CanUndeleteReason);
            }
            if (options.Format != "W" && Optional.IsDefined(EventTimestamp))
            {
                writer.WritePropertyName("eventTimestamp"u8);
                writer.WriteStringValue(EventTimestamp);
            }
            if (options.Format != "W" && Optional.IsDefined(TableName))
            {
                writer.WritePropertyName("ownerId"u8);
                writer.WriteStringValue(TableName);
            }
            if (options.Format != "W" && Optional.IsDefined(TableId))
            {
                writer.WritePropertyName("ownerResourceId"u8);
                writer.WriteStringValue(TableId);
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

        ExtendedRestorableTableResourceInfo IJsonModel<ExtendedRestorableTableResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableTableResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedRestorableTableResourceInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedRestorableTableResourceInfo(document.RootElement, options);
        }

        internal static ExtendedRestorableTableResourceInfo DeserializeExtendedRestorableTableResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string rid = default;
            CosmosDBOperationType? operationType = default;
            string canUndelete = default;
            string canUndeleteReason = default;
            string eventTimestamp = default;
            string ownerId = default;
            string ownerResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationType = new CosmosDBOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("canUndelete"u8))
                {
                    canUndelete = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("canUndeleteReason"u8))
                {
                    canUndeleteReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventTimestamp"u8))
                {
                    eventTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerId"u8))
                {
                    ownerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ownerResourceId"u8))
                {
                    ownerResourceId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExtendedRestorableTableResourceInfo(
                rid,
                operationType,
                canUndelete,
                canUndeleteReason,
                eventTimestamp,
                ownerId,
                ownerResourceId,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Rid), out propertyOverride);
            if (Optional.IsDefined(Rid) || hasPropertyOverride)
            {
                builder.Append("  _rid: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Rid.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Rid}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Rid}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OperationType), out propertyOverride);
            if (Optional.IsDefined(OperationType) || hasPropertyOverride)
            {
                builder.Append("  operationType: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{OperationType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CanUndelete), out propertyOverride);
            if (Optional.IsDefined(CanUndelete) || hasPropertyOverride)
            {
                builder.Append("  canUndelete: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (CanUndelete.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CanUndelete}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CanUndelete}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CanUndeleteReason), out propertyOverride);
            if (Optional.IsDefined(CanUndeleteReason) || hasPropertyOverride)
            {
                builder.Append("  canUndeleteReason: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (CanUndeleteReason.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CanUndeleteReason}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CanUndeleteReason}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EventTimestamp), out propertyOverride);
            if (Optional.IsDefined(EventTimestamp) || hasPropertyOverride)
            {
                builder.Append("  eventTimestamp: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (EventTimestamp.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EventTimestamp}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EventTimestamp}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TableName), out propertyOverride);
            if (Optional.IsDefined(TableName) || hasPropertyOverride)
            {
                builder.Append("  ownerId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (TableName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TableName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TableName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TableId), out propertyOverride);
            if (Optional.IsDefined(TableId) || hasPropertyOverride)
            {
                builder.Append("  ownerResourceId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (TableId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TableId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TableId}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ExtendedRestorableTableResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableTableResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ExtendedRestorableTableResourceInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ExtendedRestorableTableResourceInfo IPersistableModel<ExtendedRestorableTableResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedRestorableTableResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExtendedRestorableTableResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExtendedRestorableTableResourceInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtendedRestorableTableResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
