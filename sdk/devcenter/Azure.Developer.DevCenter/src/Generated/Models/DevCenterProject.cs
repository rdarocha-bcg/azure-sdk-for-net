// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> Project details. </summary>
    public partial class DevCenterProject
    {
        /// <summary> Initializes a new instance of <see cref="DevCenterProject"/>. </summary>
        internal DevCenterProject()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterProject"/>. </summary>
        /// <param name="name"> Name of the project. </param>
        /// <param name="description"> Description of the project. </param>
        /// <param name="maxDevBoxesPerUser">
        /// When specified, indicates the maximum number of Dev Boxes a single user can
        /// create across all pools in the project.
        /// </param>
        internal DevCenterProject(string name, string description, int? maxDevBoxesPerUser)
        {
            Name = name;
            Description = description;
            MaxDevBoxesPerUser = maxDevBoxesPerUser;
        }

        /// <summary> Name of the project. </summary>
        public string Name { get; }
        /// <summary> Description of the project. </summary>
        public string Description { get; }
        /// <summary>
        /// When specified, indicates the maximum number of Dev Boxes a single user can
        /// create across all pools in the project.
        /// </summary>
        public int? MaxDevBoxesPerUser { get; }
    }
}
