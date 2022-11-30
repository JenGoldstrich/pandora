using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Media.v2021_11_01.Encodings;


internal abstract class OverlayModel
{
    [JsonPropertyName("audioGainLevel")]
    public float? AudioGainLevel { get; set; }

    [JsonPropertyName("end")]
    public string? End { get; set; }

    [JsonPropertyName("fadeInDuration")]
    public string? FadeInDuration { get; set; }

    [JsonPropertyName("fadeOutDuration")]
    public string? FadeOutDuration { get; set; }

    [JsonPropertyName("inputLabel")]
    [Required]
    public string InputLabel { get; set; }

    [JsonPropertyName("@odata.type")]
    [ProvidesTypeHint]
    [Required]
    public string OdataType { get; set; }

    [JsonPropertyName("start")]
    public string? Start { get; set; }
}
