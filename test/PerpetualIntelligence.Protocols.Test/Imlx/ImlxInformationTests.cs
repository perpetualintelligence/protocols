﻿/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Imlx
{
    [TestClass]
    public class ImlxInformationTests
    {
        [TestMethod]
        public void InformationDescriptionTest()
        {
            Type type = typeof(ImlxInformation);
            PropertyInfo? prop = type.GetProperty(nameof(ImlxInformation.InformationDescription));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "information_description", false);
        }

        [TestMethod]
        public void InformationTest()
        {
            Type type = typeof(ImlxInformation);
            PropertyInfo? prop = type.GetProperty(nameof(ImlxInformation.Information));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "information", false);
        }

        [TestMethod]
        public void InformationUriTest()
        {
            Type type = typeof(ImlxInformation);
            PropertyInfo? prop = type.GetProperty(nameof(ImlxInformation.InformationUri));

            Assert.IsNotNull(prop);

            TestHelper.AssertAttributeCount(prop, 1, false);

            TestHelper.AssertJsonPropertyName(prop, "information_uri", false);
        }
    }
}
