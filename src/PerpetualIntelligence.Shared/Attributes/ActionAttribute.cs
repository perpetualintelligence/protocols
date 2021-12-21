﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes
{
    /// <summary>
    /// An actionable attribute.
    /// </summary>
    public abstract class ActionAttribute : Attribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        protected ActionAttribute()
        {
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="description"></param>
        /// <exception cref="ArgumentNullException"></exception>
        protected ActionAttribute(string description)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// The description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// The severity.
        /// </summary>
        public string? Severity { get; set; }

        /// <summary>
        /// The version to address an action.
        /// </summary>
        public string? Version { get; set; }

        /// <summary>
        /// The action assignee.
        /// </summary>
        public string? Assignee { get; set; }
    }
}