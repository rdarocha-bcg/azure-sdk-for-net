// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The EntitiesDocumentResult. </summary>
    internal partial class EntitiesDocumentResult : DocumentResult
    {
        /// <summary> Initializes a new instance of <see cref="EntitiesDocumentResult"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="entities"> Recognized entities in the document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="warnings"/> or <paramref name="entities"/> is null. </exception>
        public EntitiesDocumentResult(string id, IEnumerable<DocumentWarning> warnings, IEnumerable<Entity> entities) : base(id, warnings)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (warnings == null)
            {
                throw new ArgumentNullException(nameof(warnings));
            }
            if (entities == null)
            {
                throw new ArgumentNullException(nameof(entities));
            }

            Entities = entities.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="EntitiesDocumentResult"/>. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        /// <param name="entities"> Recognized entities in the document. </param>
        internal EntitiesDocumentResult(string id, IList<DocumentWarning> warnings, TextDocumentStatistics? statistics, IList<Entity> entities) : base(id, warnings, statistics)
        {
            Entities = entities;
        }

        /// <summary> Recognized entities in the document. </summary>
        public IList<Entity> Entities { get; }
    }
}
