// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The WebhookHookInfoPatch. </summary>
    internal partial class WebhookHookInfoPatch : HookInfoPatch
    {
        /// <summary> Initializes a new instance of <see cref="WebhookHookInfoPatch"/>. </summary>
        public WebhookHookInfoPatch()
        {
            HookType = NotificationHookKind.Webhook;
        }

        /// <summary> Initializes a new instance of <see cref="WebhookHookInfoPatch"/>. </summary>
        /// <param name="hookType"> hook type. </param>
        /// <param name="hookName"> hook unique name. </param>
        /// <param name="description"> hook description. </param>
        /// <param name="externalLink"> hook external link. </param>
        /// <param name="admins"> hook administrators. </param>
        /// <param name="hookParameter"></param>
        internal WebhookHookInfoPatch(NotificationHookKind hookType, string hookName, string description, string externalLink, IList<string> admins, WebhookHookParameterPatch hookParameter) : base(hookType, hookName, description, externalLink, admins)
        {
            HookParameter = hookParameter;
            HookType = hookType;
        }

        /// <summary> Gets or sets the hook parameter. </summary>
        public WebhookHookParameterPatch HookParameter { get; set; }
    }
}
