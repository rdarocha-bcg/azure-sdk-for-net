// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    public partial class RoleAssignmentScheduleRequestData : IUtf8JsonSerializable, IJsonModel<RoleAssignmentScheduleRequestData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoleAssignmentScheduleRequestData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoleAssignmentScheduleRequestData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentScheduleRequestData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleAssignmentScheduleRequestData)} does not support '{format}' format.");
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
            if (options.Format != "W" && Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(RoleDefinitionId))
            {
                writer.WritePropertyName("roleDefinitionId"u8);
                writer.WriteStringValue(RoleDefinitionId);
            }
            if (Optional.IsDefined(PrincipalId))
            {
                writer.WritePropertyName("principalId"u8);
                writer.WriteStringValue(PrincipalId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PrincipalType))
            {
                writer.WritePropertyName("principalType"u8);
                writer.WriteStringValue(PrincipalType.Value.ToString());
            }
            if (Optional.IsDefined(RequestType))
            {
                writer.WritePropertyName("requestType"u8);
                writer.WriteStringValue(RequestType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ApprovalId))
            {
                writer.WritePropertyName("approvalId"u8);
                writer.WriteStringValue(ApprovalId);
            }
            if (Optional.IsDefined(TargetRoleAssignmentScheduleId))
            {
                writer.WritePropertyName("targetRoleAssignmentScheduleId"u8);
                writer.WriteStringValue(TargetRoleAssignmentScheduleId);
            }
            if (Optional.IsDefined(TargetRoleAssignmentScheduleInstanceId))
            {
                writer.WritePropertyName("targetRoleAssignmentScheduleInstanceId"u8);
                writer.WriteStringValue(TargetRoleAssignmentScheduleInstanceId);
            }
            if (Optional.IsDefined(LinkedRoleEligibilityScheduleId))
            {
                writer.WritePropertyName("linkedRoleEligibilityScheduleId"u8);
                writer.WriteStringValue(LinkedRoleEligibilityScheduleId);
            }
            if (Optional.IsDefined(Justification))
            {
                writer.WritePropertyName("justification"u8);
                writer.WriteStringValue(Justification);
            }
            if (Optional.IsDefined(TicketInfo))
            {
                writer.WritePropertyName("ticketInfo"u8);
                writer.WriteObjectValue(TicketInfo);
            }
            if (Optional.IsDefined(Condition))
            {
                writer.WritePropertyName("condition"u8);
                writer.WriteStringValue(Condition);
            }
            if (Optional.IsDefined(ConditionVersion))
            {
                writer.WritePropertyName("conditionVersion"u8);
                writer.WriteStringValue(ConditionVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdOn"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(RequestorId))
            {
                writer.WritePropertyName("requestorId"u8);
                writer.WriteStringValue(RequestorId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ExpandedProperties))
            {
                writer.WritePropertyName("expandedProperties"u8);
                writer.WriteObjectValue(ExpandedProperties);
            }
            writer.WritePropertyName("scheduleInfo"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDateTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            writer.WritePropertyName("expiration"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ExpirationType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ExpirationType.Value.ToString());
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endDateTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration.Value, "P");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
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

        RoleAssignmentScheduleRequestData IJsonModel<RoleAssignmentScheduleRequestData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentScheduleRequestData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleAssignmentScheduleRequestData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleAssignmentScheduleRequestData(document.RootElement, options);
        }

        internal static RoleAssignmentScheduleRequestData DeserializeRoleAssignmentScheduleRequestData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<string> scope = default;
            Optional<ResourceIdentifier> roleDefinitionId = default;
            Optional<Guid> principalId = default;
            Optional<RoleManagementPrincipalType> principalType = default;
            Optional<RoleManagementScheduleRequestType> requestType = default;
            Optional<RoleManagementScheduleStatus> status = default;
            Optional<string> approvalId = default;
            Optional<ResourceIdentifier> targetRoleAssignmentScheduleId = default;
            Optional<ResourceIdentifier> targetRoleAssignmentScheduleInstanceId = default;
            Optional<ResourceIdentifier> linkedRoleEligibilityScheduleId = default;
            Optional<string> justification = default;
            Optional<RoleAssignmentScheduleTicketInfo> ticketInfo = default;
            Optional<string> condition = default;
            Optional<string> conditionVersion = default;
            Optional<DateTimeOffset> createdOn = default;
            Optional<Guid> requestorId = default;
            Optional<RoleManagementExpandedProperties> expandedProperties = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<RoleManagementScheduleExpirationType> type0 = default;
            Optional<DateTimeOffset> endDateTime = default;
            Optional<TimeSpan> duration = default;
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
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("roleDefinitionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            roleDefinitionId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("principalId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            principalId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("principalType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            principalType = new RoleManagementPrincipalType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("requestType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestType = new RoleManagementScheduleRequestType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new RoleManagementScheduleStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("approvalId"u8))
                        {
                            approvalId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetRoleAssignmentScheduleId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetRoleAssignmentScheduleId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetRoleAssignmentScheduleInstanceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetRoleAssignmentScheduleInstanceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("linkedRoleEligibilityScheduleId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            linkedRoleEligibilityScheduleId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("justification"u8))
                        {
                            justification = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ticketInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ticketInfo = RoleAssignmentScheduleTicketInfo.DeserializeRoleAssignmentScheduleTicketInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("condition"u8))
                        {
                            condition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("conditionVersion"u8))
                        {
                            conditionVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("requestorId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestorId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("expandedProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expandedProperties = RoleManagementExpandedProperties.DeserializeRoleManagementExpandedProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("scheduleInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("startDateTime"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    startDateTime = property1.Value.GetDateTimeOffset("O");
                                    continue;
                                }
                                if (property1.NameEquals("expiration"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    foreach (var property2 in property1.Value.EnumerateObject())
                                    {
                                        if (property2.NameEquals("type"u8))
                                        {
                                            if (property2.Value.ValueKind == JsonValueKind.Null)
                                            {
                                                continue;
                                            }
                                            type0 = new RoleManagementScheduleExpirationType(property2.Value.GetString());
                                            continue;
                                        }
                                        if (property2.NameEquals("endDateTime"u8))
                                        {
                                            if (property2.Value.ValueKind == JsonValueKind.Null)
                                            {
                                                continue;
                                            }
                                            endDateTime = property2.Value.GetDateTimeOffset("O");
                                            continue;
                                        }
                                        if (property2.NameEquals("duration"u8))
                                        {
                                            if (property2.Value.ValueKind == JsonValueKind.Null)
                                            {
                                                continue;
                                            }
                                            duration = property2.Value.GetTimeSpan("P");
                                            continue;
                                        }
                                    }
                                    continue;
                                }
                            }
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
            return new RoleAssignmentScheduleRequestData(id, name, type, systemData.Value, scope.Value, roleDefinitionId.Value, Optional.ToNullable(principalId), Optional.ToNullable(principalType), Optional.ToNullable(requestType), Optional.ToNullable(status), approvalId.Value, targetRoleAssignmentScheduleId.Value, targetRoleAssignmentScheduleInstanceId.Value, linkedRoleEligibilityScheduleId.Value, justification.Value, ticketInfo.Value, condition.Value, conditionVersion.Value, Optional.ToNullable(createdOn), Optional.ToNullable(requestorId), expandedProperties.Value, Optional.ToNullable(startDateTime), Optional.ToNullable(type0), Optional.ToNullable(endDateTime), Optional.ToNullable(duration), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoleAssignmentScheduleRequestData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentScheduleRequestData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoleAssignmentScheduleRequestData)} does not support '{options.Format}' format.");
            }
        }

        RoleAssignmentScheduleRequestData IPersistableModel<RoleAssignmentScheduleRequestData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleAssignmentScheduleRequestData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoleAssignmentScheduleRequestData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoleAssignmentScheduleRequestData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoleAssignmentScheduleRequestData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
