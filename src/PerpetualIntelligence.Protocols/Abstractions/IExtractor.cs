/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific extractor.
    /// </summary>
    /// <typeparam name="TContext">The extractor context.</typeparam>
    /// <typeparam name="TResult">The extractor result.</typeparam>
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
