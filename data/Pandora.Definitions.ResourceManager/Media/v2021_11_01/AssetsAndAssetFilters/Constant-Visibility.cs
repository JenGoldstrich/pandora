using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Media.v2021_11_01.AssetsAndAssetFilters;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum VisibilityConstant
{
    [Description("Hidden")]
    Hidden,

    [Description("Visible")]
    Visible,
}