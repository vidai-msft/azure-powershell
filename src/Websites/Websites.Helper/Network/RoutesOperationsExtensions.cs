// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Helper.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for RoutesOperations
    /// </summary>
    public static partial class RoutesOperationsExtensions
    {
        /// <summary>
        /// Deletes the specified route from a route table.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the route table.
        /// </param>
        /// <param name='routeName'>
        /// The name of the route.
        /// </param>
        public static void Delete(this IRoutesOperations operations, string resourceGroupName, string routeTableName, string routeName)
        {
                ((IRoutesOperations)operations).DeleteAsync(resourceGroupName, routeTableName, routeName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes the specified route from a route table.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the route table.
        /// </param>
        /// <param name='routeName'>
        /// The name of the route.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this IRoutesOperations operations, string resourceGroupName, string routeTableName, string routeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, routeTableName, routeName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Gets the specified route from a route table.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the route table.
        /// </param>
        /// <param name='routeName'>
        /// The name of the route.
        /// </param>
        public static Route Get(this IRoutesOperations operations, string resourceGroupName, string routeTableName, string routeName)
        {
                return ((IRoutesOperations)operations).GetAsync(resourceGroupName, routeTableName, routeName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the specified route from a route table.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the route table.
        /// </param>
        /// <param name='routeName'>
        /// The name of the route.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Route> GetAsync(this IRoutesOperations operations, string resourceGroupName, string routeTableName, string routeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, routeTableName, routeName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Creates or updates a route in the specified route table.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the route table.
        /// </param>
        /// <param name='routeName'>
        /// The name of the route.
        /// </param>
        public static Route CreateOrUpdate(this IRoutesOperations operations, string resourceGroupName, string routeTableName, string routeName, Route routeParameters)
        {
                return ((IRoutesOperations)operations).CreateOrUpdateAsync(resourceGroupName, routeTableName, routeName, routeParameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates or updates a route in the specified route table.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the route table.
        /// </param>
        /// <param name='routeName'>
        /// The name of the route.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Route> CreateOrUpdateAsync(this IRoutesOperations operations, string resourceGroupName, string routeTableName, string routeName, Route routeParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, routeTableName, routeName, routeParameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets all routes in a route table.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the route table.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Route> List(this IRoutesOperations operations, string resourceGroupName, string routeTableName)
        {
                return ((IRoutesOperations)operations).ListAsync(resourceGroupName, routeTableName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all routes in a route table.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the route table.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Route>> ListAsync(this IRoutesOperations operations, string resourceGroupName, string routeTableName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, routeTableName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Deletes the specified route from a route table.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the route table.
        /// </param>
        /// <param name='routeName'>
        /// The name of the route.
        /// </param>
        public static void BeginDelete(this IRoutesOperations operations, string resourceGroupName, string routeTableName, string routeName)
        {
                ((IRoutesOperations)operations).BeginDeleteAsync(resourceGroupName, routeTableName, routeName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes the specified route from a route table.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the route table.
        /// </param>
        /// <param name='routeName'>
        /// The name of the route.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task BeginDeleteAsync(this IRoutesOperations operations, string resourceGroupName, string routeTableName, string routeName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, routeTableName, routeName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Creates or updates a route in the specified route table.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the route table.
        /// </param>
        /// <param name='routeName'>
        /// The name of the route.
        /// </param>
        public static Route BeginCreateOrUpdate(this IRoutesOperations operations, string resourceGroupName, string routeTableName, string routeName, Route routeParameters)
        {
                return ((IRoutesOperations)operations).BeginCreateOrUpdateAsync(resourceGroupName, routeTableName, routeName, routeParameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates or updates a route in the specified route table.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the route table.
        /// </param>
        /// <param name='routeName'>
        /// The name of the route.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Route> BeginCreateOrUpdateAsync(this IRoutesOperations operations, string resourceGroupName, string routeTableName, string routeName, Route routeParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, routeTableName, routeName, routeParameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets all routes in a route table.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Route> ListNext(this IRoutesOperations operations, string nextPageLink)
        {
                return ((IRoutesOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all routes in a route table.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Route>> ListNextAsync(this IRoutesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
