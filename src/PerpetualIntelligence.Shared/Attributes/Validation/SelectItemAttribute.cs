﻿/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using System;

namespace PerpetualIntelligence.Shared.Attributes.Validation
{
    /// <summary>
    /// Specifies the allowed string values on the property.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    [Refactor("Move this to rendering.")]
    public class SelectItemAttribute : Attribute
    {
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public SelectItemAttribute(string name, string? value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Item display description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Item disability.
        /// </summary>
        public bool Disabled { get; }

        /// <summary>
        /// Item display name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The item value is obsolete.
        /// </summary>
        public bool Obsolete { get; set; }

        /// <summary>
        /// Item value.
        /// </summary>
        public string? Value { get; }
    }
}
