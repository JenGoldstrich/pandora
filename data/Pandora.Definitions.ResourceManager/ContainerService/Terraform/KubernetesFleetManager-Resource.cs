using System;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.ContainerService.Terraform;

public class KubernetesFleetManagerResource : TerraformResourceDefinition
{
    public string DisplayName => "Kubernetes Fleet Manager";
    public ResourceID ResourceId => new v2022_09_02_preview.Fleets.FleetId();
    public string ResourceLabel => "kubernetes_fleet_manager";
    public string ResourceCategory => "Containers";
    public string ResourceDescription => @"Manages a Kubernetes Fleet Manager

~> **Note:** This Resource is in **Preview** to use this you must be opted into the Preview. You can do this by running `az feature register --namespace Microsoft.ContainerService --name FleetResourcePreview` and then `az provider register -n Microsoft.ContainerService`
";
    public string ResourceExampleUsage => @"resource 'azurerm_kubernetes_fleet_manager' 'example' {

  hub_profile {
    dns_prefix = 'example'
  }

  location            = azurerm_resource_group.example.location
  name                = 'example'
  resource_group_name = azurerm_resource_group.example.name
}".AsTerraformTestConfig();
    public Type? SchemaModel => typeof(KubernetesFleetManagerResourceSchema);
    public TerraformMappingDefinition SchemaMappings => new KubernetesFleetManagerResourceMappings();
    public TerraformResourceTestDefinition Tests => new KubernetesFleetManagerResourceTests();

    public bool GenerateIDValidationFunction => true;
    public bool GenerateModel => true;
    public bool GenerateSchema => true;

    public MethodDefinition CreateMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2022_09_02_preview.Fleets.CreateOrUpdateOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition DeleteMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2022_09_02_preview.Fleets.DeleteOperation),
        TimeoutInMinutes = 30,
    };
    public MethodDefinition ReadMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2022_09_02_preview.Fleets.GetOperation),
        TimeoutInMinutes = 5,
    };
    public MethodDefinition? UpdateMethod => new MethodDefinition
    {
        Generate = true,
        Method = typeof(v2022_09_02_preview.Fleets.CreateOrUpdateOperation),
        TimeoutInMinutes = 30,
    };
}