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
    public partial class WebSiteData : IJsonModel<WebSiteData>
    {
        void IJsonModel<WebSiteData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IUtf8JsonSerializable)this).Write(writer);

        WebSiteData IJsonModel<WebSiteData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebSiteData(document.RootElement);
        }

        BinaryData IPersistableModel<WebSiteData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebSiteData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WebSiteData)} does not support '{options.Format}' format.");
            }
        }

        WebSiteData IPersistableModel<WebSiteData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            using var document = JsonDocument.Parse(data);
            return DeserializeWebSiteData(document.RootElement);
        }

        string IPersistableModel<WebSiteData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"  name: '{Name}'");
            sb.AppendLine($"  location: '{Location}'");
            if (Optional.IsCollectionDefined(Tags) && Tags.Count > 0)
            {
                sb.AppendLine($"  tags: {{");
                foreach (var kv in Tags)
                {
                    sb.AppendLine($"    '{kv.Key}': '{kv.Value}'");
                }
                sb.AppendLine($"  }}");
            }
            if(Optional.IsDefined(Kind))
            {
                sb.AppendLine($"  kind: '{Kind}'");
            }
            sb.AppendLine($"  properties: {{");
            sb.AppendLine($"    serverFarmId: '{AppServicePlanId}'");
            sb.AppendLine($"    siteConfig: {{");
            sb.AppendChildObject(SiteConfig, options, true, 6);
            sb.AppendLine($"    }}");
            if(IsClientAffinityEnabled.HasValue)
            {
                sb.AppendLine($"    clientAffinityEnabled: {IsClientAffinityEnabled.Value}");
            }
            if(IsHttpsOnly.HasValue)
            {
                sb.AppendLine($"    httpsOnly: {IsHttpsOnly.Value.ToString().ToLower()}");
            }
            sb.AppendLine($"  }}");
            if (Optional.IsDefined(Identity))
            {
                sb.AppendLine($"  identity: {{");
                sb.AppendLine($"    type: '{Identity.ManagedServiceIdentityType}'");
                sb.AppendLine($"  }}");
            }
            return BinaryData.FromString(sb.ToString());
        }
    }
}
