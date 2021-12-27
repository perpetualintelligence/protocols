﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

namespace PerpetualIntelligence.Protocols.Abstractions.Stores
{
    /// <summary>
    /// The abstraction of a store result that yields multiple entities.
    /// </summary>
    /// <see cref="IStoreSingleResult{TEntity}"/>
    public interface IStoreMultipleResult<TEntity> where TEntity : IEntity
    {
        /// <summary>
        /// The continuation token to get the next set of entities.
        /// </summary>
        public string? ContinuationToken { get; }

        /// <summary>
        /// The store entities.
        /// </summary>
        TEntity[]? Result { get; }
    }
}
