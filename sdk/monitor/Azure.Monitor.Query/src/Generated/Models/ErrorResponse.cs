// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Contains details when the response code indicates an error. </summary>
    internal partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of <see cref="ErrorResponse"/>. </summary>
        /// <param name="error"> The error details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/> is null. </exception>
        internal ErrorResponse(ErrorInfo error)
        {
            if (error == null)
            {
                throw new ArgumentNullException(nameof(error));
            }

            Error = error;
        }

        /// <summary> The error details. </summary>
        public ErrorInfo Error { get; }
    }
}
