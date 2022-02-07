﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Cli
{
    /// <summary>
    /// The errors for the Perpetual Intelligence's <c>cli</c> protocol.
    /// </summary>
    public static class Errors
    {
        /// <summary>
        /// The argument is not already added to the command.
        /// </summary>
        public const string DuplicateArgument = "duplicate_argument";

        /// <summary>
        /// The argument is not valid.
        /// </summary>
        public const string InvalidArgument = "invalid_argument";

        /// <summary>
        /// The command is not valid.
        /// </summary>
        public const string InvalidCommand = "invalid_command";

        /// <summary>
        /// The configuration is not valid.
        /// </summary>
        public const string InvalidConfiguration = "invalid_configuration";

        /// <summary>
        /// The request is not valid.
        /// </summary>
        public const string InvalidRequest = "invalid_request";

        /// <summary>
        /// The argument is missing.
        /// </summary>
        public const string MissingArgument = "missing_argument";

        /// <summary>
        /// The request is canceled.
        /// </summary>
        public const string RequestCanceled = "request_canceled";

        /// <summary>
        /// The server error.
        /// </summary>
        public const string ServerError = "server_error";

        /// <summary>
        /// The argument is not supported.
        /// </summary>
        public const string UnsupportedArgument = "unsupported_argument";

        /// <summary>
        /// The command is not supported.
        /// </summary>
        public const string UnsupportedCommand = "unsupported_command";
    }
}
