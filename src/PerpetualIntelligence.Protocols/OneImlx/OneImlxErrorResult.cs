﻿/*
    Copyright (c) 2019-2022. All Rights Reserved. Perpetual Intelligence L.L.C.
    https://perpetualintelligence.com
    https://api.perpetualintelligence.com
*/

using System.Collections.Generic;
using System.Linq;

namespace PerpetualIntelligence.Protocols.OneImlx
{
    /// <summary>
    /// The generic <c>oneimlx</c> error result.
    /// </summary>
    /// <seealso cref="OneImlxError"/>
    public class OneImlxErrorResult
    {
        /// <summary>
        /// The result errors.
        /// </summary>
        public OneImlxError[]? Errors
        {
            get
            {
                return _errorList?.ToArray();
            }
        }

        /// <summary>
        /// The first error, if the result represents an error.
        /// </summary>
        public OneImlxError? FirstError
        {
            get
            {
                return _errorList?[0];
            }
        }

        /// <summary>
        /// The first error code, if the result represents an error.
        /// </summary>
        public string? FirstErrorCode
        {
            get
            {
                return _errorList?[0]?.Error;
            }
        }

        /// <summary>
        /// Indicates whether the result is an error.
        /// </summary>
        public bool IsError
        {
            get
            {
                if (_errorList == null)
                {
                    return false;
                }

                // Make sure there is at-least 1 error with a valid error code
                return _errorList.Any(e => !string.IsNullOrWhiteSpace(e.Error));
            }
        }

        /// <summary>
        /// Adds an error to the result.
        /// </summary>
        public void AddError(string error, string? errorDescription = null, string? errorUri = null, string? requestId = null, int? httpStatusCode = null)
        {
            if (string.IsNullOrWhiteSpace(error))
            {
                throw new System.ArgumentException($"'{nameof(error)}' cannot be null or whitespace.", nameof(error));
            }

            AddError(new OneImlxError(error, errorDescription, errorUri, requestId, httpStatusCode));
        }

        /// <summary>
        /// Adds an error to the result.
        /// </summary>
        public void AddError(OneImlxError error)
        {
            if (error == null)
            {
                throw new System.ArgumentException($"'{nameof(error)}' cannot be null.", nameof(error));
            }

            if (string.IsNullOrWhiteSpace(error.Error))
            {
                throw new System.ArgumentException($"'{nameof(error.Error)}' cannot be null or whitespace.", nameof(error));
            }

            if (_errorList == null)
            {
                _errorList = new();
            }

            _errorList.Add(error);
        }

        /// <summary>
        /// Removes all the errors from the result.
        /// </summary>
        /// <returns></returns>
        public void NoError()
        {
            _errorList = null;
        }

        /// <summary>
        /// Set an error on the result. This will clear all the existing errors and set the specified error.
        /// </summary>
        /// <seealso cref="AddError(OneImlxError)"/>
        /// <seealso cref="AddError(string, string?, string?, string?, int?)"/>
        public void SetError(string error, string? errorDescription = null, string? errorUri = null, string? requestId = null, int? httpStatusCode = null)
        {
            if (string.IsNullOrWhiteSpace(error))
            {
                throw new System.ArgumentException($"'{nameof(error)}' cannot be null or whitespace.", nameof(error));
            }

            // Clear all errors
            NoError();

            // Now add the specified error.
            AddError(new OneImlxError(error, errorDescription, errorUri, requestId, httpStatusCode));
        }

        /// <summary>
        /// Set an error on the result. This will clear all the existing errors and set the specified error.
        /// </summary>
        /// <seealso cref="AddError(OneImlxError)"/>
        /// <seealso cref="AddError(string, string?, string?, string?, int?)"/>
        public void SetError(OneImlxError error)
        {
            if (error == null)
            {
                throw new System.ArgumentException($"'{nameof(error)}' cannot be null.", nameof(error));
            }

            // Clear all errors
            NoError();

            // Now add the specified error.
            AddError(error);
        }

        /// <summary>
        /// Syncs all the errors from the input to this instance.
        /// </summary>
        public void SyncError(OneImlxErrorResult input)
        {
            if (input.IsError)
            {
                // Clear all on this instance
                NoError();

                // Sync errors.
                _errorList = new List<OneImlxError>(input._errorList);
            }
        }

        private List<OneImlxError>? _errorList;
    }
}
