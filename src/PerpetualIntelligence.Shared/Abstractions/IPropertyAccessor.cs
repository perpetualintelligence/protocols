﻿/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace PerpetualIntelligence.Shared.Abstractions
{
    /// <summary>
    /// An abstraction to query the property parameters for UX rendering.
    /// </summary>
    public interface IPropertyAccessor
    {
        /// <summary>
        /// The property to render.
        /// </summary>
        PropertyInfo Property { get; }

        /// <summary>
        /// The property <see cref="DisplayAttribute"/>.
        /// </summary>
        DisplayAttribute Display { get; }

        /// <summary>
        /// The property <see cref="DataTypeAttribute"/>.
        /// </summary>
        DataTypeAttribute DataType { get; }
    }
}