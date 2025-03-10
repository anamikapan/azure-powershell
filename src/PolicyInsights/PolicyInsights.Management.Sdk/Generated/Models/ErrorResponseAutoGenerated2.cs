// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.PolicyInsights.Models
{
    using System.Linq;

    /// <summary>
    /// Error response.
    /// </summary>
    public partial class ErrorResponseAutoGenerated2
    {
        /// <summary>
        /// Initializes a new instance of the ErrorResponseAutoGenerated2 class.
        /// </summary>
        public ErrorResponseAutoGenerated2()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponseAutoGenerated2 class.
        /// </summary>

        /// <param name="error">The error details.
        /// </param>
        public ErrorResponseAutoGenerated2(ErrorDefinitionAutoGenerated2 error = default(ErrorDefinitionAutoGenerated2))

        {
            this.Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the error details.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "error")]
        public ErrorDefinitionAutoGenerated2 Error {get; set; }
    }
}