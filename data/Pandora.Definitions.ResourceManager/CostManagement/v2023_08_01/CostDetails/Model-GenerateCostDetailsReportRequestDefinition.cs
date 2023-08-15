using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.CostManagement.v2023_08_01.CostDetails;


internal class GenerateCostDetailsReportRequestDefinitionModel
{
    [JsonPropertyName("billingPeriod")]
    public string? BillingPeriod { get; set; }

    [JsonPropertyName("invoiceId")]
    public string? InvoiceId { get; set; }

    [JsonPropertyName("metric")]
    public CostDetailsMetricTypeConstant? Metric { get; set; }

    [JsonPropertyName("timePeriod")]
    public CostDetailsTimePeriodModel? TimePeriod { get; set; }
}
