﻿/*
    Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.Extensions.Logging;

namespace PerpetualIntelligence.Test.Services
{
    /// <summary>
    /// The test logger.
    /// </summary>
    public static class TestLogger
    {
        /// <summary>
        /// Creates a new <see cref="ILogger{TCategoryName}"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ILogger<T> Create<T>()
        {
            return new LoggerFactory().CreateLogger<T>();
        }
    }
}