// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// HDInsight Pig activity type.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HDInsightPig")]
    [Rest.Serialization.JsonTransformation]
    public partial class HDInsightPigActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the HDInsightPigActivity class.
        /// </summary>
        public HDInsightPigActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HDInsightPigActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="state">Activity state. This is an optional property
        /// and if not provided, the state will be Active by default. Possible
        /// values include: 'Active', 'Inactive'</param>
        /// <param name="onInactiveMarkAs">Status result of the activity when
        /// the state is set to Inactive. This is an optional property and if
        /// not provided when the activity is inactive, the status will be
        /// Succeeded by default. Possible values include: 'Succeeded',
        /// 'Failed', 'Skipped'</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        /// <param name="storageLinkedServices">Storage linked service
        /// references.</param>
        /// <param name="arguments">User specified arguments to
        /// HDInsightActivity. Type: array (or Expression with resultType
        /// array).</param>
        /// <param name="getDebugInfo">Debug info option. Possible values
        /// include: 'None', 'Always', 'Failure'</param>
        /// <param name="scriptPath">Script path. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="scriptLinkedService">Script linked service
        /// reference.</param>
        /// <param name="defines">Allows user to specify defines for Pig job
        /// request.</param>
        public HDInsightPigActivity(string name, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), string state = default(string), string onInactiveMarkAs = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IList<UserProperty> userProperties = default(IList<UserProperty>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), IList<LinkedServiceReference> storageLinkedServices = default(IList<LinkedServiceReference>), object arguments = default(object), string getDebugInfo = default(string), object scriptPath = default(object), LinkedServiceReference scriptLinkedService = default(LinkedServiceReference), IDictionary<string, object> defines = default(IDictionary<string, object>))
            : base(name, additionalProperties, description, state, onInactiveMarkAs, dependsOn, userProperties, linkedServiceName, policy)
        {
            StorageLinkedServices = storageLinkedServices;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            ScriptPath = scriptPath;
            ScriptLinkedService = scriptLinkedService;
            Defines = defines;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets storage linked service references.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.storageLinkedServices")]
        public IList<LinkedServiceReference> StorageLinkedServices { get; set; }

        /// <summary>
        /// Gets or sets user specified arguments to HDInsightActivity. Type:
        /// array (or Expression with resultType array).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.arguments")]
        public object Arguments { get; set; }

        /// <summary>
        /// Gets or sets debug info option. Possible values include: 'None',
        /// 'Always', 'Failure'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.getDebugInfo")]
        public string GetDebugInfo { get; set; }

        /// <summary>
        /// Gets or sets script path. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.scriptPath")]
        public object ScriptPath { get; set; }

        /// <summary>
        /// Gets or sets script linked service reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.scriptLinkedService")]
        public LinkedServiceReference ScriptLinkedService { get; set; }

        /// <summary>
        /// Gets or sets allows user to specify defines for Pig job request.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.defines")]
        public IDictionary<string, object> Defines { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (StorageLinkedServices != null)
            {
                foreach (var element in StorageLinkedServices)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ScriptLinkedService != null)
            {
                ScriptLinkedService.Validate();
            }
        }
    }
}
