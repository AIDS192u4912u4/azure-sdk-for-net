// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the ApplicationGateway data model.
    /// Application gateway resource.
    /// </summary>
    public partial class ApplicationGatewayData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of ApplicationGatewayData. </summary>
        public ApplicationGatewayData()
        {
            AvailabilityZones = new ChangeTrackingList<string>();
            GatewayIPConfigurations = new ChangeTrackingList<ApplicationGatewayIPConfiguration>();
            AuthenticationCertificates = new ChangeTrackingList<ApplicationGatewayAuthenticationCertificate>();
            TrustedRootCertificates = new ChangeTrackingList<ApplicationGatewayTrustedRootCertificate>();
            TrustedClientCertificates = new ChangeTrackingList<ApplicationGatewayTrustedClientCertificate>();
            SslCertificates = new ChangeTrackingList<ApplicationGatewaySslCertificate>();
            FrontendIPConfigurations = new ChangeTrackingList<ApplicationGatewayFrontendIPConfiguration>();
            FrontendPorts = new ChangeTrackingList<ApplicationGatewayFrontendPort>();
            Probes = new ChangeTrackingList<ApplicationGatewayProbe>();
            BackendAddressPools = new ChangeTrackingList<ApplicationGatewayBackendAddressPool>();
            BackendHttpSettingsCollection = new ChangeTrackingList<ApplicationGatewayBackendHttpSettings>();
            BackendSettingsCollection = new ChangeTrackingList<ApplicationGatewayBackendSettings>();
            HttpListeners = new ChangeTrackingList<ApplicationGatewayHttpListener>();
            Listeners = new ChangeTrackingList<ApplicationGatewayListener>();
            SslProfiles = new ChangeTrackingList<ApplicationGatewaySslProfile>();
            UrlPathMaps = new ChangeTrackingList<ApplicationGatewayUrlPathMap>();
            RequestRoutingRules = new ChangeTrackingList<ApplicationGatewayRequestRoutingRule>();
            RoutingRules = new ChangeTrackingList<ApplicationGatewayRoutingRule>();
            RewriteRuleSets = new ChangeTrackingList<ApplicationGatewayRewriteRuleSet>();
            RedirectConfigurations = new ChangeTrackingList<ApplicationGatewayRedirectConfiguration>();
            PrivateLinkConfigurations = new ChangeTrackingList<ApplicationGatewayPrivateLinkConfiguration>();
            PrivateEndpointConnections = new ChangeTrackingList<ApplicationGatewayPrivateEndpointConnectionData>();
            CustomErrorConfigurations = new ChangeTrackingList<ApplicationGatewayCustomError>();
            LoadDistributionPolicies = new ChangeTrackingList<ApplicationGatewayLoadDistributionPolicy>();
        }

        /// <summary> Initializes a new instance of ApplicationGatewayData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="availabilityZones"> A list of availability zones denoting where the resource needs to come from. </param>
        /// <param name="identity"> The identity of the application gateway, if configured. </param>
        /// <param name="sku"> SKU of the application gateway resource. </param>
        /// <param name="sslPolicy"> SSL policy of the application gateway resource. </param>
        /// <param name="operationalState"> Operational state of the application gateway resource. </param>
        /// <param name="gatewayIPConfigurations"> Subnets of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </param>
        /// <param name="authenticationCertificates"> Authentication certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </param>
        /// <param name="trustedRootCertificates"> Trusted Root certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </param>
        /// <param name="trustedClientCertificates"> Trusted client certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </param>
        /// <param name="sslCertificates"> SSL certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </param>
        /// <param name="frontendIPConfigurations"> Frontend IP addresses of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </param>
        /// <param name="frontendPorts"> Frontend ports of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </param>
        /// <param name="probes"> Probes of the application gateway resource. </param>
        /// <param name="backendAddressPools"> Backend address pool of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </param>
        /// <param name="backendHttpSettingsCollection"> Backend http settings of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </param>
        /// <param name="backendSettingsCollection"> Backend settings of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </param>
        /// <param name="httpListeners"> Http listeners of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </param>
        /// <param name="listeners"> Listeners of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </param>
        /// <param name="sslProfiles"> SSL profiles of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </param>
        /// <param name="urlPathMaps"> URL path map of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </param>
        /// <param name="requestRoutingRules"> Request routing rules of the application gateway resource. </param>
        /// <param name="routingRules"> Routing rules of the application gateway resource. </param>
        /// <param name="rewriteRuleSets"> Rewrite rules for the application gateway resource. </param>
        /// <param name="redirectConfigurations"> Redirect configurations of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </param>
        /// <param name="webApplicationFirewallConfiguration"> Web application firewall configuration. </param>
        /// <param name="firewallPolicy"> Reference to the FirewallPolicy resource. </param>
        /// <param name="enableHttp2"> Whether HTTP2 is enabled on the application gateway resource. </param>
        /// <param name="enableFips"> Whether FIPS is enabled on the application gateway resource. </param>
        /// <param name="autoscaleConfiguration"> Autoscale Configuration. </param>
        /// <param name="privateLinkConfigurations"> PrivateLink configurations on application gateway. </param>
        /// <param name="privateEndpointConnections"> Private Endpoint connections on application gateway. </param>
        /// <param name="resourceGuid"> The resource GUID property of the application gateway resource. </param>
        /// <param name="provisioningState"> The provisioning state of the application gateway resource. </param>
        /// <param name="customErrorConfigurations"> Custom error configurations of the application gateway resource. </param>
        /// <param name="forceFirewallPolicyAssociation"> If true, associates a firewall policy with an application gateway regardless whether the policy differs from the WAF Config. </param>
        /// <param name="loadDistributionPolicies"> Load distribution policies of the application gateway resource. </param>
        /// <param name="globalConfiguration"> Global Configuration. </param>
        /// <param name="defaultPredefinedSslPolicy"> The default predefined SSL Policy applied on the application gateway resource. </param>
        internal ApplicationGatewayData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ETag? etag, IList<string> availabilityZones, ManagedServiceIdentity identity, ApplicationGatewaySku sku, ApplicationGatewaySslPolicy sslPolicy, ApplicationGatewayOperationalState? operationalState, IList<ApplicationGatewayIPConfiguration> gatewayIPConfigurations, IList<ApplicationGatewayAuthenticationCertificate> authenticationCertificates, IList<ApplicationGatewayTrustedRootCertificate> trustedRootCertificates, IList<ApplicationGatewayTrustedClientCertificate> trustedClientCertificates, IList<ApplicationGatewaySslCertificate> sslCertificates, IList<ApplicationGatewayFrontendIPConfiguration> frontendIPConfigurations, IList<ApplicationGatewayFrontendPort> frontendPorts, IList<ApplicationGatewayProbe> probes, IList<ApplicationGatewayBackendAddressPool> backendAddressPools, IList<ApplicationGatewayBackendHttpSettings> backendHttpSettingsCollection, IList<ApplicationGatewayBackendSettings> backendSettingsCollection, IList<ApplicationGatewayHttpListener> httpListeners, IList<ApplicationGatewayListener> listeners, IList<ApplicationGatewaySslProfile> sslProfiles, IList<ApplicationGatewayUrlPathMap> urlPathMaps, IList<ApplicationGatewayRequestRoutingRule> requestRoutingRules, IList<ApplicationGatewayRoutingRule> routingRules, IList<ApplicationGatewayRewriteRuleSet> rewriteRuleSets, IList<ApplicationGatewayRedirectConfiguration> redirectConfigurations, ApplicationGatewayWebApplicationFirewallConfiguration webApplicationFirewallConfiguration, WritableSubResource firewallPolicy, bool? enableHttp2, bool? enableFips, ApplicationGatewayAutoscaleConfiguration autoscaleConfiguration, IList<ApplicationGatewayPrivateLinkConfiguration> privateLinkConfigurations, IReadOnlyList<ApplicationGatewayPrivateEndpointConnectionData> privateEndpointConnections, Guid? resourceGuid, NetworkProvisioningState? provisioningState, IList<ApplicationGatewayCustomError> customErrorConfigurations, bool? forceFirewallPolicyAssociation, IList<ApplicationGatewayLoadDistributionPolicy> loadDistributionPolicies, ApplicationGatewayGlobalConfiguration globalConfiguration, ApplicationGatewaySslPolicyName? defaultPredefinedSslPolicy) : base(id, name, resourceType, location, tags)
        {
            ETag = etag;
            AvailabilityZones = availabilityZones;
            Identity = identity;
            Sku = sku;
            SslPolicy = sslPolicy;
            OperationalState = operationalState;
            GatewayIPConfigurations = gatewayIPConfigurations;
            AuthenticationCertificates = authenticationCertificates;
            TrustedRootCertificates = trustedRootCertificates;
            TrustedClientCertificates = trustedClientCertificates;
            SslCertificates = sslCertificates;
            FrontendIPConfigurations = frontendIPConfigurations;
            FrontendPorts = frontendPorts;
            Probes = probes;
            BackendAddressPools = backendAddressPools;
            BackendHttpSettingsCollection = backendHttpSettingsCollection;
            BackendSettingsCollection = backendSettingsCollection;
            HttpListeners = httpListeners;
            Listeners = listeners;
            SslProfiles = sslProfiles;
            UrlPathMaps = urlPathMaps;
            RequestRoutingRules = requestRoutingRules;
            RoutingRules = routingRules;
            RewriteRuleSets = rewriteRuleSets;
            RedirectConfigurations = redirectConfigurations;
            WebApplicationFirewallConfiguration = webApplicationFirewallConfiguration;
            FirewallPolicy = firewallPolicy;
            EnableHttp2 = enableHttp2;
            EnableFips = enableFips;
            AutoscaleConfiguration = autoscaleConfiguration;
            PrivateLinkConfigurations = privateLinkConfigurations;
            PrivateEndpointConnections = privateEndpointConnections;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            CustomErrorConfigurations = customErrorConfigurations;
            ForceFirewallPolicyAssociation = forceFirewallPolicyAssociation;
            LoadDistributionPolicies = loadDistributionPolicies;
            GlobalConfiguration = globalConfiguration;
            DefaultPredefinedSslPolicy = defaultPredefinedSslPolicy;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> A list of availability zones denoting where the resource needs to come from. </summary>
        public IList<string> AvailabilityZones { get; }
        /// <summary> The identity of the application gateway, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> SKU of the application gateway resource. </summary>
        public ApplicationGatewaySku Sku { get; set; }
        /// <summary> SSL policy of the application gateway resource. </summary>
        public ApplicationGatewaySslPolicy SslPolicy { get; set; }
        /// <summary> Operational state of the application gateway resource. </summary>
        public ApplicationGatewayOperationalState? OperationalState { get; }
        /// <summary> Subnets of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </summary>
        public IList<ApplicationGatewayIPConfiguration> GatewayIPConfigurations { get; }
        /// <summary> Authentication certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </summary>
        public IList<ApplicationGatewayAuthenticationCertificate> AuthenticationCertificates { get; }
        /// <summary> Trusted Root certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </summary>
        public IList<ApplicationGatewayTrustedRootCertificate> TrustedRootCertificates { get; }
        /// <summary> Trusted client certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </summary>
        public IList<ApplicationGatewayTrustedClientCertificate> TrustedClientCertificates { get; }
        /// <summary> SSL certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </summary>
        public IList<ApplicationGatewaySslCertificate> SslCertificates { get; }
        /// <summary> Frontend IP addresses of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </summary>
        public IList<ApplicationGatewayFrontendIPConfiguration> FrontendIPConfigurations { get; }
        /// <summary> Frontend ports of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </summary>
        public IList<ApplicationGatewayFrontendPort> FrontendPorts { get; }
        /// <summary> Probes of the application gateway resource. </summary>
        public IList<ApplicationGatewayProbe> Probes { get; }
        /// <summary> Backend address pool of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </summary>
        public IList<ApplicationGatewayBackendAddressPool> BackendAddressPools { get; }
        /// <summary> Backend http settings of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </summary>
        public IList<ApplicationGatewayBackendHttpSettings> BackendHttpSettingsCollection { get; }
        /// <summary> Backend settings of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </summary>
        public IList<ApplicationGatewayBackendSettings> BackendSettingsCollection { get; }
        /// <summary> Http listeners of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </summary>
        public IList<ApplicationGatewayHttpListener> HttpListeners { get; }
        /// <summary> Listeners of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </summary>
        public IList<ApplicationGatewayListener> Listeners { get; }
        /// <summary> SSL profiles of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </summary>
        public IList<ApplicationGatewaySslProfile> SslProfiles { get; }
        /// <summary> URL path map of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </summary>
        public IList<ApplicationGatewayUrlPathMap> UrlPathMaps { get; }
        /// <summary> Request routing rules of the application gateway resource. </summary>
        public IList<ApplicationGatewayRequestRoutingRule> RequestRoutingRules { get; }
        /// <summary> Routing rules of the application gateway resource. </summary>
        public IList<ApplicationGatewayRoutingRule> RoutingRules { get; }
        /// <summary> Rewrite rules for the application gateway resource. </summary>
        public IList<ApplicationGatewayRewriteRuleSet> RewriteRuleSets { get; }
        /// <summary> Redirect configurations of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits). </summary>
        public IList<ApplicationGatewayRedirectConfiguration> RedirectConfigurations { get; }
        /// <summary> Web application firewall configuration. </summary>
        public ApplicationGatewayWebApplicationFirewallConfiguration WebApplicationFirewallConfiguration { get; set; }
        /// <summary> Reference to the FirewallPolicy resource. </summary>
        internal WritableSubResource FirewallPolicy { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier FirewallPolicyId
        {
            get => FirewallPolicy is null ? default : FirewallPolicy.Id;
            set
            {
                if (FirewallPolicy is null)
                    FirewallPolicy = new WritableSubResource();
                FirewallPolicy.Id = value;
            }
        }

        /// <summary> Whether HTTP2 is enabled on the application gateway resource. </summary>
        public bool? EnableHttp2 { get; set; }
        /// <summary> Whether FIPS is enabled on the application gateway resource. </summary>
        public bool? EnableFips { get; set; }
        /// <summary> Autoscale Configuration. </summary>
        public ApplicationGatewayAutoscaleConfiguration AutoscaleConfiguration { get; set; }
        /// <summary> PrivateLink configurations on application gateway. </summary>
        public IList<ApplicationGatewayPrivateLinkConfiguration> PrivateLinkConfigurations { get; }
        /// <summary> Private Endpoint connections on application gateway. </summary>
        public IReadOnlyList<ApplicationGatewayPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> The resource GUID property of the application gateway resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> The provisioning state of the application gateway resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Custom error configurations of the application gateway resource. </summary>
        public IList<ApplicationGatewayCustomError> CustomErrorConfigurations { get; }
        /// <summary> If true, associates a firewall policy with an application gateway regardless whether the policy differs from the WAF Config. </summary>
        public bool? ForceFirewallPolicyAssociation { get; set; }
        /// <summary> Load distribution policies of the application gateway resource. </summary>
        public IList<ApplicationGatewayLoadDistributionPolicy> LoadDistributionPolicies { get; }
        /// <summary> Global Configuration. </summary>
        public ApplicationGatewayGlobalConfiguration GlobalConfiguration { get; set; }
        /// <summary> The default predefined SSL Policy applied on the application gateway resource. </summary>
        public ApplicationGatewaySslPolicyName? DefaultPredefinedSslPolicy { get; }
    }
}
