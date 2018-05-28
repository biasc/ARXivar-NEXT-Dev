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
    /// Class of the additional field \&quot;Combo\&quot;
    /// </summary>
    [DataContract]
    public partial class AdditionalFieldComboDTO : FieldBaseDTO,  IEquatable<AdditionalFieldComboDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldComboDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdditionalFieldComboDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldComboDTO" /> class.
        /// </summary>
        /// <param name="LimitToList">Possible values ​​limited to the list.</param>
        /// <param name="DisplayValue">Value to display.</param>
        /// <param name="Value">Value.</param>
        /// <param name="NumMaxChar">Maximum number of characters.</param>
        /// <param name="NumRows">Maximum number of rows.</param>
        /// <param name="AdditionalFieldType">Possible values:  0: Textbox  1: Databox  2: Numeric  3: Combobox  4: TableBox  5: Checkbox  6: MultiValue  7: ClasseBox  8: Group  9: RubricaBox  10: TextArea .</param>
        /// <param name="GroupId">Group Identifier.</param>
        /// <param name="BinderFieldId">Binder Field Identifier.</param>
        /// <param name="TaskWorkVariableId">Variable Identifier in taskword context.</param>
        public AdditionalFieldComboDTO(bool? LimitToList = default(bool?), string DisplayValue = default(string), string Value = default(string), int? NumMaxChar = default(int?), int? NumRows = default(int?), int? AdditionalFieldType = default(int?), int? GroupId = default(int?), int? BinderFieldId = default(int?), int? TaskWorkVariableId = default(int?), string Name = default(string), string ExternalId = default(string), string Description = default(string), int? Order = default(int?), string DataSource = default(string), bool? Required = default(bool?), string Formula = default(string), bool? Locked = default(bool?), string ComboGruppiId = default(string), List<DependencyFieldItem> DependencyFields = default(List<DependencyFieldItem>), List<AssocitationFieldItem> Associations = default(List<AssocitationFieldItem>), bool? IsAdditional = default(bool?), bool? Visible = default(bool?), string PredefinedProfileFormula = default(string)) : base(Name, ExternalId, Description, Order, DataSource, Required, Formula, Locked, ComboGruppiId, DependencyFields, Associations, IsAdditional, Visible, PredefinedProfileFormula)
        {
            this.LimitToList = LimitToList;
            this.DisplayValue = DisplayValue;
            this.Value = Value;
            this.NumMaxChar = NumMaxChar;
            this.NumRows = NumRows;
            this.AdditionalFieldType = AdditionalFieldType;
            this.GroupId = GroupId;
            this.BinderFieldId = BinderFieldId;
            this.TaskWorkVariableId = TaskWorkVariableId;
        }
        
        /// <summary>
        /// Possible values ​​limited to the list
        /// </summary>
        /// <value>Possible values ​​limited to the list</value>
        [DataMember(Name="limitToList", EmitDefaultValue=false)]
        public bool? LimitToList { get; set; }

        /// <summary>
        /// Name of class
        /// </summary>
        /// <value>Name of class</value>
        [DataMember(Name="className", EmitDefaultValue=false)]
        public string ClassName { get; private set; }

        /// <summary>
        /// Value to display
        /// </summary>
        /// <value>Value to display</value>
        [DataMember(Name="displayValue", EmitDefaultValue=false)]
        public string DisplayValue { get; set; }

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
        /// Maximum number of rows
        /// </summary>
        /// <value>Maximum number of rows</value>
        [DataMember(Name="numRows", EmitDefaultValue=false)]
        public int? NumRows { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalFieldComboDTO {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  LimitToList: ").Append(LimitToList).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  DisplayValue: ").Append(DisplayValue).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  NumMaxChar: ").Append(NumMaxChar).Append("\n");
            sb.Append("  NumRows: ").Append(NumRows).Append("\n");
            sb.Append("  AdditionalFieldType: ").Append(AdditionalFieldType).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  BinderFieldId: ").Append(BinderFieldId).Append("\n");
            sb.Append("  TaskWorkVariableId: ").Append(TaskWorkVariableId).Append("\n");
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
            return this.Equals(input as AdditionalFieldComboDTO);
        }

        /// <summary>
        /// Returns true if AdditionalFieldComboDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalFieldComboDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalFieldComboDTO input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.LimitToList == input.LimitToList ||
                    (this.LimitToList != null &&
                    this.LimitToList.Equals(input.LimitToList))
                ) && base.Equals(input) && 
                (
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
                ) && base.Equals(input) && 
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
                    this.NumMaxChar == input.NumMaxChar ||
                    (this.NumMaxChar != null &&
                    this.NumMaxChar.Equals(input.NumMaxChar))
                ) && base.Equals(input) && 
                (
                    this.NumRows == input.NumRows ||
                    (this.NumRows != null &&
                    this.NumRows.Equals(input.NumRows))
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
                if (this.LimitToList != null)
                    hashCode = hashCode * 59 + this.LimitToList.GetHashCode();
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
                if (this.DisplayValue != null)
                    hashCode = hashCode * 59 + this.DisplayValue.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.NumMaxChar != null)
                    hashCode = hashCode * 59 + this.NumMaxChar.GetHashCode();
                if (this.NumRows != null)
                    hashCode = hashCode * 59 + this.NumRows.GetHashCode();
                if (this.AdditionalFieldType != null)
                    hashCode = hashCode * 59 + this.AdditionalFieldType.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.BinderFieldId != null)
                    hashCode = hashCode * 59 + this.BinderFieldId.GetHashCode();
                if (this.TaskWorkVariableId != null)
                    hashCode = hashCode * 59 + this.TaskWorkVariableId.GetHashCode();
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
