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
    /// Class of state for a binder
    /// </summary>
    [DataContract]
    public partial class BinderStateDto :  IEquatable<BinderStateDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinderStateDto" /> class.
        /// </summary>
        /// <param name="StateCode">Code of the state.</param>
        /// <param name="StateDescription">Description of the state.</param>
        public BinderStateDto(int? StateCode = default(int?), string StateDescription = default(string))
        {
            this.StateCode = StateCode;
            this.StateDescription = StateDescription;
        }
        
        /// <summary>
        /// Code of the state
        /// </summary>
        /// <value>Code of the state</value>
        [DataMember(Name="stateCode", EmitDefaultValue=false)]
        public int? StateCode { get; set; }

        /// <summary>
        /// Description of the state
        /// </summary>
        /// <value>Description of the state</value>
        [DataMember(Name="stateDescription", EmitDefaultValue=false)]
        public string StateDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BinderStateDto {\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
            sb.Append("  StateDescription: ").Append(StateDescription).Append("\n");
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
            return this.Equals(input as BinderStateDto);
        }

        /// <summary>
        /// Returns true if BinderStateDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BinderStateDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BinderStateDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StateCode == input.StateCode ||
                    (this.StateCode != null &&
                    this.StateCode.Equals(input.StateCode))
                ) && 
                (
                    this.StateDescription == input.StateDescription ||
                    (this.StateDescription != null &&
                    this.StateDescription.Equals(input.StateDescription))
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
                if (this.StateCode != null)
                    hashCode = hashCode * 59 + this.StateCode.GetHashCode();
                if (this.StateDescription != null)
                    hashCode = hashCode * 59 + this.StateDescription.GetHashCode();
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
