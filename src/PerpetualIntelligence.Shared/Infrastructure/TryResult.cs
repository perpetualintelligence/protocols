﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Infrastructure
{
    /// <summary>
    /// The <c>oneimlx</c> result of a try method.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class TryResult<T> : Result where T : class
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public TryResult()
        {
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public TryResult(Error error)
        {
            SetError(error);
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="result"></param>
        public TryResult(T result)
        {
            Result = result;
        }

        /// <summary>
        /// The result of a try.
        /// </summary>
        public T? Result { get; set; }
    }
}
