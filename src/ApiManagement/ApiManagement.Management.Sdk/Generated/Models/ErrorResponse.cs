// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Error Response.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        public ErrorResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>

        /// <param name="code">Service-defined error code. This code serves as a sub-status for the HTTP
        /// error code specified in the response.
        /// </param>

        /// <param name="message">Human-readable representation of the error.
        /// </param>

        /// <param name="details">The list of invalid fields send in request, in case of validation error.
        /// </param>
        public ErrorResponse(string code = default(string), string message = default(string), System.Collections.Generic.IList<ErrorFieldContract> details = default(System.Collections.Generic.IList<ErrorFieldContract>))

        {
            this.Code = code;
            this.Message = message;
            this.Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets service-defined error code. This code serves as a sub-status
        /// for the HTTP error code specified in the response.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "error.code")]
        public string Code {get; set; }

        /// <summary>
        /// Gets or sets human-readable representation of the error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "error.message")]
        public string Message {get; set; }

        /// <summary>
        /// Gets or sets the list of invalid fields send in request, in case of
        /// validation error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "error.details")]
        public System.Collections.Generic.IList<ErrorFieldContract> Details {get; set; }
    }
}