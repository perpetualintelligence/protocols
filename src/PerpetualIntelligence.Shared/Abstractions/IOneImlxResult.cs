﻿/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of a generic <c>oneimlx</c> result.
    /// </summary>
    public interface IOneImlxResult
    {
        /// <summary>
        /// Determines if the result is an error.
        /// </summary>
        bool IsError { get; }
    }
}
