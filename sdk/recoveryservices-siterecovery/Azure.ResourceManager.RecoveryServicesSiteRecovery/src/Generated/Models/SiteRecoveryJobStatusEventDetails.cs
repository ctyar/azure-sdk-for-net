// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Model class for event details of a job status event. </summary>
    public partial class SiteRecoveryJobStatusEventDetails : SiteRecoveryEventSpecificDetails
    {
        /// <summary> Initializes a new instance of SiteRecoveryJobStatusEventDetails. </summary>
        internal SiteRecoveryJobStatusEventDetails()
        {
            InstanceType = "JobStatus";
        }

        /// <summary> Initializes a new instance of SiteRecoveryJobStatusEventDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="jobId"> Job arm id for the event. </param>
        /// <param name="jobFriendlyName"> JobName for the Event. </param>
        /// <param name="jobStatus"> JobStatus for the Event. </param>
        /// <param name="affectedObjectType"> AffectedObjectType for the event. </param>
        internal SiteRecoveryJobStatusEventDetails(string instanceType, ResourceIdentifier jobId, string jobFriendlyName, string jobStatus, string affectedObjectType) : base(instanceType)
        {
            JobId = jobId;
            JobFriendlyName = jobFriendlyName;
            JobStatus = jobStatus;
            AffectedObjectType = affectedObjectType;
            InstanceType = instanceType ?? "JobStatus";
        }

        /// <summary> Job arm id for the event. </summary>
        public ResourceIdentifier JobId { get; }
        /// <summary> JobName for the Event. </summary>
        public string JobFriendlyName { get; }
        /// <summary> JobStatus for the Event. </summary>
        public string JobStatus { get; }
        /// <summary> AffectedObjectType for the event. </summary>
        public string AffectedObjectType { get; }
    }
}
