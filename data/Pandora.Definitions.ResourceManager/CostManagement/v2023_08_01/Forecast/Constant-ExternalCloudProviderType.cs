using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2023_08_01.Forecast;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ExternalCloudProviderTypeConstant
{
    [Description("externalBillingAccounts")]
    ExternalBillingAccounts,

    [Description("externalSubscriptions")]
    ExternalSubscriptions,
}
