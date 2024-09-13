// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Model for authentication with the API Key. Will result in additional header on the request (default behavior) to the remote server: 'ApiKeyName: ApiKeyIdentifier ApiKey'. If 'IsApiKeyInPostPayload' is true it will send it in the body of the request and not the header. </summary>
    public partial class SecurityInsightsApiKeyAuthModel : CcpAuthConfig
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsApiKeyAuthModel"/>. </summary>
        /// <param name="apiKey"> API Key for the user secret key credential. </param>
        /// <param name="apiKeyName"> API Key name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiKey"/> or <paramref name="apiKeyName"/> is null. </exception>
        public SecurityInsightsApiKeyAuthModel(string apiKey, string apiKeyName)
        {
            Argument.AssertNotNull(apiKey, nameof(apiKey));
            Argument.AssertNotNull(apiKeyName, nameof(apiKeyName));

            ApiKey = apiKey;
            ApiKeyName = apiKeyName;
            AuthType = CcpAuthType.APIKey;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsApiKeyAuthModel"/>. </summary>
        /// <param name="authType"> The auth type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="apiKey"> API Key for the user secret key credential. </param>
        /// <param name="apiKeyName"> API Key name. </param>
        /// <param name="apiKeyIdentifier"> API Key Identifier. </param>
        /// <param name="isApiKeyInPostPayload"> Flag to indicate if API key is set in HTTP POST payload. </param>
        internal SecurityInsightsApiKeyAuthModel(CcpAuthType authType, IDictionary<string, BinaryData> serializedAdditionalRawData, string apiKey, string apiKeyName, string apiKeyIdentifier, bool? isApiKeyInPostPayload) : base(authType, serializedAdditionalRawData)
        {
            ApiKey = apiKey;
            ApiKeyName = apiKeyName;
            ApiKeyIdentifier = apiKeyIdentifier;
            IsApiKeyInPostPayload = isApiKeyInPostPayload;
            AuthType = authType;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsApiKeyAuthModel"/> for deserialization. </summary>
        internal SecurityInsightsApiKeyAuthModel()
        {
        }

        /// <summary> API Key for the user secret key credential. </summary>
        [WirePath("apiKey")]
        public string ApiKey { get; set; }
        /// <summary> API Key name. </summary>
        [WirePath("apiKeyName")]
        public string ApiKeyName { get; set; }
        /// <summary> API Key Identifier. </summary>
        [WirePath("apiKeyIdentifier")]
        public string ApiKeyIdentifier { get; set; }
        /// <summary> Flag to indicate if API key is set in HTTP POST payload. </summary>
        [WirePath("isApiKeyInPostPayload")]
        public bool? IsApiKeyInPostPayload { get; set; }
    }
}
