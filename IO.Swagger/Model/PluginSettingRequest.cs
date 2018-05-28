/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Class of plugin setting request
    /// </summary>
    [DataContract]
    public partial class PluginSettingRequest :  IEquatable<PluginSettingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginSettingRequest" /> class.
        /// </summary>
        /// <param name="PluginId">Identifier of plugin.</param>
        /// <param name="DesktopId">Identifier of desktop item.</param>
        /// <param name="InstanceId">Identifier of instance.</param>
        /// <param name="Settings">Settings.</param>
        public PluginSettingRequest(string PluginId = default(string), string DesktopId = default(string), string InstanceId = default(string), Dictionary<string, Object> Settings = default(Dictionary<string, Object>))
        {
            this.PluginId = PluginId;
            this.DesktopId = DesktopId;
            this.InstanceId = InstanceId;
            this.Settings = Settings;
        }
        
        /// <summary>
        /// Identifier of plugin
        /// </summary>
        /// <value>Identifier of plugin</value>
        [DataMember(Name="pluginId", EmitDefaultValue=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// Identifier of desktop item
        /// </summary>
        /// <value>Identifier of desktop item</value>
        [DataMember(Name="desktopId", EmitDefaultValue=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// Identifier of instance
        /// </summary>
        /// <value>Identifier of instance</value>
        [DataMember(Name="instanceId", EmitDefaultValue=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Settings
        /// </summary>
        /// <value>Settings</value>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public Dictionary<string, Object> Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginSettingRequest {\n");
            sb.Append("  PluginId: ").Append(PluginId).Append("\n");
            sb.Append("  DesktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginSettingRequest);
        }

        /// <summary>
        /// Returns true if PluginSettingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PluginSettingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginSettingRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PluginId == input.PluginId ||
                    (this.PluginId != null &&
                    this.PluginId.Equals(input.PluginId))
                ) && 
                (
                    this.DesktopId == input.DesktopId ||
                    (this.DesktopId != null &&
                    this.DesktopId.Equals(input.DesktopId))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PluginId != null)
                    hashCode = hashCode * 59 + this.PluginId.GetHashCode();
                if (this.DesktopId != null)
                    hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
