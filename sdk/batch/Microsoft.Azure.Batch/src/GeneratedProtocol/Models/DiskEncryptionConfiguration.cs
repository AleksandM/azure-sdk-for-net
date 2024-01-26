// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The disk encryption configuration applied on compute nodes in the pool.
    /// Disk encryption configuration is not supported on Linux pool created
    /// with Azure Compute Gallery Image.
    /// </summary>
    public partial class DiskEncryptionConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the DiskEncryptionConfiguration
        /// class.
        /// </summary>
        public DiskEncryptionConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskEncryptionConfiguration
        /// class.
        /// </summary>
        /// <param name="targets">The list of disk targets Batch Service will
        /// encrypt on the compute node.</param>
        public DiskEncryptionConfiguration(IList<DiskEncryptionTarget> targets = default(IList<DiskEncryptionTarget>))
        {
            Targets = targets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of disk targets Batch Service will encrypt on
        /// the compute node.
        /// </summary>
        /// <remarks>
        /// If omitted, no disks on the compute nodes in the pool will be
        /// encrypted. On Linux pool, only "TemporaryDisk" is supported; on
        /// Windows pool, "OsDisk" and "TemporaryDisk" must be specified.
        /// </remarks>
        [JsonProperty(PropertyName = "targets")]
        public IList<DiskEncryptionTarget> Targets { get; set; }

    }
}
