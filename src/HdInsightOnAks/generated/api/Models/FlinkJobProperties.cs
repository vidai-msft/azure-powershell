// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Extensions;

    /// <summary>Properties of flink job.</summary>
    public partial class FlinkJobProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkJobProperties,
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkJobPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterJobProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterJobProperties __clusterJobProperties = new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ClusterJobProperties();

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private string _action;

        /// <summary>
        /// A string property that indicates the action to be performed on the Flink job. It can have one of the following enum values
        /// => NEW, UPDATE, STATELESS_UPDATE, STOP, START, CANCEL, SAVEPOINT, LIST_SAVEPOINT, or DELETE.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string Action { get => this._action; set => this._action = value; }

        /// <summary>Backing field for <see cref="ActionResult" /> property.</summary>
        private string _actionResult;

        /// <summary>Action result of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string ActionResult { get => this._actionResult; }

        /// <summary>Backing field for <see cref="Arg" /> property.</summary>
        private string _arg;

        /// <summary>
        /// A string property representing additional JVM arguments for the Flink job. It should be space separated value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string Arg { get => this._arg; set => this._arg = value; }

        /// <summary>Backing field for <see cref="EntryClass" /> property.</summary>
        private string _entryClass;

        /// <summary>A string property that specifies the entry class for the Flink job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string EntryClass { get => this._entryClass; set => this._entryClass = value; }

        /// <summary>Backing field for <see cref="FlinkConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkJobPropertiesFlinkConfiguration _flinkConfiguration;

        /// <summary>
        /// Additional properties used to configure Flink jobs. It allows users to set properties such as parallelism and jobSavePointDirectory.
        /// It accepts additional key-value pairs as properties, where the keys are strings and the values are strings as well.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkJobPropertiesFlinkConfiguration FlinkConfiguration { get => (this._flinkConfiguration = this._flinkConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.FlinkJobPropertiesFlinkConfiguration()); set => this._flinkConfiguration = value; }

        /// <summary>Backing field for <see cref="JarName" /> property.</summary>
        private string _jarName;

        /// <summary>A string property that represents the name of the job JAR.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string JarName { get => this._jarName; set => this._jarName = value; }

        /// <summary>Backing field for <see cref="JobId" /> property.</summary>
        private string _jobId;

        /// <summary>Unique id for identifying a job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string JobId { get => this._jobId; }

        /// <summary>Backing field for <see cref="JobJarDirectory" /> property.</summary>
        private string _jobJarDirectory;

        /// <summary>A string property that specifies the directory where the job JAR is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string JobJarDirectory { get => this._jobJarDirectory; set => this._jobJarDirectory = value; }

        /// <summary>Backing field for <see cref="JobName" /> property.</summary>
        private string _jobName;

        /// <summary>Name of job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string JobName { get => this._jobName; set => this._jobName = value; }

        /// <summary>Backing field for <see cref="JobOutput" /> property.</summary>
        private string _jobOutput;

        /// <summary>Output of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string JobOutput { get => this._jobOutput; }

        /// <summary>Type of cluster job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inherited)]
        public string JobType { get => "FlinkJob"; }

        /// <summary>Backing field for <see cref="LastSavePoint" /> property.</summary>
        private string _lastSavePoint;

        /// <summary>The last savepoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string LastSavePoint { get => this._lastSavePoint; }

        /// <summary>Internal Acessors for JobType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterJobPropertiesInternal.JobType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterJobPropertiesInternal)__clusterJobProperties).JobType; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterJobPropertiesInternal)__clusterJobProperties).JobType = value; }

        /// <summary>Internal Acessors for ActionResult</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkJobPropertiesInternal.ActionResult { get => this._actionResult; set { {_actionResult = value;} } }

        /// <summary>Internal Acessors for JobId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkJobPropertiesInternal.JobId { get => this._jobId; set { {_jobId = value;} } }

        /// <summary>Internal Acessors for JobOutput</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkJobPropertiesInternal.JobOutput { get => this._jobOutput; set { {_jobOutput = value;} } }

        /// <summary>Internal Acessors for LastSavePoint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkJobPropertiesInternal.LastSavePoint { get => this._lastSavePoint; set { {_lastSavePoint = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkJobPropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="SavePointName" /> property.</summary>
        private string _savePointName;

        /// <summary>A string property that represents the name of the savepoint for the Flink job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string SavePointName { get => this._savePointName; set => this._savePointName = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Status of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Creates an new <see cref="FlinkJobProperties" /> instance.</summary>
        public FlinkJobProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__clusterJobProperties), __clusterJobProperties);
            await eventListener.AssertObjectIsValid(nameof(__clusterJobProperties), __clusterJobProperties);
        }
    }
    /// Properties of flink job.
    public partial interface IFlinkJobProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterJobProperties
    {
        /// <summary>
        /// A string property that indicates the action to be performed on the Flink job. It can have one of the following enum values
        /// => NEW, UPDATE, STATELESS_UPDATE, STOP, START, CANCEL, SAVEPOINT, LIST_SAVEPOINT, or DELETE.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A string property that indicates the action to be performed on the Flink job. It can have one of the following enum values => NEW, UPDATE, STATELESS_UPDATE, STOP, START, CANCEL, SAVEPOINT, LIST_SAVEPOINT, or DELETE.",
        SerializedName = @"action",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PSArgumentCompleterAttribute("NEW", "UPDATE", "STATELESS_UPDATE", "STOP", "START", "CANCEL", "SAVEPOINT", "LIST_SAVEPOINT", "DELETE")]
        string Action { get; set; }
        /// <summary>Action result of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Action result of job.",
        SerializedName = @"actionResult",
        PossibleTypes = new [] { typeof(string) })]
        string ActionResult { get;  }
        /// <summary>
        /// A string property representing additional JVM arguments for the Flink job. It should be space separated value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A string property representing additional JVM arguments for the Flink job. It should be space separated value.",
        SerializedName = @"args",
        PossibleTypes = new [] { typeof(string) })]
        string Arg { get; set; }
        /// <summary>A string property that specifies the entry class for the Flink job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A string property that specifies the entry class for the Flink job.",
        SerializedName = @"entryClass",
        PossibleTypes = new [] { typeof(string) })]
        string EntryClass { get; set; }
        /// <summary>
        /// Additional properties used to configure Flink jobs. It allows users to set properties such as parallelism and jobSavePointDirectory.
        /// It accepts additional key-value pairs as properties, where the keys are strings and the values are strings as well.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Additional properties used to configure Flink jobs. It allows users to set properties such as parallelism and jobSavePointDirectory. It accepts additional key-value pairs as properties, where the keys are strings and the values are strings as well.",
        SerializedName = @"flinkConfiguration",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkJobPropertiesFlinkConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkJobPropertiesFlinkConfiguration FlinkConfiguration { get; set; }
        /// <summary>A string property that represents the name of the job JAR.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A string property that represents the name of the job JAR.",
        SerializedName = @"jarName",
        PossibleTypes = new [] { typeof(string) })]
        string JarName { get; set; }
        /// <summary>Unique id for identifying a job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Unique id for identifying a job",
        SerializedName = @"jobId",
        PossibleTypes = new [] { typeof(string) })]
        string JobId { get;  }
        /// <summary>A string property that specifies the directory where the job JAR is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A string property that specifies the directory where the job JAR is located.",
        SerializedName = @"jobJarDirectory",
        PossibleTypes = new [] { typeof(string) })]
        string JobJarDirectory { get; set; }
        /// <summary>Name of job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of job",
        SerializedName = @"jobName",
        PossibleTypes = new [] { typeof(string) })]
        string JobName { get; set; }
        /// <summary>Output of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Output of job.",
        SerializedName = @"jobOutput",
        PossibleTypes = new [] { typeof(string) })]
        string JobOutput { get;  }
        /// <summary>The last savepoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The last savepoint.",
        SerializedName = @"lastSavePoint",
        PossibleTypes = new [] { typeof(string) })]
        string LastSavePoint { get;  }
        /// <summary>A string property that represents the name of the savepoint for the Flink job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A string property that represents the name of the savepoint for the Flink job",
        SerializedName = @"savePointName",
        PossibleTypes = new [] { typeof(string) })]
        string SavePointName { get; set; }
        /// <summary>Status of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of job.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get;  }

    }
    /// Properties of flink job.
    internal partial interface IFlinkJobPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterJobPropertiesInternal
    {
        /// <summary>
        /// A string property that indicates the action to be performed on the Flink job. It can have one of the following enum values
        /// => NEW, UPDATE, STATELESS_UPDATE, STOP, START, CANCEL, SAVEPOINT, LIST_SAVEPOINT, or DELETE.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PSArgumentCompleterAttribute("NEW", "UPDATE", "STATELESS_UPDATE", "STOP", "START", "CANCEL", "SAVEPOINT", "LIST_SAVEPOINT", "DELETE")]
        string Action { get; set; }
        /// <summary>Action result of job.</summary>
        string ActionResult { get; set; }
        /// <summary>
        /// A string property representing additional JVM arguments for the Flink job. It should be space separated value.
        /// </summary>
        string Arg { get; set; }
        /// <summary>A string property that specifies the entry class for the Flink job.</summary>
        string EntryClass { get; set; }
        /// <summary>
        /// Additional properties used to configure Flink jobs. It allows users to set properties such as parallelism and jobSavePointDirectory.
        /// It accepts additional key-value pairs as properties, where the keys are strings and the values are strings as well.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkJobPropertiesFlinkConfiguration FlinkConfiguration { get; set; }
        /// <summary>A string property that represents the name of the job JAR.</summary>
        string JarName { get; set; }
        /// <summary>Unique id for identifying a job</summary>
        string JobId { get; set; }
        /// <summary>A string property that specifies the directory where the job JAR is located.</summary>
        string JobJarDirectory { get; set; }
        /// <summary>Name of job</summary>
        string JobName { get; set; }
        /// <summary>Output of job.</summary>
        string JobOutput { get; set; }
        /// <summary>The last savepoint.</summary>
        string LastSavePoint { get; set; }
        /// <summary>A string property that represents the name of the savepoint for the Flink job</summary>
        string SavePointName { get; set; }
        /// <summary>Status of job.</summary>
        string Status { get; set; }

    }
}