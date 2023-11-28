// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> An environment definition. </summary>
    public partial class EnvironmentDefinitionModel
    {
        /// <summary> Initializes a new instance of <see cref="EnvironmentDefinitionModel"/>. </summary>
        /// <param name="id"> The ID of the environment definition. </param>
        /// <param name="name"> Name of the environment definition. </param>
        /// <param name="catalogName"> Name of the catalog. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="name"/> or <paramref name="catalogName"/> is null. </exception>
        internal EnvironmentDefinitionModel(string id, string name, string catalogName)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(catalogName, nameof(catalogName));

            Id = id;
            Name = name;
            CatalogName = catalogName;
            Parameters = new ChangeTrackingList<EnvironmentDefinitionParameterModel>();
        }

        /// <summary> Initializes a new instance of <see cref="EnvironmentDefinitionModel"/>. </summary>
        /// <param name="id"> The ID of the environment definition. </param>
        /// <param name="name"> Name of the environment definition. </param>
        /// <param name="catalogName"> Name of the catalog. </param>
        /// <param name="description"> A short description of the environment definition. </param>
        /// <param name="parameters"> Input parameters passed to an environment. </param>
        /// <param name="parametersSchema"> JSON schema defining the parameters object passed to an environment. </param>
        /// <param name="templatePath"> Path to the Environment Definition entrypoint file. </param>
        internal EnvironmentDefinitionModel(string id, string name, string catalogName, string description, IReadOnlyList<EnvironmentDefinitionParameterModel> parameters, string parametersSchema, string templatePath)
        {
            Id = id;
            Name = name;
            CatalogName = catalogName;
            Description = description;
            Parameters = parameters;
            ParametersSchema = parametersSchema;
            TemplatePath = templatePath;
        }

        /// <summary> The ID of the environment definition. </summary>
        public string Id { get; }
        /// <summary> Name of the environment definition. </summary>
        public string Name { get; }
        /// <summary> Name of the catalog. </summary>
        public string CatalogName { get; }
        /// <summary> A short description of the environment definition. </summary>
        public string Description { get; }
        /// <summary> Input parameters passed to an environment. </summary>
        public IReadOnlyList<EnvironmentDefinitionParameterModel> Parameters { get; }
        /// <summary> JSON schema defining the parameters object passed to an environment. </summary>
        public string ParametersSchema { get; }
        /// <summary> Path to the Environment Definition entrypoint file. </summary>
        public string TemplatePath { get; }
    }
}
