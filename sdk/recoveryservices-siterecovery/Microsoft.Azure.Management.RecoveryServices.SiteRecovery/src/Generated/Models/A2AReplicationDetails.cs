// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A2A provider specific settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("A2A")]
    public partial class A2AReplicationDetails : ReplicationProviderSpecificSettings
    {
        /// <summary>
        /// Initializes a new instance of the A2AReplicationDetails class.
        /// </summary>
        public A2AReplicationDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2AReplicationDetails class.
        /// </summary>
        /// <param name="fabricObjectId">The fabric specific object Id of the
        /// virtual machine.</param>
        /// <param name="initialPrimaryZone">The initial primary availability
        /// zone.</param>
        /// <param name="initialPrimaryFabricLocation">The initial primary
        /// fabric location.</param>
        /// <param name="initialRecoveryZone">The initial recovery availability
        /// zone.</param>
        /// <param name="initialRecoveryFabricLocation">The initial recovery
        /// fabric location.</param>
        /// <param name="multiVmGroupId">The multi vm group Id.</param>
        /// <param name="multiVmGroupName">The multi vm group name.</param>
        /// <param name="multiVmGroupCreateOption">Whether Multi VM group is
        /// auto created or specified by user. Possible values include:
        /// 'AutoCreated', 'UserSpecified'</param>
        /// <param name="managementId">The management Id.</param>
        /// <param name="protectedDisks">The list of protected disks.</param>
        /// <param name="unprotectedDisks">The list of unprotected
        /// disks.</param>
        /// <param name="protectedManagedDisks">The list of protected managed
        /// disks.</param>
        /// <param name="recoveryBootDiagStorageAccountId">The recovery boot
        /// diagnostic storage account Arm Id.</param>
        /// <param name="primaryFabricLocation">Primary fabric
        /// location.</param>
        /// <param name="recoveryFabricLocation">The recovery fabric
        /// location.</param>
        /// <param name="osType">The type of operating system.</param>
        /// <param name="recoveryAzureVMSize">The size of recovery virtual
        /// machine.</param>
        /// <param name="recoveryAzureVMName">The name of recovery virtual
        /// machine.</param>
        /// <param name="recoveryAzureResourceGroupId">The recovery resource
        /// group.</param>
        /// <param name="recoveryCloudService">The recovery cloud
        /// service.</param>
        /// <param name="recoveryAvailabilitySet">The recovery availability
        /// set.</param>
        /// <param name="selectedRecoveryAzureNetworkId">The recovery virtual
        /// network.</param>
        /// <param name="selectedTfoAzureNetworkId">The test failover virtual
        /// network.</param>
        /// <param name="vmNics">The virtual machine nic details.</param>
        /// <param name="vmSyncedConfigDetails">The synced configuration
        /// details.</param>
        /// <param name="monitoringPercentageCompletion">The percentage of the
        /// monitoring job. The type of the monitoring job is defined by
        /// MonitoringJobType property.</param>
        /// <param name="monitoringJobType">The type of the monitoring job. The
        /// progress is contained in MonitoringPercentageCompletion
        /// property.</param>
        /// <param name="lastHeartbeat">The last heartbeat received from the
        /// source server.</param>
        /// <param name="agentVersion">The agent version.</param>
        /// <param name="agentExpiryDate">Agent expiry date.</param>
        /// <param name="isReplicationAgentUpdateRequired">A value indicating
        /// whether replication agent update is required.</param>
        /// <param name="agentCertificateExpiryDate">Agent certificate expiry
        /// date.</param>
        /// <param name="isReplicationAgentCertificateUpdateRequired">A value
        /// indicating whether agent certificate update is required.</param>
        /// <param name="recoveryFabricObjectId">The recovery fabric object
        /// Id.</param>
        /// <param name="vmProtectionState">The protection state for the
        /// vm.</param>
        /// <param name="vmProtectionStateDescription">The protection state
        /// description for the vm.</param>
        /// <param name="lifecycleId">An id associated with the PE that
        /// survives actions like switch protection which change the backing
        /// PE/CPE objects internally.The lifecycle id gets carried forward to
        /// have a link/continuity in being able to have an Id that denotes the
        /// "same" protected item even though other internal Ids/ARM Id might
        /// be changing.</param>
        /// <param name="testFailoverRecoveryFabricObjectId">The test failover
        /// fabric object Id.</param>
        /// <param name="rpoInSeconds">The last RPO value in seconds.</param>
        /// <param name="lastRpoCalculatedTime">The time (in UTC) when the last
        /// RPO value was calculated by Protection Service.</param>
        /// <param name="primaryAvailabilityZone">The primary availability
        /// zone.</param>
        /// <param name="recoveryAvailabilityZone">The recovery availability
        /// zone.</param>
        /// <param name="vmEncryptionType">The encryption type of the VM.
        /// Possible values include: 'NotEncrypted', 'OnePassEncrypted',
        /// 'TwoPassEncrypted'</param>
        /// <param name="tfoAzureVMName">The test failover vm name.</param>
        /// <param name="recoveryAzureGeneration">The recovery azure
        /// generation.</param>
        /// <param name="recoveryProximityPlacementGroupId">The recovery
        /// proximity placement group Id.</param>
        /// <param name="autoProtectionOfDataDisk">A value indicating whether
        /// the auto protection is enabled. Possible values include:
        /// 'Disabled', 'Enabled'</param>
        /// <param name="recoveryVirtualMachineScaleSetId">The recovery virtual
        /// machine scale set id.</param>
        /// <param name="recoveryCapacityReservationGroupId">The recovery
        /// capacity reservation group Id.</param>
        public A2AReplicationDetails(string fabricObjectId = default(string), string initialPrimaryZone = default(string), string initialPrimaryFabricLocation = default(string), string initialRecoveryZone = default(string), string initialRecoveryFabricLocation = default(string), string multiVmGroupId = default(string), string multiVmGroupName = default(string), string multiVmGroupCreateOption = default(string), string managementId = default(string), IList<A2AProtectedDiskDetails> protectedDisks = default(IList<A2AProtectedDiskDetails>), IList<A2AUnprotectedDiskDetails> unprotectedDisks = default(IList<A2AUnprotectedDiskDetails>), IList<A2AProtectedManagedDiskDetails> protectedManagedDisks = default(IList<A2AProtectedManagedDiskDetails>), string recoveryBootDiagStorageAccountId = default(string), string primaryFabricLocation = default(string), string recoveryFabricLocation = default(string), string osType = default(string), string recoveryAzureVMSize = default(string), string recoveryAzureVMName = default(string), string recoveryAzureResourceGroupId = default(string), string recoveryCloudService = default(string), string recoveryAvailabilitySet = default(string), string selectedRecoveryAzureNetworkId = default(string), string selectedTfoAzureNetworkId = default(string), IList<VMNicDetails> vmNics = default(IList<VMNicDetails>), AzureToAzureVmSyncedConfigDetails vmSyncedConfigDetails = default(AzureToAzureVmSyncedConfigDetails), int? monitoringPercentageCompletion = default(int?), string monitoringJobType = default(string), System.DateTime? lastHeartbeat = default(System.DateTime?), string agentVersion = default(string), System.DateTime? agentExpiryDate = default(System.DateTime?), bool? isReplicationAgentUpdateRequired = default(bool?), System.DateTime? agentCertificateExpiryDate = default(System.DateTime?), bool? isReplicationAgentCertificateUpdateRequired = default(bool?), string recoveryFabricObjectId = default(string), string vmProtectionState = default(string), string vmProtectionStateDescription = default(string), string lifecycleId = default(string), string testFailoverRecoveryFabricObjectId = default(string), long? rpoInSeconds = default(long?), System.DateTime? lastRpoCalculatedTime = default(System.DateTime?), string primaryAvailabilityZone = default(string), string recoveryAvailabilityZone = default(string), string vmEncryptionType = default(string), string tfoAzureVMName = default(string), string recoveryAzureGeneration = default(string), string recoveryProximityPlacementGroupId = default(string), string autoProtectionOfDataDisk = default(string), string recoveryVirtualMachineScaleSetId = default(string), string recoveryCapacityReservationGroupId = default(string))
        {
            FabricObjectId = fabricObjectId;
            InitialPrimaryZone = initialPrimaryZone;
            InitialPrimaryFabricLocation = initialPrimaryFabricLocation;
            InitialRecoveryZone = initialRecoveryZone;
            InitialRecoveryFabricLocation = initialRecoveryFabricLocation;
            MultiVmGroupId = multiVmGroupId;
            MultiVmGroupName = multiVmGroupName;
            MultiVmGroupCreateOption = multiVmGroupCreateOption;
            ManagementId = managementId;
            ProtectedDisks = protectedDisks;
            UnprotectedDisks = unprotectedDisks;
            ProtectedManagedDisks = protectedManagedDisks;
            RecoveryBootDiagStorageAccountId = recoveryBootDiagStorageAccountId;
            PrimaryFabricLocation = primaryFabricLocation;
            RecoveryFabricLocation = recoveryFabricLocation;
            OsType = osType;
            RecoveryAzureVMSize = recoveryAzureVMSize;
            RecoveryAzureVMName = recoveryAzureVMName;
            RecoveryAzureResourceGroupId = recoveryAzureResourceGroupId;
            RecoveryCloudService = recoveryCloudService;
            RecoveryAvailabilitySet = recoveryAvailabilitySet;
            SelectedRecoveryAzureNetworkId = selectedRecoveryAzureNetworkId;
            SelectedTfoAzureNetworkId = selectedTfoAzureNetworkId;
            VmNics = vmNics;
            VmSyncedConfigDetails = vmSyncedConfigDetails;
            MonitoringPercentageCompletion = monitoringPercentageCompletion;
            MonitoringJobType = monitoringJobType;
            LastHeartbeat = lastHeartbeat;
            AgentVersion = agentVersion;
            AgentExpiryDate = agentExpiryDate;
            IsReplicationAgentUpdateRequired = isReplicationAgentUpdateRequired;
            AgentCertificateExpiryDate = agentCertificateExpiryDate;
            IsReplicationAgentCertificateUpdateRequired = isReplicationAgentCertificateUpdateRequired;
            RecoveryFabricObjectId = recoveryFabricObjectId;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
            LifecycleId = lifecycleId;
            TestFailoverRecoveryFabricObjectId = testFailoverRecoveryFabricObjectId;
            RpoInSeconds = rpoInSeconds;
            LastRpoCalculatedTime = lastRpoCalculatedTime;
            PrimaryAvailabilityZone = primaryAvailabilityZone;
            RecoveryAvailabilityZone = recoveryAvailabilityZone;
            VmEncryptionType = vmEncryptionType;
            TfoAzureVMName = tfoAzureVMName;
            RecoveryAzureGeneration = recoveryAzureGeneration;
            RecoveryProximityPlacementGroupId = recoveryProximityPlacementGroupId;
            AutoProtectionOfDataDisk = autoProtectionOfDataDisk;
            RecoveryVirtualMachineScaleSetId = recoveryVirtualMachineScaleSetId;
            RecoveryCapacityReservationGroupId = recoveryCapacityReservationGroupId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fabric specific object Id of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "fabricObjectId")]
        public string FabricObjectId { get; set; }

        /// <summary>
        /// Gets the initial primary availability zone.
        /// </summary>
        [JsonProperty(PropertyName = "initialPrimaryZone")]
        public string InitialPrimaryZone { get; private set; }

        /// <summary>
        /// Gets the initial primary fabric location.
        /// </summary>
        [JsonProperty(PropertyName = "initialPrimaryFabricLocation")]
        public string InitialPrimaryFabricLocation { get; private set; }

        /// <summary>
        /// Gets the initial recovery availability zone.
        /// </summary>
        [JsonProperty(PropertyName = "initialRecoveryZone")]
        public string InitialRecoveryZone { get; private set; }

        /// <summary>
        /// Gets the initial recovery fabric location.
        /// </summary>
        [JsonProperty(PropertyName = "initialRecoveryFabricLocation")]
        public string InitialRecoveryFabricLocation { get; private set; }

        /// <summary>
        /// Gets or sets the multi vm group Id.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupId")]
        public string MultiVmGroupId { get; set; }

        /// <summary>
        /// Gets or sets the multi vm group name.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupName")]
        public string MultiVmGroupName { get; set; }

        /// <summary>
        /// Gets or sets whether Multi VM group is auto created or specified by
        /// user. Possible values include: 'AutoCreated', 'UserSpecified'
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupCreateOption")]
        public string MultiVmGroupCreateOption { get; set; }

        /// <summary>
        /// Gets or sets the management Id.
        /// </summary>
        [JsonProperty(PropertyName = "managementId")]
        public string ManagementId { get; set; }

        /// <summary>
        /// Gets or sets the list of protected disks.
        /// </summary>
        [JsonProperty(PropertyName = "protectedDisks")]
        public IList<A2AProtectedDiskDetails> ProtectedDisks { get; set; }

        /// <summary>
        /// Gets or sets the list of unprotected disks.
        /// </summary>
        [JsonProperty(PropertyName = "unprotectedDisks")]
        public IList<A2AUnprotectedDiskDetails> UnprotectedDisks { get; set; }

        /// <summary>
        /// Gets or sets the list of protected managed disks.
        /// </summary>
        [JsonProperty(PropertyName = "protectedManagedDisks")]
        public IList<A2AProtectedManagedDiskDetails> ProtectedManagedDisks { get; set; }

        /// <summary>
        /// Gets or sets the recovery boot diagnostic storage account Arm Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryBootDiagStorageAccountId")]
        public string RecoveryBootDiagStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets primary fabric location.
        /// </summary>
        [JsonProperty(PropertyName = "primaryFabricLocation")]
        public string PrimaryFabricLocation { get; set; }

        /// <summary>
        /// Gets or sets the recovery fabric location.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricLocation")]
        public string RecoveryFabricLocation { get; set; }

        /// <summary>
        /// Gets or sets the type of operating system.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the size of recovery virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureVMSize")]
        public string RecoveryAzureVMSize { get; set; }

        /// <summary>
        /// Gets or sets the name of recovery virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureVMName")]
        public string RecoveryAzureVMName { get; set; }

        /// <summary>
        /// Gets or sets the recovery resource group.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureResourceGroupId")]
        public string RecoveryAzureResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets the recovery cloud service.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryCloudService")]
        public string RecoveryCloudService { get; set; }

        /// <summary>
        /// Gets or sets the recovery availability set.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAvailabilitySet")]
        public string RecoveryAvailabilitySet { get; set; }

        /// <summary>
        /// Gets or sets the recovery virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "selectedRecoveryAzureNetworkId")]
        public string SelectedRecoveryAzureNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the test failover virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "selectedTfoAzureNetworkId")]
        public string SelectedTfoAzureNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine nic details.
        /// </summary>
        [JsonProperty(PropertyName = "vmNics")]
        public IList<VMNicDetails> VmNics { get; set; }

        /// <summary>
        /// Gets or sets the synced configuration details.
        /// </summary>
        [JsonProperty(PropertyName = "vmSyncedConfigDetails")]
        public AzureToAzureVmSyncedConfigDetails VmSyncedConfigDetails { get; set; }

        /// <summary>
        /// Gets or sets the percentage of the monitoring job. The type of the
        /// monitoring job is defined by MonitoringJobType property.
        /// </summary>
        [JsonProperty(PropertyName = "monitoringPercentageCompletion")]
        public int? MonitoringPercentageCompletion { get; set; }

        /// <summary>
        /// Gets or sets the type of the monitoring job. The progress is
        /// contained in MonitoringPercentageCompletion property.
        /// </summary>
        [JsonProperty(PropertyName = "monitoringJobType")]
        public string MonitoringJobType { get; set; }

        /// <summary>
        /// Gets or sets the last heartbeat received from the source server.
        /// </summary>
        [JsonProperty(PropertyName = "lastHeartbeat")]
        public System.DateTime? LastHeartbeat { get; set; }

        /// <summary>
        /// Gets or sets the agent version.
        /// </summary>
        [JsonProperty(PropertyName = "agentVersion")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Gets or sets agent expiry date.
        /// </summary>
        [JsonProperty(PropertyName = "agentExpiryDate")]
        public System.DateTime? AgentExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether replication agent update is
        /// required.
        /// </summary>
        [JsonProperty(PropertyName = "isReplicationAgentUpdateRequired")]
        public bool? IsReplicationAgentUpdateRequired { get; set; }

        /// <summary>
        /// Gets agent certificate expiry date.
        /// </summary>
        [JsonProperty(PropertyName = "agentCertificateExpiryDate")]
        public System.DateTime? AgentCertificateExpiryDate { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether agent certificate update is
        /// required.
        /// </summary>
        [JsonProperty(PropertyName = "isReplicationAgentCertificateUpdateRequired")]
        public bool? IsReplicationAgentCertificateUpdateRequired { get; set; }

        /// <summary>
        /// Gets or sets the recovery fabric object Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricObjectId")]
        public string RecoveryFabricObjectId { get; set; }

        /// <summary>
        /// Gets or sets the protection state for the vm.
        /// </summary>
        [JsonProperty(PropertyName = "vmProtectionState")]
        public string VmProtectionState { get; set; }

        /// <summary>
        /// Gets or sets the protection state description for the vm.
        /// </summary>
        [JsonProperty(PropertyName = "vmProtectionStateDescription")]
        public string VmProtectionStateDescription { get; set; }

        /// <summary>
        /// Gets or sets an id associated with the PE that survives actions
        /// like switch protection which change the backing PE/CPE objects
        /// internally.The lifecycle id gets carried forward to have a
        /// link/continuity in being able to have an Id that denotes the "same"
        /// protected item even though other internal Ids/ARM Id might be
        /// changing.
        /// </summary>
        [JsonProperty(PropertyName = "lifecycleId")]
        public string LifecycleId { get; set; }

        /// <summary>
        /// Gets or sets the test failover fabric object Id.
        /// </summary>
        [JsonProperty(PropertyName = "testFailoverRecoveryFabricObjectId")]
        public string TestFailoverRecoveryFabricObjectId { get; set; }

        /// <summary>
        /// Gets or sets the last RPO value in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "rpoInSeconds")]
        public long? RpoInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the time (in UTC) when the last RPO value was
        /// calculated by Protection Service.
        /// </summary>
        [JsonProperty(PropertyName = "lastRpoCalculatedTime")]
        public System.DateTime? LastRpoCalculatedTime { get; set; }

        /// <summary>
        /// Gets or sets the primary availability zone.
        /// </summary>
        [JsonProperty(PropertyName = "primaryAvailabilityZone")]
        public string PrimaryAvailabilityZone { get; set; }

        /// <summary>
        /// Gets or sets the recovery availability zone.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAvailabilityZone")]
        public string RecoveryAvailabilityZone { get; set; }

        /// <summary>
        /// Gets the encryption type of the VM. Possible values include:
        /// 'NotEncrypted', 'OnePassEncrypted', 'TwoPassEncrypted'
        /// </summary>
        [JsonProperty(PropertyName = "vmEncryptionType")]
        public string VmEncryptionType { get; private set; }

        /// <summary>
        /// Gets or sets the test failover vm name.
        /// </summary>
        [JsonProperty(PropertyName = "tfoAzureVMName")]
        public string TfoAzureVMName { get; set; }

        /// <summary>
        /// Gets the recovery azure generation.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureGeneration")]
        public string RecoveryAzureGeneration { get; private set; }

        /// <summary>
        /// Gets or sets the recovery proximity placement group Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryProximityPlacementGroupId")]
        public string RecoveryProximityPlacementGroupId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the auto protection is
        /// enabled. Possible values include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "autoProtectionOfDataDisk")]
        public string AutoProtectionOfDataDisk { get; set; }

        /// <summary>
        /// Gets or sets the recovery virtual machine scale set id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryVirtualMachineScaleSetId")]
        public string RecoveryVirtualMachineScaleSetId { get; set; }

        /// <summary>
        /// Gets or sets the recovery capacity reservation group Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryCapacityReservationGroupId")]
        public string RecoveryCapacityReservationGroupId { get; set; }

    }
}
