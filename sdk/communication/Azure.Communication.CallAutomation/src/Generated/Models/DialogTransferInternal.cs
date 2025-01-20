// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The DialogTransfer. </summary>
    internal partial class DialogTransferInternal
    {
        /// <summary> Initializes a new instance of <see cref="DialogTransferInternal"/>. </summary>
        internal DialogTransferInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DialogTransferInternal"/>. </summary>
        /// <param name="transferType"></param>
        /// <param name="transferDestination"></param>
        /// <param name="operationContext"></param>
        /// <param name="resultInformation"></param>
        /// <param name="dialogInputType"> Determines the type of the dialog. </param>
        /// <param name="dialogId"></param>
        /// <param name="ivrContext"> Any object. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        internal DialogTransferInternal(string transferType, string transferDestination, string operationContext, ResultInformation resultInformation, DialogInputType? dialogInputType, string dialogId, object ivrContext, string callConnectionId, string serverCallId, string correlationId)
        {
            TransferType = transferType;
            TransferDestination = transferDestination;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            DialogInputType = dialogInputType;
            DialogId = dialogId;
            IvrContext = ivrContext;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
        }

        /// <summary> Gets the transfer type. </summary>
        public string TransferType { get; }
        /// <summary> Gets the transfer destination. </summary>
        public string TransferDestination { get; }
        /// <summary> Gets the operation context. </summary>
        public string OperationContext { get; }
        /// <summary> Gets the result information. </summary>
        public ResultInformation ResultInformation { get; }
        /// <summary> Determines the type of the dialog. </summary>
        public DialogInputType? DialogInputType { get; }
        /// <summary> Gets the dialog id. </summary>
        public string DialogId { get; }
        /// <summary> Any object. </summary>
        public object IvrContext { get; }
        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
    }
}
