using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2023_08_01.Budgets;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum BudgetNotificationOperatorTypeConstant
{
    [Description("EqualTo")]
    EqualTo,

    [Description("GreaterThan")]
    GreaterThan,

    [Description("GreaterThanOrEqualTo")]
    GreaterThanOrEqualTo,

    [Description("LessThan")]
    LessThan,
}
