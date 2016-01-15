﻿// ------------------------------------------------------------------------------------------------
// <copyright file="Error.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// ------------------------------------------------------------------------------------------------

namespace HwaCli.Logging
{
    using System;

    public class Error
    {
        public int Code { get; set; }

        public string Type { get; set; }

        public string Severity { get; set; }

        public string[] Params { get; set; }

        public string Message { get; set; }
    }

    public static class Errors
    {
        private const string ERROR = "ERROR";
        private const string WARNING = "WARNING";

        public static Error ManifestNotFound
        {
            get
            {
                return new Error()
                {
                    Code = 1,
                    Type = "ManifestNotFound",
                    Severity = ERROR,
                    Message = "Manifest could not be found at {0}."
                };
            }
        }

        public static Error StartUrlNotSpecified
        {
            get
            {
                return new Error()
                {
                    Code = 2,
                    Type = "StartUrlNotSpecified",
                    Severity = ERROR,
                    Message = "The W3C manifest must specify a start_url."
                };
            }
        } 

        public static Error AppxCreationFailed
        { 
            get
            {
                return new Error()
                {
                    Code = 3,
                    Type = "AppxCreationFailed",
                    Severity = ERROR,
                    Message = "Error while running MakeAppx.exe to create Appx package. Reason: {0}"
                };
            }
        }

        public static Error LaunchUrlNotSpecified
        {
            get
            {
                return new Error()
                {
                    Code = 4,
                    Type = "LaunchUrlNotSpecified",
                    Severity = ERROR,
                    Message = "A value was specified neither at app.launch.web_url nor app.launch.local_path in the JSON manifest."
                };
            }
        }

        public static Error DomainParsingFailed
        {
            get
            {
                return new Error()
                {
                    Code = 5,
                    Type = "DomainParsingFailed",
                    Severity = ERROR,
                    Message = "Domain parsing failed for the following url: {0}"
                };
            }
        }

        public static Error NoIconsFound
        {
            get
            {
                return new Error()
                {
                    Code = 6,
                    Type = "NoIconsFound",
                    Severity = ERROR,
                    Message = "Manifest must contain at least one icon."
                };
            }
        }

        public static Error RelativePathReferencesParentDirectory
        {
            get
            {
                return new Error()
                {
                    Code = 7,
                    Type = "RelativePathReferencesParentDirectory",
                    Severity = ERROR,
                    Message = "Relative paths in manifest cannot reference parent directory using \"..\". Violating path: {0}"
                };
            }
        }

        public static Error RelativePathExpected
        {
            get
            {
                return new Error()
                {
                    Code = 8,
                    Type = "RelativePathExpected",
                    Severity = ERROR,
                    Message = "A relative path was expected, but instead found an abosolute path: {0}"
                };
            }
        }

        public static Error UnsupportedProtocolInAcur
        {
            get
            {
                return new Error()
                {
                    Code = 9,
                    Type = "UnsupportedProtocolInAcur",
                    Severity = ERROR,
                    Message = "Expected protocol to be in ['http', 'https', '*']. Instead protocol was '{0}'."
                };
            }
        }

        public static Error IconNotFound
        {
            get
            {
                return new Error()
                {
                    Code = 10,
                    Type = "IconNotFound",
                    Severity = ERROR,
                    Message = "Manifest specifies icon that cannot be found at path: \"{0}\""
                };
            }
        }
    }
}