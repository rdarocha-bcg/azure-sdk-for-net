// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The Edifact agreement framing settings. </summary>
    public partial class EdifactFramingSettings
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

        /// <summary> Initializes a new instance of <see cref="EdifactFramingSettings"/>. </summary>
        /// <param name="protocolVersion"> The protocol version. </param>
        /// <param name="dataElementSeparator"> The data element separator. </param>
        /// <param name="componentSeparator"> The component separator. </param>
        /// <param name="segmentTerminator"> The segment terminator. </param>
        /// <param name="releaseIndicator"> The release indicator. </param>
        /// <param name="repetitionSeparator"> The repetition separator. </param>
        /// <param name="characterSet"> The EDIFACT frame setting characterSet. </param>
        /// <param name="decimalPointIndicator"> The EDIFACT frame setting decimal indicator. </param>
        /// <param name="segmentTerminatorSuffix"> The EDIFACT frame setting segment terminator suffix. </param>
        public EdifactFramingSettings(int protocolVersion, int dataElementSeparator, int componentSeparator, int segmentTerminator, int releaseIndicator, int repetitionSeparator, EdifactCharacterSet characterSet, EdifactDecimalIndicator decimalPointIndicator, SegmentTerminatorSuffix segmentTerminatorSuffix)
        {
            ProtocolVersion = protocolVersion;
            DataElementSeparator = dataElementSeparator;
            ComponentSeparator = componentSeparator;
            SegmentTerminator = segmentTerminator;
            ReleaseIndicator = releaseIndicator;
            RepetitionSeparator = repetitionSeparator;
            CharacterSet = characterSet;
            DecimalPointIndicator = decimalPointIndicator;
            SegmentTerminatorSuffix = segmentTerminatorSuffix;
        }

        /// <summary> Initializes a new instance of <see cref="EdifactFramingSettings"/>. </summary>
        /// <param name="serviceCodeListDirectoryVersion"> The service code list directory version. </param>
        /// <param name="characterEncoding"> The character encoding. </param>
        /// <param name="protocolVersion"> The protocol version. </param>
        /// <param name="dataElementSeparator"> The data element separator. </param>
        /// <param name="componentSeparator"> The component separator. </param>
        /// <param name="segmentTerminator"> The segment terminator. </param>
        /// <param name="releaseIndicator"> The release indicator. </param>
        /// <param name="repetitionSeparator"> The repetition separator. </param>
        /// <param name="characterSet"> The EDIFACT frame setting characterSet. </param>
        /// <param name="decimalPointIndicator"> The EDIFACT frame setting decimal indicator. </param>
        /// <param name="segmentTerminatorSuffix"> The EDIFACT frame setting segment terminator suffix. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdifactFramingSettings(string serviceCodeListDirectoryVersion, string characterEncoding, int protocolVersion, int dataElementSeparator, int componentSeparator, int segmentTerminator, int releaseIndicator, int repetitionSeparator, EdifactCharacterSet characterSet, EdifactDecimalIndicator decimalPointIndicator, SegmentTerminatorSuffix segmentTerminatorSuffix, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ServiceCodeListDirectoryVersion = serviceCodeListDirectoryVersion;
            CharacterEncoding = characterEncoding;
            ProtocolVersion = protocolVersion;
            DataElementSeparator = dataElementSeparator;
            ComponentSeparator = componentSeparator;
            SegmentTerminator = segmentTerminator;
            ReleaseIndicator = releaseIndicator;
            RepetitionSeparator = repetitionSeparator;
            CharacterSet = characterSet;
            DecimalPointIndicator = decimalPointIndicator;
            SegmentTerminatorSuffix = segmentTerminatorSuffix;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EdifactFramingSettings"/> for deserialization. </summary>
        internal EdifactFramingSettings()
        {
        }

        /// <summary> The service code list directory version. </summary>
        public string ServiceCodeListDirectoryVersion { get; set; }
        /// <summary> The character encoding. </summary>
        public string CharacterEncoding { get; set; }
        /// <summary> The protocol version. </summary>
        public int ProtocolVersion { get; set; }
        /// <summary> The data element separator. </summary>
        public int DataElementSeparator { get; set; }
        /// <summary> The component separator. </summary>
        public int ComponentSeparator { get; set; }
        /// <summary> The segment terminator. </summary>
        public int SegmentTerminator { get; set; }
        /// <summary> The release indicator. </summary>
        public int ReleaseIndicator { get; set; }
        /// <summary> The repetition separator. </summary>
        public int RepetitionSeparator { get; set; }
        /// <summary> The EDIFACT frame setting characterSet. </summary>
        public EdifactCharacterSet CharacterSet { get; set; }
        /// <summary> The EDIFACT frame setting decimal indicator. </summary>
        public EdifactDecimalIndicator DecimalPointIndicator { get; set; }
        /// <summary> The EDIFACT frame setting segment terminator suffix. </summary>
        public SegmentTerminatorSuffix SegmentTerminatorSuffix { get; set; }
    }
}
