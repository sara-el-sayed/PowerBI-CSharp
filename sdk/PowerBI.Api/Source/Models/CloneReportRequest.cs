// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Power BI Clone Report Request
    /// </summary>
    public partial class CloneReportRequest
    {
        /// <summary>
        /// Initializes a new instance of the CloneReportRequest class.
        /// </summary>
        public CloneReportRequest() { }

        /// <summary>
        /// Initializes a new instance of the CloneReportRequest class.
        /// </summary>
        public CloneReportRequest(string name = default(string), string targetWorkspaceId = default(string), string targetModelId = default(string))
        {
            Name = name;
            TargetWorkspaceId = targetWorkspaceId;
            TargetModelId = targetModelId;
        }

        /// <summary>
        /// The requested report name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional parameter for specifying the target workspace id
        /// </summary>
        [JsonProperty(PropertyName = "targetWorkspaceId")]
        public string TargetWorkspaceId { get; set; }

        /// <summary>
        /// Optional parameter for specifying the target associated model
        /// (dataset) id
        /// </summary>
        [JsonProperty(PropertyName = "targetModelId")]
        public string TargetModelId { get; set; }

    }
}
