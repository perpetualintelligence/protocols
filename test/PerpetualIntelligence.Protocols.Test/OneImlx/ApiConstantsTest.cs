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
    public class ApiConstantsTest
    {
        [TestMethod]
        public void ConstantTest()
        {
            TestHelper.AssertConstantCount(typeof(ApiConstants), 10);

            Assert.AreEqual("urn:oneimlx:apiserver", ApiConstants.ApiServerHttpClient);
            Assert.AreEqual("urn:oneimlx:clientapp", ApiConstants.ClientAppHttpClient);
            Assert.AreEqual("application/x-www-form-urlencoded", ApiConstants.ContentTypeForm);
            Assert.AreEqual("text/html; charset=UTF-8", ApiConstants.ContentTypeHtml);
            Assert.AreEqual("application/json", ApiConstants.ContentTypeJson);
            Assert.AreEqual("multipart/form-data", ApiConstants.ContentTypeMultipart);
            Assert.AreEqual("urn:oneimlx:payment:live", ApiConstants.LivePayment);
            Assert.AreEqual("urn:oneimlx:localhost", ApiConstants.LocalhostEndpoint);
            Assert.AreEqual("urn:oneimlx:production", ApiConstants.ProductionEndpoint);
            Assert.AreEqual("urn:oneimlx:payment:test", ApiConstants.TestPayment);
        }
    }
}
