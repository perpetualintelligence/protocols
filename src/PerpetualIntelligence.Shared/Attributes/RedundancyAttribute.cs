﻿/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes
{
    /// <summary>
    /// Specifies that the target has a redundancy that can be resolved in future releases. Applications can use the
    /// target element, but the design may change in future releases including breaking changes.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class RedundancyAttribute : ActionAttribute
    {
        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="description"></param>
        public RedundancyAttribute(string description) : base(description)
        {
            Description = description;
        }
    }
}
