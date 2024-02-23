// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError : IUtf8JsonSerializable, IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError(document.RootElement, options);
        }

        internal static MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> errorMessage = default;
            Optional<IReadOnlyList<SyncMigrationDatabaseErrorEvent>> events = default;
            Optional<string> id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SyncMigrationDatabaseErrorEvent> array = new List<SyncMigrationDatabaseErrorEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncMigrationDatabaseErrorEvent.DeserializeSyncMigrationDatabaseErrorEvent(item, options));
                    }
                    events = array;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError(id.Value, resultType, serializedAdditionalRawData, errorMessage.Value, Optional.ToList(events));
        }

        BinaryData IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError)} does not support '{options.Format}' format.");
            }
        }

        MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskOutputDatabaseError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
