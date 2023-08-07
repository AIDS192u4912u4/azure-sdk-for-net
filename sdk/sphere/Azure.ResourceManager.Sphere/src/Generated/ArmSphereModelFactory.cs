// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sphere;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmSphereModelFactory
    {
        /// <summary> Initializes a new instance of SphereCatalogData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState">
        /// The status of the last operation.
        /// Serialized Name: Catalog.properties.provisioningState
        /// </param>
        /// <returns> A new <see cref="Sphere.SphereCatalogData"/> instance for mocking. </returns>
        public static SphereCatalogData SphereCatalogData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, SphereProvisioningState? provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();

            return new SphereCatalogData(id, name, resourceType, systemData, tags, location, provisioningState);
        }

        /// <summary> Initializes a new instance of SphereCertificateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="certificate">
        /// The certificate as a UTF-8 encoded base 64 string.
        /// Serialized Name: Certificate.properties.certificate
        /// </param>
        /// <param name="status">
        /// The certificate status.
        /// Serialized Name: Certificate.properties.status
        /// </param>
        /// <param name="subject">
        /// The certificate subject.
        /// Serialized Name: Certificate.properties.subject
        /// </param>
        /// <param name="thumbprint">
        /// The certificate thumbprint.
        /// Serialized Name: Certificate.properties.thumbprint
        /// </param>
        /// <param name="expiryUtc">
        /// The certificate expiry date.
        /// Serialized Name: Certificate.properties.expiryUtc
        /// </param>
        /// <param name="notBeforeUtc">
        /// The certificate not before date.
        /// Serialized Name: Certificate.properties.notBeforeUtc
        /// </param>
        /// <param name="provisioningState">
        /// The status of the last operation.
        /// Serialized Name: Certificate.properties.provisioningState
        /// </param>
        /// <returns> A new <see cref="Sphere.SphereCertificateData"/> instance for mocking. </returns>
        public static SphereCertificateData SphereCertificateData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string certificate = null, SphereCertificateStatus? status = null, string subject = null, string thumbprint = null, DateTimeOffset? expiryUtc = null, DateTimeOffset? notBeforeUtc = null, SphereProvisioningState? provisioningState = null)
        {
            return new SphereCertificateData(id, name, resourceType, systemData, certificate, status, subject, thumbprint, expiryUtc, notBeforeUtc, provisioningState);
        }

        /// <summary> Initializes a new instance of SphereCertificateProperties. </summary>
        /// <param name="certificate">
        /// The certificate as a UTF-8 encoded base 64 string.
        /// Serialized Name: CertificateProperties.certificate
        /// </param>
        /// <param name="status">
        /// The certificate status.
        /// Serialized Name: CertificateProperties.status
        /// </param>
        /// <param name="subject">
        /// The certificate subject.
        /// Serialized Name: CertificateProperties.subject
        /// </param>
        /// <param name="thumbprint">
        /// The certificate thumbprint.
        /// Serialized Name: CertificateProperties.thumbprint
        /// </param>
        /// <param name="expiryUtc">
        /// The certificate expiry date.
        /// Serialized Name: CertificateProperties.expiryUtc
        /// </param>
        /// <param name="notBeforeUtc">
        /// The certificate not before date.
        /// Serialized Name: CertificateProperties.notBeforeUtc
        /// </param>
        /// <param name="provisioningState">
        /// The status of the last operation.
        /// Serialized Name: CertificateProperties.provisioningState
        /// </param>
        /// <returns> A new <see cref="Models.SphereCertificateProperties"/> instance for mocking. </returns>
        public static SphereCertificateProperties SphereCertificateProperties(string certificate = null, SphereCertificateStatus? status = null, string subject = null, string thumbprint = null, DateTimeOffset? expiryUtc = null, DateTimeOffset? notBeforeUtc = null, SphereProvisioningState? provisioningState = null)
        {
            return new SphereCertificateProperties(certificate, status, subject, thumbprint, expiryUtc, notBeforeUtc, provisioningState);
        }

        /// <summary> Initializes a new instance of SphereCertificateChainResult. </summary>
        /// <param name="certificateChain">
        /// The certificate chain.
        /// Serialized Name: CertificateChainResponse.certificateChain
        /// </param>
        /// <returns> A new <see cref="Models.SphereCertificateChainResult"/> instance for mocking. </returns>
        public static SphereCertificateChainResult SphereCertificateChainResult(string certificateChain = null)
        {
            return new SphereCertificateChainResult(certificateChain);
        }

        /// <summary> Initializes a new instance of ProofOfPossessionNonceResponse. </summary>
        /// <param name="certificate">
        /// The certificate as a UTF-8 encoded base 64 string.
        /// Serialized Name: CertificateProperties.certificate
        /// </param>
        /// <param name="status">
        /// The certificate status.
        /// Serialized Name: CertificateProperties.status
        /// </param>
        /// <param name="subject">
        /// The certificate subject.
        /// Serialized Name: CertificateProperties.subject
        /// </param>
        /// <param name="thumbprint">
        /// The certificate thumbprint.
        /// Serialized Name: CertificateProperties.thumbprint
        /// </param>
        /// <param name="expiryUtc">
        /// The certificate expiry date.
        /// Serialized Name: CertificateProperties.expiryUtc
        /// </param>
        /// <param name="notBeforeUtc">
        /// The certificate not before date.
        /// Serialized Name: CertificateProperties.notBeforeUtc
        /// </param>
        /// <param name="provisioningState">
        /// The status of the last operation.
        /// Serialized Name: CertificateProperties.provisioningState
        /// </param>
        /// <returns> A new <see cref="Models.ProofOfPossessionNonceResponse"/> instance for mocking. </returns>
        public static ProofOfPossessionNonceResponse ProofOfPossessionNonceResponse(string certificate = null, SphereCertificateStatus? status = null, string subject = null, string thumbprint = null, DateTimeOffset? expiryUtc = null, DateTimeOffset? notBeforeUtc = null, SphereProvisioningState? provisioningState = null)
        {
            return new ProofOfPossessionNonceResponse(certificate, status, subject, thumbprint, expiryUtc, notBeforeUtc, provisioningState);
        }

        /// <summary> Initializes a new instance of CountDeviceResult. </summary>
        /// <param name="value">
        /// Number of children resources in parent resource.
        /// Serialized Name: CountElementsResponse.value
        /// </param>
        /// <returns> A new <see cref="Models.CountDeviceResult"/> instance for mocking. </returns>
        public static CountDeviceResult CountDeviceResult(int value = default)
        {
            return new CountDeviceResult(value);
        }

        /// <summary> Initializes a new instance of CountElementsResult. </summary>
        /// <param name="value">
        /// Number of children resources in parent resource.
        /// Serialized Name: CountElementsResponse.value
        /// </param>
        /// <returns> A new <see cref="Models.CountElementsResult"/> instance for mocking. </returns>
        public static CountElementsResult CountElementsResult(int value = default)
        {
            return new CountElementsResult(value);
        }

        /// <summary> Initializes a new instance of SphereImageData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="image">
        /// Image as a UTF-8 encoded base 64 string on image create. This field contains the image URI on image reads.
        /// Serialized Name: Image.properties.image
        /// </param>
        /// <param name="imageId">
        /// Image ID
        /// Serialized Name: Image.properties.imageId
        /// </param>
        /// <param name="imageName">
        /// Image name
        /// Serialized Name: Image.properties.imageName
        /// </param>
        /// <param name="regionalDataBoundary">
        /// Regional data boundary for an image
        /// Serialized Name: Image.properties.regionalDataBoundary
        /// </param>
        /// <param name="uri">
        /// Location the image
        /// Serialized Name: Image.properties.uri
        /// </param>
        /// <param name="description">
        /// The image description.
        /// Serialized Name: Image.properties.description
        /// </param>
        /// <param name="componentId">
        /// The image component id.
        /// Serialized Name: Image.properties.componentId
        /// </param>
        /// <param name="imageType">
        /// The image type.
        /// Serialized Name: Image.properties.imageType
        /// </param>
        /// <param name="provisioningState">
        /// The status of the last operation.
        /// Serialized Name: Image.properties.provisioningState
        /// </param>
        /// <returns> A new <see cref="Sphere.SphereImageData"/> instance for mocking. </returns>
        public static SphereImageData SphereImageData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string image = null, string imageId = null, string imageName = null, RegionalDataBoundary? regionalDataBoundary = null, Uri uri = null, string description = null, string componentId = null, SphereImageType? imageType = null, SphereProvisioningState? provisioningState = null)
        {
            return new SphereImageData(id, name, resourceType, systemData, image, imageId, imageName, regionalDataBoundary, uri, description, componentId, imageType, provisioningState);
        }

        /// <summary> Initializes a new instance of SphereDeploymentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="deploymentId">
        /// Deployment ID
        /// Serialized Name: Deployment.properties.deploymentId
        /// </param>
        /// <param name="deployedImages">
        /// Images deployed
        /// Serialized Name: Deployment.properties.deployedImages
        /// </param>
        /// <param name="deploymentDateUtc">
        /// Deployment date UTC
        /// Serialized Name: Deployment.properties.deploymentDateUtc
        /// </param>
        /// <param name="provisioningState">
        /// The status of the last operation.
        /// Serialized Name: Deployment.properties.provisioningState
        /// </param>
        /// <returns> A new <see cref="Sphere.SphereDeploymentData"/> instance for mocking. </returns>
        public static SphereDeploymentData SphereDeploymentData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string deploymentId = null, IEnumerable<SphereImageData> deployedImages = null, DateTimeOffset? deploymentDateUtc = null, SphereProvisioningState? provisioningState = null)
        {
            deployedImages ??= new List<SphereImageData>();

            return new SphereDeploymentData(id, name, resourceType, systemData, deploymentId, deployedImages?.ToList(), deploymentDateUtc, provisioningState);
        }

        /// <summary> Initializes a new instance of SphereDeviceGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description">
        /// Description of the device group.
        /// Serialized Name: DeviceGroup.properties.description
        /// </param>
        /// <param name="osFeedType">
        /// Operating system feed type of the device group.
        /// Serialized Name: DeviceGroup.properties.osFeedType
        /// </param>
        /// <param name="updatePolicy">
        /// Update policy of the device group.
        /// Serialized Name: DeviceGroup.properties.updatePolicy
        /// </param>
        /// <param name="allowCrashDumpsCollection">
        /// Flag to define if the user allows for crash dump collection.
        /// Serialized Name: DeviceGroup.properties.allowCrashDumpsCollection
        /// </param>
        /// <param name="regionalDataBoundary">
        /// Regional data boundary for the device group.
        /// Serialized Name: DeviceGroup.properties.regionalDataBoundary
        /// </param>
        /// <param name="hasDeployment">
        /// Deployment status for the device group.
        /// Serialized Name: DeviceGroup.properties.hasDeployment
        /// </param>
        /// <param name="provisioningState">
        /// The status of the last operation.
        /// Serialized Name: DeviceGroup.properties.provisioningState
        /// </param>
        /// <returns> A new <see cref="Sphere.SphereDeviceGroupData"/> instance for mocking. </returns>
        public static SphereDeviceGroupData SphereDeviceGroupData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string description = null, SphereOSFeedType? osFeedType = null, SphereUpdatePolicy? updatePolicy = null, SphereAllowCrashDumpCollectionStatus? allowCrashDumpsCollection = null, RegionalDataBoundary? regionalDataBoundary = null, bool? hasDeployment = null, SphereProvisioningState? provisioningState = null)
        {
            return new SphereDeviceGroupData(id, name, resourceType, systemData, description, osFeedType, updatePolicy, allowCrashDumpsCollection, regionalDataBoundary, hasDeployment, provisioningState);
        }

        /// <summary> Initializes a new instance of SphereDeviceInsight. </summary>
        /// <param name="deviceId">
        /// Device ID
        /// Serialized Name: DeviceInsight.deviceId
        /// </param>
        /// <param name="description">
        /// Event description
        /// Serialized Name: DeviceInsight.description
        /// </param>
        /// <param name="startTimestampUtc">
        /// Event start timestamp
        /// Serialized Name: DeviceInsight.startTimestampUtc
        /// </param>
        /// <param name="endTimestampUtc">
        /// Event end timestamp
        /// Serialized Name: DeviceInsight.endTimestampUtc
        /// </param>
        /// <param name="eventCategory">
        /// Event category
        /// Serialized Name: DeviceInsight.eventCategory
        /// </param>
        /// <param name="eventClass">
        /// Event class
        /// Serialized Name: DeviceInsight.eventClass
        /// </param>
        /// <param name="eventType">
        /// Event type
        /// Serialized Name: DeviceInsight.eventType
        /// </param>
        /// <param name="eventCount">
        /// Event count
        /// Serialized Name: DeviceInsight.eventCount
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceId"/>, <paramref name="description"/>, <paramref name="eventCategory"/>, <paramref name="eventClass"/> or <paramref name="eventType"/> is null. </exception>
        /// <returns> A new <see cref="Models.SphereDeviceInsight"/> instance for mocking. </returns>
        public static SphereDeviceInsight SphereDeviceInsight(string deviceId = null, string description = null, DateTimeOffset startTimestampUtc = default, DateTimeOffset endTimestampUtc = default, string eventCategory = null, string eventClass = null, string eventType = null, int eventCount = default)
        {
            if (deviceId == null)
            {
                throw new ArgumentNullException(nameof(deviceId));
            }
            if (description == null)
            {
                throw new ArgumentNullException(nameof(description));
            }
            if (eventCategory == null)
            {
                throw new ArgumentNullException(nameof(eventCategory));
            }
            if (eventClass == null)
            {
                throw new ArgumentNullException(nameof(eventClass));
            }
            if (eventType == null)
            {
                throw new ArgumentNullException(nameof(eventType));
            }

            return new SphereDeviceInsight(deviceId, description, startTimestampUtc, endTimestampUtc, eventCategory, eventClass, eventType, eventCount);
        }

        /// <summary> Initializes a new instance of SphereDeviceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="deviceId">
        /// Device ID
        /// Serialized Name: Device.properties.deviceId
        /// </param>
        /// <param name="chipSku">
        /// SKU of the chip
        /// Serialized Name: Device.properties.chipSku
        /// </param>
        /// <param name="lastAvailableOSVersion">
        /// OS version available for installation when update requested
        /// Serialized Name: Device.properties.lastAvailableOsVersion
        /// </param>
        /// <param name="lastInstalledOSVersion">
        /// OS version running on device when update requested
        /// Serialized Name: Device.properties.lastInstalledOsVersion
        /// </param>
        /// <param name="lastOSUpdateUtc">
        /// Time when update requested and new OS version available
        /// Serialized Name: Device.properties.lastOsUpdateUtc
        /// </param>
        /// <param name="lastUpdateRequestUtc">
        /// Time when update was last requested
        /// Serialized Name: Device.properties.lastUpdateRequestUtc
        /// </param>
        /// <param name="provisioningState">
        /// The status of the last operation.
        /// Serialized Name: Device.properties.provisioningState
        /// </param>
        /// <returns> A new <see cref="Sphere.SphereDeviceData"/> instance for mocking. </returns>
        public static SphereDeviceData SphereDeviceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string deviceId = null, string chipSku = null, string lastAvailableOSVersion = null, string lastInstalledOSVersion = null, DateTimeOffset? lastOSUpdateUtc = null, DateTimeOffset? lastUpdateRequestUtc = null, SphereProvisioningState? provisioningState = null)
        {
            return new SphereDeviceData(id, name, resourceType, systemData, deviceId, chipSku, lastAvailableOSVersion, lastInstalledOSVersion, lastOSUpdateUtc, lastUpdateRequestUtc, provisioningState);
        }

        /// <summary> Initializes a new instance of SphereProductData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description">
        /// Description of the product
        /// Serialized Name: Product.properties.description
        /// </param>
        /// <param name="provisioningState">
        /// The status of the last operation.
        /// Serialized Name: Product.properties.provisioningState
        /// </param>
        /// <returns> A new <see cref="Sphere.SphereProductData"/> instance for mocking. </returns>
        public static SphereProductData SphereProductData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string description = null, SphereProvisioningState? provisioningState = null)
        {
            return new SphereProductData(id, name, resourceType, systemData, description, provisioningState);
        }

        /// <summary> Initializes a new instance of SignedCapabilityImageResponse. </summary>
        /// <param name="image">
        /// The signed device capability image as a UTF-8 encoded base 64 string.
        /// Serialized Name: SignedCapabilityImageResponse.image
        /// </param>
        /// <returns> A new <see cref="Models.SignedCapabilityImageResponse"/> instance for mocking. </returns>
        public static SignedCapabilityImageResponse SignedCapabilityImageResponse(string image = null)
        {
            return new SignedCapabilityImageResponse(image);
        }
    }
}
