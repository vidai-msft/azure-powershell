// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Extensions;

    /// <summary>The response of a VmInstanceHybridIdentityMetadata list operation.</summary>
    public partial class VMInstanceHybridIdentityMetadataListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVMInstanceHybridIdentityMetadataListResult,
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVMInstanceHybridIdentityMetadataListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVMInstanceHybridIdentityMetadataListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVMInstanceHybridIdentityMetadata> _value;

        /// <summary>The VmInstanceHybridIdentityMetadata items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVMInstanceHybridIdentityMetadata> Value { get => this._value; set => this._value = value; }

        /// <summary>
        /// Creates an new <see cref="VMInstanceHybridIdentityMetadataListResult" /> instance.
        /// </summary>
        public VMInstanceHybridIdentityMetadataListResult()
        {

        }
    }
    /// The response of a VmInstanceHybridIdentityMetadata list operation.
    public partial interface IVMInstanceHybridIdentityMetadataListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>The VmInstanceHybridIdentityMetadata items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The VmInstanceHybridIdentityMetadata items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVMInstanceHybridIdentityMetadata) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVMInstanceHybridIdentityMetadata> Value { get; set; }

    }
    /// The response of a VmInstanceHybridIdentityMetadata list operation.
    internal partial interface IVMInstanceHybridIdentityMetadataListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The VmInstanceHybridIdentityMetadata items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVMInstanceHybridIdentityMetadata> Value { get; set; }

    }
}