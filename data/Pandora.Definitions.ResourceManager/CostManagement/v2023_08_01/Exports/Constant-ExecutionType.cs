using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2023_08_01.Exports;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ExecutionTypeConstant
{
    [Description("OnDemand")]
    OnDemand,

    [Description("Scheduled")]
    Scheduled,
}
