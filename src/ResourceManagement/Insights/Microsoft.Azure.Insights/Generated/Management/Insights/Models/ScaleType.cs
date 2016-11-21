// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{

    /// <summary>
    /// Defines values for ScaleType.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ScaleType
    {
        [System.Runtime.Serialization.EnumMember(Value = "ChangeCount")]
        ChangeCount,
        [System.Runtime.Serialization.EnumMember(Value = "PercentChangeCount")]
        PercentChangeCount,
        [System.Runtime.Serialization.EnumMember(Value = "ExactCount")]
        ExactCount
    }
}
