// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> The information of an AutoApprovedPrivateLinkService. </summary>
    public partial class AutoApprovedPrivateLinkService
    {
        /// <summary> Initializes a new instance of AutoApprovedPrivateLinkService. </summary>
        internal AutoApprovedPrivateLinkService()
        {
        }

        /// <summary> Initializes a new instance of AutoApprovedPrivateLinkService. </summary>
        /// <param name="privateLinkService"> The id of the private link service resource. </param>
        internal AutoApprovedPrivateLinkService(string privateLinkService)
        {
            PrivateLinkService = privateLinkService;
        }

        /// <summary> The id of the private link service resource. </summary>
        public string PrivateLinkService { get; }
    }
}
