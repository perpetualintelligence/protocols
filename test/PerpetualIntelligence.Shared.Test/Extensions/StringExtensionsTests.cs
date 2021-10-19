﻿// Copyright (c) 2021. All Rights Reserved. Perpetual Intelligence L.L.C.
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Shared.Extensions
{
    [TestClass]
   public class StringExtensionsTests
    {
        [TestMethod]
        public void IsNullOrEmptyTest()
        {
            Assert.IsTrue(StringExtensions.IsNullOrEmpty(""));

            Assert.IsFalse(StringExtensions.IsNullOrEmpty("Test"));
        }

        [TestMethod]
        public void IsNullOrWhiteSpace()
        {
            Assert.IsTrue(StringExtensions.IsNullOrWhiteSpace(""));

            Assert.IsFalse(StringExtensions.IsNullOrWhiteSpace("Test"));
        }
    }
}