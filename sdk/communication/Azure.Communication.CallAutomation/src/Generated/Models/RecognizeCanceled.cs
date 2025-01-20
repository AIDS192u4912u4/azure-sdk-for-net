// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The RecognizeCanceled. </summary>
    public partial class RecognizeCanceled
    {
        /// <summary> Initializes a new instance of <see cref="RecognizeCanceled"/>. </summary>
        internal RecognizeCanceled()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecognizeCanceled"/>. </summary>
        /// <param name="operationContext"></param>
        /// <param name="resultInformation"> Contains the resulting SIP code/sub-code and message from NGC services. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        internal RecognizeCanceled(string operationContext, ResultInformation resultInformation, string callConnectionId, string serverCallId, string correlationId)
        {
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
        }
    }
}
