/* 
 * WebAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: data
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
    /// Class of queue status
    /// </summary>
    [DataContract]
    public partial class QueueStateHistoryDto :  IEquatable<QueueStateHistoryDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueStateHistoryDto" /> class.
        /// </summary>
        /// <param name="stateName">Status.</param>
        /// <param name="reason">Reason.</param>
        /// <param name="createdAt">Creation Date.</param>
        /// <param name="data">Key\\Value Items.</param>
        public QueueStateHistoryDto(string stateName = default(string), string reason = default(string), DateTime? createdAt = default(DateTime?), List<KeyValueElementDto> data = default(List<KeyValueElementDto>))
        {
            this.StateName = stateName;
            this.Reason = reason;
            this.CreatedAt = createdAt;
            this.Data = data;
        }
        
        /// <summary>
        /// Status
        /// </summary>
        /// <value>Status</value>
        [DataMember(Name="stateName", EmitDefaultValue=false)]
        public string StateName { get; set; }

        /// <summary>
        /// Reason
        /// </summary>
        /// <value>Reason</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Creation Date
        /// </summary>
        /// <value>Creation Date</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Key\\Value Items
        /// </summary>
        /// <value>Key\\Value Items</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<KeyValueElementDto> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueStateHistoryDto {\n");
            sb.Append("  StateName: ").Append(StateName).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as QueueStateHistoryDto);
        }

        /// <summary>
        /// Returns true if QueueStateHistoryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueStateHistoryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueStateHistoryDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StateName == input.StateName ||
                    (this.StateName != null &&
                    this.StateName.Equals(input.StateName))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.StateName != null)
                    hashCode = hashCode * 59 + this.StateName.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
