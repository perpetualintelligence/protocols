﻿/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Test
{
    /// <summary>
    /// Represents a test class that provides the test context.
    /// </summary>
    public abstract class ImlxTest
    {
        /// <summary>
        /// The test context. This property is set automatically by the test engine.
        /// </summary>
        public TestContext TestContext { get; set; } = null!;
    }
}
