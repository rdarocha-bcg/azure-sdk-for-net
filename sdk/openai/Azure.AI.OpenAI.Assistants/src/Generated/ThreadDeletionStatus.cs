// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The status of a thread deletion operation. </summary>
    internal partial class ThreadDeletionStatus
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

        /// <summary> Initializes a new instance of <see cref="ThreadDeletionStatus"/>. </summary>
        /// <param name="id"> The ID of the resource specified for deletion. </param>
        /// <param name="deleted"> A value indicating whether deletion was successful. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal ThreadDeletionStatus(string id, bool deleted)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
            Deleted = deleted;
        }

        /// <summary> Initializes a new instance of <see cref="ThreadDeletionStatus"/>. </summary>
        /// <param name="id"> The ID of the resource specified for deletion. </param>
        /// <param name="deleted"> A value indicating whether deletion was successful. </param>
        /// <param name="object"> The object type, which is always 'thread.deleted'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreadDeletionStatus(string id, bool deleted, ThreadDeletionStatusObject @object, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Deleted = deleted;
            Object = @object;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ThreadDeletionStatus"/> for deserialization. </summary>
        internal ThreadDeletionStatus()
        {
        }

        /// <summary> The ID of the resource specified for deletion. </summary>
        public string Id { get; }
        /// <summary> A value indicating whether deletion was successful. </summary>
        public bool Deleted { get; }
        /// <summary> The object type, which is always 'thread.deleted'. </summary>
        public ThreadDeletionStatusObject Object { get; } = ThreadDeletionStatusObject.ThreadDeleted;
    }
}
