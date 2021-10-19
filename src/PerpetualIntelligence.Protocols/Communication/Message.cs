﻿/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;
using System.Text.Json.Serialization;

namespace PerpetualIntelligence.Protocols.Communication
{
    /// <summary>
    /// The generic communication message.
    /// </summary>
    /// <typeparam name="TData">The message data.</typeparam>
    public sealed class Message<TData>
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public Message()
        { }

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="data">The cookie data.</param>
        public Message(TData data) : this(data, DateTimeOffset.UtcNow)
        { }

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="data">The cookie data.</param>
        /// <param name="createStamp">
        /// The create timestamp of the cookie expressed in the Coordinated Universal Time (UTC).
        /// </param>
        public Message(TData data, DateTimeOffset createStamp)
        {
            CreateStamp = createStamp;
            Data = data;
        }

        /// <summary>
        /// The create timestamp of the cookie expressed in the Coordinated Universal Time (UTC).
        /// </summary>
        [JsonPropertyName("create_stamp")]
        public DateTimeOffset CreateStamp { get; set; }

        /// <summary>
        /// The message data.
        /// </summary>
        [JsonPropertyName("data")]
        public TData? Data { get; set; }

        /// <summary>
        /// The number of ticks that represents the <see cref="CreateStamp"/>.
        /// </summary>
        [JsonIgnore]
        public long Ticks
        {
            get
            {
                return CreateStamp.Ticks;
            }
        }
    }
}