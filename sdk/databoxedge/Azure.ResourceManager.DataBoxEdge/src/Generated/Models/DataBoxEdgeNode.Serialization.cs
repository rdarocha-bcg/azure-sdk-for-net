// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeNode : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeNode>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeNode>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxEdgeNode>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeNode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeNode)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(NodeStatus))
            {
                writer.WritePropertyName("nodeStatus"u8);
                writer.WriteStringValue(NodeStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(NodeChassisSerialNumber))
            {
                writer.WritePropertyName("nodeChassisSerialNumber"u8);
                writer.WriteStringValue(NodeChassisSerialNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(NodeSerialNumber))
            {
                writer.WritePropertyName("nodeSerialNumber"u8);
                writer.WriteStringValue(NodeSerialNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(NodeDisplayName))
            {
                writer.WritePropertyName("nodeDisplayName"u8);
                writer.WriteStringValue(NodeDisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(NodeFriendlySoftwareVersion))
            {
                writer.WritePropertyName("nodeFriendlySoftwareVersion"u8);
                writer.WriteStringValue(NodeFriendlySoftwareVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(NodeHcsVersion))
            {
                writer.WritePropertyName("nodeHcsVersion"u8);
                writer.WriteStringValue(NodeHcsVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(NodeInstanceId))
            {
                writer.WritePropertyName("nodeInstanceId"u8);
                writer.WriteStringValue(NodeInstanceId.Value);
            }
            writer.WriteEndObject();
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

        DataBoxEdgeNode IJsonModel<DataBoxEdgeNode>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeNode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeNode)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeNode(document.RootElement, options);
        }

        internal static DataBoxEdgeNode DeserializeDataBoxEdgeNode(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DataBoxEdgeNodeStatus> nodeStatus = default;
            Optional<string> nodeChassisSerialNumber = default;
            Optional<string> nodeSerialNumber = default;
            Optional<string> nodeDisplayName = default;
            Optional<string> nodeFriendlySoftwareVersion = default;
            Optional<string> nodeHcsVersion = default;
            Optional<Guid> nodeInstanceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("nodeStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeStatus = new DataBoxEdgeNodeStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("nodeChassisSerialNumber"u8))
                        {
                            nodeChassisSerialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeSerialNumber"u8))
                        {
                            nodeSerialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeDisplayName"u8))
                        {
                            nodeDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeFriendlySoftwareVersion"u8))
                        {
                            nodeFriendlySoftwareVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeHcsVersion"u8))
                        {
                            nodeHcsVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeInstanceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeInstanceId = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxEdgeNode(id, name, type, systemData.Value, Optional.ToNullable(nodeStatus), nodeChassisSerialNumber.Value, nodeSerialNumber.Value, nodeDisplayName.Value, nodeFriendlySoftwareVersion.Value, nodeHcsVersion.Value, Optional.ToNullable(nodeInstanceId), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxEdgeNode>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeNode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeNode)} does not support '{options.Format}' format.");
            }
        }

        DataBoxEdgeNode IPersistableModel<DataBoxEdgeNode>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeNode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxEdgeNode(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeNode)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeNode>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
