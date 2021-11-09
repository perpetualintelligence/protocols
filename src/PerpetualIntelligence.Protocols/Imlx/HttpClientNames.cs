﻿/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/


namespace PerpetualIntelligence.Protocols.Imlx
{
    /// <summary>
    /// The HTTP client names used by the <c>oneimlx</c> managed services.
    /// </summary>
    public static class HttpClientNames
    {
        /// <summary>
        /// The client application HTTP client name.
        /// </summary>
        public const string ClientApp = "pi:protocols:imlx:http:capp";

        /// <summary>
        /// The API server HTTP client name.
        /// </summary>
        public const string ApiServer = "pi:protocols:imlx:http:apisvr";

        /// <summary>
        /// The <c>jwt_uris</c> HTTP client name.
        /// </summary>
        public const string JwtRequestUri = "pi:protocols:imlx:http:jwturis";

        /// <summary>
        /// The back channel logout HTTP client name.
        /// </summary>
        public const string BackChannelLogout = "pi:protocols:imlx:http:bclogout";
    }
}
