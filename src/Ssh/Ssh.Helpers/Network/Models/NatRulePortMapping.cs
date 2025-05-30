// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Individual port mappings for inbound NAT rule created for backend pool.
    /// </summary>
    public partial class NatRulePortMapping
    {
        /// <summary>
        /// Initializes a new instance of the NatRulePortMapping class.
        /// </summary>
        public NatRulePortMapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NatRulePortMapping class.
        /// </summary>

        /// <param name="inboundNatRuleName">Name of inbound NAT rule.
        /// </param>

        /// <param name="frontendPort">Frontend port.
        /// </param>

        /// <param name="backendPort">Backend port.
        /// </param>
        public NatRulePortMapping(string inboundNatRuleName = default(string), int? frontendPort = default(int?), int? backendPort = default(int?))

        {
            this.InboundNatRuleName = inboundNatRuleName;
            this.FrontendPort = frontendPort;
            this.BackendPort = backendPort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of inbound NAT rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "inboundNatRuleName")]
        public string InboundNatRuleName {get; set; }

        /// <summary>
        /// Gets or sets frontend port.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "frontendPort")]
        public int? FrontendPort {get; set; }

        /// <summary>
        /// Gets or sets backend port.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "backendPort")]
        public int? BackendPort {get; set; }
    }
}