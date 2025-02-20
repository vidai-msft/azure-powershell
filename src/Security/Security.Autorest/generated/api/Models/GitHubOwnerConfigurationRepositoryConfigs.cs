// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Security.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Extensions;

    /// <summary>
    /// GitHub Repository Inventory Configuration.
    /// Dictionary of GitHub repository name to desired repository configuration.
    /// If AutoDiscovery is Enabled, this field should be null or empty.
    /// </summary>
    public partial class GitHubOwnerConfigurationRepositoryConfigs :
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitHubOwnerConfigurationRepositoryConfigs,
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitHubOwnerConfigurationRepositoryConfigsInternal
    {

        /// <summary>
        /// Creates an new <see cref="GitHubOwnerConfigurationRepositoryConfigs" /> instance.
        /// </summary>
        public GitHubOwnerConfigurationRepositoryConfigs()
        {

        }
    }
    /// GitHub Repository Inventory Configuration.
    /// Dictionary of GitHub repository name to desired repository configuration.
    /// If AutoDiscovery is Enabled, this field should be null or empty.
    public partial interface IGitHubOwnerConfigurationRepositoryConfigs :
        Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IBaseResourceConfiguration>
    {

    }
    /// GitHub Repository Inventory Configuration.
    /// Dictionary of GitHub repository name to desired repository configuration.
    /// If AutoDiscovery is Enabled, this field should be null or empty.
    internal partial interface IGitHubOwnerConfigurationRepositoryConfigsInternal

    {

    }
}