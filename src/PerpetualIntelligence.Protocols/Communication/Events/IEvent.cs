﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Communication.Events
{
    /// <summary>
    /// The abstraction of an event in the publish/subscribe-style communication without requiring the components to
    /// explicitly be aware of each other.
    /// </summary>
    /// <seealso cref="IEventSubscriber{TContext, TResult}"/>
    /// <seealso cref="IEventPublisher{TContext, TResult}"/>
    /// <seealso cref="IEventRecorder{TContext, TResult}"/>
    public interface IEvent
    {
        /// <summary>
        /// The unique event name.
        /// </summary>
        public string Name { get; }
    }
}
