// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> Provides remote connection information for a Dev Box. </summary>
    public partial class RemoteConnection
    {
        /// <summary> Initializes a new instance of <see cref="RemoteConnection"/>. </summary>
        internal RemoteConnection()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RemoteConnection"/>. </summary>
        /// <param name="webUrl"> URL to open a browser based RDP session. </param>
        /// <param name="rdpConnectionUrl"> Link to open a Remote Desktop session. </param>
        internal RemoteConnection(string webUrl, string rdpConnectionUrl)
        {
            WebUrl = webUrl;
            RdpConnectionUrl = rdpConnectionUrl;
        }

        /// <summary> URL to open a browser based RDP session. </summary>
        public string WebUrl { get; }
        /// <summary> Link to open a Remote Desktop session. </summary>
        public string RdpConnectionUrl { get; }
    }
}
