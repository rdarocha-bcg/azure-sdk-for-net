// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    public partial class DataExplorerConnectionProperties : IUtf8JsonSerializable, IJsonModel<DataExplorerConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataExplorerConnectionProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataExplorerConnectionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataExplorerConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataExplorerConnectionProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("adxResourceId"u8);
            writer.WriteStringValue(AdxResourceId);
            writer.WritePropertyName("adxEndpointUri"u8);
            writer.WriteStringValue(AdxEndpointUri.AbsoluteUri);
            writer.WritePropertyName("adxDatabaseName"u8);
            writer.WriteStringValue(AdxDatabaseName);
            if (Optional.IsDefined(AdxTableName))
            {
                if (AdxTableName != null)
                {
                    writer.WritePropertyName("adxTableName"u8);
                    writer.WriteStringValue(AdxTableName);
                }
                else
                {
                    writer.WriteNull("adxTableName");
                }
            }
            if (Optional.IsDefined(AdxTwinLifecycleEventsTableName))
            {
                if (AdxTwinLifecycleEventsTableName != null)
                {
                    writer.WritePropertyName("adxTwinLifecycleEventsTableName"u8);
                    writer.WriteStringValue(AdxTwinLifecycleEventsTableName);
                }
                else
                {
                    writer.WriteNull("adxTwinLifecycleEventsTableName");
                }
            }
            if (Optional.IsDefined(AdxRelationshipLifecycleEventsTableName))
            {
                if (AdxRelationshipLifecycleEventsTableName != null)
                {
                    writer.WritePropertyName("adxRelationshipLifecycleEventsTableName"u8);
                    writer.WriteStringValue(AdxRelationshipLifecycleEventsTableName);
                }
                else
                {
                    writer.WriteNull("adxRelationshipLifecycleEventsTableName");
                }
            }
            writer.WritePropertyName("eventHubEndpointUri"u8);
            writer.WriteStringValue(EventHubEndpointUri.AbsoluteUri);
            writer.WritePropertyName("eventHubEntityPath"u8);
            writer.WriteStringValue(EventHubEntityPath);
            writer.WritePropertyName("eventHubNamespaceResourceId"u8);
            writer.WriteStringValue(EventHubNamespaceResourceId);
            if (Optional.IsDefined(EventHubConsumerGroup))
            {
                if (EventHubConsumerGroup != null)
                {
                    writer.WritePropertyName("eventHubConsumerGroup"u8);
                    writer.WriteStringValue(EventHubConsumerGroup);
                }
                else
                {
                    writer.WriteNull("eventHubConsumerGroup");
                }
            }
            if (Optional.IsDefined(RecordPropertyAndItemRemovals))
            {
                if (RecordPropertyAndItemRemovals != null)
                {
                    writer.WritePropertyName("recordPropertyAndItemRemovals"u8);
                    writer.WriteStringValue(RecordPropertyAndItemRemovals.Value.ToString());
                }
                else
                {
                    writer.WriteNull("recordPropertyAndItemRemovals");
                }
            }
            writer.WritePropertyName("connectionType"u8);
            writer.WriteStringValue(ConnectionType.ToString());
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
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

        DataExplorerConnectionProperties IJsonModel<DataExplorerConnectionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataExplorerConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataExplorerConnectionProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataExplorerConnectionProperties(document.RootElement, options);
        }

        internal static DataExplorerConnectionProperties DeserializeDataExplorerConnectionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier adxResourceId = default;
            Uri adxEndpointUri = default;
            string adxDatabaseName = default;
            Optional<string> adxTableName = default;
            Optional<string> adxTwinLifecycleEventsTableName = default;
            Optional<string> adxRelationshipLifecycleEventsTableName = default;
            Uri eventHubEndpointUri = default;
            string eventHubEntityPath = default;
            ResourceIdentifier eventHubNamespaceResourceId = default;
            Optional<string> eventHubConsumerGroup = default;
            Optional<RecordPropertyAndItemRemoval?> recordPropertyAndItemRemovals = default;
            ConnectionType connectionType = default;
            Optional<TimeSeriesDatabaseConnectionState> provisioningState = default;
            Optional<DigitalTwinsManagedIdentityReference> identity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adxResourceId"u8))
                {
                    adxResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("adxEndpointUri"u8))
                {
                    adxEndpointUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("adxDatabaseName"u8))
                {
                    adxDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adxTableName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        adxTableName = null;
                        continue;
                    }
                    adxTableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adxTwinLifecycleEventsTableName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        adxTwinLifecycleEventsTableName = null;
                        continue;
                    }
                    adxTwinLifecycleEventsTableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adxRelationshipLifecycleEventsTableName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        adxRelationshipLifecycleEventsTableName = null;
                        continue;
                    }
                    adxRelationshipLifecycleEventsTableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventHubEndpointUri"u8))
                {
                    eventHubEndpointUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("eventHubEntityPath"u8))
                {
                    eventHubEntityPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventHubNamespaceResourceId"u8))
                {
                    eventHubNamespaceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("eventHubConsumerGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        eventHubConsumerGroup = null;
                        continue;
                    }
                    eventHubConsumerGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recordPropertyAndItemRemovals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        recordPropertyAndItemRemovals = null;
                        continue;
                    }
                    recordPropertyAndItemRemovals = new RecordPropertyAndItemRemoval(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("connectionType"u8))
                {
                    connectionType = new ConnectionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new TimeSeriesDatabaseConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = DigitalTwinsManagedIdentityReference.DeserializeDigitalTwinsManagedIdentityReference(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataExplorerConnectionProperties(connectionType, Optional.ToNullable(provisioningState), identity.Value, serializedAdditionalRawData, adxResourceId, adxEndpointUri, adxDatabaseName, adxTableName.Value, adxTwinLifecycleEventsTableName.Value, adxRelationshipLifecycleEventsTableName.Value, eventHubEndpointUri, eventHubEntityPath, eventHubNamespaceResourceId, eventHubConsumerGroup.Value, Optional.ToNullable(recordPropertyAndItemRemovals));
        }

        BinaryData IPersistableModel<DataExplorerConnectionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataExplorerConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataExplorerConnectionProperties)} does not support '{options.Format}' format.");
            }
        }

        DataExplorerConnectionProperties IPersistableModel<DataExplorerConnectionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataExplorerConnectionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataExplorerConnectionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataExplorerConnectionProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataExplorerConnectionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
