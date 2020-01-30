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
    /// Class represents a delete items from desktop operation
    /// </summary>
    [DataContract]
    public partial class DesktopItemDeleteRequestDTO :  IEquatable<DesktopItemDeleteRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DesktopItemDeleteRequestDTO" /> class.
        /// </summary>
        /// <param name="desktopItems">Items to delete.</param>
        public DesktopItemDeleteRequestDTO(List<DesktopItemDTO> desktopItems = default(List<DesktopItemDTO>))
        {
            this.DesktopItems = desktopItems;
        }
        
        /// <summary>
        /// Items to delete
        /// </summary>
        /// <value>Items to delete</value>
        [DataMember(Name="desktopItems", EmitDefaultValue=false)]
        public List<DesktopItemDTO> DesktopItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopItemDeleteRequestDTO {\n");
            sb.Append("  DesktopItems: ").Append(DesktopItems).Append("\n");
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
            return this.Equals(input as DesktopItemDeleteRequestDTO);
        }

        /// <summary>
        /// Returns true if DesktopItemDeleteRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DesktopItemDeleteRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesktopItemDeleteRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DesktopItems == input.DesktopItems ||
                    this.DesktopItems != null &&
                    this.DesktopItems.SequenceEqual(input.DesktopItems)
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
                if (this.DesktopItems != null)
                    hashCode = hashCode * 59 + this.DesktopItems.GetHashCode();
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
