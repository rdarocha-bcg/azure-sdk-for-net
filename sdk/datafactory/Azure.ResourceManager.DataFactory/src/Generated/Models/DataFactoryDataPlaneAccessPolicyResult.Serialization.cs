// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryDataPlaneAccessPolicyResult : IUtf8JsonSerializable, IJsonModel<DataFactoryDataPlaneAccessPolicyResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryDataPlaneAccessPolicyResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFactoryDataPlaneAccessPolicyResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataPlaneAccessPolicyResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryDataPlaneAccessPolicyResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy"u8);
                writer.WriteObjectValue(Policy);
            }
            if (Optional.IsDefined(AccessToken))
            {
                writer.WritePropertyName("accessToken"u8);
                writer.WriteStringValue(AccessToken);
            }
            if (Optional.IsDefined(DataPlaneUri))
            {
                writer.WritePropertyName("dataPlaneUrl"u8);
                writer.WriteStringValue(DataPlaneUri.AbsoluteUri);
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

        DataFactoryDataPlaneAccessPolicyResult IJsonModel<DataFactoryDataPlaneAccessPolicyResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataPlaneAccessPolicyResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryDataPlaneAccessPolicyResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryDataPlaneAccessPolicyResult(document.RootElement, options);
        }

        internal static DataFactoryDataPlaneAccessPolicyResult DeserializeDataFactoryDataPlaneAccessPolicyResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryDataPlaneUserAccessPolicy> policy = default;
            Optional<string> accessToken = default;
            Optional<Uri> dataPlaneUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = DataFactoryDataPlaneUserAccessPolicy.DeserializeDataFactoryDataPlaneUserAccessPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("accessToken"u8))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataPlaneUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPlaneUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataFactoryDataPlaneAccessPolicyResult(policy.Value, accessToken.Value, dataPlaneUrl.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataFactoryDataPlaneAccessPolicyResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataPlaneAccessPolicyResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryDataPlaneAccessPolicyResult)} does not support '{options.Format}' format.");
            }
        }

        DataFactoryDataPlaneAccessPolicyResult IPersistableModel<DataFactoryDataPlaneAccessPolicyResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataPlaneAccessPolicyResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryDataPlaneAccessPolicyResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryDataPlaneAccessPolicyResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryDataPlaneAccessPolicyResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
