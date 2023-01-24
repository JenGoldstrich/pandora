using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Authorization.v2020_10_01.RoleEligibilityScheduleRequests;

internal class ValidateOperation : Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => typeof(RoleEligibilityScheduleRequestModel);

    public override ResourceID? ResourceId() => new ScopedRoleEligibilityScheduleRequestId();

    public override Type? ResponseObject() => typeof(RoleEligibilityScheduleRequestModel);

    public override string? UriSuffix() => "/validate";


}