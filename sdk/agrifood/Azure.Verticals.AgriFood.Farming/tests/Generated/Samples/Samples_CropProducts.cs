// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    internal class Samples_CropProducts
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCropProduct()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            Response response = client.GetCropProduct("<cropProductId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCropProduct_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            Response response = client.GetCropProduct("<cropProductId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("cropIds")[0].ToString());
            Console.WriteLine(result.GetProperty("brand").ToString());
            Console.WriteLine(result.GetProperty("product").ToString());
            Console.WriteLine(result.GetProperty("trait").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("treatments")[0].ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCropProduct_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            Response response = await client.GetCropProductAsync("<cropProductId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCropProduct_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            Response response = await client.GetCropProductAsync("<cropProductId>", new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("cropIds")[0].ToString());
            Console.WriteLine(result.GetProperty("brand").ToString());
            Console.WriteLine(result.GetProperty("product").ToString());
            Console.WriteLine(result.GetProperty("trait").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("treatments")[0].ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            var data = new { };

            Response response = client.CreateOrUpdate("<cropProductId>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            var data = new
            {
                cropIds = new[] {
        "<String>"
    },
                brand = "<brand>",
                product = "<product>",
                trait = "<trait>",
                relativeMaturity = new
                {
                    unit = "<unit>",
                    value = 123.45d,
                },
                treatments = new[] {
        "<String>"
    },
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new { },
                },
            };

            Response response = client.CreateOrUpdate("<cropProductId>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("cropIds")[0].ToString());
            Console.WriteLine(result.GetProperty("brand").ToString());
            Console.WriteLine(result.GetProperty("product").ToString());
            Console.WriteLine(result.GetProperty("trait").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("treatments")[0].ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            var data = new { };

            Response response = await client.CreateOrUpdateAsync("<cropProductId>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            var data = new
            {
                cropIds = new[] {
        "<String>"
    },
                brand = "<brand>",
                product = "<product>",
                trait = "<trait>",
                relativeMaturity = new
                {
                    unit = "<unit>",
                    value = 123.45d,
                },
                treatments = new[] {
        "<String>"
    },
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new { },
                },
            };

            Response response = await client.CreateOrUpdateAsync("<cropProductId>", RequestContent.Create(data));

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("cropIds")[0].ToString());
            Console.WriteLine(result.GetProperty("brand").ToString());
            Console.WriteLine(result.GetProperty("product").ToString());
            Console.WriteLine(result.GetProperty("trait").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("treatments")[0].ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            Response response = client.Delete("<cropProductId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            Response response = client.Delete("<cropProductId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            Response response = await client.DeleteAsync("<cropProductId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            Response response = await client.DeleteAsync("<cropProductId>");
            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCropProducts()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            foreach (var item in client.GetCropProducts(new string[] { "<cropIds>" }, new string[] { "<brands>" }, new string[] { "<products>" }, new string[] { "<traits>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, 1234, "<skipToken>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCropProducts_AllParameters()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            foreach (var item in client.GetCropProducts(new string[] { "<cropIds>" }, new string[] { "<brands>" }, new string[] { "<products>" }, new string[] { "<traits>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, 1234, "<skipToken>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("cropIds")[0].ToString());
                Console.WriteLine(result.GetProperty("brand").ToString());
                Console.WriteLine(result.GetProperty("product").ToString());
                Console.WriteLine(result.GetProperty("trait").ToString());
                Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("unit").ToString());
                Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("value").ToString());
                Console.WriteLine(result.GetProperty("treatments")[0].ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("source").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCropProducts_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            await foreach (var item in client.GetCropProductsAsync(new string[] { "<cropIds>" }, new string[] { "<brands>" }, new string[] { "<products>" }, new string[] { "<traits>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, 1234, "<skipToken>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCropProducts_AllParameters_Async()
        {
            var credential = new DefaultAzureCredential();
            var client = new FarmBeatsClient(credential).GetCropProductsClient("2022-11-01-preview");

            await foreach (var item in client.GetCropProductsAsync(new string[] { "<cropIds>" }, new string[] { "<brands>" }, new string[] { "<products>" }, new string[] { "<traits>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, DateTimeOffset.UtcNow, 1234, "<skipToken>", new RequestContext()))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("cropIds")[0].ToString());
                Console.WriteLine(result.GetProperty("brand").ToString());
                Console.WriteLine(result.GetProperty("product").ToString());
                Console.WriteLine(result.GetProperty("trait").ToString());
                Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("unit").ToString());
                Console.WriteLine(result.GetProperty("relativeMaturity").GetProperty("value").ToString());
                Console.WriteLine(result.GetProperty("treatments")[0].ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("source").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<test>").ToString());
            }
        }
    }
}
