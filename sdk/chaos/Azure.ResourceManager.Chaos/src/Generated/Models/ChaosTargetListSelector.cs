// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents a list selector. </summary>
    public partial class ChaosTargetListSelector : ChaosTargetSelector
    {
        /// <summary> Initializes a new instance of <see cref="ChaosTargetListSelector"/>. </summary>
        /// <param name="id"> String of the selector ID. </param>
        /// <param name="targets"> List of Target references. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="targets"/> is null. </exception>
        public ChaosTargetListSelector(string id, IEnumerable<ChaosTargetReference> targets) : base(id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (targets == null)
            {
                throw new ArgumentNullException(nameof(targets));
            }

            Targets = targets.ToList();
            SelectorType = SelectorType.List;
        }

        /// <summary> Initializes a new instance of <see cref="ChaosTargetListSelector"/>. </summary>
        /// <param name="selectorType"> Enum of the selector type. </param>
        /// <param name="id"> String of the selector ID. </param>
        /// <param name="filter">
        /// Model that represents available filter types that can be applied to a targets list.
        /// Please note <see cref="ChaosTargetFilter"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ChaosTargetSimpleFilter"/>.
        /// </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="targets"> List of Target references. </param>
        internal ChaosTargetListSelector(SelectorType selectorType, string id, ChaosTargetFilter filter, IDictionary<string, BinaryData> additionalProperties, IList<ChaosTargetReference> targets) : base(selectorType, id, filter, additionalProperties)
        {
            Targets = targets;
            SelectorType = selectorType;
        }

        /// <summary> Initializes a new instance of <see cref="ChaosTargetListSelector"/> for deserialization. </summary>
        internal ChaosTargetListSelector()
        {
        }

        /// <summary> List of Target references. </summary>
        public IList<ChaosTargetReference> Targets { get; }
    }
}
