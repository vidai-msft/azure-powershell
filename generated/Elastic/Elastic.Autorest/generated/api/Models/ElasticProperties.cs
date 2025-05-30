// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Extensions;

    /// <summary>Elastic Resource Properties.</summary>
    public partial class ElasticProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ElasticCloudDeployment" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeployment _elasticCloudDeployment;

        /// <summary>Details of the elastic cloud deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeployment ElasticCloudDeployment { get => (this._elasticCloudDeployment = this._elasticCloudDeployment ?? new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.ElasticCloudDeployment()); set => this._elasticCloudDeployment = value; }

        /// <summary>Associated Azure subscription Id for the elastic deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        public string ElasticCloudDeploymentAzureSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).AzureSubscriptionId; }

        /// <summary>Region where Deployment at Elastic side took place.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        public string ElasticCloudDeploymentElasticsearchRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).ElasticsearchRegion; }

        /// <summary>Elasticsearch ingestion endpoint of the Elastic deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        public string ElasticCloudDeploymentElasticsearchServiceUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).ElasticsearchServiceUrl; }

        /// <summary>Elastic deployment Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        public string ElasticCloudDeploymentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).DeploymentId; }

        /// <summary>Kibana endpoint of the Elastic deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        public string ElasticCloudDeploymentKibanaServiceUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).KibanaServiceUrl; }

        /// <summary>Kibana dashboard sso URL of the Elastic deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        public string ElasticCloudDeploymentKibanaSsoUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).KibanaSsoUrl; }

        /// <summary>Elastic deployment name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        public string ElasticCloudDeploymentName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).Name; }

        /// <summary>Backing field for <see cref="ElasticCloudUser" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudUser _elasticCloudUser;

        /// <summary>Details of the user's elastic account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudUser ElasticCloudUser { get => (this._elasticCloudUser = this._elasticCloudUser ?? new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.ElasticCloudUser()); set => this._elasticCloudUser = value; }

        /// <summary>Elastic cloud default dashboard sso URL of the Elastic user account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        public string ElasticCloudUserElasticCloudSsoDefaultUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudUserInternal)ElasticCloudUser).ElasticCloudSsoDefaultUrl; }

        /// <summary>Email of the Elastic User Account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        public string ElasticCloudUserEmailAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudUserInternal)ElasticCloudUser).EmailAddress; }

        /// <summary>User Id of the elastic account of the User.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Inlined)]
        public string ElasticCloudUserId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudUserInternal)ElasticCloudUser).Id; }

        /// <summary>Internal Acessors for ElasticCloudDeployment</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeployment Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticPropertiesInternal.ElasticCloudDeployment { get => (this._elasticCloudDeployment = this._elasticCloudDeployment ?? new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.ElasticCloudDeployment()); set { {_elasticCloudDeployment = value;} } }

        /// <summary>Internal Acessors for ElasticCloudDeploymentAzureSubscriptionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticPropertiesInternal.ElasticCloudDeploymentAzureSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).AzureSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).AzureSubscriptionId = value; }

        /// <summary>Internal Acessors for ElasticCloudDeploymentElasticsearchRegion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticPropertiesInternal.ElasticCloudDeploymentElasticsearchRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).ElasticsearchRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).ElasticsearchRegion = value; }

        /// <summary>Internal Acessors for ElasticCloudDeploymentElasticsearchServiceUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticPropertiesInternal.ElasticCloudDeploymentElasticsearchServiceUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).ElasticsearchServiceUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).ElasticsearchServiceUrl = value; }

        /// <summary>Internal Acessors for ElasticCloudDeploymentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticPropertiesInternal.ElasticCloudDeploymentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).DeploymentId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).DeploymentId = value; }

        /// <summary>Internal Acessors for ElasticCloudDeploymentKibanaServiceUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticPropertiesInternal.ElasticCloudDeploymentKibanaServiceUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).KibanaServiceUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).KibanaServiceUrl = value; }

        /// <summary>Internal Acessors for ElasticCloudDeploymentKibanaSsoUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticPropertiesInternal.ElasticCloudDeploymentKibanaSsoUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).KibanaSsoUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).KibanaSsoUrl = value; }

        /// <summary>Internal Acessors for ElasticCloudDeploymentName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticPropertiesInternal.ElasticCloudDeploymentName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeploymentInternal)ElasticCloudDeployment).Name = value; }

        /// <summary>Internal Acessors for ElasticCloudUser</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudUser Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticPropertiesInternal.ElasticCloudUser { get => (this._elasticCloudUser = this._elasticCloudUser ?? new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.ElasticCloudUser()); set { {_elasticCloudUser = value;} } }

        /// <summary>Internal Acessors for ElasticCloudUserElasticCloudSsoDefaultUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticPropertiesInternal.ElasticCloudUserElasticCloudSsoDefaultUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudUserInternal)ElasticCloudUser).ElasticCloudSsoDefaultUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudUserInternal)ElasticCloudUser).ElasticCloudSsoDefaultUrl = value; }

        /// <summary>Internal Acessors for ElasticCloudUserEmailAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticPropertiesInternal.ElasticCloudUserEmailAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudUserInternal)ElasticCloudUser).EmailAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudUserInternal)ElasticCloudUser).EmailAddress = value; }

        /// <summary>Internal Acessors for ElasticCloudUserId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticPropertiesInternal.ElasticCloudUserId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudUserInternal)ElasticCloudUser).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudUserInternal)ElasticCloudUser).Id = value; }

        /// <summary>Creates an new <see cref="ElasticProperties" /> instance.</summary>
        public ElasticProperties()
        {

        }
    }
    /// Elastic Resource Properties.
    public partial interface IElasticProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.IJsonSerializable
    {
        /// <summary>Associated Azure subscription Id for the elastic deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Associated Azure subscription Id for the elastic deployment.",
        SerializedName = @"azureSubscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string ElasticCloudDeploymentAzureSubscriptionId { get;  }
        /// <summary>Region where Deployment at Elastic side took place.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Region where Deployment at Elastic side took place.",
        SerializedName = @"elasticsearchRegion",
        PossibleTypes = new [] { typeof(string) })]
        string ElasticCloudDeploymentElasticsearchRegion { get;  }
        /// <summary>Elasticsearch ingestion endpoint of the Elastic deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Elasticsearch ingestion endpoint of the Elastic deployment.",
        SerializedName = @"elasticsearchServiceUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ElasticCloudDeploymentElasticsearchServiceUrl { get;  }
        /// <summary>Elastic deployment Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Elastic deployment Id",
        SerializedName = @"deploymentId",
        PossibleTypes = new [] { typeof(string) })]
        string ElasticCloudDeploymentId { get;  }
        /// <summary>Kibana endpoint of the Elastic deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Kibana endpoint of the Elastic deployment.",
        SerializedName = @"kibanaServiceUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ElasticCloudDeploymentKibanaServiceUrl { get;  }
        /// <summary>Kibana dashboard sso URL of the Elastic deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Kibana dashboard sso URL of the Elastic deployment.",
        SerializedName = @"kibanaSsoUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ElasticCloudDeploymentKibanaSsoUrl { get;  }
        /// <summary>Elastic deployment name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Elastic deployment name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ElasticCloudDeploymentName { get;  }
        /// <summary>Elastic cloud default dashboard sso URL of the Elastic user account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Elastic cloud default dashboard sso URL of the Elastic user account.",
        SerializedName = @"elasticCloudSsoDefaultUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ElasticCloudUserElasticCloudSsoDefaultUrl { get;  }
        /// <summary>Email of the Elastic User Account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Email of the Elastic User Account.",
        SerializedName = @"emailAddress",
        PossibleTypes = new [] { typeof(string) })]
        string ElasticCloudUserEmailAddress { get;  }
        /// <summary>User Id of the elastic account of the User.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"User Id of the elastic account of the User.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ElasticCloudUserId { get;  }

    }
    /// Elastic Resource Properties.
    internal partial interface IElasticPropertiesInternal

    {
        /// <summary>Details of the elastic cloud deployment.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeployment ElasticCloudDeployment { get; set; }
        /// <summary>Associated Azure subscription Id for the elastic deployment.</summary>
        string ElasticCloudDeploymentAzureSubscriptionId { get; set; }
        /// <summary>Region where Deployment at Elastic side took place.</summary>
        string ElasticCloudDeploymentElasticsearchRegion { get; set; }
        /// <summary>Elasticsearch ingestion endpoint of the Elastic deployment.</summary>
        string ElasticCloudDeploymentElasticsearchServiceUrl { get; set; }
        /// <summary>Elastic deployment Id</summary>
        string ElasticCloudDeploymentId { get; set; }
        /// <summary>Kibana endpoint of the Elastic deployment.</summary>
        string ElasticCloudDeploymentKibanaServiceUrl { get; set; }
        /// <summary>Kibana dashboard sso URL of the Elastic deployment.</summary>
        string ElasticCloudDeploymentKibanaSsoUrl { get; set; }
        /// <summary>Elastic deployment name</summary>
        string ElasticCloudDeploymentName { get; set; }
        /// <summary>Details of the user's elastic account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudUser ElasticCloudUser { get; set; }
        /// <summary>Elastic cloud default dashboard sso URL of the Elastic user account.</summary>
        string ElasticCloudUserElasticCloudSsoDefaultUrl { get; set; }
        /// <summary>Email of the Elastic User Account.</summary>
        string ElasticCloudUserEmailAddress { get; set; }
        /// <summary>User Id of the elastic account of the User.</summary>
        string ElasticCloudUserId { get; set; }

    }
}