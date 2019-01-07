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
    /// Class of the additional field \&quot;Group\&quot;
    /// </summary>
    [DataContract]
    public partial class AdditionalFieldGroupDTO : FieldBaseDTO,  IEquatable<AdditionalFieldGroupDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldGroupDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdditionalFieldGroupDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldGroupDTO" /> class.
        /// </summary>
        /// <param name="Value">Value.</param>
        /// <param name="NumMaxChar">Maximum number of characters.</param>
        /// <param name="Key">Key.</param>
        /// <param name="AdditionalFieldType">Possible values:  0: Textbox  1: Databox  2: Numeric  3: Combobox  4: TableBox  5: Checkbox  6: MultiValue  7: ClasseBox  8: Group  9: RubricaBox  10: TextArea .</param>
        /// <param name="GroupId">Group Identifier.</param>
        /// <param name="BinderFieldId">Binder Field Identifier.</param>
        /// <param name="TaskWorkVariableId">Variable Identifier in taskword context.</param>
        /// <param name="ValidationType">Possible values:  0: None  1: Regex  2: Formula .</param>
        /// <param name="ValidationString">Validation string (regex or formula).</param>
        public AdditionalFieldGroupDTO(string Value = default(string), int? NumMaxChar = default(int?), int? Key = default(int?), int? AdditionalFieldType = default(int?), int? GroupId = default(int?), int? BinderFieldId = default(int?), int? TaskWorkVariableId = default(int?), int? ValidationType = default(int?), string ValidationString = default(string), string Name = default(string), string ExternalId = default(string), string Description = default(string), int? Order = default(int?), string DataSource = default(string), bool? Required = default(bool?), string Formula = default(string), string ClassName = "AdditionalFieldGroupDTO", bool? Locked = default(bool?), string ComboGruppiId = default(string), List<DependencyFieldItem> DependencyFields = default(List<DependencyFieldItem>), List<AssocitationFieldItem> Associations = default(List<AssocitationFieldItem>), bool? IsAdditional = default(bool?), bool? Visible = default(bool?), string PredefinedProfileFormula = default(string)) : base(Name, ExternalId, Description, Order, DataSource, Required, Formula, ClassName, Locked, ComboGruppiId, DependencyFields, Associations, IsAdditional, Visible, PredefinedProfileFormula)
        {
            this.Value = Value;
            this.NumMaxChar = NumMaxChar;
            this.Key = Key;
            this.AdditionalFieldType = AdditionalFieldType;
            this.GroupId = GroupId;
            this.BinderFieldId = BinderFieldId;
            this.TaskWorkVariableId = TaskWorkVariableId;
            this.ValidationType = ValidationType;
            this.ValidationString = ValidationString;
        }
        
        /// <summary>
        /// Value
        /// </summary>
        /// <value>Value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Maximum number of characters
        /// </summary>
        /// <value>Maximum number of characters</value>
        [DataMember(Name="numMaxChar", EmitDefaultValue=false)]
        public int? NumMaxChar { get; set; }

        /// <summary>
        /// Key
        /// </summary>
        /// <value>Key</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public int? Key { get; set; }

        /// <summary>
        /// Possible values:  0: Textbox  1: Databox  2: Numeric  3: Combobox  4: TableBox  5: Checkbox  6: MultiValue  7: ClasseBox  8: Group  9: RubricaBox  10: TextArea 
        /// </summary>
        /// <value>Possible values:  0: Textbox  1: Databox  2: Numeric  3: Combobox  4: TableBox  5: Checkbox  6: MultiValue  7: ClasseBox  8: Group  9: RubricaBox  10: TextArea </value>
        [DataMember(Name="additionalFieldType", EmitDefaultValue=false)]
        public int? AdditionalFieldType { get; set; }

        /// <summary>
        /// Group Identifier
        /// </summary>
        /// <value>Group Identifier</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public int? GroupId { get; set; }

        /// <summary>
        /// Binder Field Identifier
        /// </summary>
        /// <value>Binder Field Identifier</value>
        [DataMember(Name="binderFieldId", EmitDefaultValue=false)]
        public int? BinderFieldId { get; set; }

        /// <summary>
        /// Variable Identifier in taskword context
        /// </summary>
        /// <value>Variable Identifier in taskword context</value>
        [DataMember(Name="taskWorkVariableId", EmitDefaultValue=false)]
        public int? TaskWorkVariableId { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: Regex  2: Formula 
        /// </summary>
        /// <value>Possible values:  0: None  1: Regex  2: Formula </value>
        [DataMember(Name="validationType", EmitDefaultValue=false)]
        public int? ValidationType { get; set; }

        /// <summary>
        /// Validation string (regex or formula)
        /// </summary>
        /// <value>Validation string (regex or formula)</value>
        [DataMember(Name="validationString", EmitDefaultValue=false)]
        public string ValidationString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalFieldGroupDTO {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  NumMaxChar: ").Append(NumMaxChar).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  AdditionalFieldType: ").Append(AdditionalFieldType).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  BinderFieldId: ").Append(BinderFieldId).Append("\n");
            sb.Append("  TaskWorkVariableId: ").Append(TaskWorkVariableId).Append("\n");
            sb.Append("  ValidationType: ").Append(ValidationType).Append("\n");
            sb.Append("  ValidationString: ").Append(ValidationString).Append("\n");
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
            return this.Equals(input as AdditionalFieldGroupDTO);
        }

        /// <summary>
        /// Returns true if AdditionalFieldGroupDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalFieldGroupDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalFieldGroupDTO input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && base.Equals(input) && 
                (
                    this.NumMaxChar == input.NumMaxChar ||
                    (this.NumMaxChar != null &&
                    this.NumMaxChar.Equals(input.NumMaxChar))
                ) && base.Equals(input) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && base.Equals(input) && 
                (
                    this.AdditionalFieldType == input.AdditionalFieldType ||
                    (this.AdditionalFieldType != null &&
                    this.AdditionalFieldType.Equals(input.AdditionalFieldType))
                ) && base.Equals(input) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && base.Equals(input) && 
                (
                    this.BinderFieldId == input.BinderFieldId ||
                    (this.BinderFieldId != null &&
                    this.BinderFieldId.Equals(input.BinderFieldId))
                ) && base.Equals(input) && 
                (
                    this.TaskWorkVariableId == input.TaskWorkVariableId ||
                    (this.TaskWorkVariableId != null &&
                    this.TaskWorkVariableId.Equals(input.TaskWorkVariableId))
                ) && base.Equals(input) && 
                (
                    this.ValidationType == input.ValidationType ||
                    (this.ValidationType != null &&
                    this.ValidationType.Equals(input.ValidationType))
                ) && base.Equals(input) && 
                (
                    this.ValidationString == input.ValidationString ||
                    (this.ValidationString != null &&
                    this.ValidationString.Equals(input.ValidationString))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.NumMaxChar != null)
                    hashCode = hashCode * 59 + this.NumMaxChar.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.AdditionalFieldType != null)
                    hashCode = hashCode * 59 + this.AdditionalFieldType.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.BinderFieldId != null)
                    hashCode = hashCode * 59 + this.BinderFieldId.GetHashCode();
                if (this.TaskWorkVariableId != null)
                    hashCode = hashCode * 59 + this.TaskWorkVariableId.GetHashCode();
                if (this.ValidationType != null)
                    hashCode = hashCode * 59 + this.ValidationType.GetHashCode();
                if (this.ValidationString != null)
                    hashCode = hashCode * 59 + this.ValidationString.GetHashCode();
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
