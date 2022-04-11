﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Licensing
{
    [TestClass]
    public class SaaSPlansTests
    {
        [TestMethod]
        public void IsValidShouldReturnTrueForValidSaaSPlans()
        {
            Assert.IsTrue(SaaSPlans.IsValid(SaaSPlans.Community));
            Assert.IsTrue(SaaSPlans.IsValid(SaaSPlans.Micro));
            Assert.IsTrue(SaaSPlans.IsValid(SaaSPlans.SMB));
            Assert.IsTrue(SaaSPlans.IsValid(SaaSPlans.Enterprise));
            Assert.IsTrue(SaaSPlans.IsValid(SaaSPlans.Custom));
            Assert.IsTrue(SaaSPlans.IsValid(SaaSPlans.ISV));
            Assert.IsTrue(SaaSPlans.IsValid(SaaSPlans.ISVU));
            Assert.IsTrue(SaaSPlans.IsValid(SaaSPlans.None));
        }

        [TestMethod]
        public void IsValidShouldReturnFalseForInvalidSaaSPlans()
        {
            Assert.IsFalse(SaaSPlans.IsValid("invalid"));
        }

        [TestMethod]
        public void SaaSPlansTest()
        {
            TestHelper.AssertConstantCount(typeof(SaaSPlans), 8);

            Assert.AreEqual("urn:oneimlx:lic:saasplan:community", SaaSPlans.Community);
            Assert.AreEqual("urn:oneimlx:lic:saasplan:micro", SaaSPlans.Micro);
            Assert.AreEqual("urn:oneimlx:lic:saasplan:smb", SaaSPlans.SMB);
            Assert.AreEqual("urn:oneimlx:lic:saasplan:enterprise", SaaSPlans.Enterprise);
            Assert.AreEqual("urn:oneimlx:lic:saasplan:custom", SaaSPlans.Custom);
            Assert.AreEqual("urn:oneimlx:lic:saasplan:isv", SaaSPlans.ISV);
            Assert.AreEqual("urn:oneimlx:lic:saasplan:isvu", SaaSPlans.ISVU);

            Assert.AreEqual("urn:oneimlx:lic:saasplan:none", SaaSPlans.None);
        }
    }
}
