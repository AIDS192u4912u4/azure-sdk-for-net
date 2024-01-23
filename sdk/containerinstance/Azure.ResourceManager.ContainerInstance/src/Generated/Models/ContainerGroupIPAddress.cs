// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> IP address for the container group. </summary>
    public partial class ContainerGroupIPAddress
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

        /// <summary> Initializes a new instance of <see cref="ContainerGroupIPAddress"/>. </summary>
        /// <param name="ports"> The list of ports exposed on the container group. </param>
        /// <param name="addressType"> Specifies if the IP is exposed to the public internet or private VNET. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ports"/> is null. </exception>
        public ContainerGroupIPAddress(IEnumerable<ContainerGroupPort> ports, ContainerGroupIPAddressType addressType)
        {
            Argument.AssertNotNull(ports, nameof(ports));

            Ports = ports.ToList();
            AddressType = addressType;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupIPAddress"/>. </summary>
        /// <param name="ports"> The list of ports exposed on the container group. </param>
        /// <param name="addressType"> Specifies if the IP is exposed to the public internet or private VNET. </param>
        /// <param name="ip"> The IP exposed to the public internet. </param>
        /// <param name="dnsNameLabel"> The Dns name label for the IP. </param>
        /// <param name="autoGeneratedDomainNameLabelScope"> The value representing the security enum. The 'Unsecure' value is the default value if not selected and means the object's domain name label is not secured against subdomain takeover. The 'TenantReuse' value is the default value if selected and means the object's domain name label can be reused within the same tenant. The 'SubscriptionReuse' value means the object's domain name label can be reused within the same subscription. The 'ResourceGroupReuse' value means the object's domain name label can be reused within the same resource group. The 'NoReuse' value means the object's domain name label cannot be reused within the same resource group, subscription, or tenant. </param>
        /// <param name="fqdn"> The FQDN for the IP. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerGroupIPAddress(IList<ContainerGroupPort> ports, ContainerGroupIPAddressType addressType, IPAddress ip, string dnsNameLabel, DnsNameLabelReusePolicy? autoGeneratedDomainNameLabelScope, string fqdn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Ports = ports;
            AddressType = addressType;
            IP = ip;
            DnsNameLabel = dnsNameLabel;
            AutoGeneratedDomainNameLabelScope = autoGeneratedDomainNameLabelScope;
            Fqdn = fqdn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupIPAddress"/> for deserialization. </summary>
        internal ContainerGroupIPAddress()
        {
        }

        /// <summary> The list of ports exposed on the container group. </summary>
        public IList<ContainerGroupPort> Ports { get; }
        /// <summary> Specifies if the IP is exposed to the public internet or private VNET. </summary>
        public ContainerGroupIPAddressType AddressType { get; set; }
        /// <summary> The IP exposed to the public internet. </summary>
        public IPAddress IP { get; set; }
        /// <summary> The Dns name label for the IP. </summary>
        public string DnsNameLabel { get; set; }
        /// <summary> The value representing the security enum. The 'Unsecure' value is the default value if not selected and means the object's domain name label is not secured against subdomain takeover. The 'TenantReuse' value is the default value if selected and means the object's domain name label can be reused within the same tenant. The 'SubscriptionReuse' value means the object's domain name label can be reused within the same subscription. The 'ResourceGroupReuse' value means the object's domain name label can be reused within the same resource group. The 'NoReuse' value means the object's domain name label cannot be reused within the same resource group, subscription, or tenant. </summary>
        public DnsNameLabelReusePolicy? AutoGeneratedDomainNameLabelScope { get; set; }
        /// <summary> The FQDN for the IP. </summary>
        public string Fqdn { get; }
    }
}
