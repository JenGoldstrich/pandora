using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataBoxEdge.v2020_12_01.Roles;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum HostPlatformTypeConstant
{
    [Description("KubernetesCluster")]
    KubernetesCluster,

    [Description("LinuxVM")]
    LinuxVM,
}