// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningAzureDataLakeGen2Datastore : IUtf8JsonSerializable, IJsonModel<MachineLearningAzureDataLakeGen2Datastore>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningAzureDataLakeGen2Datastore>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningAzureDataLakeGen2Datastore>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAzureDataLakeGen2Datastore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAzureDataLakeGen2Datastore)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("accountName"u8);
            writer.WriteStringValue(AccountName);
            if (Optional.IsDefined(Endpoint))
            {
                if (Endpoint != null)
                {
                    writer.WritePropertyName("endpoint"u8);
                    writer.WriteStringValue(Endpoint);
                }
                else
                {
                    writer.WriteNull("endpoint");
                }
            }
            writer.WritePropertyName("filesystem"u8);
            writer.WriteStringValue(Filesystem);
            if (Optional.IsDefined(Protocol))
            {
                if (Protocol != null)
                {
                    writer.WritePropertyName("protocol"u8);
                    writer.WriteStringValue(Protocol);
                }
                else
                {
                    writer.WriteNull("protocol");
                }
            }
            if (Optional.IsDefined(ServiceDataAccessAuthIdentity))
            {
                writer.WritePropertyName("serviceDataAccessAuthIdentity"u8);
                writer.WriteStringValue(ServiceDataAccessAuthIdentity.Value.ToString());
            }
            if (Optional.IsDefined(ResourceGroup))
            {
                if (ResourceGroup != null)
                {
                    writer.WritePropertyName("resourceGroup"u8);
                    writer.WriteStringValue(ResourceGroup);
                }
                else
                {
                    writer.WriteNull("resourceGroup");
                }
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                if (SubscriptionId != null)
                {
                    writer.WritePropertyName("subscriptionId"u8);
                    writer.WriteStringValue(SubscriptionId);
                }
                else
                {
                    writer.WriteNull("subscriptionId");
                }
            }
            writer.WritePropertyName("credentials"u8);
            writer.WriteObjectValue(Credentials);
            writer.WritePropertyName("datastoreType"u8);
            writer.WriteStringValue(DatastoreType.ToString());
            if (Optional.IsDefined(IntellectualProperty))
            {
                if (IntellectualProperty != null)
                {
                    writer.WritePropertyName("intellectualProperty"u8);
                    writer.WriteObjectValue(IntellectualProperty);
                }
                else
                {
                    writer.WriteNull("intellectualProperty");
                }
            }
            if (options.Format != "W" && Optional.IsDefined(IsDefault))
            {
                writer.WritePropertyName("isDefault"u8);
                writer.WriteBooleanValue(IsDefault.Value);
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
                {
                    writer.WritePropertyName("tags"u8);
                    writer.WriteStartObject();
                    foreach (var item in Tags)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("tags");
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

        MachineLearningAzureDataLakeGen2Datastore IJsonModel<MachineLearningAzureDataLakeGen2Datastore>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAzureDataLakeGen2Datastore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningAzureDataLakeGen2Datastore)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAzureDataLakeGen2Datastore(document.RootElement, options);
        }

        internal static MachineLearningAzureDataLakeGen2Datastore DeserializeMachineLearningAzureDataLakeGen2Datastore(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accountName = default;
            Optional<string> endpoint = default;
            string filesystem = default;
            Optional<string> protocol = default;
            Optional<MachineLearningServiceDataAccessAuthIdentity> serviceDataAccessAuthIdentity = default;
            Optional<string> resourceGroup = default;
            Optional<string> subscriptionId = default;
            MachineLearningDatastoreCredentials credentials = default;
            DatastoreType datastoreType = default;
            Optional<IntellectualProperty> intellectualProperty = default;
            Optional<bool> isDefault = default;
            Optional<string> description = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<IDictionary<string, string>> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endpoint = null;
                        continue;
                    }
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filesystem"u8))
                {
                    filesystem = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        protocol = null;
                        continue;
                    }
                    protocol = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceDataAccessAuthIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceDataAccessAuthIdentity = new MachineLearningServiceDataAccessAuthIdentity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceGroup = null;
                        continue;
                    }
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        subscriptionId = null;
                        continue;
                    }
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    credentials = MachineLearningDatastoreCredentials.DeserializeMachineLearningDatastoreCredentials(property.Value, options);
                    continue;
                }
                if (property.NameEquals("datastoreType"u8))
                {
                    datastoreType = new DatastoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("intellectualProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        intellectualProperty = null;
                        continue;
                    }
                    intellectualProperty = IntellectualProperty.DeserializeIntellectualProperty(property.Value, options);
                    continue;
                }
                if (property.NameEquals("isDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningAzureDataLakeGen2Datastore(description.Value, Optional.ToDictionary(properties), Optional.ToDictionary(tags), serializedAdditionalRawData, credentials, datastoreType, intellectualProperty.Value, Optional.ToNullable(isDefault), accountName, endpoint.Value, filesystem, protocol.Value, Optional.ToNullable(serviceDataAccessAuthIdentity), resourceGroup.Value, subscriptionId.Value);
        }

        BinaryData IPersistableModel<MachineLearningAzureDataLakeGen2Datastore>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAzureDataLakeGen2Datastore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAzureDataLakeGen2Datastore)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningAzureDataLakeGen2Datastore IPersistableModel<MachineLearningAzureDataLakeGen2Datastore>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningAzureDataLakeGen2Datastore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningAzureDataLakeGen2Datastore(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningAzureDataLakeGen2Datastore)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningAzureDataLakeGen2Datastore>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
