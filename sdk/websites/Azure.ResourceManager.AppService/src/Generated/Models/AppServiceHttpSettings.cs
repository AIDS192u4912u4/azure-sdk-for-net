// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the HTTP requests for authentication and authorization requests made against App Service Authentication/Authorization. </summary>
    public partial class AppServiceHttpSettings
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceHttpSettings"/>. </summary>
        public AppServiceHttpSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceHttpSettings"/>. </summary>
        /// <param name="isHttpsRequired"> &lt;code&gt;false&lt;/code&gt; if the authentication/authorization responses not having the HTTPS scheme are permissible; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="routes"> The configuration settings of the paths HTTP requests. </param>
        /// <param name="forwardProxy"> The configuration settings of a forward proxy used to make the requests. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceHttpSettings(bool? isHttpsRequired, AppServiceHttpSettingsRoutes routes, AppServiceForwardProxy forwardProxy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsHttpsRequired = isHttpsRequired;
            Routes = routes;
            ForwardProxy = forwardProxy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the authentication/authorization responses not having the HTTPS scheme are permissible; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? IsHttpsRequired { get; set; }
        /// <summary> The configuration settings of the paths HTTP requests. </summary>
        internal AppServiceHttpSettingsRoutes Routes { get; set; }
        /// <summary> The prefix that should precede all the authentication/authorization paths. </summary>
        public string RoutesApiPrefix
        {
            get => Routes is null ? default : Routes.ApiPrefix;
            set
            {
                if (Routes is null)
                    Routes = new AppServiceHttpSettingsRoutes();
                Routes.ApiPrefix = value;
            }
        }

        /// <summary> The configuration settings of a forward proxy used to make the requests. </summary>
        public AppServiceForwardProxy ForwardProxy { get; set; }
    }
}
