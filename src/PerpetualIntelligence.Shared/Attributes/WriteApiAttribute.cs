/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes
{
    /// <summary>
    /// Indicates that the target element should add the relevant back-end API.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public sealed class WriteApiAttribute : ActionAttribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="description">Additional description.</param>
        public WriteApiAttribute(string description) : base(description)
        {
            Description = description;
        }
    }
}
