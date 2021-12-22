﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of context specific publisher.
    /// </summary>
    /// <typeparam name="TContext">The publisher context.</typeparam>
    /// <typeparam name="TResult">The publisher context.</typeparam>
    public interface IPublisher<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Publishes asynchronously.
        /// </summary>
        /// <param name="context">The publisher context.</param>
        Task<TResult> ProcessAsync(TContext context);
    }
}
