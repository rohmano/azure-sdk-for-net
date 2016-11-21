// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{
    using System.Linq;

    /// <summary>
    /// The diagnostic settings for service.
    /// </summary>
    public partial class ServiceDiagnosticSettings
    {
        /// <summary>
        /// Initializes a new instance of the ServiceDiagnosticSettings class.
        /// </summary>
        public ServiceDiagnosticSettings() { }

        /// <summary>
        /// Initializes a new instance of the ServiceDiagnosticSettings class.
        /// </summary>
        /// <param name="storageAccountId">The resource ID of the storage
        /// account to which you would like to send Diagnostic Logs.</param>
        /// <param name="serviceBusRuleId">The service bus rule ID of the
        /// service bus namespace in which you would like to have Event Hubs
        /// created for streaming Diagnostic Logs. The rule ID is of the
        /// format: '{service bus resource ID}/authorizationrules/{key
        /// name}'.</param>
        /// <param name="metrics">the list of metric settings.</param>
        /// <param name="logs">the list of logs settings.</param>
        /// <param name="workspaceId">The workspace ID (resource ID of a Log
        /// Analytics workspace) for a Log Analytics workspace to which you
        /// would like to send Diagnostic Logs. Example:
        /// /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2</param>
        public ServiceDiagnosticSettings(string storageAccountId = default(string), string serviceBusRuleId = default(string), System.Collections.Generic.IList<MetricSettings> metrics = default(System.Collections.Generic.IList<MetricSettings>), System.Collections.Generic.IList<LogSettings> logs = default(System.Collections.Generic.IList<LogSettings>), string workspaceId = default(string))
        {
            StorageAccountId = storageAccountId;
            ServiceBusRuleId = serviceBusRuleId;
            Metrics = metrics;
            Logs = logs;
            WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Gets or sets the resource ID of the storage account to which you
        /// would like to send Diagnostic Logs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the service bus rule ID of the service bus namespace
        /// in which you would like to have Event Hubs created for streaming
        /// Diagnostic Logs. The rule ID is of the format: '{service bus
        /// resource ID}/authorizationrules/{key name}'.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serviceBusRuleId")]
        public string ServiceBusRuleId { get; set; }

        /// <summary>
        /// Gets or sets the list of metric settings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metrics")]
        public System.Collections.Generic.IList<MetricSettings> Metrics { get; set; }

        /// <summary>
        /// Gets or sets the list of logs settings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "logs")]
        public System.Collections.Generic.IList<LogSettings> Logs { get; set; }

        /// <summary>
        /// Gets or sets the workspace ID (resource ID of a Log Analytics
        /// workspace) for a Log Analytics workspace to which you would like to
        /// send Diagnostic Logs. Example:
        /// /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "workspaceId")]
        public string WorkspaceId { get; set; }

    }
}
