// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Extensions;

    /// <summary>Defines the SAP Message Server properties.</summary>
    public partial class MessageServerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMessageServerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMessageServerPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Health" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapHealthState? _health;

        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapHealthState? Health { get => this._health; }

        /// <summary>Backing field for <see cref="Hostname" /> property.</summary>
        private string _hostname;

        /// <summary>Message Server SAP Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string Hostname { get => this._hostname; }

        /// <summary>Backing field for <see cref="HttpPort" /> property.</summary>
        private long? _httpPort;

        /// <summary>Message Server HTTP Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public long? HttpPort { get => this._httpPort; }

        /// <summary>Backing field for <see cref="HttpsPort" /> property.</summary>
        private long? _httpsPort;

        /// <summary>Message Server HTTPS Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public long? HttpsPort { get => this._httpsPort; }

        /// <summary>Backing field for <see cref="IPAddress" /> property.</summary>
        private string _iPAddress;

        /// <summary>Message server IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string IPAddress { get => this._iPAddress; }

        /// <summary>Backing field for <see cref="InternalMSPort" /> property.</summary>
        private long? _internalMSPort;

        /// <summary>Message Server internal MS port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public long? InternalMSPort { get => this._internalMSPort; }

        /// <summary>Backing field for <see cref="MSPort" /> property.</summary>
        private long? _mSPort;

        /// <summary>Message Server port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public long? MSPort { get => this._mSPort; }

        /// <summary>Internal Acessors for Health</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapHealthState? Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMessageServerPropertiesInternal.Health { get => this._health; set { {_health = value;} } }

        /// <summary>Internal Acessors for Hostname</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMessageServerPropertiesInternal.Hostname { get => this._hostname; set { {_hostname = value;} } }

        /// <summary>Internal Acessors for HttpPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMessageServerPropertiesInternal.HttpPort { get => this._httpPort; set { {_httpPort = value;} } }

        /// <summary>Internal Acessors for HttpsPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMessageServerPropertiesInternal.HttpsPort { get => this._httpsPort; set { {_httpsPort = value;} } }

        /// <summary>Internal Acessors for IPAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMessageServerPropertiesInternal.IPAddress { get => this._iPAddress; set { {_iPAddress = value;} } }

        /// <summary>Internal Acessors for InternalMSPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMessageServerPropertiesInternal.InternalMSPort { get => this._internalMSPort; set { {_internalMSPort = value;} } }

        /// <summary>Internal Acessors for MSPort</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.IMessageServerPropertiesInternal.MSPort { get => this._mSPort; set { {_mSPort = value;} } }

        /// <summary>Creates an new <see cref="MessageServerProperties" /> instance.</summary>
        public MessageServerProperties()
        {

        }
    }
    /// Defines the SAP Message Server properties.
    public partial interface IMessageServerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IJsonSerializable
    {
        /// <summary>Defines the health of SAP Instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Defines the health of SAP Instances.",
        SerializedName = @"health",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapHealthState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapHealthState? Health { get;  }
        /// <summary>Message Server SAP Hostname.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Message Server SAP Hostname.",
        SerializedName = @"hostname",
        PossibleTypes = new [] { typeof(string) })]
        string Hostname { get;  }
        /// <summary>Message Server HTTP Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Message Server HTTP Port.",
        SerializedName = @"httpPort",
        PossibleTypes = new [] { typeof(long) })]
        long? HttpPort { get;  }
        /// <summary>Message Server HTTPS Port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Message Server HTTPS Port.",
        SerializedName = @"httpsPort",
        PossibleTypes = new [] { typeof(long) })]
        long? HttpsPort { get;  }
        /// <summary>Message server IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Message server IP Address.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get;  }
        /// <summary>Message Server internal MS port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Message Server internal MS port.",
        SerializedName = @"internalMsPort",
        PossibleTypes = new [] { typeof(long) })]
        long? InternalMSPort { get;  }
        /// <summary>Message Server port.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Message Server port.",
        SerializedName = @"msPort",
        PossibleTypes = new [] { typeof(long) })]
        long? MSPort { get;  }

    }
    /// Defines the SAP Message Server properties.
    internal partial interface IMessageServerPropertiesInternal

    {
        /// <summary>Defines the health of SAP Instances.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Support.SapHealthState? Health { get; set; }
        /// <summary>Message Server SAP Hostname.</summary>
        string Hostname { get; set; }
        /// <summary>Message Server HTTP Port.</summary>
        long? HttpPort { get; set; }
        /// <summary>Message Server HTTPS Port.</summary>
        long? HttpsPort { get; set; }
        /// <summary>Message server IP Address.</summary>
        string IPAddress { get; set; }
        /// <summary>Message Server internal MS port.</summary>
        long? InternalMSPort { get; set; }
        /// <summary>Message Server port.</summary>
        long? MSPort { get; set; }

    }
}