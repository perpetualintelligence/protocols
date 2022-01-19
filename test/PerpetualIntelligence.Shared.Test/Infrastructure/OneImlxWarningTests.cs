﻿/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://terms.perpetualintelligence.com/articles/intro.html
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;
using System;
using System.Reflection;

namespace PerpetualIntelligence.Shared.Infrastructure
{
    [TestClass]
    public class OneImlxWarningTests
    {
        [TestMethod]
        public void RequestIdTest()
        {
            Type type = typeof(Warning);
            PropertyInfo? prop = type.GetProperty(nameof(Warning.RequestId));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "request_id", false);
        }

        [TestMethod]
        public void WarningDescriptionTest()
        {
            Type type = typeof(Warning);
            PropertyInfo? prop = type.GetProperty(nameof(Warning.WarningDescription));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "warning_description", false);
        }

        [TestMethod]
        public void WarningTest()
        {
            Type type = typeof(Warning);
            PropertyInfo? prop = type.GetProperty(nameof(Warning.WarningCode));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "warning", false);
        }

        [TestMethod]
        public void WarningUriTest()
        {
            Type type = typeof(Warning);
            PropertyInfo? prop = type.GetProperty(nameof(Warning.WarningUri));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "warning_uri", false);
        }
    }
}
