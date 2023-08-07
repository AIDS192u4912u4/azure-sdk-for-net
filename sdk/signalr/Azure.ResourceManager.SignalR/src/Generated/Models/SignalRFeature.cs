// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Feature of a resource, which controls the runtime behavior. </summary>
    public partial class SignalRFeature
    {
        /// <summary> Initializes a new instance of SignalRFeature. </summary>
        /// <param name="flag">
        /// FeatureFlags is the supported features of Azure SignalR service.
        /// - ServiceMode: Flag for backend server for SignalR service. Values allowed: "Default": have your own backend server; "Serverless": your application doesn't have a backend server; "Classic": for backward compatibility. Support both Default and Serverless mode but not recommended; "PredefinedOnly": for future use.
        /// - EnableConnectivityLogs: "true"/"false", to enable/disable the connectivity log category respectively.
        /// - EnableMessagingLogs: "true"/"false", to enable/disable the connectivity log category respectively.
        /// - EnableLiveTrace: Live Trace allows you to know what's happening inside Azure SignalR service, it will give you live traces in real time, it will be helpful when you developing your own Azure SignalR based web application or self-troubleshooting some issues. Please note that live traces are counted as outbound messages that will be charged. Values allowed: "true"/"false", to enable/disable live trace feature.
        /// </param>
        /// <param name="value"> Value of the feature flag. See Azure SignalR service document https://docs.microsoft.com/azure/azure-signalr/ for allowed values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SignalRFeature(SignalRFeatureFlag flag, string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Flag = flag;
            Value = value;
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of SignalRFeature. </summary>
        /// <param name="flag">
        /// FeatureFlags is the supported features of Azure SignalR service.
        /// - ServiceMode: Flag for backend server for SignalR service. Values allowed: "Default": have your own backend server; "Serverless": your application doesn't have a backend server; "Classic": for backward compatibility. Support both Default and Serverless mode but not recommended; "PredefinedOnly": for future use.
        /// - EnableConnectivityLogs: "true"/"false", to enable/disable the connectivity log category respectively.
        /// - EnableMessagingLogs: "true"/"false", to enable/disable the connectivity log category respectively.
        /// - EnableLiveTrace: Live Trace allows you to know what's happening inside Azure SignalR service, it will give you live traces in real time, it will be helpful when you developing your own Azure SignalR based web application or self-troubleshooting some issues. Please note that live traces are counted as outbound messages that will be charged. Values allowed: "true"/"false", to enable/disable live trace feature.
        /// </param>
        /// <param name="value"> Value of the feature flag. See Azure SignalR service document https://docs.microsoft.com/azure/azure-signalr/ for allowed values. </param>
        /// <param name="properties"> Optional properties related to this feature. </param>
        internal SignalRFeature(SignalRFeatureFlag flag, string value, IDictionary<string, string> properties)
        {
            Flag = flag;
            Value = value;
            Properties = properties;
        }

        /// <summary>
        /// FeatureFlags is the supported features of Azure SignalR service.
        /// - ServiceMode: Flag for backend server for SignalR service. Values allowed: "Default": have your own backend server; "Serverless": your application doesn't have a backend server; "Classic": for backward compatibility. Support both Default and Serverless mode but not recommended; "PredefinedOnly": for future use.
        /// - EnableConnectivityLogs: "true"/"false", to enable/disable the connectivity log category respectively.
        /// - EnableMessagingLogs: "true"/"false", to enable/disable the connectivity log category respectively.
        /// - EnableLiveTrace: Live Trace allows you to know what's happening inside Azure SignalR service, it will give you live traces in real time, it will be helpful when you developing your own Azure SignalR based web application or self-troubleshooting some issues. Please note that live traces are counted as outbound messages that will be charged. Values allowed: "true"/"false", to enable/disable live trace feature.
        /// </summary>
        public SignalRFeatureFlag Flag { get; set; }
        /// <summary> Value of the feature flag. See Azure SignalR service document https://docs.microsoft.com/azure/azure-signalr/ for allowed values. </summary>
        public string Value { get; set; }
        /// <summary> Optional properties related to this feature. </summary>
        public IDictionary<string, string> Properties { get; }
    }
}
