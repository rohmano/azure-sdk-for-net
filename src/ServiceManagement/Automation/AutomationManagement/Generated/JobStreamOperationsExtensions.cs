// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.Automation;
using Microsoft.WindowsAzure.Management.Automation.Models;

namespace Microsoft.WindowsAzure.Management.Automation
{
    public static partial class JobStreamOperationsExtensions
    {
        /// <summary>
        /// Retrieve the job stream identified by job stream id.  (see
        /// http://aka.ms/azureautomationsdk/jobstreamoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobStreamOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job id.
        /// </param>
        /// <param name='jobStreamId'>
        /// Required. The job stream id.
        /// </param>
        /// <returns>
        /// The response model for the get job stream operation.
        /// </returns>
        public static JobStreamGetResponse Get(this IJobStreamOperations operations, string automationAccount, Guid jobId, string jobStreamId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobStreamOperations)s).GetAsync(automationAccount, jobId, jobStreamId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the job stream identified by job stream id.  (see
        /// http://aka.ms/azureautomationsdk/jobstreamoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobStreamOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job id.
        /// </param>
        /// <param name='jobStreamId'>
        /// Required. The job stream id.
        /// </param>
        /// <returns>
        /// The response model for the get job stream operation.
        /// </returns>
        public static Task<JobStreamGetResponse> GetAsync(this IJobStreamOperations operations, string automationAccount, Guid jobId, string jobStreamId)
        {
            return operations.GetAsync(automationAccount, jobId, jobStreamId, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a test job streams identified by runbook name and stream
        /// id.  (see http://aka.ms/azureautomationsdk/jobstreamoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobStreamOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <param name='jobStreamId'>
        /// Required. The job stream id.
        /// </param>
        /// <returns>
        /// The response model for the get job stream operation.
        /// </returns>
        public static JobStreamGetResponse GetTestJobStream(this IJobStreamOperations operations, string automationAccount, string runbookName, string jobStreamId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobStreamOperations)s).GetTestJobStreamAsync(automationAccount, runbookName, jobStreamId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a test job streams identified by runbook name and stream
        /// id.  (see http://aka.ms/azureautomationsdk/jobstreamoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobStreamOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <param name='jobStreamId'>
        /// Required. The job stream id.
        /// </param>
        /// <returns>
        /// The response model for the get job stream operation.
        /// </returns>
        public static Task<JobStreamGetResponse> GetTestJobStreamAsync(this IJobStreamOperations operations, string automationAccount, string runbookName, string jobStreamId)
        {
            return operations.GetTestJobStreamAsync(automationAccount, runbookName, jobStreamId, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of jobs streams identified by job id.  (see
        /// http://aka.ms/azureautomationsdk/jobstreamoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobStreamOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job Id.
        /// </param>
        /// <param name='parameters'>
        /// Optional. The parameters supplied to the list job stream's stream
        /// items operation.
        /// </param>
        /// <returns>
        /// The response model for the list job stream operation.
        /// </returns>
        public static JobStreamListResponse List(this IJobStreamOperations operations, string automationAccount, Guid jobId, JobStreamListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobStreamOperations)s).ListAsync(automationAccount, jobId, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of jobs streams identified by job id.  (see
        /// http://aka.ms/azureautomationsdk/jobstreamoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobStreamOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='jobId'>
        /// Required. The job Id.
        /// </param>
        /// <param name='parameters'>
        /// Optional. The parameters supplied to the list job stream's stream
        /// items operation.
        /// </param>
        /// <returns>
        /// The response model for the list job stream operation.
        /// </returns>
        public static Task<JobStreamListResponse> ListAsync(this IJobStreamOperations operations, string automationAccount, Guid jobId, JobStreamListParameters parameters)
        {
            return operations.ListAsync(automationAccount, jobId, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the next page of job streams using next link.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobStreamOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// The response model for the list job stream operation.
        /// </returns>
        public static JobStreamListResponse ListNext(this IJobStreamOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobStreamOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the next page of job streams using next link.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobStreamOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// The response model for the list job stream operation.
        /// </returns>
        public static Task<JobStreamListResponse> ListNextAsync(this IJobStreamOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of test job streams identified by runbook name.
        /// (see http://aka.ms/azureautomationsdk/jobstreamoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobStreamOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <param name='parameters'>
        /// Optional. The parameters supplied to the list job stream's stream
        /// items operation.
        /// </param>
        /// <returns>
        /// The response model for the list job stream operation.
        /// </returns>
        public static JobStreamListResponse ListTestJobStreams(this IJobStreamOperations operations, string automationAccount, string runbookName, JobStreamListParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IJobStreamOperations)s).ListTestJobStreamsAsync(automationAccount, runbookName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of test job streams identified by runbook name.
        /// (see http://aka.ms/azureautomationsdk/jobstreamoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Automation.IJobStreamOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='runbookName'>
        /// Required. The runbook name.
        /// </param>
        /// <param name='parameters'>
        /// Optional. The parameters supplied to the list job stream's stream
        /// items operation.
        /// </param>
        /// <returns>
        /// The response model for the list job stream operation.
        /// </returns>
        public static Task<JobStreamListResponse> ListTestJobStreamsAsync(this IJobStreamOperations operations, string automationAccount, string runbookName, JobStreamListParameters parameters)
        {
            return operations.ListTestJobStreamsAsync(automationAccount, runbookName, parameters, CancellationToken.None);
        }
    }
}