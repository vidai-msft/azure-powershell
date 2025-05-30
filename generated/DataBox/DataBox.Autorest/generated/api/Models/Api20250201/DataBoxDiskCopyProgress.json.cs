// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>DataBox Disk Copy Progress</summary>
    public partial class DataBoxDiskCopyProgress
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject into a new instance of <see cref="DataBoxDiskCopyProgress" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DataBoxDiskCopyProgress(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_error = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject>("error"), out var __jsonError) ? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.CloudError.FromJson(__jsonError) : Error;}
            {_serialNumber = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString>("serialNumber"), out var __jsonSerialNumber) ? (string)__jsonSerialNumber : (string)SerialNumber;}
            {_bytesCopied = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNumber>("bytesCopied"), out var __jsonBytesCopied) ? (long?)__jsonBytesCopied : BytesCopied;}
            {_percentComplete = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNumber>("percentComplete"), out var __jsonPercentComplete) ? (int?)__jsonPercentComplete : PercentComplete;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;}
            {_action = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonArray>("actions"), out var __jsonActions) ? If( __jsonActions as Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.CustomerResolutionCode[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.CustomerResolutionCode) (__u is Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString __t ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.CustomerResolutionCode)(__t.ToString()) : ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.CustomerResolutionCode)""))) ))() : null : Action;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxDiskCopyProgress.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxDiskCopyProgress.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxDiskCopyProgress FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject json ? new DataBoxDiskCopyProgress(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DataBoxDiskCopyProgress" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DataBoxDiskCopyProgress" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._error ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode) this._error.ToJson(null,serializationMode) : null, "error" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._serialNumber)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString(this._serialNumber.ToString()) : null, "serialNumber" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._bytesCopied ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNumber((long)this._bytesCopied) : null, "bytesCopied" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._percentComplete ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNumber((int)this._percentComplete) : null, "percentComplete" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._action)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.XNodeArray();
                    foreach( var __x in this._action )
                    {
                        AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                    }
                    container.Add("actions",__w);
                }
            }
            AfterToJson(ref container);
            return container;
        }
    }
}