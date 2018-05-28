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
    /// RelationInsertItemDTO
    /// </summary>
    [DataContract]
    public partial class RelationInsertItemDTO :  IEquatable<RelationInsertItemDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationInsertItemDTO" /> class.
        /// </summary>
        /// <param name="DocNumber">Document Identifier.</param>
        /// <param name="RelationType">Possible values:  0: Date  1: Father  2: Child .</param>
        public RelationInsertItemDTO(int? DocNumber = default(int?), int? RelationType = default(int?))
        {
            this.DocNumber = DocNumber;
            this.RelationType = RelationType;
        }
        
        /// <summary>
        /// Document Identifier
        /// </summary>
        /// <value>Document Identifier</value>
        [DataMember(Name="docNumber", EmitDefaultValue=false)]
        public int? DocNumber { get; set; }

        /// <summary>
        /// Possible values:  0: Date  1: Father  2: Child 
        /// </summary>
        /// <value>Possible values:  0: Date  1: Father  2: Child </value>
        [DataMember(Name="relationType", EmitDefaultValue=false)]
        public int? RelationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationInsertItemDTO {\n");
            sb.Append("  DocNumber: ").Append(DocNumber).Append("\n");
            sb.Append("  RelationType: ").Append(RelationType).Append("\n");
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
            return this.Equals(input as RelationInsertItemDTO);
        }

        /// <summary>
        /// Returns true if RelationInsertItemDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RelationInsertItemDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationInsertItemDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocNumber == input.DocNumber ||
                    (this.DocNumber != null &&
                    this.DocNumber.Equals(input.DocNumber))
                ) && 
                (
                    this.RelationType == input.RelationType ||
                    (this.RelationType != null &&
                    this.RelationType.Equals(input.RelationType))
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
                if (this.DocNumber != null)
                    hashCode = hashCode * 59 + this.DocNumber.GetHashCode();
                if (this.RelationType != null)
                    hashCode = hashCode * 59 + this.RelationType.GetHashCode();
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
