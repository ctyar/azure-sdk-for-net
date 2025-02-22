// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Single sign-on request information for domain management. </summary>
    public partial class DomainControlCenterSsoRequestInfo
    {
        /// <summary> Initializes a new instance of DomainControlCenterSsoRequestInfo. </summary>
        internal DomainControlCenterSsoRequestInfo()
        {
        }

        /// <summary> Initializes a new instance of DomainControlCenterSsoRequestInfo. </summary>
        /// <param name="uri"> URL where the single sign-on request is to be made. </param>
        /// <param name="postParameterKey"> Post parameter key. </param>
        /// <param name="postParameterValue"> Post parameter value. Client should use 'application/x-www-form-urlencoded' encoding for this value. </param>
        internal DomainControlCenterSsoRequestInfo(Uri uri, string postParameterKey, string postParameterValue)
        {
            Uri = uri;
            PostParameterKey = postParameterKey;
            PostParameterValue = postParameterValue;
        }

        /// <summary> URL where the single sign-on request is to be made. </summary>
        public Uri Uri { get; }
        /// <summary> Post parameter key. </summary>
        public string PostParameterKey { get; }
        /// <summary> Post parameter value. Client should use 'application/x-www-form-urlencoded' encoding for this value. </summary>
        public string PostParameterValue { get; }
    }
}
