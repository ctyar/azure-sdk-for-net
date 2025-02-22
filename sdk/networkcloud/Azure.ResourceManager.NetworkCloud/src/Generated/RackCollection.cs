// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing a collection of <see cref="RackResource" /> and their operations.
    /// Each <see cref="RackResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="RackCollection" /> instance call the GetRacks method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class RackCollection : ArmCollection, IEnumerable<RackResource>, IAsyncEnumerable<RackResource>
    {
        private readonly ClientDiagnostics _rackClientDiagnostics;
        private readonly RacksRestOperations _rackRestClient;

        /// <summary> Initializes a new instance of the <see cref="RackCollection"/> class for mocking. </summary>
        protected RackCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RackCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RackCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _rackClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", RackResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RackResource.ResourceType, out string rackApiVersion);
            _rackRestClient = new RacksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, rackApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get properties of the provided rack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks/{rackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackName"> The name of the rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackName"/> is null. </exception>
        public virtual async Task<Response<RackResource>> GetAsync(string rackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackName, nameof(rackName));

            using var scope = _rackClientDiagnostics.CreateScope("RackCollection.Get");
            scope.Start();
            try
            {
                var response = await _rackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, rackName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of the provided rack.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks/{rackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackName"> The name of the rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackName"/> is null. </exception>
        public virtual Response<RackResource> Get(string rackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackName, nameof(rackName));

            using var scope = _rackClientDiagnostics.CreateScope("RackCollection.Get");
            scope.Start();
            try
            {
                var response = _rackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, rackName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RackResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of racks in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RackResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _rackRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _rackRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RackResource(Client, RackData.DeserializeRackData(e)), _rackClientDiagnostics, Pipeline, "RackCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of racks in the provided resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RackResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _rackRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _rackRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RackResource(Client, RackData.DeserializeRackData(e)), _rackClientDiagnostics, Pipeline, "RackCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks/{rackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackName"> The name of the rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string rackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackName, nameof(rackName));

            using var scope = _rackClientDiagnostics.CreateScope("RackCollection.Exists");
            scope.Start();
            try
            {
                var response = await _rackRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, rackName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/racks/{rackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Racks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackName"> The name of the rack. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackName"/> is null. </exception>
        public virtual Response<bool> Exists(string rackName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackName, nameof(rackName));

            using var scope = _rackClientDiagnostics.CreateScope("RackCollection.Exists");
            scope.Start();
            try
            {
                var response = _rackRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, rackName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RackResource> IEnumerable<RackResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RackResource> IAsyncEnumerable<RackResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
