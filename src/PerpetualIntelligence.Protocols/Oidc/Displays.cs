﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

namespace PerpetualIntelligence.Protocols.Oidc
{
    /// <summary>
    /// The OpenID Connect authentication protocol display modes.
    /// </summary>
    /// <seealso href="https://openid.net/specs/openid-connect-basic-1_0.html"/>
    public static class Displays
    {
        /// <summary>
        /// The Authorization Server SHOULD display the authentication and consent UI consistent with a full User Agent
        /// page view. If the display parameter is not specified, this is the default display mode.
        /// </summary>
        public const string Page = "page";

        /// <summary>
        /// The Authorization Server SHOULD display the authentication and consent UI consistent with a popup User Agent
        /// window. The pop-up User Agent window should be of an appropriate size for a login-focused dialog and should
        /// not obscure the entire window that it is popping up over.
        /// </summary>
        public const string Popup = "popup";

        /// <summary>
        /// The Authorization Server SHOULD display the authentication and consent UI consistent with a device that
        /// leverages a touch interface.
        /// </summary>
        public const string Touch = "touch";

        /// <summary>
        /// The Authorization Server SHOULD display the authentication and consent UI consistent with a "feature phone"
        /// type display.
        /// </summary>
        public const string Wap = "wap";
    }
}