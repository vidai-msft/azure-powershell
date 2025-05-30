// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Encryption key containing details about key to encrypt different keys.</summary>
    [System.ComponentModel.TypeConverter(typeof(KeyEncryptionKeyTypeConverter))]
    public partial class KeyEncryptionKey
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.KeyEncryptionKey"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKey" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKey DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new KeyEncryptionKey(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.KeyEncryptionKey"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKey" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKey DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new KeyEncryptionKey(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="KeyEncryptionKey" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="KeyEncryptionKey" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKey FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.KeyEncryptionKey"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal KeyEncryptionKey(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("KekType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).KekType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.KekType) content.GetValueForProperty("KekType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).KekType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.KekType.CreateFrom);
            }
            if (content.Contains("IdentityProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).IdentityProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IIdentityProperties) content.GetValueForProperty("IdentityProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).IdentityProperty, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IdentityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("KekUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).KekUrl = (string) content.GetValueForProperty("KekUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).KekUrl, global::System.Convert.ToString);
            }
            if (content.Contains("KekVaultResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).KekVaultResourceId = (string) content.GetValueForProperty("KekVaultResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).KekVaultResourceId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.KeyEncryptionKey"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal KeyEncryptionKey(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("KekType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).KekType = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.KekType) content.GetValueForProperty("KekType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).KekType, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.KekType.CreateFrom);
            }
            if (content.Contains("IdentityProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).IdentityProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IIdentityProperties) content.GetValueForProperty("IdentityProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).IdentityProperty, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IdentityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("KekUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).KekUrl = (string) content.GetValueForProperty("KekUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).KekUrl, global::System.Convert.ToString);
            }
            if (content.Contains("KekVaultResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).KekVaultResourceId = (string) content.GetValueForProperty("KekVaultResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IKeyEncryptionKeyInternal)this).KekVaultResourceId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Encryption key containing details about key to encrypt different keys.
    [System.ComponentModel.TypeConverter(typeof(KeyEncryptionKeyTypeConverter))]
    public partial interface IKeyEncryptionKey

    {

    }
}