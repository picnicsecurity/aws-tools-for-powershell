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
using Amazon.CodeGuruReviewer;
using Amazon.CodeGuruReviewer.Model;

namespace Amazon.PowerShell.Cmdlets.CGR
{
    /// <summary>
    /// Use to associate an AWS CodeCommit repository or a repostory managed by AWS CodeStar
    /// Connections with Amazon CodeGuru Reviewer. When you associate a repository, CodeGuru
    /// Reviewer reviews source code changes in the repository's pull requests and provides
    /// automatic recommendations. You can view recommendations using the CodeGuru Reviewer
    /// console. For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/recommendations.html">Recommendations
    /// in Amazon CodeGuru Reviewer</a> in the <i>Amazon CodeGuru Reviewer User Guide.</i><para>
    /// If you associate a CodeCommit repository, it must be in the same AWS Region and AWS
    /// account where its CodeGuru Reviewer code reviews are configured.
    /// </para><para>
    ///  Bitbucket and GitHub Enterprise Server repositories are managed by AWS CodeStar Connections
    /// to connect to CodeGuru Reviewer. For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/reviewer-ug/step-one.html#select-repository-source-provider">Connect
    /// to a repository source provider</a> in the <i>Amazon CodeGuru Reviewer User Guide.</i></para><note><para>
    ///  You cannot use the CodeGuru Reviewer SDK or the AWS CLI to associate a GitHub repository
    /// with Amazon CodeGuru Reviewer. To associate a GitHub repository, use the console.
    /// For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/getting-started-with-guru.html">Getting
    /// started with CodeGuru Reviewer</a> in the <i>CodeGuru Reviewer User Guide.</i></para></note>
    /// </summary>
    [Cmdlet("Register", "CGRRepository", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.CodeGuruReviewer.Model.RepositoryAssociation")]
    [AWSCmdlet("Calls the Amazon CodeGuru Reviewer AssociateRepository API operation.", Operation = new[] {"AssociateRepository"}, SelectReturnType = typeof(Amazon.CodeGuruReviewer.Model.AssociateRepositoryResponse))]
    [AWSCmdletOutput("Amazon.CodeGuruReviewer.Model.RepositoryAssociation or Amazon.CodeGuruReviewer.Model.AssociateRepositoryResponse",
        "This cmdlet returns an Amazon.CodeGuruReviewer.Model.RepositoryAssociation object.",
        "The service call response (type Amazon.CodeGuruReviewer.Model.AssociateRepositoryResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class RegisterCGRRepositoryCmdlet : AmazonCodeGuruReviewerClientCmdlet, IExecutor
    {
        
        #region Parameter ClientRequestToken
        /// <summary>
        /// <para>
        /// <para>Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.</para><para>To add a new repository association, this parameter specifies a unique identifier
        /// for the new repository association that helps ensure idempotency.</para><para>If you use the AWS CLI or one of the AWS SDKs to call this operation, you can leave
        /// this parameter empty. The CLI or SDK generates a random UUID for you and includes
        /// that in the request. If you don't use the SDK and instead generate a raw HTTP request
        /// to the Secrets Manager service endpoint, you must generate a ClientRequestToken yourself
        /// for new versions and include that value in the request.</para><para>You typically interact with this value if you implement your own retry logic and want
        /// to ensure that a given repository association is not created twice. We recommend that
        /// you generate a UUID-type value to ensure uniqueness within the specified repository
        /// association.</para><para>Amazon CodeGuru Reviewer uses this value to prevent the accidental creation of duplicate
        /// repository associations if there are failures and retries. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String ClientRequestToken { get; set; }
        #endregion
        
        #region Parameter Bitbucket_ConnectionArn
        /// <summary>
        /// <para>
        /// <para> The Amazon Resource Name (ARN) of an AWS CodeStar Connections connection. Its format
        /// is <code>arn:aws:codestar-connections:region-id:aws-account_id:connection/connection-id</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/codestar-connections/latest/APIReference/API_Connection.html">Connection</a>
        /// in the <i>AWS CodeStar Connections API Reference</i>. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Repository_Bitbucket_ConnectionArn")]
        public System.String Bitbucket_ConnectionArn { get; set; }
        #endregion
        
        #region Parameter GitHubEnterpriseServer_ConnectionArn
        /// <summary>
        /// <para>
        /// <para> The Amazon Resource Name (ARN) of an AWS CodeStar Connections connection. Its format
        /// is <code>arn:aws:codestar-connections:region-id:aws-account_id:connection/connection-id</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/codestar-connections/latest/APIReference/API_Connection.html">Connection</a>
        /// in the <i>AWS CodeStar Connections API Reference</i>. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Repository_GitHubEnterpriseServer_ConnectionArn")]
        public System.String GitHubEnterpriseServer_ConnectionArn { get; set; }
        #endregion
        
        #region Parameter Bitbucket_Name
        /// <summary>
        /// <para>
        /// <para> The name of the third party source repository. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Repository_Bitbucket_Name")]
        public System.String Bitbucket_Name { get; set; }
        #endregion
        
        #region Parameter CodeCommit_Name
        /// <summary>
        /// <para>
        /// <para>The name of the AWS CodeCommit repository. For more information, see <a href="https://docs.aws.amazon.com/codecommit/latest/APIReference/API_GetRepository.html#CodeCommit-GetRepository-request-repositoryName">repositoryName</a>
        /// in the <i>AWS CodeCommit API Reference</i>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        [Alias("Repository_CodeCommit_Name")]
        public System.String CodeCommit_Name { get; set; }
        #endregion
        
        #region Parameter GitHubEnterpriseServer_Name
        /// <summary>
        /// <para>
        /// <para> The name of the third party source repository. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Repository_GitHubEnterpriseServer_Name")]
        public System.String GitHubEnterpriseServer_Name { get; set; }
        #endregion
        
        #region Parameter Bitbucket_Owner
        /// <summary>
        /// <para>
        /// <para> The owner of the repository. For a GitHub, GitHub Enterprise, or Bitbucket repository,
        /// this is the username for the account that owns the repository. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Repository_Bitbucket_Owner")]
        public System.String Bitbucket_Owner { get; set; }
        #endregion
        
        #region Parameter GitHubEnterpriseServer_Owner
        /// <summary>
        /// <para>
        /// <para> The owner of the repository. For a GitHub, GitHub Enterprise, or Bitbucket repository,
        /// this is the username for the account that owns the repository. </para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Repository_GitHubEnterpriseServer_Owner")]
        public System.String GitHubEnterpriseServer_Owner { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'RepositoryAssociation'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.CodeGuruReviewer.Model.AssociateRepositoryResponse).
        /// Specifying the name of a property of type Amazon.CodeGuruReviewer.Model.AssociateRepositoryResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "RepositoryAssociation";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the CodeCommit_Name parameter.
        /// The -PassThru parameter is deprecated, use -Select '^CodeCommit_Name' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^CodeCommit_Name' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.CodeCommit_Name), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Register-CGRRepository (AssociateRepository)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.CodeGuruReviewer.Model.AssociateRepositoryResponse, RegisterCGRRepositoryCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.CodeCommit_Name;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.ClientRequestToken = this.ClientRequestToken;
            context.Bitbucket_ConnectionArn = this.Bitbucket_ConnectionArn;
            context.Bitbucket_Name = this.Bitbucket_Name;
            context.Bitbucket_Owner = this.Bitbucket_Owner;
            context.CodeCommit_Name = this.CodeCommit_Name;
            context.GitHubEnterpriseServer_ConnectionArn = this.GitHubEnterpriseServer_ConnectionArn;
            context.GitHubEnterpriseServer_Name = this.GitHubEnterpriseServer_Name;
            context.GitHubEnterpriseServer_Owner = this.GitHubEnterpriseServer_Owner;
            
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
            var request = new Amazon.CodeGuruReviewer.Model.AssociateRepositoryRequest();
            
            if (cmdletContext.ClientRequestToken != null)
            {
                request.ClientRequestToken = cmdletContext.ClientRequestToken;
            }
            
             // populate Repository
            var requestRepositoryIsNull = true;
            request.Repository = new Amazon.CodeGuruReviewer.Model.Repository();
            Amazon.CodeGuruReviewer.Model.CodeCommitRepository requestRepository_repository_CodeCommit = null;
            
             // populate CodeCommit
            var requestRepository_repository_CodeCommitIsNull = true;
            requestRepository_repository_CodeCommit = new Amazon.CodeGuruReviewer.Model.CodeCommitRepository();
            System.String requestRepository_repository_CodeCommit_codeCommit_Name = null;
            if (cmdletContext.CodeCommit_Name != null)
            {
                requestRepository_repository_CodeCommit_codeCommit_Name = cmdletContext.CodeCommit_Name;
            }
            if (requestRepository_repository_CodeCommit_codeCommit_Name != null)
            {
                requestRepository_repository_CodeCommit.Name = requestRepository_repository_CodeCommit_codeCommit_Name;
                requestRepository_repository_CodeCommitIsNull = false;
            }
             // determine if requestRepository_repository_CodeCommit should be set to null
            if (requestRepository_repository_CodeCommitIsNull)
            {
                requestRepository_repository_CodeCommit = null;
            }
            if (requestRepository_repository_CodeCommit != null)
            {
                request.Repository.CodeCommit = requestRepository_repository_CodeCommit;
                requestRepositoryIsNull = false;
            }
            Amazon.CodeGuruReviewer.Model.ThirdPartySourceRepository requestRepository_repository_Bitbucket = null;
            
             // populate Bitbucket
            var requestRepository_repository_BitbucketIsNull = true;
            requestRepository_repository_Bitbucket = new Amazon.CodeGuruReviewer.Model.ThirdPartySourceRepository();
            System.String requestRepository_repository_Bitbucket_bitbucket_ConnectionArn = null;
            if (cmdletContext.Bitbucket_ConnectionArn != null)
            {
                requestRepository_repository_Bitbucket_bitbucket_ConnectionArn = cmdletContext.Bitbucket_ConnectionArn;
            }
            if (requestRepository_repository_Bitbucket_bitbucket_ConnectionArn != null)
            {
                requestRepository_repository_Bitbucket.ConnectionArn = requestRepository_repository_Bitbucket_bitbucket_ConnectionArn;
                requestRepository_repository_BitbucketIsNull = false;
            }
            System.String requestRepository_repository_Bitbucket_bitbucket_Name = null;
            if (cmdletContext.Bitbucket_Name != null)
            {
                requestRepository_repository_Bitbucket_bitbucket_Name = cmdletContext.Bitbucket_Name;
            }
            if (requestRepository_repository_Bitbucket_bitbucket_Name != null)
            {
                requestRepository_repository_Bitbucket.Name = requestRepository_repository_Bitbucket_bitbucket_Name;
                requestRepository_repository_BitbucketIsNull = false;
            }
            System.String requestRepository_repository_Bitbucket_bitbucket_Owner = null;
            if (cmdletContext.Bitbucket_Owner != null)
            {
                requestRepository_repository_Bitbucket_bitbucket_Owner = cmdletContext.Bitbucket_Owner;
            }
            if (requestRepository_repository_Bitbucket_bitbucket_Owner != null)
            {
                requestRepository_repository_Bitbucket.Owner = requestRepository_repository_Bitbucket_bitbucket_Owner;
                requestRepository_repository_BitbucketIsNull = false;
            }
             // determine if requestRepository_repository_Bitbucket should be set to null
            if (requestRepository_repository_BitbucketIsNull)
            {
                requestRepository_repository_Bitbucket = null;
            }
            if (requestRepository_repository_Bitbucket != null)
            {
                request.Repository.Bitbucket = requestRepository_repository_Bitbucket;
                requestRepositoryIsNull = false;
            }
            Amazon.CodeGuruReviewer.Model.ThirdPartySourceRepository requestRepository_repository_GitHubEnterpriseServer = null;
            
             // populate GitHubEnterpriseServer
            var requestRepository_repository_GitHubEnterpriseServerIsNull = true;
            requestRepository_repository_GitHubEnterpriseServer = new Amazon.CodeGuruReviewer.Model.ThirdPartySourceRepository();
            System.String requestRepository_repository_GitHubEnterpriseServer_gitHubEnterpriseServer_ConnectionArn = null;
            if (cmdletContext.GitHubEnterpriseServer_ConnectionArn != null)
            {
                requestRepository_repository_GitHubEnterpriseServer_gitHubEnterpriseServer_ConnectionArn = cmdletContext.GitHubEnterpriseServer_ConnectionArn;
            }
            if (requestRepository_repository_GitHubEnterpriseServer_gitHubEnterpriseServer_ConnectionArn != null)
            {
                requestRepository_repository_GitHubEnterpriseServer.ConnectionArn = requestRepository_repository_GitHubEnterpriseServer_gitHubEnterpriseServer_ConnectionArn;
                requestRepository_repository_GitHubEnterpriseServerIsNull = false;
            }
            System.String requestRepository_repository_GitHubEnterpriseServer_gitHubEnterpriseServer_Name = null;
            if (cmdletContext.GitHubEnterpriseServer_Name != null)
            {
                requestRepository_repository_GitHubEnterpriseServer_gitHubEnterpriseServer_Name = cmdletContext.GitHubEnterpriseServer_Name;
            }
            if (requestRepository_repository_GitHubEnterpriseServer_gitHubEnterpriseServer_Name != null)
            {
                requestRepository_repository_GitHubEnterpriseServer.Name = requestRepository_repository_GitHubEnterpriseServer_gitHubEnterpriseServer_Name;
                requestRepository_repository_GitHubEnterpriseServerIsNull = false;
            }
            System.String requestRepository_repository_GitHubEnterpriseServer_gitHubEnterpriseServer_Owner = null;
            if (cmdletContext.GitHubEnterpriseServer_Owner != null)
            {
                requestRepository_repository_GitHubEnterpriseServer_gitHubEnterpriseServer_Owner = cmdletContext.GitHubEnterpriseServer_Owner;
            }
            if (requestRepository_repository_GitHubEnterpriseServer_gitHubEnterpriseServer_Owner != null)
            {
                requestRepository_repository_GitHubEnterpriseServer.Owner = requestRepository_repository_GitHubEnterpriseServer_gitHubEnterpriseServer_Owner;
                requestRepository_repository_GitHubEnterpriseServerIsNull = false;
            }
             // determine if requestRepository_repository_GitHubEnterpriseServer should be set to null
            if (requestRepository_repository_GitHubEnterpriseServerIsNull)
            {
                requestRepository_repository_GitHubEnterpriseServer = null;
            }
            if (requestRepository_repository_GitHubEnterpriseServer != null)
            {
                request.Repository.GitHubEnterpriseServer = requestRepository_repository_GitHubEnterpriseServer;
                requestRepositoryIsNull = false;
            }
             // determine if request.Repository should be set to null
            if (requestRepositoryIsNull)
            {
                request.Repository = null;
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
        
        private Amazon.CodeGuruReviewer.Model.AssociateRepositoryResponse CallAWSServiceOperation(IAmazonCodeGuruReviewer client, Amazon.CodeGuruReviewer.Model.AssociateRepositoryRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon CodeGuru Reviewer", "AssociateRepository");
            try
            {
                #if DESKTOP
                return client.AssociateRepository(request);
                #elif CORECLR
                return client.AssociateRepositoryAsync(request).GetAwaiter().GetResult();
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
            public System.String ClientRequestToken { get; set; }
            public System.String Bitbucket_ConnectionArn { get; set; }
            public System.String Bitbucket_Name { get; set; }
            public System.String Bitbucket_Owner { get; set; }
            public System.String CodeCommit_Name { get; set; }
            public System.String GitHubEnterpriseServer_ConnectionArn { get; set; }
            public System.String GitHubEnterpriseServer_Name { get; set; }
            public System.String GitHubEnterpriseServer_Owner { get; set; }
            public System.Func<Amazon.CodeGuruReviewer.Model.AssociateRepositoryResponse, RegisterCGRRepositoryCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.RepositoryAssociation;
        }
        
    }
}
