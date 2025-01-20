﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using System.Text.Json;

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// The Recognize failed event.
    /// </summary>
    [CodeGenModel("RecognizeFailed", Usage = new string[] { "output" }, Formats = new string[] { "json" })]
    public partial class RecognizeFailed : CallAutomationEventBase
    {
        /// <summary>
        /// Reason code.
        /// </summary>
        public MediaEventReasonCode ReasonCode { get; internal set; }

        /// <summary> Initializes a new instance of <see cref="RecognizeFailed"/>. </summary>
        /// <param name="operationContext"></param>
        /// <param name="resultInformation"></param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        internal RecognizeFailed(string operationContext, ResultInformation resultInformation, string callConnectionId, string serverCallId, string correlationId)
        {
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            ReasonCode = new MediaEventReasonCode(resultInformation.SubCode.ToString());
        }

        /// <summary>
        /// Deserialize <see cref="RecognizeFailed"/> event.
        /// </summary>
        /// <param name="content">The json content.</param>
        /// <returns>The new <see cref="RecognizeFailed"/> object.</returns>
        public static RecognizeFailed Deserialize(string content)
        {
            using var document = JsonDocument.Parse(content);
            JsonElement element = document.RootElement;

            return DeserializeRecognizeFailed(element);
        }
    }
}
