﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
    https://oneimlx.com
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PerpetualIntelligence.Protocols.Oidc
{
    [TestClass]
    public class ClaimsPrincipalFactoryTests
    {
        [TestMethod]
        public void CreateFromCertificateTest()
        {
            // Assert.AreEqual("System.Security.Claims.ClaimsIdentity", ClaimsPrincipalFactory.CreateFromCertificate().ToString());
        }

        [TestMethod]
        public void FromAnonymityTest()
        {
            Assert.AreEqual("System.Security.Claims.ClaimsPrincipal", ClaimsPrincipalFactory.FromAnonymity().ToString());
        }

        [TestMethod]
        public void FromClaimsTest()
        {
            Assert.AreEqual("System.Security.Claims.ClaimsPrincipal", ClaimsPrincipalFactory.FromClaims("Test").ToString());
        }
    }
}
