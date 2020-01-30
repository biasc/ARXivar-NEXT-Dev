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
    /// Class of additional field for Matrix type
    /// </summary>
    [DataContract]
    public partial class AdditionalFieldClasseDTO : FieldBaseDTO,  IEquatable<AdditionalFieldClasseDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldClasseDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdditionalFieldClasseDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalFieldClasseDTO" /> class.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="composedValues">List of search items.</param>
        /// <param name="documentType">Document Type for profiling.</param>
        /// <param name="insertMaskId">Identifier of the profiling mask.</param>
        /// <param name="showExpanded">Show all expanded items.</param>
        /// <param name="singleElement">Only one item.</param>
        /// <param name="columns">Columns to show.</param>
        /// <param name="additionalFieldType">Possible values:  0: Textbox  1: Databox  2: Numeric  3: Combobox  4: TableBox  5: Checkbox  6: MultiValue  7: ClasseBox  8: Group  9: RubricaBox  10: TextArea .</param>
        /// <param name="groupId">Group Identifier.</param>
        /// <param name="binderFieldId">Binder Field Identifier.</param>
        /// <param name="taskWorkVariableId">Variable Identifier in taskword context.</param>
        /// <param name="validationType">Possible values:  0: None  1: Regex  2: Formula .</param>
        /// <param name="validationString">Validation string (regex or formula).</param>
        public AdditionalFieldClasseDTO(List<int?> value = default(List<int?>), List<RowSearchResult> composedValues = default(List<RowSearchResult>), DocumentTypeBaseDTO documentType = default(DocumentTypeBaseDTO), string insertMaskId = default(string), bool? showExpanded = default(bool?), bool? singleElement = default(bool?), List<ColumnInfo> columns = default(List<ColumnInfo>), int? additionalFieldType = default(int?), int? groupId = default(int?), int? binderFieldId = default(int?), int? taskWorkVariableId = default(int?), int? validationType = default(int?), string validationString = default(string), string name = default(string), string externalId = default(string), string description = default(string), int? order = default(int?), string dataSource = default(string), bool? required = default(bool?), string formula = default(string), string className = "AdditionalFieldClasseDTO", bool? locked = default(bool?), string comboGruppiId = default(string), List<DependencyFieldItem> dependencyFields = default(List<DependencyFieldItem>), List<AssocitationFieldItem> associations = default(List<AssocitationFieldItem>), bool? isAdditional = default(bool?), bool? visible = default(bool?), string predefinedProfileFormula = default(string), string visibilityCondition = default(string), int? addressBookDefaultFilter = default(int?), List<int?> enabledAddressBook = default(List<int?>)) : base(name, externalId, description, order, dataSource, required, formula, className, locked, comboGruppiId, dependencyFields, associations, isAdditional, visible, predefinedProfileFormula, visibilityCondition, addressBookDefaultFilter, enabledAddressBook)
        {
            this.Value = value;
            this.ComposedValues = composedValues;
            this.DocumentType = documentType;
            this.InsertMaskId = insertMaskId;
            this.ShowExpanded = showExpanded;
            this.SingleElement = singleElement;
            this.Columns = columns;
            this.AdditionalFieldType = additionalFieldType;
            this.GroupId = groupId;
            this.BinderFieldId = binderFieldId;
            this.TaskWorkVariableId = taskWorkVariableId;
            this.ValidationType = validationType;
            this.ValidationString = validationString;
        }
        
        /// <summary>
        /// Value
        /// </summary>
        /// <value>Value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public List<int?> Value { get; set; }

        /// <summary>
        /// List of search items
        /// </summary>
        /// <value>List of search items</value>
        [DataMember(Name="composedValues", EmitDefaultValue=false)]
        public List<RowSearchResult> ComposedValues { get; set; }

        /// <summary>
        /// Document Type for profiling
        /// </summary>
        /// <value>Document Type for profiling</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public DocumentTypeBaseDTO DocumentType { get; set; }

        /// <summary>
        /// Identifier of the profiling mask
        /// </summary>
        /// <value>Identifier of the profiling mask</value>
        [DataMember(Name="insertMaskId", EmitDefaultValue=false)]
        public string InsertMaskId { get; set; }

        /// <summary>
        /// Show all expanded items
        /// </summary>
        /// <value>Show all expanded items</value>
        [DataMember(Name="showExpanded", EmitDefaultValue=false)]
        public bool? ShowExpanded { get; set; }

        /// <summary>
        /// Only one item
        /// </summary>
        /// <value>Only one item</value>
        [DataMember(Name="singleElement", EmitDefaultValue=false)]
        public bool? SingleElement { get; set; }

        /// <summary>
        /// Columns to show
        /// </summary>
        /// <value>Columns to show</value>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<ColumnInfo> Columns { get; set; }

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
            sb.Append("class AdditionalFieldClasseDTO {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ComposedValues: ").Append(ComposedValues).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  InsertMaskId: ").Append(InsertMaskId).Append("\n");
            sb.Append("  ShowExpanded: ").Append(ShowExpanded).Append("\n");
            sb.Append("  SingleElement: ").Append(SingleElement).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
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
            return this.Equals(input as AdditionalFieldClasseDTO);
        }

        /// <summary>
        /// Returns true if AdditionalFieldClasseDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalFieldClasseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalFieldClasseDTO input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    this.Value.SequenceEqual(input.Value)
                ) && base.Equals(input) && 
                (
                    this.ComposedValues == input.ComposedValues ||
                    this.ComposedValues != null &&
                    this.ComposedValues.SequenceEqual(input.ComposedValues)
                ) && base.Equals(input) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && base.Equals(input) && 
                (
                    this.InsertMaskId == input.InsertMaskId ||
                    (this.InsertMaskId != null &&
                    this.InsertMaskId.Equals(input.InsertMaskId))
                ) && base.Equals(input) && 
                (
                    this.ShowExpanded == input.ShowExpanded ||
                    (this.ShowExpanded != null &&
                    this.ShowExpanded.Equals(input.ShowExpanded))
                ) && base.Equals(input) && 
                (
                    this.SingleElement == input.SingleElement ||
                    (this.SingleElement != null &&
                    this.SingleElement.Equals(input.SingleElement))
                ) && base.Equals(input) && 
                (
                    this.Columns == input.Columns ||
                    this.Columns != null &&
                    this.Columns.SequenceEqual(input.Columns)
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
                if (this.ComposedValues != null)
                    hashCode = hashCode * 59 + this.ComposedValues.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.InsertMaskId != null)
                    hashCode = hashCode * 59 + this.InsertMaskId.GetHashCode();
                if (this.ShowExpanded != null)
                    hashCode = hashCode * 59 + this.ShowExpanded.GetHashCode();
                if (this.SingleElement != null)
                    hashCode = hashCode * 59 + this.SingleElement.GetHashCode();
                if (this.Columns != null)
                    hashCode = hashCode * 59 + this.Columns.GetHashCode();
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
