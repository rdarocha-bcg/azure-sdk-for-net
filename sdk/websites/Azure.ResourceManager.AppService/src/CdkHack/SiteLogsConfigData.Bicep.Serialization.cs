// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService
{
    public partial class SiteLogsConfigData : IJsonModel<SiteLogsConfigData>
    {
        void IJsonModel<SiteLogsConfigData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IUtf8JsonSerializable)this).Write(writer);

        SiteLogsConfigData IJsonModel<SiteLogsConfigData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteLogsConfigData(document.RootElement);
        }

        BinaryData IPersistableModel<SiteLogsConfigData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteLogsConfigData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SiteLogsConfigData)} does not support '{options.Format}' format.");
            }
        }

        SiteLogsConfigData IPersistableModel<SiteLogsConfigData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            using var document = JsonDocument.Parse(data);
            return DeserializeSiteLogsConfigData(document.RootElement);
        }

        string IPersistableModel<SiteLogsConfigData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"  name: 'logs'");
            sb.AppendLine($"  properties: {{");
            sb.AppendLine($"    applicationLogs: {{");
            sb.AppendChildObject(ApplicationLogs, options, true, 4);
            sb.AppendLine($"    }}");
            sb.AppendLine($"    detailedErrorMessages: {{");
            sb.AppendLine($"      enabled: {IsDetailedErrorMessagesEnabled.ToString().ToLower()}");
            sb.AppendLine($"    }}");
            sb.AppendLine($"    failedRequestsTracing: {{");
            sb.AppendLine($"      enabled: {IsFailedRequestsTracingEnabled.ToString().ToLower()}");
            sb.AppendLine($"    }}");
            sb.AppendLine($"    httpLogs: {{");
            sb.AppendChildObject(HttpLogs, options, true, 4);
            sb.AppendLine($"    }}");
            sb.AppendLine($"  }}");
            return BinaryData.FromString(sb.ToString());
        }
    }
}
