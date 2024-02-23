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
    /// Specification for creating a new Pool.
    /// </summary>
    public partial class PoolSpecification
    {
        /// <summary>
        /// Initializes a new instance of the PoolSpecification class.
        /// </summary>
        public PoolSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PoolSpecification class.
        /// </summary>
        /// <param name="vmSize">The size of the virtual machines in the Pool.
        /// All virtual machines in a Pool are the same size.</param>
        /// <param name="displayName">The display name for the Pool.</param>
        /// <param name="cloudServiceConfiguration">The cloud service
        /// configuration for the Pool.</param>
        /// <param name="virtualMachineConfiguration">The virtual machine
        /// configuration for the Pool.</param>
        /// <param name="taskSlotsPerNode">The number of task slots that can be
        /// used to run concurrent tasks on a single compute node in the
        /// pool.</param>
        /// <param name="taskSchedulingPolicy">How Tasks are distributed across
        /// Compute Nodes in a Pool.</param>
        /// <param name="resizeTimeout">The timeout for allocation of Compute
        /// Nodes to the Pool.</param>
        /// <param name="targetDedicatedNodes">The desired number of dedicated
        /// Compute Nodes in the Pool.</param>
        /// <param name="targetLowPriorityNodes">The desired number of
        /// Spot/Low-priority Compute Nodes in the Pool.</param>
        /// <param name="enableAutoScale">Whether the Pool size should
        /// automatically adjust over time.</param>
        /// <param name="autoScaleFormula">The formula for the desired number
        /// of Compute Nodes in the Pool.</param>
        /// <param name="autoScaleEvaluationInterval">The time interval at
        /// which to automatically adjust the Pool size according to the
        /// autoscale formula.</param>
        /// <param name="enableInterNodeCommunication">Whether the Pool permits
        /// direct communication between Compute Nodes.</param>
        /// <param name="networkConfiguration">The network configuration for
        /// the Pool.</param>
        /// <param name="startTask">A Task to run on each Compute Node as it
        /// joins the Pool. The Task runs when the Compute Node is added to the
        /// Pool or when the Compute Node is restarted.</param>
        /// <param name="certificateReferences">A list of Certificates to be
        /// installed on each Compute Node in the Pool.</param>
        /// <param name="applicationPackageReferences">The list of Packages to
        /// be installed on each Compute Node in the Pool.</param>
        /// <param name="applicationLicenses">The list of application licenses
        /// the Batch service will make available on each Compute Node in the
        /// Pool.</param>
        /// <param name="userAccounts">The list of user Accounts to be created
        /// on each Compute Node in the Pool.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the Pool as metadata.</param>
        /// <param name="mountConfiguration">A list of file systems to mount on
        /// each node in the pool.</param>
        /// <param name="targetNodeCommunicationMode">The desired node
        /// communication mode for the pool.</param>
        /// <param name="resourceTags">The user-specified tags associated with
        /// the pool.</param>
        public PoolSpecification(string vmSize, string displayName = default(string), CloudServiceConfiguration cloudServiceConfiguration = default(CloudServiceConfiguration), VirtualMachineConfiguration virtualMachineConfiguration = default(VirtualMachineConfiguration), int? taskSlotsPerNode = default(int?), TaskSchedulingPolicy taskSchedulingPolicy = default(TaskSchedulingPolicy), System.TimeSpan? resizeTimeout = default(System.TimeSpan?), int? targetDedicatedNodes = default(int?), int? targetLowPriorityNodes = default(int?), bool? enableAutoScale = default(bool?), string autoScaleFormula = default(string), System.TimeSpan? autoScaleEvaluationInterval = default(System.TimeSpan?), bool? enableInterNodeCommunication = default(bool?), NetworkConfiguration networkConfiguration = default(NetworkConfiguration), StartTask startTask = default(StartTask), IList<CertificateReference> certificateReferences = default(IList<CertificateReference>), IList<ApplicationPackageReference> applicationPackageReferences = default(IList<ApplicationPackageReference>), IList<string> applicationLicenses = default(IList<string>), IList<UserAccount> userAccounts = default(IList<UserAccount>), IList<MetadataItem> metadata = default(IList<MetadataItem>), IList<MountConfiguration> mountConfiguration = default(IList<MountConfiguration>), NodeCommunicationMode? targetNodeCommunicationMode = default(NodeCommunicationMode?), IDictionary<string, string> resourceTags = default(IDictionary<string, string>))
        {
            DisplayName = displayName;
            VmSize = vmSize;
            CloudServiceConfiguration = cloudServiceConfiguration;
            VirtualMachineConfiguration = virtualMachineConfiguration;
            TaskSlotsPerNode = taskSlotsPerNode;
            TaskSchedulingPolicy = taskSchedulingPolicy;
            ResizeTimeout = resizeTimeout;
            TargetDedicatedNodes = targetDedicatedNodes;
            TargetLowPriorityNodes = targetLowPriorityNodes;
            EnableAutoScale = enableAutoScale;
            AutoScaleFormula = autoScaleFormula;
            AutoScaleEvaluationInterval = autoScaleEvaluationInterval;
            EnableInterNodeCommunication = enableInterNodeCommunication;
            NetworkConfiguration = networkConfiguration;
            StartTask = startTask;
            CertificateReferences = certificateReferences;
            ApplicationPackageReferences = applicationPackageReferences;
            ApplicationLicenses = applicationLicenses;
            UserAccounts = userAccounts;
            Metadata = metadata;
            MountConfiguration = mountConfiguration;
            TargetNodeCommunicationMode = targetNodeCommunicationMode;
            ResourceTags = resourceTags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the display name for the Pool.
        /// </summary>
        /// <remarks>
        /// The display name need not be unique and can contain any Unicode
        /// characters up to a maximum length of 1024.
        /// </remarks>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the size of the virtual machines in the Pool. All
        /// virtual machines in a Pool are the same size.
        /// </summary>
        /// <remarks>
        /// For information about available sizes of virtual machines in Pools,
        /// see Choose a VM size for Compute Nodes in an Azure Batch Pool
        /// (https://docs.microsoft.com/azure/batch/batch-pool-vm-sizes).
        /// </remarks>
        [JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets the cloud service configuration for the Pool.
        /// </summary>
        /// <remarks>
        /// This property must be specified if the Pool needs to be created
        /// with Azure PaaS VMs. This property and virtualMachineConfiguration
        /// are mutually exclusive and one of the properties must be specified.
        /// If neither is specified then the Batch service returns an error; if
        /// you are calling the REST API directly, the HTTP status code is 400
        /// (Bad Request). This property cannot be specified if the Batch
        /// Account was created with its poolAllocationMode property set to
        /// 'UserSubscription'.
        /// </remarks>
        [JsonProperty(PropertyName = "cloudServiceConfiguration")]
        public CloudServiceConfiguration CloudServiceConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine configuration for the Pool.
        /// </summary>
        /// <remarks>
        /// This property must be specified if the Pool needs to be created
        /// with Azure IaaS VMs. This property and cloudServiceConfiguration
        /// are mutually exclusive and one of the properties must be specified.
        /// If neither is specified then the Batch service returns an error; if
        /// you are calling the REST API directly, the HTTP status code is 400
        /// (Bad Request).
        /// </remarks>
        [JsonProperty(PropertyName = "virtualMachineConfiguration")]
        public VirtualMachineConfiguration VirtualMachineConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the number of task slots that can be used to run
        /// concurrent tasks on a single compute node in the pool.
        /// </summary>
        /// <remarks>
        /// The default value is 1. The maximum value is the smaller of 4 times
        /// the number of cores of the vmSize of the pool or 256.
        /// </remarks>
        [JsonProperty(PropertyName = "taskSlotsPerNode")]
        public int? TaskSlotsPerNode { get; set; }

        /// <summary>
        /// Gets or sets how Tasks are distributed across Compute Nodes in a
        /// Pool.
        /// </summary>
        /// <remarks>
        /// If not specified, the default is spread.
        /// </remarks>
        [JsonProperty(PropertyName = "taskSchedulingPolicy")]
        public TaskSchedulingPolicy TaskSchedulingPolicy { get; set; }

        /// <summary>
        /// Gets or sets the timeout for allocation of Compute Nodes to the
        /// Pool.
        /// </summary>
        /// <remarks>
        /// This timeout applies only to manual scaling; it has no effect when
        /// enableAutoScale is set to true. The default value is 15 minutes.
        /// The minimum value is 5 minutes. If you specify a value less than 5
        /// minutes, the Batch service rejects the request with an error; if
        /// you are calling the REST API directly, the HTTP status code is 400
        /// (Bad Request).
        /// </remarks>
        [JsonProperty(PropertyName = "resizeTimeout")]
        public System.TimeSpan? ResizeTimeout { get; set; }

        /// <summary>
        /// Gets or sets the desired number of dedicated Compute Nodes in the
        /// Pool.
        /// </summary>
        /// <remarks>
        /// This property must not be specified if enableAutoScale is set to
        /// true. If enableAutoScale is set to false, then you must set either
        /// targetDedicatedNodes, targetLowPriorityNodes, or both.
        /// </remarks>
        [JsonProperty(PropertyName = "targetDedicatedNodes")]
        public int? TargetDedicatedNodes { get; set; }

        /// <summary>
        /// Gets or sets the desired number of Spot/Low-priority Compute Nodes
        /// in the Pool.
        /// </summary>
        /// <remarks>
        /// This property must not be specified if enableAutoScale is set to
        /// true. If enableAutoScale is set to false, then you must set either
        /// targetDedicatedNodes, targetLowPriorityNodes, or both.
        /// </remarks>
        [JsonProperty(PropertyName = "targetLowPriorityNodes")]
        public int? TargetLowPriorityNodes { get; set; }

        /// <summary>
        /// Gets or sets whether the Pool size should automatically adjust over
        /// time.
        /// </summary>
        /// <remarks>
        /// If false, at least one of targetDedicatedNodes and
        /// targetLowPriorityNodes must be specified. If true, the
        /// autoScaleFormula element is required. The Pool automatically
        /// resizes according to the formula. The default value is false.
        /// </remarks>
        [JsonProperty(PropertyName = "enableAutoScale")]
        public bool? EnableAutoScale { get; set; }

        /// <summary>
        /// Gets or sets the formula for the desired number of Compute Nodes in
        /// the Pool.
        /// </summary>
        /// <remarks>
        /// This property must not be specified if enableAutoScale is set to
        /// false. It is required if enableAutoScale is set to true. The
        /// formula is checked for validity before the Pool is created. If the
        /// formula is not valid, the Batch service rejects the request with
        /// detailed error information.
        /// </remarks>
        [JsonProperty(PropertyName = "autoScaleFormula")]
        public string AutoScaleFormula { get; set; }

        /// <summary>
        /// Gets or sets the time interval at which to automatically adjust the
        /// Pool size according to the autoscale formula.
        /// </summary>
        /// <remarks>
        /// The default value is 15 minutes. The minimum and maximum value are
        /// 5 minutes and 168 hours respectively. If you specify a value less
        /// than 5 minutes or greater than 168 hours, the Batch service rejects
        /// the request with an invalid property value error; if you are
        /// calling the REST API directly, the HTTP status code is 400 (Bad
        /// Request).
        /// </remarks>
        [JsonProperty(PropertyName = "autoScaleEvaluationInterval")]
        public System.TimeSpan? AutoScaleEvaluationInterval { get; set; }

        /// <summary>
        /// Gets or sets whether the Pool permits direct communication between
        /// Compute Nodes.
        /// </summary>
        /// <remarks>
        /// Enabling inter-node communication limits the maximum size of the
        /// Pool due to deployment restrictions on the Compute Nodes of the
        /// Pool. This may result in the Pool not reaching its desired size.
        /// The default value is false.
        /// </remarks>
        [JsonProperty(PropertyName = "enableInterNodeCommunication")]
        public bool? EnableInterNodeCommunication { get; set; }

        /// <summary>
        /// Gets or sets the network configuration for the Pool.
        /// </summary>
        [JsonProperty(PropertyName = "networkConfiguration")]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Gets or sets a Task to run on each Compute Node as it joins the
        /// Pool. The Task runs when the Compute Node is added to the Pool or
        /// when the Compute Node is restarted.
        /// </summary>
        [JsonProperty(PropertyName = "startTask")]
        public StartTask StartTask { get; set; }

        /// <summary>
        /// Gets or sets a list of Certificates to be installed on each Compute
        /// Node in the Pool.
        /// </summary>
        /// <remarks>
        /// For Windows Nodes, the Batch service installs the Certificates to
        /// the specified Certificate store and location. For Linux Compute
        /// Nodes, the Certificates are stored in a directory inside the Task
        /// working directory and an environment variable
        /// AZ_BATCH_CERTIFICATES_DIR is supplied to the Task to query for this
        /// location. For Certificates with visibility of 'remoteUser', a
        /// 'certs' directory is created in the user's home directory (e.g.,
        /// /home/{user-name}/certs) and Certificates are placed in that
        /// directory.
        ///
        /// Warning: This property is deprecated and will be removed after
        /// February, 2024. Please use the [Azure KeyVault
        /// Extension](https://learn.microsoft.com/azure/batch/batch-certificate-migration-guide)
        /// instead.
        /// </remarks>
        [JsonProperty(PropertyName = "certificateReferences")]
        public IList<CertificateReference> CertificateReferences { get; set; }

        /// <summary>
        /// Gets or sets the list of Packages to be installed on each Compute
        /// Node in the Pool.
        /// </summary>
        /// <remarks>
        /// When creating a pool, the package's application ID must be fully
        /// qualified
        /// (/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}).
        /// Changes to Package references affect all new Nodes joining the
        /// Pool, but do not affect Compute Nodes that are already in the Pool
        /// until they are rebooted or reimaged. There is a maximum of 10
        /// Package references on any given Pool.
        /// </remarks>
        [JsonProperty(PropertyName = "applicationPackageReferences")]
        public IList<ApplicationPackageReference> ApplicationPackageReferences { get; set; }

        /// <summary>
        /// Gets or sets the list of application licenses the Batch service
        /// will make available on each Compute Node in the Pool.
        /// </summary>
        /// <remarks>
        /// The list of application licenses must be a subset of available
        /// Batch service application licenses. If a license is requested which
        /// is not supported, Pool creation will fail. The permitted licenses
        /// available on the Pool are 'maya', 'vray', '3dsmax', 'arnold'. An
        /// additional charge applies for each application license added to the
        /// Pool.
        /// </remarks>
        [JsonProperty(PropertyName = "applicationLicenses")]
        public IList<string> ApplicationLicenses { get; set; }

        /// <summary>
        /// Gets or sets the list of user Accounts to be created on each
        /// Compute Node in the Pool.
        /// </summary>
        [JsonProperty(PropertyName = "userAccounts")]
        public IList<UserAccount> UserAccounts { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the Pool as
        /// metadata.
        /// </summary>
        /// <remarks>
        /// The Batch service does not assign any meaning to metadata; it is
        /// solely for the use of user code.
        /// </remarks>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Gets or sets a list of file systems to mount on each node in the
        /// pool.
        /// </summary>
        /// <remarks>
        /// This supports Azure Files, NFS, CIFS/SMB, and Blobfuse.
        /// </remarks>
        [JsonProperty(PropertyName = "mountConfiguration")]
        public IList<MountConfiguration> MountConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the desired node communication mode for the pool.
        /// </summary>
        /// <remarks>
        /// If omitted, the default value is Default. Possible values include:
        /// 'default', 'classic', 'simplified'
        /// </remarks>
        [JsonProperty(PropertyName = "targetNodeCommunicationMode")]
        public NodeCommunicationMode? TargetNodeCommunicationMode { get; set; }

        /// <summary>
        /// Gets or sets the user-specified tags associated with the pool.
        /// </summary>
        /// <remarks>
        /// The user-defined tags to be associated with the Azure Batch Pool.
        /// When specified, these tags are propagated to the backing Azure
        /// resources associated with the pool. This property can only be
        /// specified when the Batch account was created with the
        /// poolAllocationMode property set to 'UserSubscription'.
        /// </remarks>
        [JsonProperty(PropertyName = "resourceTags")]
        public IDictionary<string, string> ResourceTags { get; set; }

    }
}
