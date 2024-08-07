// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;

namespace Azure.Messaging.EventGrid.Namespaces
{
    /// <summary> Model factory for models. </summary>
    public static partial class EventGridNamespacesModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Namespaces.AcknowledgeResult"/>. </summary>
        /// <param name="failedLockTokens"> Array of FailedLockToken for failed cloud events. Each FailedLockToken includes the lock token along with the related error information (namely, the error code and description). </param>
        /// <param name="succeededLockTokens"> Array of lock tokens for the successfully acknowledged cloud events. </param>
        /// <returns> A new <see cref="Namespaces.AcknowledgeResult"/> instance for mocking. </returns>
        public static AcknowledgeResult AcknowledgeResult(IEnumerable<FailedLockToken> failedLockTokens = null, IEnumerable<string> succeededLockTokens = null)
        {
            failedLockTokens ??= new List<FailedLockToken>();
            succeededLockTokens ??= new List<string>();

            return new AcknowledgeResult(failedLockTokens?.ToList(), succeededLockTokens?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Namespaces.FailedLockToken"/>. </summary>
        /// <param name="lockToken"> The lock token of an entry in the request. </param>
        /// <param name="error"> Error information of the failed operation result for the lock token in the request. </param>
        /// <returns> A new <see cref="Namespaces.FailedLockToken"/> instance for mocking. </returns>
        public static FailedLockToken FailedLockToken(string lockToken = null, ResponseError error = null)
        {
            return new FailedLockToken(lockToken, error, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Namespaces.ReleaseResult"/>. </summary>
        /// <param name="failedLockTokens"> Array of FailedLockToken for failed cloud events. Each FailedLockToken includes the lock token along with the related error information (namely, the error code and description). </param>
        /// <param name="succeededLockTokens"> Array of lock tokens for the successfully released cloud events. </param>
        /// <returns> A new <see cref="Namespaces.ReleaseResult"/> instance for mocking. </returns>
        public static ReleaseResult ReleaseResult(IEnumerable<FailedLockToken> failedLockTokens = null, IEnumerable<string> succeededLockTokens = null)
        {
            failedLockTokens ??= new List<FailedLockToken>();
            succeededLockTokens ??= new List<string>();

            return new ReleaseResult(failedLockTokens?.ToList(), succeededLockTokens?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Namespaces.RejectResult"/>. </summary>
        /// <param name="failedLockTokens"> Array of FailedLockToken for failed cloud events. Each FailedLockToken includes the lock token along with the related error information (namely, the error code and description). </param>
        /// <param name="succeededLockTokens"> Array of lock tokens for the successfully rejected cloud events. </param>
        /// <returns> A new <see cref="Namespaces.RejectResult"/> instance for mocking. </returns>
        public static RejectResult RejectResult(IEnumerable<FailedLockToken> failedLockTokens = null, IEnumerable<string> succeededLockTokens = null)
        {
            failedLockTokens ??= new List<FailedLockToken>();
            succeededLockTokens ??= new List<string>();

            return new RejectResult(failedLockTokens?.ToList(), succeededLockTokens?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Namespaces.RenewLocksResult"/>. </summary>
        /// <param name="failedLockTokens"> Array of FailedLockToken for failed cloud events. Each FailedLockToken includes the lock token along with the related error information (namely, the error code and description). </param>
        /// <param name="succeededLockTokens"> Array of lock tokens for the successfully renewed locks. </param>
        /// <returns> A new <see cref="Namespaces.RenewLocksResult"/> instance for mocking. </returns>
        public static RenewLocksResult RenewLocksResult(IEnumerable<FailedLockToken> failedLockTokens = null, IEnumerable<string> succeededLockTokens = null)
        {
            failedLockTokens ??= new List<FailedLockToken>();
            succeededLockTokens ??= new List<string>();

            return new RenewLocksResult(failedLockTokens?.ToList(), succeededLockTokens?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Namespaces.ReceiveResult"/>. </summary>
        /// <param name="details"> Array of receive responses, one per cloud event. </param>
        /// <returns> A new <see cref="Namespaces.ReceiveResult"/> instance for mocking. </returns>
        public static ReceiveResult ReceiveResult(IEnumerable<ReceiveDetails> details = null)
        {
            details ??= new List<ReceiveDetails>();

            return new ReceiveResult(details?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Namespaces.ReceiveDetails"/>. </summary>
        /// <param name="brokerProperties"> The Event Broker details. </param>
        /// <param name="event"> Cloud Event details. </param>
        /// <returns> A new <see cref="Namespaces.ReceiveDetails"/> instance for mocking. </returns>
        public static ReceiveDetails ReceiveDetails(BrokerProperties brokerProperties = null, CloudEvent @event = null)
        {
            return new ReceiveDetails(brokerProperties, @event, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Namespaces.BrokerProperties"/>. </summary>
        /// <param name="lockToken"> The token of the lock on the event. </param>
        /// <param name="deliveryCount"> The attempt count for delivering the event. </param>
        /// <returns> A new <see cref="Namespaces.BrokerProperties"/> instance for mocking. </returns>
        public static BrokerProperties BrokerProperties(string lockToken = null, int deliveryCount = default)
        {
            return new BrokerProperties(lockToken, deliveryCount, serializedAdditionalRawData: null);
        }
    }
}
