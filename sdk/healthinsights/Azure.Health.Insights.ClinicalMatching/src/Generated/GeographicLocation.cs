// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary>
    /// A location given as a combination of city, state and country/region. It could specify a city, a state or a country/region.
    /// In case a city is specified, either state +country/region or country/region (for countries/regions where there are no states) should be added.
    /// In case a state is specified (without a city), country/region should be added.
    /// </summary>
    public partial class GeographicLocation
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GeographicLocation"/>. </summary>
        /// <param name="countryOrRegion"> Country/region name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="countryOrRegion"/> is null. </exception>
        public GeographicLocation(string countryOrRegion)
        {
            if (countryOrRegion == null)
            {
                throw new ArgumentNullException(nameof(countryOrRegion));
            }

            CountryOrRegion = countryOrRegion;
        }

        /// <summary> Initializes a new instance of <see cref="GeographicLocation"/>. </summary>
        /// <param name="city"> City name. </param>
        /// <param name="state"> State name. </param>
        /// <param name="countryOrRegion"> Country/region name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GeographicLocation(string city, string state, string countryOrRegion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            City = city;
            State = state;
            CountryOrRegion = countryOrRegion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GeographicLocation"/> for deserialization. </summary>
        internal GeographicLocation()
        {
        }

        /// <summary> City name. </summary>
        public string City { get; set; }
        /// <summary> State name. </summary>
        public string State { get; set; }
        /// <summary> Country/region name. </summary>
        public string CountryOrRegion { get; }
    }
}
