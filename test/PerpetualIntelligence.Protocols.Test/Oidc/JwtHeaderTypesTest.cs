﻿// Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
// https://perpetualintelligence.com
// https://api.perpetualintelligence.com

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerpetualIntelligence.Test.Services;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class JwtHeaderTypesTest
    {
        [TestMethod]
        public void JwtDefaultTypesConstantsTest()
        {
            TestHelper.AssertConstantCount(typeof(JwtHeaderTypes), 2);

            Assert.AreEqual("oneimlx-oidc-at+jwt", JwtHeaderTypes.AccessToken);
            Assert.AreEqual("oneimlx-oidc-ar+jwt", JwtHeaderTypes.AuthorizationRequest);
        }
    }
}
