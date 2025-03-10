// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of a cost item.
    /// </summary>
    public partial class LabCostProperties
    {
        /// <summary>
        /// Initializes a new instance of the LabCostProperties class.
        /// </summary>
        public LabCostProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LabCostProperties class.
        /// </summary>

        /// <param name="targetCost">The target cost properties
        /// </param>

        /// <param name="labCostSummary">The lab cost summary component of the cost data.
        /// </param>

        /// <param name="labCostDetails">The lab cost details component of the cost data.
        /// </param>

        /// <param name="resourceCosts">The resource cost component of the cost data.
        /// </param>

        /// <param name="currencyCode">The currency code of the cost.
        /// </param>

        /// <param name="startDateTime">The start time of the cost data.
        /// </param>

        /// <param name="endDateTime">The end time of the cost data.
        /// </param>

        /// <param name="createdDate">The creation date of the cost.
        /// </param>

        /// <param name="provisioningState">The provisioning status of the resource.
        /// </param>

        /// <param name="uniqueIdentifier">The unique immutable identifier of a resource (Guid).
        /// </param>
        public LabCostProperties(TargetCostProperties targetCost = default(TargetCostProperties), LabCostSummaryProperties labCostSummary = default(LabCostSummaryProperties), System.Collections.Generic.IList<LabCostDetailsProperties> labCostDetails = default(System.Collections.Generic.IList<LabCostDetailsProperties>), System.Collections.Generic.IList<LabResourceCostProperties> resourceCosts = default(System.Collections.Generic.IList<LabResourceCostProperties>), string currencyCode = default(string), System.DateTime? startDateTime = default(System.DateTime?), System.DateTime? endDateTime = default(System.DateTime?), System.DateTime? createdDate = default(System.DateTime?), string provisioningState = default(string), string uniqueIdentifier = default(string))

        {
            this.TargetCost = targetCost;
            this.LabCostSummary = labCostSummary;
            this.LabCostDetails = labCostDetails;
            this.ResourceCosts = resourceCosts;
            this.CurrencyCode = currencyCode;
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
            this.CreatedDate = createdDate;
            this.ProvisioningState = provisioningState;
            this.UniqueIdentifier = uniqueIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the target cost properties
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetCost")]
        public TargetCostProperties TargetCost {get; set; }

        /// <summary>
        /// Gets the lab cost summary component of the cost data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "labCostSummary")]
        public LabCostSummaryProperties LabCostSummary {get; private set; }

        /// <summary>
        /// Gets the lab cost details component of the cost data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "labCostDetails")]
        public System.Collections.Generic.IList<LabCostDetailsProperties> LabCostDetails {get; private set; }

        /// <summary>
        /// Gets the resource cost component of the cost data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceCosts")]
        public System.Collections.Generic.IList<LabResourceCostProperties> ResourceCosts {get; private set; }

        /// <summary>
        /// Gets or sets the currency code of the cost.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "currencyCode")]
        public string CurrencyCode {get; set; }

        /// <summary>
        /// Gets or sets the start time of the cost data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startDateTime")]
        public System.DateTime? StartDateTime {get; set; }

        /// <summary>
        /// Gets or sets the end time of the cost data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endDateTime")]
        public System.DateTime? EndDateTime {get; set; }

        /// <summary>
        /// Gets or sets the creation date of the cost.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "createdDate")]
        public System.DateTime? CreatedDate {get; set; }

        /// <summary>
        /// Gets or sets the provisioning status of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; set; }

        /// <summary>
        /// Gets or sets the unique immutable identifier of a resource (Guid).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "uniqueIdentifier")]
        public string UniqueIdentifier {get; set; }
    }
}