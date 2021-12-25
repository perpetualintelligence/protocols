﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    [TestClass]
    public class OrgConstantsTest
    {
        [TestMethod]
        public void ConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(OrgConstants), 8);

            Assert.AreEqual("https://en.gravatar.com/userimage/152742631/5c2800c8660bdabbfdcc1bf9497964d4.png", OrgConstants.LogoUrl);
            Assert.AreEqual("Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved", OrgConstants.Copyright);
            Assert.AreEqual("donotreply@perpetualintelligence.com", OrgConstants.DoNotReplyEmail);
            Assert.AreEqual("Perpetual Intelligence L.L.C.", OrgConstants.FullName);
            Assert.AreEqual("Perpetual Intelligence", OrgConstants.ShortName);
            Assert.AreEqual("PerpetualIntelligence.OneImlx", OrgConstants.OneImlxOrg);
            Assert.AreEqual("https://perpetualintelligence.com/legal/privacy", OrgConstants.PrivacyUrl);
            Assert.AreEqual("https://perpetualintelligence.com/legal/terms", OrgConstants.TermsUrl);
        }
    }
}
