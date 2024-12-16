// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Reservations.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Reservations.Samples
{
    public partial class Sample_ReservationOrderResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetReservationOrder()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2022-11-01/examples/GetReservationOrderDetails.json
            // this example is just showing the usage of "ReservationOrder_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ReservationOrderResource created on azure
            // for more information of creating ReservationOrderResource, please refer to the document of ReservationOrderResource
            Guid reservationOrderId = Guid.Parse("a075419f-44cc-497f-b68a-14ee811d48b9");
            ResourceIdentifier reservationOrderResourceId = ReservationOrderResource.CreateResourceIdentifier(reservationOrderId);
            ReservationOrderResource reservationOrder = client.GetReservationOrderResource(reservationOrderResourceId);

            // invoke the operation
            ReservationOrderResource result = await reservationOrder.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReservationOrderData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetReservationWithExpandPayments()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2022-11-01/examples/GetReservationOrderDetailsWithExpandPlanInformation.json
            // this example is just showing the usage of "ReservationOrder_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ReservationOrderResource created on azure
            // for more information of creating ReservationOrderResource, please refer to the document of ReservationOrderResource
            Guid reservationOrderId = Guid.Parse("a075419f-44cc-497f-b68a-14ee811d48b9");
            ResourceIdentifier reservationOrderResourceId = ReservationOrderResource.CreateResourceIdentifier(reservationOrderId);
            ReservationOrderResource reservationOrder = client.GetReservationOrderResource(reservationOrderResourceId);

            // invoke the operation
            string expand = "schedule";
            ReservationOrderResource result = await reservationOrder.GetAsync(expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReservationOrderData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_Purchase()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2022-11-01/examples/PurchaseReservationOrder.json
            // this example is just showing the usage of "ReservationOrder_Purchase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ReservationOrderResource created on azure
            // for more information of creating ReservationOrderResource, please refer to the document of ReservationOrderResource
            Guid reservationOrderId = Guid.Parse("a075419f-44cc-497f-b68a-14ee811d48b9");
            ResourceIdentifier reservationOrderResourceId = ReservationOrderResource.CreateResourceIdentifier(reservationOrderId);
            ReservationOrderResource reservationOrder = client.GetReservationOrderResource(reservationOrderResourceId);

            // invoke the operation
            ReservationPurchaseContent content = new ReservationPurchaseContent
            {
                SkuName = "standard_D1",
                Location = new AzureLocation("westus"),
                ReservedResourceType = ReservedResourceType.VirtualMachines,
                BillingScopeId = new ResourceIdentifier("/subscriptions/ed3a1871-612d-abcd-a849-c2542a68be83"),
                Term = ReservationTerm.P1Y,
                BillingPlan = ReservationBillingPlan.Monthly,
                Quantity = 1,
                DisplayName = "TestReservationOrder",
                AppliedScopeType = AppliedScopeType.Shared,
                AppliedScopes = { },
                IsRenewEnabled = false,
                ReservedResourceInstanceFlexibility = InstanceFlexibility.On,
            };
            ArmOperation<ReservationOrderResource> lro = await reservationOrder.UpdateAsync(WaitUntil.Completed, content);
            ReservationOrderResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReservationOrderData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task SplitReservation_Split()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2022-11-01/examples/SplitReservation.json
            // this example is just showing the usage of "Reservation_Split" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ReservationOrderResource created on azure
            // for more information of creating ReservationOrderResource, please refer to the document of ReservationOrderResource
            Guid reservationOrderId = Guid.Parse("276e7ae4-84d0-4da6-ab4b-d6b94f3557da");
            ResourceIdentifier reservationOrderResourceId = ReservationOrderResource.CreateResourceIdentifier(reservationOrderId);
            ReservationOrderResource reservationOrder = client.GetReservationOrderResource(reservationOrderResourceId);

            // invoke the operation
            SplitContent content = new SplitContent
            {
                Quantities = { 1, 2 },
                ReservationId = new ResourceIdentifier("/providers/Microsoft.Capacity/reservationOrders/276e7ae4-84d0-4da6-ab4b-d6b94f3557da/reservations/bcae77cd-3119-4766-919f-b50d36c75c7a"),
            };
            ArmOperation<IList<ReservationDetailData>> lro = await reservationOrder.SplitReservationAsync(WaitUntil.Completed, content);
            IList<ReservationDetailData> result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task MergeReservation_Merge()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2022-11-01/examples/MergeReservations.json
            // this example is just showing the usage of "Reservation_Merge" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ReservationOrderResource created on azure
            // for more information of creating ReservationOrderResource, please refer to the document of ReservationOrderResource
            Guid reservationOrderId = Guid.Parse("276e7ae4-84d0-4da6-ab4b-d6b94f3557da");
            ResourceIdentifier reservationOrderResourceId = ReservationOrderResource.CreateResourceIdentifier(reservationOrderId);
            ReservationOrderResource reservationOrder = client.GetReservationOrderResource(reservationOrderResourceId);

            // invoke the operation
            MergeContent content = new MergeContent
            {
                Sources = { "/providers/Microsoft.Capacity/reservationOrders/c0565a8a-4491-4e77-b07b-5e6d66718e1c/reservations/cea04232-932e-47db-acb5-e29a945ecc73", "/providers/Microsoft.Capacity/reservationOrders/c0565a8a-4491-4e77-b07b-5e6d66718e1c/reservations/5bf54dc7-dacd-4f46-a16b-7b78f4a59799" },
            };
            ArmOperation<IList<ReservationDetailData>> lro = await reservationOrder.MergeReservationAsync(WaitUntil.Completed, content);
            IList<ReservationDetailData> result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ChangeDirectory_ChangeDirectory()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2022-11-01/examples/ChangeDirectoryReservationOrder.json
            // this example is just showing the usage of "ReservationOrder_ChangeDirectory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ReservationOrderResource created on azure
            // for more information of creating ReservationOrderResource, please refer to the document of ReservationOrderResource
            Guid reservationOrderId = Guid.Parse("a075419f-44cc-497f-b68a-14ee811d48b9");
            ResourceIdentifier reservationOrderResourceId = ReservationOrderResource.CreateResourceIdentifier(reservationOrderId);
            ReservationOrderResource reservationOrder = client.GetReservationOrderResource(reservationOrderResourceId);

            // invoke the operation
            ChangeDirectoryContent content = new ChangeDirectoryContent
            {
                DestinationTenantId = Guid.Parse("906655ea-30be-4587-9d12-b50e077b0f32"),
            };
            ChangeDirectoryDetail result = await reservationOrder.ChangeDirectoryAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CalculateRefund_CalculateRefund()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2022-11-01/examples/CalculateRefund.json
            // this example is just showing the usage of "CalculateRefund_Post" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ReservationOrderResource created on azure
            // for more information of creating ReservationOrderResource, please refer to the document of ReservationOrderResource
            Guid reservationOrderId = Guid.Parse("276e7ae4-84d0-4da6-ab4b-d6b94f3557da");
            ResourceIdentifier reservationOrderResourceId = ReservationOrderResource.CreateResourceIdentifier(reservationOrderId);
            ReservationOrderResource reservationOrder = client.GetReservationOrderResource(reservationOrderResourceId);

            // invoke the operation
            ReservationCalculateRefundContent content = new ReservationCalculateRefundContent
            {
                Id = "/providers/microsoft.capacity/reservationOrders/50000000-aaaa-bbbb-cccc-100000000004",
                Properties = new ReservationCalculateRefundRequestProperties
                {
                    Scope = "Reservation",
                    ReservationToReturn = new ReservationToReturn
                    {
                        ReservationId = new ResourceIdentifier("/providers/microsoft.capacity/reservationOrders/50000000-aaaa-bbbb-cccc-100000000004/reservations/40000000-aaaa-bbbb-cccc-100000000000"),
                        Quantity = 1,
                    },
                },
            };
            ReservationCalculateRefundResult result = await reservationOrder.CalculateRefundAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Return_ReturnAReservation()
        {
            // Generated from example definition: specification/reservations/resource-manager/Microsoft.Capacity/stable/2022-11-01/examples/Return.json
            // this example is just showing the usage of "Return_Post" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ReservationOrderResource created on azure
            // for more information of creating ReservationOrderResource, please refer to the document of ReservationOrderResource
            Guid reservationOrderId = Guid.Parse("50000000-aaaa-bbbb-cccc-100000000004");
            ResourceIdentifier reservationOrderResourceId = ReservationOrderResource.CreateResourceIdentifier(reservationOrderId);
            ReservationOrderResource reservationOrder = client.GetReservationOrderResource(reservationOrderResourceId);

            // invoke the operation
            ReservationRefundContent content = new ReservationRefundContent
            {
                Properties = new ReservationRefundRequestProperties
                {
                    SessionId = Guid.Parse("10000000-aaaa-bbbb-cccc-200000000000"),
                    Scope = "Reservation",
                    ReservationToReturn = new ReservationToReturn
                    {
                        ReservationId = new ResourceIdentifier("/providers/microsoft.capacity/reservationOrders/50000000-aaaa-bbbb-cccc-100000000004/reservations/40000000-aaaa-bbbb-cccc-100000000000"),
                        Quantity = 1,
                    },
                    ReturnReason = "PurchasedWrongProduct",
                },
            };
            ArmOperation<ReservationOrderResource> lro = await reservationOrder.ReturnAsync(WaitUntil.Completed, content);
            ReservationOrderResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReservationOrderData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
