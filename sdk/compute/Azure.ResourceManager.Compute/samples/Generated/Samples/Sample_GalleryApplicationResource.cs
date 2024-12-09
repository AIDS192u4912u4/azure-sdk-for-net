// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Compute.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_GalleryApplicationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAGalleryApplication()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/galleryExamples/GalleryApplication_Get.json
            // this example is just showing the usage of "GalleryApplications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryApplicationResource created on azure
            // for more information of creating GalleryApplicationResource, please refer to the document of GalleryApplicationResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryApplicationName = "myGalleryApplicationName";
            ResourceIdentifier galleryApplicationResourceId = GalleryApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryApplicationName);
            GalleryApplicationResource galleryApplication = client.GetGalleryApplicationResource(galleryApplicationResourceId);

            // invoke the operation
            GalleryApplicationResource result = await galleryApplication.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAGalleryApplication()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/galleryExamples/GalleryApplication_Delete.json
            // this example is just showing the usage of "GalleryApplications_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryApplicationResource created on azure
            // for more information of creating GalleryApplicationResource, please refer to the document of GalleryApplicationResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryApplicationName = "myGalleryApplicationName";
            ResourceIdentifier galleryApplicationResourceId = GalleryApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryApplicationName);
            GalleryApplicationResource galleryApplication = client.GetGalleryApplicationResource(galleryApplicationResourceId);

            // invoke the operation
            await galleryApplication.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_UpdateASimpleGalleryApplication()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/galleryExamples/GalleryApplication_Update.json
            // this example is just showing the usage of "GalleryApplications_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryApplicationResource created on azure
            // for more information of creating GalleryApplicationResource, please refer to the document of GalleryApplicationResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryApplicationName = "myGalleryApplicationName";
            ResourceIdentifier galleryApplicationResourceId = GalleryApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryApplicationName);
            GalleryApplicationResource galleryApplication = client.GetGalleryApplicationResource(galleryApplicationResourceId);

            // invoke the operation
            GalleryApplicationPatch patch = new GalleryApplicationPatch
            {
                Description = "This is the gallery application description.",
                Eula = "This is the gallery application EULA.",
                PrivacyStatementUri = new Uri("myPrivacyStatementUri}"),
                ReleaseNoteUri = new Uri("myReleaseNoteUri"),
                SupportedOSType = SupportedOperatingSystemType.Windows,
                CustomActions = {new GalleryApplicationCustomAction("myCustomAction", "myCustomActionScript")
{
Description = "This is the custom action description.",
Parameters = {new GalleryApplicationCustomActionParameter("myCustomActionParameter")
{
IsRequired = false,
ParameterType = GalleryApplicationCustomActionParameterType.String,
DefaultValue = "default value of parameter.",
Description = "This is the description of the parameter",
}},
}},
            };
            ArmOperation<GalleryApplicationResource> lro = await galleryApplication.UpdateAsync(WaitUntil.Completed, patch);
            GalleryApplicationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
