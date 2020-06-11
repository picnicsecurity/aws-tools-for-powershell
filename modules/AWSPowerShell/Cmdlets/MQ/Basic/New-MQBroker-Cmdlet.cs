/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.MQ;
using Amazon.MQ.Model;

namespace Amazon.PowerShell.Cmdlets.MQ
{
    /// <summary>
    /// Creates a broker. Note: This API is asynchronous.
    /// </summary>
    [Cmdlet("New", "MQBroker", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.MQ.Model.CreateBrokerResponse")]
    [AWSCmdlet("Calls the Amazon MQ CreateBroker API operation.", Operation = new[] {"CreateBroker"}, SelectReturnType = typeof(Amazon.MQ.Model.CreateBrokerResponse))]
    [AWSCmdletOutput("Amazon.MQ.Model.CreateBrokerResponse",
        "This cmdlet returns an Amazon.MQ.Model.CreateBrokerResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewMQBrokerCmdlet : AmazonMQClientCmdlet, IExecutor
    {
        
        #region Parameter Logs_Audit
        /// <summary>
        /// <para>
        /// Enables audit logging. Every user management action
        /// made using JMX or the ActiveMQ Web Console is logged.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? Logs_Audit { get; set; }
        #endregion
        
        #region Parameter AuthenticationStrategy
        /// <summary>
        /// <para>
        /// The authentication strategy used
        /// to secure the broker.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.MQ.AuthenticationStrategy")]
        public Amazon.MQ.AuthenticationStrategy AuthenticationStrategy { get; set; }
        #endregion
        
        #region Parameter AutoMinorVersionUpgrade
        /// <summary>
        /// <para>
        /// Required. Enables automatic upgrades
        /// to new minor versions for brokers, as Apache releases the versions. The automatic
        /// upgrades occur during the maintenance window of the broker or after a manual broker
        /// reboot.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? AutoMinorVersionUpgrade { get; set; }
        #endregion
        
        #region Parameter BrokerName
        /// <summary>
        /// <para>
        /// Required. The name of the broker. This value
        /// must be unique in your AWS account, 1-50 characters long, must contain only letters,
        /// numbers, dashes, and underscores, and must not contain whitespaces, brackets, wildcard
        /// characters, or special characters.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        public System.String BrokerName { get; set; }
        #endregion
        
        #region Parameter Configuration
        /// <summary>
        /// <para>
        /// A list of information about the configuration.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.MQ.Model.ConfigurationId Configuration { get; set; }
        #endregion
        
        #region Parameter CreatorRequestId
        /// <summary>
        /// <para>
        /// The unique ID that the requester receives
        /// for the created broker. Amazon MQ passes your ID with the API action. Note: We recommend
        /// using a Universally Unique Identifier (UUID) for the creatorRequestId. You may omit
        /// the creatorRequestId if your application doesn't require idempotency.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String CreatorRequestId { get; set; }
        #endregion
        
        #region Parameter DeploymentMode
        /// <summary>
        /// <para>
        /// Required. The deployment mode of the broker.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.MQ.DeploymentMode")]
        public Amazon.MQ.DeploymentMode DeploymentMode { get; set; }
        #endregion
        
        #region Parameter EngineType
        /// <summary>
        /// <para>
        /// Required. The type of broker engine. Note:
        /// Currently, Amazon MQ supports only ACTIVEMQ.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.MQ.EngineType")]
        public Amazon.MQ.EngineType EngineType { get; set; }
        #endregion
        
        #region Parameter EngineVersion
        /// <summary>
        /// <para>
        /// Required. The version of the broker engine.
        /// For a list of supported engine versions, see https://docs.aws.amazon.com/amazon-mq/latest/developer-guide/broker-engine.html
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String EngineVersion { get; set; }
        #endregion
        
        #region Parameter Logs_General
        /// <summary>
        /// <para>
        /// Enables general logging.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? Logs_General { get; set; }
        #endregion
        
        #region Parameter HostInstanceType
        /// <summary>
        /// <para>
        /// Required. The broker's instance type.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String HostInstanceType { get; set; }
        #endregion
        
        #region Parameter LdapServerMetadata_Host
        /// <summary>
        /// <para>
        /// Fully qualified domain name of the LDAP server.
        /// Optional failover server.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("LdapServerMetadata_Hosts")]
        public System.String[] LdapServerMetadata_Host { get; set; }
        #endregion
        
        #region Parameter EncryptionOptions_KmsKeyId
        /// <summary>
        /// <para>
        /// The symmetric customer master key (CMK) to use
        /// for the AWS Key Management Service (KMS). This key is used to encrypt your data at
        /// rest. If not provided, Amazon MQ will use a default CMK to encrypt your data.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String EncryptionOptions_KmsKeyId { get; set; }
        #endregion
        
        #region Parameter MaintenanceWindowStartTime
        /// <summary>
        /// <para>
        /// The parameters that determine
        /// the WeeklyStartTime.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public Amazon.MQ.Model.WeeklyStartTime MaintenanceWindowStartTime { get; set; }
        #endregion
        
        #region Parameter PubliclyAccessible
        /// <summary>
        /// <para>
        /// Required. Enables connections from
        /// applications outside of the VPC that hosts the broker's subnets.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? PubliclyAccessible { get; set; }
        #endregion
        
        #region Parameter LdapServerMetadata_RoleBase
        /// <summary>
        /// <para>
        /// Fully qualified name of the directory to search
        /// for a user’s groups.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String LdapServerMetadata_RoleBase { get; set; }
        #endregion
        
        #region Parameter LdapServerMetadata_RoleName
        /// <summary>
        /// <para>
        /// Specifies the LDAP attribute that identifies
        /// the group name attribute in the object returned from the group membership query.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String LdapServerMetadata_RoleName { get; set; }
        #endregion
        
        #region Parameter LdapServerMetadata_RoleSearchMatching
        /// <summary>
        /// <para>
        /// The search criteria for groups.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String LdapServerMetadata_RoleSearchMatching { get; set; }
        #endregion
        
        #region Parameter LdapServerMetadata_RoleSearchSubtree
        /// <summary>
        /// <para>
        /// The directory search scope for the role.
        /// If set to true, scope is to search the entire sub-tree.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? LdapServerMetadata_RoleSearchSubtree { get; set; }
        #endregion
        
        #region Parameter SecurityGroup
        /// <summary>
        /// <para>
        /// The list of security groups (1 minimum,
        /// 5 maximum) that authorizes connections to brokers.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SecurityGroups")]
        public System.String[] SecurityGroup { get; set; }
        #endregion
        
        #region Parameter LdapServerMetadata_ServiceAccountPassword
        /// <summary>
        /// <para>
        /// Service account password.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String LdapServerMetadata_ServiceAccountPassword { get; set; }
        #endregion
        
        #region Parameter LdapServerMetadata_ServiceAccountUsername
        /// <summary>
        /// <para>
        /// Service account username.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String LdapServerMetadata_ServiceAccountUsername { get; set; }
        #endregion
        
        #region Parameter StorageType
        /// <summary>
        /// <para>
        /// The broker's storage type.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.MQ.BrokerStorageType")]
        public Amazon.MQ.BrokerStorageType StorageType { get; set; }
        #endregion
        
        #region Parameter SubnetId
        /// <summary>
        /// <para>
        /// The list of groups (2 maximum) that define which
        /// subnets and IP ranges the broker can use from different Availability Zones. A SINGLE_INSTANCE
        /// deployment requires one subnet (for example, the default subnet). An ACTIVE_STANDBY_MULTI_AZ
        /// deployment requires two subnets.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("SubnetIds")]
        public System.String[] SubnetId { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// Create tags when creating the broker.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public System.Collections.Hashtable Tag { get; set; }
        #endregion
        
        #region Parameter EncryptionOptions_UseAwsOwnedKey
        /// <summary>
        /// <para>
        /// Enables the use of an AWS owned CMK using
        /// AWS Key Management Service (KMS).
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? EncryptionOptions_UseAwsOwnedKey { get; set; }
        #endregion
        
        #region Parameter LdapServerMetadata_UserBase
        /// <summary>
        /// <para>
        /// Fully qualified name of the directory where you
        /// want to search for users.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String LdapServerMetadata_UserBase { get; set; }
        #endregion
        
        #region Parameter LdapServerMetadata_UserRoleName
        /// <summary>
        /// <para>
        /// Specifies the name of the LDAP attribute
        /// for the user group membership.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String LdapServerMetadata_UserRoleName { get; set; }
        #endregion
        
        #region Parameter User
        /// <summary>
        /// <para>
        /// Required. The list of ActiveMQ users (persons or
        /// applications) who can access queues and topics. This value can contain only alphanumeric
        /// characters, dashes, periods, underscores, and tildes (- . _ ~). This value must be
        /// 2-100 characters long.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Users")]
        public Amazon.MQ.Model.User[] User { get; set; }
        #endregion
        
        #region Parameter LdapServerMetadata_UserSearchMatching
        /// <summary>
        /// <para>
        /// The search criteria for users.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String LdapServerMetadata_UserSearchMatching { get; set; }
        #endregion
        
        #region Parameter LdapServerMetadata_UserSearchSubtree
        /// <summary>
        /// <para>
        /// The directory search scope for the user.
        /// If set to true, scope is to search the entire sub-tree.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? LdapServerMetadata_UserSearchSubtree { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.MQ.Model.CreateBrokerResponse).
        /// Specifying the name of a property of type Amazon.MQ.Model.CreateBrokerResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the BrokerName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^BrokerName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^BrokerName' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.BrokerName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-MQBroker (CreateBroker)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.MQ.Model.CreateBrokerResponse, NewMQBrokerCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.BrokerName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AuthenticationStrategy = this.AuthenticationStrategy;
            context.AutoMinorVersionUpgrade = this.AutoMinorVersionUpgrade;
            context.BrokerName = this.BrokerName;
            context.Configuration = this.Configuration;
            context.CreatorRequestId = this.CreatorRequestId;
            context.DeploymentMode = this.DeploymentMode;
            context.EncryptionOptions_KmsKeyId = this.EncryptionOptions_KmsKeyId;
            context.EncryptionOptions_UseAwsOwnedKey = this.EncryptionOptions_UseAwsOwnedKey;
            context.EngineType = this.EngineType;
            context.EngineVersion = this.EngineVersion;
            context.HostInstanceType = this.HostInstanceType;
            if (this.LdapServerMetadata_Host != null)
            {
                context.LdapServerMetadata_Host = new List<System.String>(this.LdapServerMetadata_Host);
            }
            context.LdapServerMetadata_RoleBase = this.LdapServerMetadata_RoleBase;
            context.LdapServerMetadata_RoleName = this.LdapServerMetadata_RoleName;
            context.LdapServerMetadata_RoleSearchMatching = this.LdapServerMetadata_RoleSearchMatching;
            context.LdapServerMetadata_RoleSearchSubtree = this.LdapServerMetadata_RoleSearchSubtree;
            context.LdapServerMetadata_ServiceAccountPassword = this.LdapServerMetadata_ServiceAccountPassword;
            context.LdapServerMetadata_ServiceAccountUsername = this.LdapServerMetadata_ServiceAccountUsername;
            context.LdapServerMetadata_UserBase = this.LdapServerMetadata_UserBase;
            context.LdapServerMetadata_UserRoleName = this.LdapServerMetadata_UserRoleName;
            context.LdapServerMetadata_UserSearchMatching = this.LdapServerMetadata_UserSearchMatching;
            context.LdapServerMetadata_UserSearchSubtree = this.LdapServerMetadata_UserSearchSubtree;
            context.Logs_Audit = this.Logs_Audit;
            context.Logs_General = this.Logs_General;
            context.MaintenanceWindowStartTime = this.MaintenanceWindowStartTime;
            context.PubliclyAccessible = this.PubliclyAccessible;
            if (this.SecurityGroup != null)
            {
                context.SecurityGroup = new List<System.String>(this.SecurityGroup);
            }
            context.StorageType = this.StorageType;
            if (this.SubnetId != null)
            {
                context.SubnetId = new List<System.String>(this.SubnetId);
            }
            if (this.Tag != null)
            {
                context.Tag = new Dictionary<System.String, System.String>(StringComparer.Ordinal);
                foreach (var hashKey in this.Tag.Keys)
                {
                    context.Tag.Add((String)hashKey, (String)(this.Tag[hashKey]));
                }
            }
            if (this.User != null)
            {
                context.User = new List<Amazon.MQ.Model.User>(this.User);
            }
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.MQ.Model.CreateBrokerRequest();
            
            if (cmdletContext.AuthenticationStrategy != null)
            {
                request.AuthenticationStrategy = cmdletContext.AuthenticationStrategy;
            }
            if (cmdletContext.AutoMinorVersionUpgrade != null)
            {
                request.AutoMinorVersionUpgrade = cmdletContext.AutoMinorVersionUpgrade.Value;
            }
            if (cmdletContext.BrokerName != null)
            {
                request.BrokerName = cmdletContext.BrokerName;
            }
            if (cmdletContext.Configuration != null)
            {
                request.Configuration = cmdletContext.Configuration;
            }
            if (cmdletContext.CreatorRequestId != null)
            {
                request.CreatorRequestId = cmdletContext.CreatorRequestId;
            }
            if (cmdletContext.DeploymentMode != null)
            {
                request.DeploymentMode = cmdletContext.DeploymentMode;
            }
            
             // populate EncryptionOptions
            var requestEncryptionOptionsIsNull = true;
            request.EncryptionOptions = new Amazon.MQ.Model.EncryptionOptions();
            System.String requestEncryptionOptions_encryptionOptions_KmsKeyId = null;
            if (cmdletContext.EncryptionOptions_KmsKeyId != null)
            {
                requestEncryptionOptions_encryptionOptions_KmsKeyId = cmdletContext.EncryptionOptions_KmsKeyId;
            }
            if (requestEncryptionOptions_encryptionOptions_KmsKeyId != null)
            {
                request.EncryptionOptions.KmsKeyId = requestEncryptionOptions_encryptionOptions_KmsKeyId;
                requestEncryptionOptionsIsNull = false;
            }
            System.Boolean? requestEncryptionOptions_encryptionOptions_UseAwsOwnedKey = null;
            if (cmdletContext.EncryptionOptions_UseAwsOwnedKey != null)
            {
                requestEncryptionOptions_encryptionOptions_UseAwsOwnedKey = cmdletContext.EncryptionOptions_UseAwsOwnedKey.Value;
            }
            if (requestEncryptionOptions_encryptionOptions_UseAwsOwnedKey != null)
            {
                request.EncryptionOptions.UseAwsOwnedKey = requestEncryptionOptions_encryptionOptions_UseAwsOwnedKey.Value;
                requestEncryptionOptionsIsNull = false;
            }
             // determine if request.EncryptionOptions should be set to null
            if (requestEncryptionOptionsIsNull)
            {
                request.EncryptionOptions = null;
            }
            if (cmdletContext.EngineType != null)
            {
                request.EngineType = cmdletContext.EngineType;
            }
            if (cmdletContext.EngineVersion != null)
            {
                request.EngineVersion = cmdletContext.EngineVersion;
            }
            if (cmdletContext.HostInstanceType != null)
            {
                request.HostInstanceType = cmdletContext.HostInstanceType;
            }
            
             // populate LdapServerMetadata
            var requestLdapServerMetadataIsNull = true;
            request.LdapServerMetadata = new Amazon.MQ.Model.LdapServerMetadataInput();
            List<System.String> requestLdapServerMetadata_ldapServerMetadata_Host = null;
            if (cmdletContext.LdapServerMetadata_Host != null)
            {
                requestLdapServerMetadata_ldapServerMetadata_Host = cmdletContext.LdapServerMetadata_Host;
            }
            if (requestLdapServerMetadata_ldapServerMetadata_Host != null)
            {
                request.LdapServerMetadata.Hosts = requestLdapServerMetadata_ldapServerMetadata_Host;
                requestLdapServerMetadataIsNull = false;
            }
            System.String requestLdapServerMetadata_ldapServerMetadata_RoleBase = null;
            if (cmdletContext.LdapServerMetadata_RoleBase != null)
            {
                requestLdapServerMetadata_ldapServerMetadata_RoleBase = cmdletContext.LdapServerMetadata_RoleBase;
            }
            if (requestLdapServerMetadata_ldapServerMetadata_RoleBase != null)
            {
                request.LdapServerMetadata.RoleBase = requestLdapServerMetadata_ldapServerMetadata_RoleBase;
                requestLdapServerMetadataIsNull = false;
            }
            System.String requestLdapServerMetadata_ldapServerMetadata_RoleName = null;
            if (cmdletContext.LdapServerMetadata_RoleName != null)
            {
                requestLdapServerMetadata_ldapServerMetadata_RoleName = cmdletContext.LdapServerMetadata_RoleName;
            }
            if (requestLdapServerMetadata_ldapServerMetadata_RoleName != null)
            {
                request.LdapServerMetadata.RoleName = requestLdapServerMetadata_ldapServerMetadata_RoleName;
                requestLdapServerMetadataIsNull = false;
            }
            System.String requestLdapServerMetadata_ldapServerMetadata_RoleSearchMatching = null;
            if (cmdletContext.LdapServerMetadata_RoleSearchMatching != null)
            {
                requestLdapServerMetadata_ldapServerMetadata_RoleSearchMatching = cmdletContext.LdapServerMetadata_RoleSearchMatching;
            }
            if (requestLdapServerMetadata_ldapServerMetadata_RoleSearchMatching != null)
            {
                request.LdapServerMetadata.RoleSearchMatching = requestLdapServerMetadata_ldapServerMetadata_RoleSearchMatching;
                requestLdapServerMetadataIsNull = false;
            }
            System.Boolean? requestLdapServerMetadata_ldapServerMetadata_RoleSearchSubtree = null;
            if (cmdletContext.LdapServerMetadata_RoleSearchSubtree != null)
            {
                requestLdapServerMetadata_ldapServerMetadata_RoleSearchSubtree = cmdletContext.LdapServerMetadata_RoleSearchSubtree.Value;
            }
            if (requestLdapServerMetadata_ldapServerMetadata_RoleSearchSubtree != null)
            {
                request.LdapServerMetadata.RoleSearchSubtree = requestLdapServerMetadata_ldapServerMetadata_RoleSearchSubtree.Value;
                requestLdapServerMetadataIsNull = false;
            }
            System.String requestLdapServerMetadata_ldapServerMetadata_ServiceAccountPassword = null;
            if (cmdletContext.LdapServerMetadata_ServiceAccountPassword != null)
            {
                requestLdapServerMetadata_ldapServerMetadata_ServiceAccountPassword = cmdletContext.LdapServerMetadata_ServiceAccountPassword;
            }
            if (requestLdapServerMetadata_ldapServerMetadata_ServiceAccountPassword != null)
            {
                request.LdapServerMetadata.ServiceAccountPassword = requestLdapServerMetadata_ldapServerMetadata_ServiceAccountPassword;
                requestLdapServerMetadataIsNull = false;
            }
            System.String requestLdapServerMetadata_ldapServerMetadata_ServiceAccountUsername = null;
            if (cmdletContext.LdapServerMetadata_ServiceAccountUsername != null)
            {
                requestLdapServerMetadata_ldapServerMetadata_ServiceAccountUsername = cmdletContext.LdapServerMetadata_ServiceAccountUsername;
            }
            if (requestLdapServerMetadata_ldapServerMetadata_ServiceAccountUsername != null)
            {
                request.LdapServerMetadata.ServiceAccountUsername = requestLdapServerMetadata_ldapServerMetadata_ServiceAccountUsername;
                requestLdapServerMetadataIsNull = false;
            }
            System.String requestLdapServerMetadata_ldapServerMetadata_UserBase = null;
            if (cmdletContext.LdapServerMetadata_UserBase != null)
            {
                requestLdapServerMetadata_ldapServerMetadata_UserBase = cmdletContext.LdapServerMetadata_UserBase;
            }
            if (requestLdapServerMetadata_ldapServerMetadata_UserBase != null)
            {
                request.LdapServerMetadata.UserBase = requestLdapServerMetadata_ldapServerMetadata_UserBase;
                requestLdapServerMetadataIsNull = false;
            }
            System.String requestLdapServerMetadata_ldapServerMetadata_UserRoleName = null;
            if (cmdletContext.LdapServerMetadata_UserRoleName != null)
            {
                requestLdapServerMetadata_ldapServerMetadata_UserRoleName = cmdletContext.LdapServerMetadata_UserRoleName;
            }
            if (requestLdapServerMetadata_ldapServerMetadata_UserRoleName != null)
            {
                request.LdapServerMetadata.UserRoleName = requestLdapServerMetadata_ldapServerMetadata_UserRoleName;
                requestLdapServerMetadataIsNull = false;
            }
            System.String requestLdapServerMetadata_ldapServerMetadata_UserSearchMatching = null;
            if (cmdletContext.LdapServerMetadata_UserSearchMatching != null)
            {
                requestLdapServerMetadata_ldapServerMetadata_UserSearchMatching = cmdletContext.LdapServerMetadata_UserSearchMatching;
            }
            if (requestLdapServerMetadata_ldapServerMetadata_UserSearchMatching != null)
            {
                request.LdapServerMetadata.UserSearchMatching = requestLdapServerMetadata_ldapServerMetadata_UserSearchMatching;
                requestLdapServerMetadataIsNull = false;
            }
            System.Boolean? requestLdapServerMetadata_ldapServerMetadata_UserSearchSubtree = null;
            if (cmdletContext.LdapServerMetadata_UserSearchSubtree != null)
            {
                requestLdapServerMetadata_ldapServerMetadata_UserSearchSubtree = cmdletContext.LdapServerMetadata_UserSearchSubtree.Value;
            }
            if (requestLdapServerMetadata_ldapServerMetadata_UserSearchSubtree != null)
            {
                request.LdapServerMetadata.UserSearchSubtree = requestLdapServerMetadata_ldapServerMetadata_UserSearchSubtree.Value;
                requestLdapServerMetadataIsNull = false;
            }
             // determine if request.LdapServerMetadata should be set to null
            if (requestLdapServerMetadataIsNull)
            {
                request.LdapServerMetadata = null;
            }
            
             // populate Logs
            var requestLogsIsNull = true;
            request.Logs = new Amazon.MQ.Model.Logs();
            System.Boolean? requestLogs_logs_Audit = null;
            if (cmdletContext.Logs_Audit != null)
            {
                requestLogs_logs_Audit = cmdletContext.Logs_Audit.Value;
            }
            if (requestLogs_logs_Audit != null)
            {
                request.Logs.Audit = requestLogs_logs_Audit.Value;
                requestLogsIsNull = false;
            }
            System.Boolean? requestLogs_logs_General = null;
            if (cmdletContext.Logs_General != null)
            {
                requestLogs_logs_General = cmdletContext.Logs_General.Value;
            }
            if (requestLogs_logs_General != null)
            {
                request.Logs.General = requestLogs_logs_General.Value;
                requestLogsIsNull = false;
            }
             // determine if request.Logs should be set to null
            if (requestLogsIsNull)
            {
                request.Logs = null;
            }
            if (cmdletContext.MaintenanceWindowStartTime != null)
            {
                request.MaintenanceWindowStartTime = cmdletContext.MaintenanceWindowStartTime;
            }
            if (cmdletContext.PubliclyAccessible != null)
            {
                request.PubliclyAccessible = cmdletContext.PubliclyAccessible.Value;
            }
            if (cmdletContext.SecurityGroup != null)
            {
                request.SecurityGroups = cmdletContext.SecurityGroup;
            }
            if (cmdletContext.StorageType != null)
            {
                request.StorageType = cmdletContext.StorageType;
            }
            if (cmdletContext.SubnetId != null)
            {
                request.SubnetIds = cmdletContext.SubnetId;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.User != null)
            {
                request.Users = cmdletContext.User;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.MQ.Model.CreateBrokerResponse CallAWSServiceOperation(IAmazonMQ client, Amazon.MQ.Model.CreateBrokerRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon MQ", "CreateBroker");
            try
            {
                #if DESKTOP
                return client.CreateBroker(request);
                #elif CORECLR
                return client.CreateBrokerAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public Amazon.MQ.AuthenticationStrategy AuthenticationStrategy { get; set; }
            public System.Boolean? AutoMinorVersionUpgrade { get; set; }
            public System.String BrokerName { get; set; }
            public Amazon.MQ.Model.ConfigurationId Configuration { get; set; }
            public System.String CreatorRequestId { get; set; }
            public Amazon.MQ.DeploymentMode DeploymentMode { get; set; }
            public System.String EncryptionOptions_KmsKeyId { get; set; }
            public System.Boolean? EncryptionOptions_UseAwsOwnedKey { get; set; }
            public Amazon.MQ.EngineType EngineType { get; set; }
            public System.String EngineVersion { get; set; }
            public System.String HostInstanceType { get; set; }
            public List<System.String> LdapServerMetadata_Host { get; set; }
            public System.String LdapServerMetadata_RoleBase { get; set; }
            public System.String LdapServerMetadata_RoleName { get; set; }
            public System.String LdapServerMetadata_RoleSearchMatching { get; set; }
            public System.Boolean? LdapServerMetadata_RoleSearchSubtree { get; set; }
            public System.String LdapServerMetadata_ServiceAccountPassword { get; set; }
            public System.String LdapServerMetadata_ServiceAccountUsername { get; set; }
            public System.String LdapServerMetadata_UserBase { get; set; }
            public System.String LdapServerMetadata_UserRoleName { get; set; }
            public System.String LdapServerMetadata_UserSearchMatching { get; set; }
            public System.Boolean? LdapServerMetadata_UserSearchSubtree { get; set; }
            public System.Boolean? Logs_Audit { get; set; }
            public System.Boolean? Logs_General { get; set; }
            public Amazon.MQ.Model.WeeklyStartTime MaintenanceWindowStartTime { get; set; }
            public System.Boolean? PubliclyAccessible { get; set; }
            public List<System.String> SecurityGroup { get; set; }
            public Amazon.MQ.BrokerStorageType StorageType { get; set; }
            public List<System.String> SubnetId { get; set; }
            public Dictionary<System.String, System.String> Tag { get; set; }
            public List<Amazon.MQ.Model.User> User { get; set; }
            public System.Func<Amazon.MQ.Model.CreateBrokerResponse, NewMQBrokerCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
