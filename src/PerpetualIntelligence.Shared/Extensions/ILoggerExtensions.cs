﻿/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

using Microsoft.Extensions.Logging;
using PerpetualIntelligence.Shared.Infrastructure;
using PerpetualIntelligence.Shared.Services;
using System;

namespace PerpetualIntelligence.Shared.Extensions
{
    /// <summary>
    /// The <see cref="ILogger{T}"/> extension methods.
    /// </summary>
    public static class ILoggerExtensions
    {
        /// <summary>
        /// Logs the formated message and returns the logged message for downstream processing.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="logLevel"></param>
        /// <param name="loggingOptions"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string FormatAndLog(this ILogger logger, LogLevel logLevel, LoggingOptions loggingOptions, string message, params object[]? args)
        {
            // For downstream processing
            Tuple<string, object[]?> formatted = FormatMessage(loggingOptions, message, args);

            // For actual logging
            switch (logLevel)
            {
                case LogLevel.Information:
                    {
                        logger.LogInformation(message, formatted.Item2);
                        break;
                    }
                case LogLevel.Warning:
                    {
                        logger.LogWarning(message, formatted.Item2);
                        break;
                    }
                case LogLevel.Error:
                    {
                        logger.LogError(message, formatted.Item2);
                        break;
                    }
                case LogLevel.Debug:
                    {
                        logger.LogDebug(message, formatted.Item2);
                        break;
                    }
                case LogLevel.Trace:
                    {
                        logger.LogTrace(message, formatted.Item2);
                        break;
                    }
                case LogLevel.Critical:
                    {
                        logger.LogCritical(message, formatted.Item2);
                        break;
                    }
                default:
                    {
                        // Don't log
                        break;
                    }
            }

            return formatted.Item1;
        }

        private static Tuple<string, object[]?> FormatMessage(LoggingOptions loggingOptions, string message, params object[]? args)
        {
            if (args != null)
            {
                object[]? argsToUse = Formatter.Obscure(loggingOptions, args);
                return new(string.Format(message, argsToUse), argsToUse);
            }
            else
            {
                return new(message, null); ;
            }
        }
    }
}
