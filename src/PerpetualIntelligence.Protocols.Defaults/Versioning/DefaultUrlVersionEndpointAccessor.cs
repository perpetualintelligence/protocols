﻿/*
    Copyright 2021 Perpetual Intelligence L.L.C. All Rights Reserved.

    Licensed under the Apache License, Version 2.0.
    https://github.com/perpetualintelligence/terms/blob/main/LICENSE

    Additional terms and policies.
    https://github.com/perpetualintelligence/terms/blob/main/policies.md
*/

using Microsoft.Extensions.Configuration;
using PerpetualIntelligence.Protocols.Oidc;
using PerpetualIntelligence.Protocols.OneImlx;
using PerpetualIntelligence.Shared.Abstractions;

namespace PerpetualIntelligence.Protocols.Defaults.Versioning
{
    /// <summary>
    /// The default versioned <see cref="IOPAccessor"/>. The version information is added in the URL path.
    /// </summary>
    /// <seealso cref="IOPAccessor"/>
    public sealed class DefaultUrlVersionEndpointAccessor : IOPAccessor
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <param name="urlVersionAccessor">The URL version accessor.</param>
        public DefaultUrlVersionEndpointAccessor(IConfiguration configuration, IUrlVersionAccessor urlVersionAccessor)
        {
            Configuration = configuration;
            UrlVersionAccessor = urlVersionAccessor;
            EndpointHost = Configuration[RuntimeOptions.EndpointsHost];
        }

        /// <inheritdoc/>
        public string Authority
        {
            get
            {
                if (EndpointHost == ApiConstants.LocalhostEndpoint)
                {
                    return Configuration[RuntimeOptions.ApiServerLocalhostEndpoint];
                }
                else
                {
                    return Configuration[RuntimeOptions.ApiServerProductionEndpoint];
                }
            }
        }

        /// <inheritdoc/>
        public string AuthorizeEndpoint
        {
            get
            {
                return $"{UrlVersionAccessor.GetVersion()}/oidc/authorization/authenticate";
            }
        }

        /// <inheritdoc/>
        public string ClientId
        {
            get
            {
                return "Neutral.Q3Wv09Dfk06cGMKONRzXXw.perpetualintelligencetest";
            }
        }

        /// <inheritdoc/>
        public string ClientUri
        {
            get
            {
                if (EndpointHost == ApiConstants.LocalhostEndpoint)
                {
                    return Configuration[RuntimeOptions.ClientAppLocalhostEndpoint];
                }
                else
                {
                    return Configuration[RuntimeOptions.ClientAppProductionEndpoint];
                }
            }
        }

        /// <inheritdoc/>
        public string[] DefaultScopes
        {
            get
            {
                return new string[] {
                    Scopes.OpenId,
                    Scopes.Profile,
                    Scopes.Email,
                    Scopes.Tenant,
                    Scopes.Role,
                    Scopes.Permission,
                    Scopes.Application
                };
            }
        }

        /// <inheritdoc/>
        public string PostLogoutRedirectUri
        {
            get
            {
                return "authentication/logout-callback";
            }
        }

        /// <inheritdoc/>
        public string ProfileEndpoint
        {
            get
            {
                return $"{UrlVersionAccessor.GetVersion()}/oidc/authorization/profile";
            }
        }

        /// <inheritdoc/>
        public string RedirectUri
        {
            get
            {
                return "authentication/login-callback";
            }
        }

        /// <inheritdoc/>
        public string RegisterEndpoint
        {
            get
            {
                return $"{UrlVersionAccessor.GetVersion()}/oidc/authorization/register";
            }
        }

        /// <inheritdoc/>
        public string ResponseType
        {
            get
            {
                return ResponseTypes.Code;
            }
        }

        /// <inheritdoc/>
        public string TokenEndpoint
        {
            get
            {
                return $"{UrlVersionAccessor.GetVersion()}/oidc/authorization/token";
            }
        }

        /// <summary>
        /// The application configuration.
        /// </summary>
        private IConfiguration Configuration { get; }

        /// <summary>
        /// The endpoint host.
        /// </summary>
        private string EndpointHost { get; }

        /// <summary>
        /// The Url version accessor.
        /// </summary>
        private IUrlVersionAccessor UrlVersionAccessor { get; }
    }
}
