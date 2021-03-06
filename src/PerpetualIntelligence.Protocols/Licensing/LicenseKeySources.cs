/*
    Copyright (c) Perpetual Intelligence L.L.C. All Rights Reserved.

    For license, terms, and data policies, go to:
    https://terms.perpetualintelligence.com
*/

namespace PerpetualIntelligence.Protocols.Licensing
{
    /// <summary>
    /// The license key sources.
    /// </summary>
    public sealed class LicenseKeySources
    {
        /// <summary>
        /// Determines if the key source is valid.
        /// </summary>
        /// <returns><c>true</c> if the key source is valid; otherwise, <c>false</c>.</returns>
        public static bool IsValid(string keySource)
        {
            switch (keySource)
            {
                case JsonFile:
                    {
                        return true;
                    }
                default:
                    {
                        return false;
                    }
            }
        }

        /// <summary>
        /// The key source is a json file.
        /// </summary>
        public const string JsonFile = "urn:oneimlx:lic:ksource:jsonfile";
    }
}
