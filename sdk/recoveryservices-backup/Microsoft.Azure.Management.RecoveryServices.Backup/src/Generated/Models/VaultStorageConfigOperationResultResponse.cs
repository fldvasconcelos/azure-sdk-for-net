// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Operation result response for VaultStorageConfig
    /// </summary>
    public partial class VaultStorageConfigOperationResultResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VaultStorageConfigOperationResultResponse class.
        /// </summary>
        public VaultStorageConfigOperationResultResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VaultStorageConfigOperationResultResponse class.
        /// </summary>
        public VaultStorageConfigOperationResultResponse(string objectType)
        {
            ObjectType = objectType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ObjectType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ObjectType");
            }
        }
    }
}
