﻿/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes
{
    /// <summary>
    /// Indicates that the target element requires documentation.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public sealed class ToDocumentationAttribute : ActionAttribute
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public ToDocumentationAttribute() : base()
        {
        }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="description">Additional description.</param>
        public ToDocumentationAttribute(string description) : base(description)
        {
            Description = description;
        }
    }
}