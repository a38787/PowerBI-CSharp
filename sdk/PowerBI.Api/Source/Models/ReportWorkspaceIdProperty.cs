// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ReportWorkspaceIdProperty
    {
        /// <summary>
        /// Initializes a new instance of the ReportWorkspaceIdProperty class.
        /// </summary>
        public ReportWorkspaceIdProperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReportWorkspaceIdProperty class.
        /// </summary>
        /// <param name="workspaceId">The report workspace ID. This property
        /// will be returned only in GetReportsAsAdmin.</param>
        public ReportWorkspaceIdProperty(System.Guid? workspaceId = default(System.Guid?))
        {
            WorkspaceId = workspaceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the report workspace ID. This property will be
        /// returned only in GetReportsAsAdmin.
        /// </summary>
        [JsonProperty(PropertyName = "workspaceId")]
        public System.Guid? WorkspaceId { get; set; }

    }
}
