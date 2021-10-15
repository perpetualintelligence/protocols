﻿/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Attributes;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Extractors
{
    /// <summary>
    /// An abstraction of a context specific extractor.
    /// </summary>
    /// <typeparam name="TContext">The extractor context.</typeparam>
    /// <typeparam name="TResult">The extractor result.</typeparam>
    /// <seealso cref="IExtracted"/>
    /// <seealso cref="IExtractorResult"/>
    [Concept("Extractors")]
    public interface IExtractor<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Extracts from a context asynchronously.
        /// </summary>
        /// <param name="context">The extractor context.</param>
        /// <returns>The extractor result.</returns>
        Task<TResult> ExtractAsync(TContext context);
    }
}
