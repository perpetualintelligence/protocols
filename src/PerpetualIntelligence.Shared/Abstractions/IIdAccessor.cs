﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction of an id accessor.
    /// </summary>
    /// <seealso cref="IIdGenerator"/>
    /// <seealso cref="IIdentityAccessor"/>
    public interface IIdAccessor
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <returns>An identifier.</returns>
        string GetId();
    }
}
