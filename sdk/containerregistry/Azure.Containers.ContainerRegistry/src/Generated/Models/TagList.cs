// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> List of tag details. </summary>
    internal partial class TagList
    {
        /// <summary> Initializes a new instance of <see cref="TagList"/>. </summary>
        /// <param name="registryLoginServer"> Registry login server name. This is likely to be similar to {registry-name}.azurecr.io. </param>
        /// <param name="repository"> Image name. </param>
        /// <param name="tagAttributeBases"> List of tag attribute details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="registryLoginServer"/>, <paramref name="repository"/> or <paramref name="tagAttributeBases"/> is null. </exception>
        internal TagList(string registryLoginServer, string repository, IEnumerable<TagAttributesBase> tagAttributeBases)
        {
            if (registryLoginServer == null)
            {
                throw new ArgumentNullException(nameof(registryLoginServer));
            }
            if (repository == null)
            {
                throw new ArgumentNullException(nameof(repository));
            }
            if (tagAttributeBases == null)
            {
                throw new ArgumentNullException(nameof(tagAttributeBases));
            }

            RegistryLoginServer = registryLoginServer;
            Repository = repository;
            TagAttributeBases = tagAttributeBases.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="TagList"/>. </summary>
        /// <param name="registryLoginServer"> Registry login server name. This is likely to be similar to {registry-name}.azurecr.io. </param>
        /// <param name="repository"> Image name. </param>
        /// <param name="tagAttributeBases"> List of tag attribute details. </param>
        /// <param name="link"></param>
        internal TagList(string registryLoginServer, string repository, IReadOnlyList<TagAttributesBase> tagAttributeBases, string link)
        {
            RegistryLoginServer = registryLoginServer;
            Repository = repository;
            TagAttributeBases = tagAttributeBases;
            Link = link;
        }

        /// <summary> Registry login server name. This is likely to be similar to {registry-name}.azurecr.io. </summary>
        public string RegistryLoginServer { get; }
        /// <summary> Image name. </summary>
        public string Repository { get; }
        /// <summary> List of tag attribute details. </summary>
        public IReadOnlyList<TagAttributesBase> TagAttributeBases { get; }
        /// <summary> Gets the link. </summary>
        public string Link { get; }
    }
}
