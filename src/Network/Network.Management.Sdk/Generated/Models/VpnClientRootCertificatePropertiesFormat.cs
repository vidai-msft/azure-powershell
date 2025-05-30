// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of SSL certificates of application gateway.
    /// </summary>
    public partial class VpnClientRootCertificatePropertiesFormat
    {
        /// <summary>
        /// Initializes a new instance of the VpnClientRootCertificatePropertiesFormat class.
        /// </summary>
        public VpnClientRootCertificatePropertiesFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VpnClientRootCertificatePropertiesFormat class.
        /// </summary>

        /// <param name="publicCertData">The certificate public data.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the VPN client root certificate resource.
        /// Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;,
        /// &#39;Updating&#39;, &#39;Deleting&#39;</param>
        public VpnClientRootCertificatePropertiesFormat(string publicCertData, string provisioningState = default(string))

        {
            this.PublicCertData = publicCertData;
            this.ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the certificate public data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "publicCertData")]
        public string PublicCertData {get; set; }

        /// <summary>
        /// Gets the provisioning state of the VPN client root certificate resource. Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.PublicCertData == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "PublicCertData");
            }


        }
    }
}