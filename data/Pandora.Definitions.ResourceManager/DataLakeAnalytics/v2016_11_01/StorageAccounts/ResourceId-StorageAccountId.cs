using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.DataLakeAnalytics.v2016_11_01.StorageAccounts
{
    internal class StorageAccountId : ResourceID
    {
        public string? CommonAlias => null;

        public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataLakeAnalytics/accounts/{accountName}/storageAccounts/{storageAccountName}";

        public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
        {
                new()
                {
                    Name = "subscriptions",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "subscriptions"
                },

                new()
                {
                    Name = "subscriptionId",
                    Type = ResourceIDSegmentType.SubscriptionId
                },

                new()
                {
                    Name = "resourceGroups",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "resourceGroups"
                },

                new()
                {
                    Name = "resourceGroupName",
                    Type = ResourceIDSegmentType.ResourceGroup
                },

                new()
                {
                    Name = "providers",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "providers"
                },

                new()
                {
                    Name = "microsoftDataLakeAnalytics",
                    Type = ResourceIDSegmentType.ResourceProvider,
                    FixedValue = "Microsoft.DataLakeAnalytics"
                },

                new()
                {
                    Name = "accounts",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "accounts"
                },

                new()
                {
                    Name = "accountName",
                    Type = ResourceIDSegmentType.UserSpecified
                },

                new()
                {
                    Name = "storageAccounts",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "storageAccounts"
                },

                new()
                {
                    Name = "storageAccountName",
                    Type = ResourceIDSegmentType.UserSpecified
                },

        };
    }
}
