// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of an operation executed on a recommended sensitivity label.
    /// </summary>
    public partial class RecommendedSensitivityLabelUpdateProperties
    {
        /// <summary>
        /// Initializes a new instance of the RecommendedSensitivityLabelUpdateProperties class.
        /// </summary>
        public RecommendedSensitivityLabelUpdateProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecommendedSensitivityLabelUpdateProperties class.
        /// </summary>

        /// <param name="op">
        /// Possible values include: &#39;enable&#39;, &#39;disable&#39;</param>

        /// <param name="schema">Schema name of the column to update.
        /// </param>

        /// <param name="table">Table name of the column to update.
        /// </param>

        /// <param name="column">Column name to update.
        /// </param>
        public RecommendedSensitivityLabelUpdateProperties(RecommendedSensitivityLabelUpdateKind op, string schema, string table, string column)

        {
            this.Op = op;
            this.Schema = schema;
            this.Table = table;
            this.Column = column;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets Possible values include: &#39;enable&#39;, &#39;disable&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "op")]
        public RecommendedSensitivityLabelUpdateKind Op {get; set; }

        /// <summary>
        /// Gets or sets schema name of the column to update.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "schema")]
        public string Schema {get; set; }

        /// <summary>
        /// Gets or sets table name of the column to update.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "table")]
        public string Table {get; set; }

        /// <summary>
        /// Gets or sets column name to update.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "column")]
        public string Column {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Schema == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Schema");
            }
            if (this.Table == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Table");
            }
            if (this.Column == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Column");
            }




        }
    }
}