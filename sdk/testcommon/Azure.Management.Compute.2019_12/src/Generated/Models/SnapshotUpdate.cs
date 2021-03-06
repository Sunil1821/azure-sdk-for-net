// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Compute.Models
{
    /// <summary> Snapshot update resource. </summary>
    public partial class SnapshotUpdate
    {
        /// <summary> Initializes a new instance of SnapshotUpdate. </summary>
        public SnapshotUpdate()
        {
        }

        /// <summary> Initializes a new instance of SnapshotUpdate. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="sku"> The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. </param>
        /// <param name="osType"> the Operating System type. </param>
        /// <param name="diskSizeGB"> If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk&apos;s size. </param>
        /// <param name="encryptionSettingsCollection"> Encryption settings collection used be Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot. </param>
        /// <param name="encryption"> Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys. </param>
        internal SnapshotUpdate(IDictionary<string, string> tags, SnapshotSku sku, OperatingSystemTypes? osType, int? diskSizeGB, EncryptionSettingsCollection encryptionSettingsCollection, Encryption encryption)
        {
            Tags = tags;
            Sku = sku;
            OsType = osType;
            DiskSizeGB = diskSizeGB;
            EncryptionSettingsCollection = encryptionSettingsCollection;
            Encryption = encryption;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; set; }
        /// <summary> The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. </summary>
        public SnapshotSku Sku { get; set; }
        /// <summary> the Operating System type. </summary>
        public OperatingSystemTypes? OsType { get; set; }
        /// <summary> If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk&apos;s size. </summary>
        public int? DiskSizeGB { get; set; }
        /// <summary> Encryption settings collection used be Azure Disk Encryption, can contain multiple encryption settings per disk or snapshot. </summary>
        public EncryptionSettingsCollection EncryptionSettingsCollection { get; set; }
        /// <summary> Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys. </summary>
        public Encryption Encryption { get; set; }
    }
}
