﻿/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The <c>oneimlx</c> endpoint names for OAuth and OpenID Connect protocols..
    /// </summary>
    /// <seealso cref="EndpointIds"/>
    public static class EndpointNames
    {
        /// <summary>
        /// The <c>authorize</c> endpoint.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-4.2.1"/>
        public const string Authorize = "authorize";

        /// <summary>
        /// The <c>check_session</c> or <c>check_session_iframe</c> endpoint.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-session-1_0.html"/>
        public const string CheckSession = "check_session";

        /// <summary>
        /// The <c>device_authorization</c> endpoint.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc8628"/>
        public const string DeviceAuthorization = "device_authorization";

        /// <summary>
        /// The <c>discovery</c> or <c>.well-known</c> configuration.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-discovery-1_0.html"/>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7517"/>
        public const string Discovery = "discovery";

        /// <summary>
        /// The <c>end_session</c> endpoint.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-session-1_0.html"/>
        public const string EndSession = "end_session";

        /// <summary>
        /// The token introspection or <c>introspect</c> endpoint.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7662#section-2"/>
        public const string Introspect = "introspect";

        /// <summary>
        /// The token revocation or <c>revoke</c> endpoint.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc7009#section-2.1"/>
        public const string Revoke = "revoke";

        /// <summary>
        /// The <c>token</c> endpoint.
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-3.2"/>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#HybridTokenEndpoint"/>
        public const string Token = "token";

        /// <summary>
        /// The <c>user_info</c> or <c>userinfo</c> endpoint.
        /// </summary>
        /// <seealso href="https://openid.net/specs/openid-connect-core-1_0.html#UserInfo"/>
        public const string UserInfo = "user_info";
    }
}
