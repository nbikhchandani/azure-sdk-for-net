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
using Microsoft.Azure;
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network
{
    /// <summary>
    /// The Network Resource Provider API includes operations for managing the
    /// load balancers for your subscription.
    /// </summary>
    public partial interface ILoadBalancerOperations
    {
        /// <summary>
        /// The Put LoadBalancer operation creates/updates a LoadBalancer
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='loadBalancerName'>
        /// The name of the loadBalancer.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create/delete LoadBalancer operation
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response of a PUT Load Balancer operation
        /// </returns>
        Task<LoadBalancerPutResponse> BeginCreateOrUpdatingAsync(string resourceGroupName, string loadBalancerName, LoadBalancer parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The delete loadbalancer operation deletes the specified
        /// loadbalancer.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='loadBalancerName'>
        /// The name of the loadBalancer.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// If the resource provide needs to return an error to any operation,
        /// it should return the appropriate HTTP error code and a message
        /// body as can be seen below.The message should be localized per the
        /// Accept-Language header specified in the original request such
        /// thatit could be directly be exposed to users
        /// </returns>
        Task<UpdateOperationResponse> BeginDeletingAsync(string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Put LoadBalancer operation creates/updates a LoadBalancer
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='loadBalancerName'>
        /// The name of the loadBalancer.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create/update LoadBalancer operation
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<AzureAsyncOperationResponse> CreateOrUpdateAsync(string resourceGroupName, string loadBalancerName, LoadBalancer parameters, CancellationToken cancellationToken);
        
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='loadBalancerName'>
        /// The name of the loadBalancer.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get ntework interface operation retreives information about the
        /// specified network interface.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='loadBalancerName'>
        /// The name of the loadBalancer.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response of a GET Load Balancer operation
        /// </returns>
        Task<LoadBalancerGetResponse> GetAsync(string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List loadBalancer opertion retrieves all the loadbalancers in a
        /// resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for ListLoadBalancers Api service call
        /// </returns>
        Task<LoadBalancerListResponse> ListAsync(string resourceGroupName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List loadBalancer opertion retrieves all the loadbalancers in a
        /// subscription.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for ListLoadBalancers Api service call
        /// </returns>
        Task<LoadBalancerListResponse> ListAllAsync(CancellationToken cancellationToken);
    }
}
