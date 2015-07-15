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
using Microsoft.Azure;
using Microsoft.Azure.Management.BackupServices;

namespace Microsoft.Azure.Management.BackupServices
{
    public partial interface IBackupServicesManagementClient : IDisposable
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        string ApiVersion
        {
            get; 
        }
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        Uri BaseUri
        {
            get; 
        }
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; 
        }
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationInitialTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationRetryTimeout
        {
            get; set; 
        }
        
        string ResourceGroupName
        {
            get; set; 
        }
        
        string ResourceName
        {
            get; set; 
        }
        
        /// <summary>
        /// Definition of BackUp operations for the Azure Backup extension.
        /// </summary>
        IBackUpOperations BackUp
        {
            get; 
        }
        
        /// <summary>
        /// Definition of Container operations for the Azure Backup extension.
        /// </summary>
        IContainerOperation Container
        {
            get; 
        }
        
        /// <summary>
        /// Definition of DataSource operations for the Azure Backup extension.
        /// </summary>
        IDataSourceOperations DataSource
        {
            get; 
        }
        
        /// <summary>
        /// Definition of Job operations for Azure backup extension.
        /// </summary>
        IJobOperations Job
        {
            get; 
        }
        
        /// <summary>
        /// Definition of Workflow operation for the Azure Backup extension.
        /// </summary>
        IOperationStatus OperationStatus
        {
            get; 
        }
        
        /// <summary>
        /// Definition of Protectable ObjectOperation operations for the Azure
        /// Backup extension.
        /// </summary>
        IProtectableObjectOperations ProtectableObject
        {
            get; 
        }
        
        /// <summary>
        /// Definition of Protection Policy operations for the Azure Backup
        /// extension.
        /// </summary>
        IProtectionPolicyOperations ProtectionPolicy
        {
            get; 
        }
        
        /// <summary>
        /// Definition of Recovery Point operations for the Azure Backup
        /// extension.
        /// </summary>
        IRecoveryPointOperations RecoveryPoint
        {
            get; 
        }
        
        /// <summary>
        /// Definition of Restore operations for the Azure Backup extension.
        /// </summary>
        IRestoreOperations Restore
        {
            get; 
        }
    }
}
