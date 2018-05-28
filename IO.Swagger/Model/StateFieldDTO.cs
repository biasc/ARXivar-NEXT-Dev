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
    /// StateFieldDTO
    /// </summary>
    [DataContract]
    public partial class StateFieldDTO : FieldBaseDTO,  IEquatable<StateFieldDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateFieldDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StateFieldDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StateFieldDTO" /> class.
        /// </summary>
        /// <param name="DisplayValue">DisplayValue.</param>
        /// <param name="Value">Value.</param>
        public StateFieldDTO(string DisplayValue = default(string), string Value = default(string), string Name = default(string), string ExternalId = default(string), string Description = default(string), int? Order = default(int?), string DataSource = default(string), bool? Required = default(bool?), string Formula = default(string), bool? Locked = default(bool?), string ComboGruppiId = default(string), List<DependencyFieldItem> DependencyFields = default(List<DependencyFieldItem>), List<AssocitationFieldItem> Associations = default(List<AssocitationFieldItem>), bool? IsAdditional = default(bool?), bool? Visible = default(bool?), string PredefinedProfileFormula = default(string)) : base(Name, ExternalId, Description, Order, DataSource, Required, Formula, Locked, ComboGruppiId, DependencyFields, Associations, IsAdditional, Visible, PredefinedProfileFormula)
        {
            this.DisplayValue = DisplayValue;
            this.Value = Value;
        }
        
        /// <summary>
        /// Gets or Sets DisplayValue
        /// </summary>
        [DataMember(Name="displayValue", EmitDefaultValue=false)]
        public string DisplayValue { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Name of class
        /// </summary>
        /// <value>Name of class</value>
        [DataMember(Name="className", EmitDefaultValue=false)]
        public string ClassName { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StateFieldDTO {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  DisplayValue: ").Append(DisplayValue).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as StateFieldDTO);
        }

        /// <summary>
        /// Returns true if StateFieldDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of StateFieldDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateFieldDTO input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.DisplayValue == input.DisplayValue ||
                    (this.DisplayValue != null &&
                    this.DisplayValue.Equals(input.DisplayValue))
                ) && base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && base.Equals(input) && 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
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
                int hashCode = base.GetHashCode();
                if (this.DisplayValue != null)
                    hashCode = hashCode * 59 + this.DisplayValue.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
