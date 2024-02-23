// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> File sink allows for video and audio content to be recorded on the file system on the edge device. </summary>
    public partial class FileSink : SinkNodeBase
    {
        /// <summary> Initializes a new instance of <see cref="FileSink"/>. </summary>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="inputs"> An array of upstream node references within the topology to be used as inputs for this node. </param>
        /// <param name="baseDirectoryPath"> Absolute directory path where media files will be stored. </param>
        /// <param name="fileNamePattern"> File name pattern for creating new files when performing event based recording. The pattern must include at least one system variable. </param>
        /// <param name="maximumSizeMiB"> Maximum amount of disk space that can be used for storing files from this sink. Once this limit is reached, the oldest files from this sink will be automatically deleted. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="inputs"/>, <paramref name="baseDirectoryPath"/>, <paramref name="fileNamePattern"/> or <paramref name="maximumSizeMiB"/> is null. </exception>
        public FileSink(string name, IEnumerable<NodeInput> inputs, string baseDirectoryPath, string fileNamePattern, string maximumSizeMiB) : base(name, inputs)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }
            if (baseDirectoryPath == null)
            {
                throw new ArgumentNullException(nameof(baseDirectoryPath));
            }
            if (fileNamePattern == null)
            {
                throw new ArgumentNullException(nameof(fileNamePattern));
            }
            if (maximumSizeMiB == null)
            {
                throw new ArgumentNullException(nameof(maximumSizeMiB));
            }

            BaseDirectoryPath = baseDirectoryPath;
            FileNamePattern = fileNamePattern;
            MaximumSizeMiB = maximumSizeMiB;
            Type = "#Microsoft.VideoAnalyzer.FileSink";
        }

        /// <summary> Initializes a new instance of <see cref="FileSink"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="inputs"> An array of upstream node references within the topology to be used as inputs for this node. </param>
        /// <param name="baseDirectoryPath"> Absolute directory path where media files will be stored. </param>
        /// <param name="fileNamePattern"> File name pattern for creating new files when performing event based recording. The pattern must include at least one system variable. </param>
        /// <param name="maximumSizeMiB"> Maximum amount of disk space that can be used for storing files from this sink. Once this limit is reached, the oldest files from this sink will be automatically deleted. </param>
        internal FileSink(string type, string name, IList<NodeInput> inputs, string baseDirectoryPath, string fileNamePattern, string maximumSizeMiB) : base(type, name, inputs)
        {
            BaseDirectoryPath = baseDirectoryPath;
            FileNamePattern = fileNamePattern;
            MaximumSizeMiB = maximumSizeMiB;
            Type = type ?? "#Microsoft.VideoAnalyzer.FileSink";
        }

        /// <summary> Absolute directory path where media files will be stored. </summary>
        public string BaseDirectoryPath { get; set; }
        /// <summary> File name pattern for creating new files when performing event based recording. The pattern must include at least one system variable. </summary>
        public string FileNamePattern { get; set; }
        /// <summary> Maximum amount of disk space that can be used for storing files from this sink. Once this limit is reached, the oldest files from this sink will be automatically deleted. </summary>
        public string MaximumSizeMiB { get; set; }
    }
}
