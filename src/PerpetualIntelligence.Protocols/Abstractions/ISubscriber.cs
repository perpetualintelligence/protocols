﻿/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using PerpetualIntelligence.Shared.Abstractions;
using System.Threading.Tasks;

namespace PerpetualIntelligence.Protocols.Abstractions
{
    /// <summary>
    /// An abstraction of a context specific subscriber.
    /// </summary>
    /// <typeparam name="TContext">The subscriber context.</typeparam>
    /// <typeparam name="TResult">The subscriber result.</typeparam>
    public interface ISubscriber<TContext, TResult> where TContext : class where TResult : class
    {
        /// <summary>
        /// Subscribes asynchronously.
        /// </summary>
        /// <param name="context">The subscriber context.</param>
        /// <returns>The subscriber result.</returns>
        Task<TResult> SubscribeAsync(TContext context);
    }
}
