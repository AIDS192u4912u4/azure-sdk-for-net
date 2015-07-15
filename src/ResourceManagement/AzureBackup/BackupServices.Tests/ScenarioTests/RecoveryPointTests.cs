﻿using Microsoft.Azure.Management.BackupServices.Models;
using Microsoft.Azure.Management.BackupServices;
using Microsoft.Azure.Test;
using System.Net;
using Xunit;
using System.Configuration;
using System;

namespace BackupServices.Tests
{
    public class RecoveryPointTests : BackupServicesTestsBase
    {
        [Fact]
        public void ListRecoveryPointTest()
        {
            using (UndoContext context = UndoContext.Current)
            {
                context.Start();
                var client = GetServiceClient<BackupServicesManagementClient>();

                string containerName = ConfigurationManager.AppSettings["ContainerName"];
                string itemName = ConfigurationManager.AppSettings["ItemName"];

                var response = client.RecoveryPoint.List(GetCustomRequestHeaders(), containerName, itemName);

                if (response != null &&
                    response.CSMRecoveryPointListResponse != null)
                {
                    foreach (var rpo in response.CSMRecoveryPointListResponse.Value)
                    {
                        Assert.True(!string.IsNullOrEmpty(rpo.Name), "RecoveryPointId can't be null or empty");
                        Assert.True((rpo.Properties.RecoveryPointTime != null), "RecoveryPointTime can't be null or empty");
                        Assert.True(!string.IsNullOrEmpty(rpo.Properties.RecoveryPointType), "RecoveryPointType can't be null or empty");
                    }
                }                
                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }
        }
    }
}
