// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

#nullable disable

namespace Azure
{
    /// <summary>
    /// Represents a long-running operation.
    /// </summary>
#pragma warning disable AZC0012 // Avoid single word type names
    public class Operation
#pragma warning restore AZC0012 // Avoid single word type names
    {
        private readonly NextLinkOperationImplementation _nextLinkOperation;
        private readonly OperationInternal _operation;

        /// <summary> Initializes a new instance of ArmOperation for mocking. </summary>
        protected Operation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Operation"/> class.
        /// </summary>
        /// <param name="pipeline">The Http pipeline.</param>
        /// <param name="rehydrationToken">The rehydration token.</param>
        /// <param name="options">The client options.</param>
        public Operation(HttpPipeline pipeline, RehydrationToken rehydrationToken, ClientOptions options = null)
        {
            AssertNotNull(pipeline, nameof(pipeline));
            AssertNotNull(rehydrationToken, nameof(rehydrationToken));
            _nextLinkOperation = (NextLinkOperationImplementation)NextLinkOperationImplementation.Create(pipeline, rehydrationToken);
            _operation = new OperationInternal(_nextLinkOperation, new ClientDiagnostics(options ?? ClientOptions.Default), null, requestMethod: _nextLinkOperation.RequestMethod);
        }

        /// <summary>
        /// Get a token that can be used to rehydrate the operation.
        /// </summary>
        public virtual RehydrationToken? GetRehydrationToken() => _nextLinkOperation?.GetRehydrationToken() ?? null;

        /// <summary>
        /// Gets an ID representing the operation that can be used to poll for
        /// the status of the long-running operation.
        /// </summary>
        public virtual string Id => _nextLinkOperation?.OperationId ?? null;

        /// <summary>
        /// The last HTTP response received from the server.
        /// </summary>
        /// <remarks>
        /// The last response returned from the server during the lifecycle of this instance.
        /// An instance of <see cref="Operation{T}"/> sends requests to a server in UpdateStatusAsync, UpdateStatus, and other methods.
        /// Responses from these requests can be accessed using GetRawResponse.
        /// </remarks>
        public virtual Response GetRawResponse() => _operation.RawResponse;

        /// <summary>
        /// Returns true if the long-running operation completed.
        /// </summary>
        public virtual bool HasCompleted => _operation.HasCompleted;

        /// <summary>
        /// Calls the server to get updated status of the long-running operation.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the service call.</param>
        /// <returns>The HTTP response received from the server.</returns>
        /// <remarks>
        /// This operation will update the value returned from GetRawResponse and might update HasCompleted.
        /// </remarks>
        public virtual ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <summary>
        /// Calls the server to get updated status of the long-running operation.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the service call.</param>
        /// <returns>The HTTP response received from the server.</returns>
        /// <remarks>
        /// This operation will update the value returned from GetRawResponse and might update HasCompleted.
        /// </remarks>
        public virtual Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <summary>
        /// Periodically calls the server till the long-running operation completes.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the periodical service calls.</param>
        /// <returns>The last HTTP response received from the server.</returns>
        /// <remarks>
        /// This method will periodically call UpdateStatusAsync till HasCompleted is true, then return the final response of the operation.
        /// </remarks>
        public virtual async ValueTask<Response> WaitForCompletionResponseAsync(CancellationToken cancellationToken = default)
        {
            OperationPoller poller = new OperationPoller();
            return await poller.WaitForCompletionResponseAsync(this, null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Periodically calls the server till the long-running operation completes.
        /// </summary>
        /// <param name="pollingInterval">
        /// The interval between status requests to the server.
        /// The interval can change based on information returned from the server.
        /// For example, the server might communicate to the client that there is not reason to poll for status change sooner than some time.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the periodical service calls.</param>
        /// <returns>The last HTTP response received from the server.</returns>
        /// <remarks>
        /// This method will periodically call UpdateStatusAsync till HasCompleted is true, then return the final response of the operation.
        /// </remarks>
        public virtual async ValueTask<Response> WaitForCompletionResponseAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default)
        {
            OperationPoller poller = new OperationPoller();
            return await poller.WaitForCompletionResponseAsync(this, pollingInterval, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Periodically calls the server till the long-running operation completes.
        /// </summary>
        /// <param name="delayStrategy">
        /// The strategy to use to determine the delay between status requests to the server. If the server returns retry-after header,
        /// the delay used will be the maximum specified by the strategy and the header value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the periodical service calls.</param>
        /// <returns>The last HTTP response received from the server.</returns>
        /// <remarks>
        /// This method will periodically call UpdateStatusAsync till HasCompleted is true, then return the final response of the operation.
        /// </remarks>
        public virtual async ValueTask<Response> WaitForCompletionResponseAsync(DelayStrategy delayStrategy, CancellationToken cancellationToken = default)
        {
            OperationPoller poller = new OperationPoller(delayStrategy);
            return await poller.WaitForCompletionResponseAsync(this, default, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Periodically calls the server till the long-running operation completes.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the periodical service calls.</param>
        /// <returns>The last HTTP response received from the server.</returns>
        /// <remarks>
        /// This method will periodically call UpdateStatusAsync till HasCompleted is true, then return the final response of the operation.
        /// </remarks>
        public virtual Response WaitForCompletionResponse(CancellationToken cancellationToken = default)
        {
            OperationPoller poller = new OperationPoller();
            return poller.WaitForCompletionResponse(this, null, cancellationToken);
        }

        /// <summary>
        /// Periodically calls the server till the long-running operation completes.
        /// </summary>
        /// <param name="pollingInterval">
        /// The interval between status requests to the server.
        /// The interval can change based on information returned from the server.
        /// For example, the server might communicate to the client that there is not reason to poll for status change sooner than some time.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the periodical service calls.</param>
        /// <returns>The last HTTP response received from the server.</returns>
        /// <remarks>
        /// This method will periodically call UpdateStatusAsync till HasCompleted is true, then return the final response of the operation.
        /// </remarks>
        public virtual Response WaitForCompletionResponse(TimeSpan pollingInterval, CancellationToken cancellationToken = default)
        {
            OperationPoller poller = new OperationPoller();
            return poller.WaitForCompletionResponse(this, pollingInterval, cancellationToken);
        }

        /// <summary>
        /// Periodically calls the server till the long-running operation completes.
        /// </summary>
        /// <param name="delayStrategy">
        /// The strategy to use to determine the delay between status requests to the server. If the server returns retry-after header,
        /// the delay used will be the maximum specified by the strategy and the header value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the periodical service calls.</param>
        /// <returns>The last HTTP response received from the server.</returns>
        /// <remarks>
        /// This method will periodically call UpdateStatusAsync till HasCompleted is true, then return the final response of the operation.
        /// </remarks>
        public virtual Response WaitForCompletionResponse(DelayStrategy delayStrategy, CancellationToken cancellationToken = default)
        {
            OperationPoller poller = new OperationPoller(delayStrategy);
            return poller.WaitForCompletionResponse(this, default, cancellationToken);
        }

        internal static T GetValue<T>(ref T value) where T : class
        {
            if (value is null)
            {
                throw new InvalidOperationException("The operation has not completed yet.");
            }

            return value;
        }

        internal static T GetValue<T>(ref T? value) where T : struct
        {
            if (value == null)
            {
                throw new InvalidOperationException("The operation has not completed yet.");
            }

            return value.Value;
        }

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();

        private static void AssertNotNull<T>(T value, string name)
        {
            if (value is null)
            {
                throw new ArgumentNullException(name);
            }
        }
    }
}
