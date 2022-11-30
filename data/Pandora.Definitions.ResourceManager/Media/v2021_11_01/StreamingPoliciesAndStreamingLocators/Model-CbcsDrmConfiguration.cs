using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Media.v2021_11_01.StreamingPoliciesAndStreamingLocators;


internal class CbcsDrmConfigurationModel
{
    [JsonPropertyName("fairPlay")]
    public StreamingPolicyFairPlayConfigurationModel? FairPlay { get; set; }

    [JsonPropertyName("playReady")]
    public StreamingPolicyPlayReadyConfigurationModel? PlayReady { get; set; }

    [JsonPropertyName("widevine")]
    public StreamingPolicyWidevineConfigurationModel? Widevine { get; set; }
}
