// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of AfdRule and their operations over its parent. </summary>
    public partial class AfdRuleCollection : ArmCollection, IEnumerable<AfdRule>, IAsyncEnumerable<AfdRule>
    {
        private readonly ClientDiagnostics _afdRuleClientDiagnostics;
        private readonly AfdRulesRestOperations _afdRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="AfdRuleCollection"/> class for mocking. </summary>
        protected AfdRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AfdRuleCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AfdRuleCollection(ArmResource parent) : base(parent)
        {
            _afdRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", AfdRule.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(AfdRule.ResourceType, out string afdRuleApiVersion);
            _afdRuleRestClient = new AfdRulesRestOperations(_afdRuleClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, afdRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AfdRuleSet.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AfdRuleSet.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a new delivery rule within the specified rule set. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="rule"> The delivery rule properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="rule"/> is null. </exception>
        public virtual AfdRuleCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string ruleName, AfdRuleData rule, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            if (rule == null)
            {
                throw new ArgumentNullException(nameof(rule));
            }

            using var scope = _afdRuleClientDiagnostics.CreateScope("AfdRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _afdRuleRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleName, rule, cancellationToken);
                var operation = new AfdRuleCreateOrUpdateOperation(ArmClient, _afdRuleClientDiagnostics, Pipeline, _afdRuleRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleName, rule).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new delivery rule within the specified rule set. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="rule"> The delivery rule properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="rule"/> is null. </exception>
        public async virtual Task<AfdRuleCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string ruleName, AfdRuleData rule, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            if (rule == null)
            {
                throw new ArgumentNullException(nameof(rule));
            }

            using var scope = _afdRuleClientDiagnostics.CreateScope("AfdRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _afdRuleRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleName, rule, cancellationToken).ConfigureAwait(false);
                var operation = new AfdRuleCreateOrUpdateOperation(ArmClient, _afdRuleClientDiagnostics, Pipeline, _afdRuleRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleName, rule).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing delivery rule within a rule set. </summary>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<AfdRule> Get(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _afdRuleClientDiagnostics.CreateScope("AfdRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _afdRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleName, cancellationToken);
                if (response.Value == null)
                    throw _afdRuleClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdRule(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing delivery rule within a rule set. </summary>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public async virtual Task<Response<AfdRule>> GetAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _afdRuleClientDiagnostics.CreateScope("AfdRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _afdRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _afdRuleClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AfdRule(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<AfdRule> GetIfExists(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _afdRuleClientDiagnostics.CreateScope("AfdRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _afdRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AfdRule>(null, response.GetRawResponse());
                return Response.FromValue(new AfdRule(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public async virtual Task<Response<AfdRule>> GetIfExistsAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _afdRuleClientDiagnostics.CreateScope("AfdRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _afdRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ruleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AfdRule>(null, response.GetRawResponse());
                return Response.FromValue(new AfdRule(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _afdRuleClientDiagnostics.CreateScope("AfdRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(ruleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _afdRuleClientDiagnostics.CreateScope("AfdRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(ruleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the existing delivery rules within a rule set. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AfdRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AfdRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AfdRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdRuleClientDiagnostics.CreateScope("AfdRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdRuleRestClient.ListByRuleSet(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdRule(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AfdRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdRuleClientDiagnostics.CreateScope("AfdRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdRuleRestClient.ListByRuleSetNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdRule(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the existing delivery rules within a rule set. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AfdRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AfdRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AfdRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _afdRuleClientDiagnostics.CreateScope("AfdRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdRuleRestClient.ListByRuleSetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdRule(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AfdRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _afdRuleClientDiagnostics.CreateScope("AfdRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdRuleRestClient.ListByRuleSetNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdRule(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<AfdRule> IEnumerable<AfdRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AfdRule> IAsyncEnumerable<AfdRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
