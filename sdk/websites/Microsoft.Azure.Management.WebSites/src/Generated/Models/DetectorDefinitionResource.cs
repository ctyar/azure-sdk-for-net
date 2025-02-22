// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ARM resource for a detector definition
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DetectorDefinitionResource : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the DetectorDefinitionResource class.
        /// </summary>
        public DetectorDefinitionResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DetectorDefinitionResource class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">Display name of the detector</param>
        /// <param name="description">Description of the detector</param>
        /// <param name="rank">Detector Rank</param>
        /// <param name="isEnabled">Flag representing whether detector is
        /// enabled or not.</param>
        public DetectorDefinitionResource(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string displayName = default(string), string description = default(string), double? rank = default(double?), bool? isEnabled = default(bool?))
            : base(id, name, kind, type)
        {
            DisplayName = displayName;
            Description = description;
            Rank = rank;
            IsEnabled = isEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets display name of the detector
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets description of the detector
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets detector Rank
        /// </summary>
        [JsonProperty(PropertyName = "properties.rank")]
        public double? Rank { get; private set; }

        /// <summary>
        /// Gets flag representing whether detector is enabled or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isEnabled")]
        public bool? IsEnabled { get; private set; }

    }
}
