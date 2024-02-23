// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class AvailableDataBoxEdgeSku : IUtf8JsonSerializable, IJsonModel<AvailableDataBoxEdgeSku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailableDataBoxEdgeSku>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AvailableDataBoxEdgeSku>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableDataBoxEdgeSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailableDataBoxEdgeSku)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W" && Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size);
            }
            if (options.Format != "W" && Optional.IsDefined(Family))
            {
                writer.WritePropertyName("family"u8);
                writer.WriteStringValue(Family);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ApiVersions))
            {
                writer.WritePropertyName("apiVersions"u8);
                writer.WriteStartArray();
                foreach (var item in ApiVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(LocationInfo))
            {
                writer.WritePropertyName("locationInfo"u8);
                writer.WriteStartArray();
                foreach (var item in LocationInfo)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Costs))
            {
                writer.WritePropertyName("costs"u8);
                writer.WriteStartArray();
                foreach (var item in Costs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(SignupOption))
            {
                writer.WritePropertyName("signupOption"u8);
                writer.WriteStringValue(SignupOption.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Availability))
            {
                writer.WritePropertyName("availability"u8);
                writer.WriteStringValue(Availability.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ShipmentTypes))
            {
                writer.WritePropertyName("shipmentTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ShipmentTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        AvailableDataBoxEdgeSku IJsonModel<AvailableDataBoxEdgeSku>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableDataBoxEdgeSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailableDataBoxEdgeSku)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailableDataBoxEdgeSku(document.RootElement, options);
        }

        internal static AvailableDataBoxEdgeSku DeserializeAvailableDataBoxEdgeSku(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceType = default;
            Optional<DataBoxEdgeSkuName> name = default;
            Optional<string> kind = default;
            Optional<DataBoxEdgeSkuTier> tier = default;
            Optional<string> size = default;
            Optional<string> family = default;
            Optional<IReadOnlyList<AzureLocation>> locations = default;
            Optional<IReadOnlyList<string>> apiVersions = default;
            Optional<IReadOnlyList<DataBoxEdgeSkuLocationInfo>> locationInfo = default;
            Optional<IReadOnlyList<DataBoxEdgeSkuCost>> costs = default;
            Optional<DataBoxEdgeSkuSignupOption> signupOption = default;
            Optional<DataBoxEdgeSkuVersion> version = default;
            Optional<DataBoxEdgeSkuAvailability> availability = default;
            Optional<IReadOnlyList<DataBoxEdgeShipmentType>> shipmentTypes = default;
            Optional<IReadOnlyList<DataBoxEdgeSkuCapability>> capabilities = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = new DataBoxEdgeSkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = new DataBoxEdgeSkuTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("family"u8))
                {
                    family = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("apiVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    apiVersions = array;
                    continue;
                }
                if (property.NameEquals("locationInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxEdgeSkuLocationInfo> array = new List<DataBoxEdgeSkuLocationInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxEdgeSkuLocationInfo.DeserializeDataBoxEdgeSkuLocationInfo(item, options));
                    }
                    locationInfo = array;
                    continue;
                }
                if (property.NameEquals("costs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxEdgeSkuCost> array = new List<DataBoxEdgeSkuCost>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxEdgeSkuCost.DeserializeDataBoxEdgeSkuCost(item, options));
                    }
                    costs = array;
                    continue;
                }
                if (property.NameEquals("signupOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    signupOption = new DataBoxEdgeSkuSignupOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = new DataBoxEdgeSkuVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("availability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availability = new DataBoxEdgeSkuAvailability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("shipmentTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxEdgeShipmentType> array = new List<DataBoxEdgeShipmentType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new DataBoxEdgeShipmentType(item.GetString()));
                    }
                    shipmentTypes = array;
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxEdgeSkuCapability> array = new List<DataBoxEdgeSkuCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxEdgeSkuCapability.DeserializeDataBoxEdgeSkuCapability(item, options));
                    }
                    capabilities = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvailableDataBoxEdgeSku(resourceType.Value, Optional.ToNullable(name), kind.Value, Optional.ToNullable(tier), size.Value, family.Value, Optional.ToList(locations), Optional.ToList(apiVersions), Optional.ToList(locationInfo), Optional.ToList(costs), Optional.ToNullable(signupOption), Optional.ToNullable(version), Optional.ToNullable(availability), Optional.ToList(shipmentTypes), Optional.ToList(capabilities), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailableDataBoxEdgeSku>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableDataBoxEdgeSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvailableDataBoxEdgeSku)} does not support '{options.Format}' format.");
            }
        }

        AvailableDataBoxEdgeSku IPersistableModel<AvailableDataBoxEdgeSku>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableDataBoxEdgeSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvailableDataBoxEdgeSku(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvailableDataBoxEdgeSku)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvailableDataBoxEdgeSku>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
