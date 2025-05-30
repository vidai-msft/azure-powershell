// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Extensions;

    /// <summary>Virtual Machine Instance Properties Update model</summary>
    public partial class VirtualMachineInstanceUpdateProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVirtualMachineInstanceUpdateProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVirtualMachineInstanceUpdateProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IVirtualMachineInstanceUpdateProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json ? new VirtualMachineInstanceUpdateProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VirtualMachineInstanceUpdateProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VirtualMachineInstanceUpdateProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._hardwareProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) this._hardwareProfile.ToJson(null,serializationMode) : null, "hardwareProfile" ,container.Add );
            AddIf( null != this._networkProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) this._networkProfile.ToJson(null,serializationMode) : null, "networkProfile" ,container.Add );
            AddIf( null != this._storageProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) this._storageProfile.ToJson(null,serializationMode) : null, "storageProfile" ,container.Add );
            AddIf( null != this._infrastructureProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) this._infrastructureProfile.ToJson(null,serializationMode) : null, "infrastructureProfile" ,container.Add );
            if (null != this._availabilitySet)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.XNodeArray();
                foreach( var __x in this._availabilitySet )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("availabilitySets",__w);
            }
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject into a new instance of <see cref="VirtualMachineInstanceUpdateProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VirtualMachineInstanceUpdateProperties(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_hardwareProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject>("hardwareProfile"), out var __jsonHardwareProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.HardwareProfileUpdate.FromJson(__jsonHardwareProfile) : _hardwareProfile;}
            {_networkProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject>("networkProfile"), out var __jsonNetworkProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.NetworkProfileUpdate.FromJson(__jsonNetworkProfile) : _networkProfile;}
            {_storageProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject>("storageProfile"), out var __jsonStorageProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.StorageProfileUpdate.FromJson(__jsonStorageProfile) : _storageProfile;}
            {_infrastructureProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject>("infrastructureProfile"), out var __jsonInfrastructureProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.InfrastructureProfileUpdate.FromJson(__jsonInfrastructureProfile) : _infrastructureProfile;}
            {_availabilitySet = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonArray>("availabilitySets"), out var __jsonAvailabilitySets) ? If( __jsonAvailabilitySets as Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetListItem>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetListItem) (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.AvailabilitySetListItem.FromJson(__u) )) ))() : null : _availabilitySet;}
            AfterFromJson(json);
        }
    }
}