// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.StorageSync
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for StorageSyncServicesOperations
    /// </summary>
    public static partial class StorageSyncServicesOperationsExtensions
    {
        /// <summary>
        /// Check the give namespace name availability.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='locationName'>
        /// The desired region for the name check.
        /// </param>
        public static CheckNameAvailabilityResult CheckNameAvailability(this IStorageSyncServicesOperations operations, string locationName, string name)
        {
                return ((IStorageSyncServicesOperations)operations).CheckNameAvailabilityAsync(locationName, name).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Check the give namespace name availability.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='locationName'>
        /// The desired region for the name check.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<CheckNameAvailabilityResult> CheckNameAvailabilityAsync(this IStorageSyncServicesOperations operations, string locationName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(locationName, name, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Create a new StorageSyncService.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        public static StorageSyncService Create(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, StorageSyncServiceCreateParameters parameters)
        {
                return ((IStorageSyncServicesOperations)operations).CreateAsync(resourceGroupName, storageSyncServiceName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a new StorageSyncService.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<StorageSyncService> CreateAsync(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, StorageSyncServiceCreateParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Get a given StorageSyncService.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        public static StorageSyncService Get(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName)
        {
                return ((IStorageSyncServicesOperations)operations).GetAsync(resourceGroupName, storageSyncServiceName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a given StorageSyncService.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<StorageSyncService> GetAsync(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Patch a given StorageSyncService.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        public static StorageSyncService Update(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, StorageSyncServiceUpdateParameters parameters = default(StorageSyncServiceUpdateParameters))
        {
                return ((IStorageSyncServicesOperations)operations).UpdateAsync(resourceGroupName, storageSyncServiceName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Patch a given StorageSyncService.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<StorageSyncService> UpdateAsync(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, StorageSyncServiceUpdateParameters parameters = default(StorageSyncServiceUpdateParameters), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Delete a given StorageSyncService.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        public static StorageSyncServicesDeleteHeaders Delete(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName)
        {
                return ((IStorageSyncServicesOperations)operations).DeleteAsync(resourceGroupName, storageSyncServiceName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a given StorageSyncService.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<StorageSyncServicesDeleteHeaders> DeleteAsync(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Headers;
            }
        }
        /// <summary>
        /// Get a StorageSyncService list by Resource group name.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        public static System.Collections.Generic.IEnumerable<StorageSyncService> ListByResourceGroup(this IStorageSyncServicesOperations operations, string resourceGroupName)
        {
                return ((IStorageSyncServicesOperations)operations).ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a StorageSyncService list by Resource group name.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<StorageSyncService>> ListByResourceGroupAsync(this IStorageSyncServicesOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Get a StorageSyncService list by subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static System.Collections.Generic.IEnumerable<StorageSyncService> ListBySubscription(this IStorageSyncServicesOperations operations)
        {
                return ((IStorageSyncServicesOperations)operations).ListBySubscriptionAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a StorageSyncService list by subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<StorageSyncService>> ListBySubscriptionAsync(this IStorageSyncServicesOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Create a new StorageSyncService.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        public static StorageSyncService BeginCreate(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, StorageSyncServiceCreateParameters parameters)
        {
                return ((IStorageSyncServicesOperations)operations).BeginCreateAsync(resourceGroupName, storageSyncServiceName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a new StorageSyncService.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<StorageSyncService> BeginCreateAsync(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, StorageSyncServiceCreateParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Patch a given StorageSyncService.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        public static StorageSyncService BeginUpdate(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, StorageSyncServiceUpdateParameters parameters = default(StorageSyncServiceUpdateParameters))
        {
                return ((IStorageSyncServicesOperations)operations).BeginUpdateAsync(resourceGroupName, storageSyncServiceName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Patch a given StorageSyncService.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<StorageSyncService> BeginUpdateAsync(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, StorageSyncServiceUpdateParameters parameters = default(StorageSyncServiceUpdateParameters), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Delete a given StorageSyncService.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        public static StorageSyncServicesDeleteHeaders BeginDelete(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName)
        {
                return ((IStorageSyncServicesOperations)operations).BeginDeleteAsync(resourceGroupName, storageSyncServiceName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a given StorageSyncService.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<StorageSyncServicesDeleteHeaders> BeginDeleteAsync(this IStorageSyncServicesOperations operations, string resourceGroupName, string storageSyncServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Headers;
            }
        }
    }
}
