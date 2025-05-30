// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Extensions;

    /// <summary>Troubleshooters in Solutions</summary>
    public partial class SolutionsTroubleshooters :
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionsTroubleshooters,
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionsTroubleshootersInternal
    {

        /// <summary>Backing field for <see cref="SolutionId" /> property.</summary>
        private string _solutionId;

        /// <summary>Solution Id to identify single Solutions Troubleshooter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public string SolutionId { get => this._solutionId; set => this._solutionId = value; }

        /// <summary>Backing field for <see cref="Summary" /> property.</summary>
        private string _summary;

        /// <summary>Troubleshooter summary</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public string Summary { get => this._summary; set => this._summary = value; }

        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private string _title;

        /// <summary>Troubleshooter title</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public string Title { get => this._title; set => this._title = value; }

        /// <summary>Creates an new <see cref="SolutionsTroubleshooters" /> instance.</summary>
        public SolutionsTroubleshooters()
        {

        }
    }
    /// Troubleshooters in Solutions
    public partial interface ISolutionsTroubleshooters :
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.IJsonSerializable
    {
        /// <summary>Solution Id to identify single Solutions Troubleshooter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Solution Id to identify single Solutions Troubleshooter",
        SerializedName = @"solutionId",
        PossibleTypes = new [] { typeof(string) })]
        string SolutionId { get; set; }
        /// <summary>Troubleshooter summary</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Troubleshooter summary",
        SerializedName = @"summary",
        PossibleTypes = new [] { typeof(string) })]
        string Summary { get; set; }
        /// <summary>Troubleshooter title</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Troubleshooter title",
        SerializedName = @"title",
        PossibleTypes = new [] { typeof(string) })]
        string Title { get; set; }

    }
    /// Troubleshooters in Solutions
    internal partial interface ISolutionsTroubleshootersInternal

    {
        /// <summary>Solution Id to identify single Solutions Troubleshooter</summary>
        string SolutionId { get; set; }
        /// <summary>Troubleshooter summary</summary>
        string Summary { get; set; }
        /// <summary>Troubleshooter title</summary>
        string Title { get; set; }

    }
}