// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// OData response wrapper for a Power BI available features list
    /// </summary>
    public partial class AvailableFeatures
    {
        /// <summary>
        /// Initializes a new instance of the AvailableFeatures class.
        /// </summary>
        public AvailableFeatures()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableFeatures class.
        /// </summary>
        /// <param name="features">The available features list</param>
        public AvailableFeatures(string odatacontext = default(string), IList<AvailableFeature> features = default(IList<AvailableFeature>))
        {
            Odatacontext = odatacontext;
            Features = features;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets the available features list
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public IList<AvailableFeature> Features { get; set; }

    }
}
