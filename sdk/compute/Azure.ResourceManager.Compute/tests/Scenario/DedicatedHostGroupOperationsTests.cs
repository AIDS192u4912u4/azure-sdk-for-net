﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Compute.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Tests
{
    public class DedicatedHostGroupOperationsTests : ComputeTestBase
    {
        public DedicatedHostGroupOperationsTests(bool isAsync)
            : base(isAsync, RecordedTestMode.Record)
        {
        }

        private async Task<DedicatedHostGroup> CreateDedicatedHostGroupAsync(string groupName)
        {
            var container = (await CreateResourceGroupAsync()).GetDedicatedHostGroups();
            var input = DedicatedHostGroupHelper.GetBasicDedicatedHostGroup(DefaultLocation);
            return await container.CreateOrUpdateAsync(groupName, input);
        }

        [TestCase]
        [RecordedTest]
        public async Task Delete()
        {
            var groupName = Recording.GenerateAssetName("testDHG-");
            var DedicatedHostGroup = await CreateDedicatedHostGroupAsync(groupName);
            await DedicatedHostGroup.DeleteAsync();
        }

        [TestCase]
        [RecordedTest]
        public async Task StartDelete()
        {
            var groupName = Recording.GenerateAssetName("testDHG-");
            var DedicatedHostGroup = await CreateDedicatedHostGroupAsync(groupName);
            var deleteOp = await DedicatedHostGroup.StartDeleteAsync();
            await deleteOp.WaitForCompletionResponseAsync();
        }

        [TestCase]
        [RecordedTest]
        public async Task Get()
        {
            var groupName = Recording.GenerateAssetName("testDHG-");
            var group1 = await CreateDedicatedHostGroupAsync(groupName);
            DedicatedHostGroup group2 = await group1.GetAsync();

            DedicatedHostGroupHelper.AssertGroup(group1.Data, group2.Data);
        }
    }
}
