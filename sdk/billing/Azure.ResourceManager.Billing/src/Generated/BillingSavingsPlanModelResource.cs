// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Billing.Models;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A Class representing a BillingSavingsPlanModel along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="BillingSavingsPlanModelResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetBillingSavingsPlanModelResource method.
    /// Otherwise you can get one from its parent resource <see cref="SavingsPlanOrderModelResource"/> using the GetBillingSavingsPlanModel method.
    /// </summary>
    public partial class BillingSavingsPlanModelResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BillingSavingsPlanModelResource"/> instance. </summary>
        /// <param name="billingAccountName"> The billingAccountName. </param>
        /// <param name="savingsPlanOrderId"> The savingsPlanOrderId. </param>
        /// <param name="savingsPlanId"> The savingsPlanId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string savingsPlanOrderId, string savingsPlanId)
        {
            var resourceId = $"/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _billingSavingsPlanModelSavingsPlansClientDiagnostics;
        private readonly SavingsPlansRestOperations _billingSavingsPlanModelSavingsPlansRestClient;
        private readonly BillingSavingsPlanModelData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/billingAccounts/savingsPlanOrders/savingsPlans";

        /// <summary> Initializes a new instance of the <see cref="BillingSavingsPlanModelResource"/> class for mocking. </summary>
        protected BillingSavingsPlanModelResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingSavingsPlanModelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BillingSavingsPlanModelResource(ArmClient client, BillingSavingsPlanModelData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BillingSavingsPlanModelResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BillingSavingsPlanModelResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingSavingsPlanModelSavingsPlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string billingSavingsPlanModelSavingsPlansApiVersion);
            _billingSavingsPlanModelSavingsPlansRestClient = new SavingsPlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingSavingsPlanModelSavingsPlansApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BillingSavingsPlanModelData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get savings plan by billing account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlans_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSavingsPlanModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BillingSavingsPlanModelResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _billingSavingsPlanModelSavingsPlansClientDiagnostics.CreateScope("BillingSavingsPlanModelResource.Get");
            scope.Start();
            try
            {
                var response = await _billingSavingsPlanModelSavingsPlansRestClient.GetByBillingAccountAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingSavingsPlanModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get savings plan by billing account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlans_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSavingsPlanModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BillingSavingsPlanModelResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _billingSavingsPlanModelSavingsPlansClientDiagnostics.CreateScope("BillingSavingsPlanModelResource.Get");
            scope.Start();
            try
            {
                var response = _billingSavingsPlanModelSavingsPlansRestClient.GetByBillingAccount(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingSavingsPlanModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update savings plan by billing account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlans_UpdateByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSavingsPlanModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Request body for patching a savings plan order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<BillingSavingsPlanModelResource>> UpdateAsync(WaitUntil waitUntil, BillingSavingsPlanModelPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _billingSavingsPlanModelSavingsPlansClientDiagnostics.CreateScope("BillingSavingsPlanModelResource.Update");
            scope.Start();
            try
            {
                var response = await _billingSavingsPlanModelSavingsPlansRestClient.UpdateByBillingAccountAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new BillingArmOperation<BillingSavingsPlanModelResource>(new BillingSavingsPlanModelOperationSource(Client), _billingSavingsPlanModelSavingsPlansClientDiagnostics, Pipeline, _billingSavingsPlanModelSavingsPlansRestClient.CreateUpdateByBillingAccountRequest(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update savings plan by billing account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlans_UpdateByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSavingsPlanModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Request body for patching a savings plan order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<BillingSavingsPlanModelResource> Update(WaitUntil waitUntil, BillingSavingsPlanModelPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _billingSavingsPlanModelSavingsPlansClientDiagnostics.CreateScope("BillingSavingsPlanModelResource.Update");
            scope.Start();
            try
            {
                var response = _billingSavingsPlanModelSavingsPlansRestClient.UpdateByBillingAccount(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new BillingArmOperation<BillingSavingsPlanModelResource>(new BillingSavingsPlanModelOperationSource(Client), _billingSavingsPlanModelSavingsPlansClientDiagnostics, Pipeline, _billingSavingsPlanModelSavingsPlansRestClient.CreateUpdateByBillingAccountRequest(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Validate savings plan patch by billing account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlans_ValidateUpdateByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSavingsPlanModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Request body for patching a savings plan order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<SavingsPlanValidateResult>> ValidateUpdateByBillingAccountAsync(SavingsPlanUpdateValidateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _billingSavingsPlanModelSavingsPlansClientDiagnostics.CreateScope("BillingSavingsPlanModelResource.ValidateUpdateByBillingAccount");
            scope.Start();
            try
            {
                var response = await _billingSavingsPlanModelSavingsPlansRestClient.ValidateUpdateByBillingAccountAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Validate savings plan patch by billing account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlans_ValidateUpdateByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSavingsPlanModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Request body for patching a savings plan order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<SavingsPlanValidateResult> ValidateUpdateByBillingAccount(SavingsPlanUpdateValidateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _billingSavingsPlanModelSavingsPlansClientDiagnostics.CreateScope("BillingSavingsPlanModelResource.ValidateUpdateByBillingAccount");
            scope.Start();
            try
            {
                var response = _billingSavingsPlanModelSavingsPlansRestClient.ValidateUpdateByBillingAccount(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlans_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSavingsPlanModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<BillingSavingsPlanModelResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _billingSavingsPlanModelSavingsPlansClientDiagnostics.CreateScope("BillingSavingsPlanModelResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _billingSavingsPlanModelSavingsPlansRestClient.GetByBillingAccountAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new BillingSavingsPlanModelResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new BillingSavingsPlanModelPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = await UpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlans_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSavingsPlanModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<BillingSavingsPlanModelResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _billingSavingsPlanModelSavingsPlansClientDiagnostics.CreateScope("BillingSavingsPlanModelResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _billingSavingsPlanModelSavingsPlansRestClient.GetByBillingAccount(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken);
                    return Response.FromValue(new BillingSavingsPlanModelResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new BillingSavingsPlanModelPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = Update(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlans_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSavingsPlanModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<BillingSavingsPlanModelResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _billingSavingsPlanModelSavingsPlansClientDiagnostics.CreateScope("BillingSavingsPlanModelResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _billingSavingsPlanModelSavingsPlansRestClient.GetByBillingAccountAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new BillingSavingsPlanModelResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new BillingSavingsPlanModelPatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = await UpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlans_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSavingsPlanModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<BillingSavingsPlanModelResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _billingSavingsPlanModelSavingsPlansClientDiagnostics.CreateScope("BillingSavingsPlanModelResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _billingSavingsPlanModelSavingsPlansRestClient.GetByBillingAccount(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken);
                    return Response.FromValue(new BillingSavingsPlanModelResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new BillingSavingsPlanModelPatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = Update(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlans_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSavingsPlanModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<BillingSavingsPlanModelResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _billingSavingsPlanModelSavingsPlansClientDiagnostics.CreateScope("BillingSavingsPlanModelResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _billingSavingsPlanModelSavingsPlansRestClient.GetByBillingAccountAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new BillingSavingsPlanModelResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new BillingSavingsPlanModelPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = await UpdateAsync(WaitUntil.Completed, patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/billingAccounts/{billingAccountName}/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlans_GetByBillingAccount</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingSavingsPlanModelResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<BillingSavingsPlanModelResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _billingSavingsPlanModelSavingsPlansClientDiagnostics.CreateScope("BillingSavingsPlanModelResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _billingSavingsPlanModelSavingsPlansRestClient.GetByBillingAccount(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, null, cancellationToken);
                    return Response.FromValue(new BillingSavingsPlanModelResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new BillingSavingsPlanModelPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = Update(WaitUntil.Completed, patch, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
