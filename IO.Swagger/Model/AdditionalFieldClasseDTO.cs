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
        /// <param name="Value">Value.</param>
        /// <param name="ComposedValues">List of search items.</param>
        /// <param name="DocumentType">Document Type for profiling.</param>
        /// <param name="InsertMaskId">Identifier of the profiling mask.</param>
        /// <param name="ShowExpanded">Show all expanded items.</param>
        /// <param name="SingleElement">Only one item.</param>
        /// <param name="Columns">Columns to show.</param>
        /// <param name="AdditionalFieldType">Possible values:  0: Textbox  1: Databox  2: Numeric  3: Combobox  4: TableBox  5: Checkbox  6: MultiValue  7: ClasseBox  8: Group  9: RubricaBox  10: TextArea .</param>
        /// <param name="GroupId">Group Identifier.</param>
        /// <param name="BinderFieldId">Binder Field Identifier.</param>
        /// <param name="TaskWorkVariableId">Variable Identifier in taskword context.</param>
        public AdditionalFieldClasseDTO(List<int?> Value = default(List<int?>), List<RowSearchResult> ComposedValues = default(List<RowSearchResult>), DocumentTypeBaseDTO DocumentType = default(DocumentTypeBaseDTO), string InsertMaskId = default(string), bool? ShowExpanded = default(bool?), bool? SingleElement = default(bool?), List<ColumnInfo> Columns = default(List<ColumnInfo>), int? AdditionalFieldType = default(int?), int? GroupId = default(int?), int? BinderFieldId = default(int?), int? TaskWorkVariableId = default(int?), string Name = default(string), string ExternalId = default(string), string Description = default(string), int? Order = default(int?), string DataSource = default(string), bool? Required = default(bool?), string Formula = default(string), bool? Locked = default(bool?), string ComboGruppiId = default(string), List<DependencyFieldItem> DependencyFields = default(List<DependencyFieldItem>), List<AssocitationFieldItem> Associations = default(List<AssocitationFieldItem>), bool? IsAdditional = default(bool?), bool? Visible = default(bool?), string PredefinedProfileFormula = default(string)) : base(Name, ExternalId, Description, Order, DataSource, Required, Formula, Locked, ComboGruppiId, DependencyFields, Associations, IsAdditional, Visible, PredefinedProfileFormula)
        {
            this.Value = Value;
            this.ComposedValues = ComposedValues;
            this.DocumentType = DocumentType;
            this.InsertMaskId = InsertMaskId;
            this.ShowExpanded = ShowExpanded;
            this.SingleElement = SingleElement;
            this.Columns = Columns;
            this.AdditionalFieldType = AdditionalFieldType;
            this.GroupId = GroupId;
            this.BinderFieldId = BinderFieldId;
            this.TaskWorkVariableId = TaskWorkVariableId;
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
        /// Name of class
        /// </summary>
        /// <value>Name of class</value>
        [DataMember(Name="className", EmitDefaultValue=false)]
        public string ClassName { get; private set; }

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
            sb.Append("class AdditionalFieldClasseDTO {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ComposedValues: ").Append(ComposedValues).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  InsertMaskId: ").Append(InsertMaskId).Append("\n");
            sb.Append("  ShowExpanded: ").Append(ShowExpanded).Append("\n");
            sb.Append("  SingleElement: ").Append(SingleElement).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
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
                    this.ClassName == input.ClassName ||
                    (this.ClassName != null &&
                    this.ClassName.Equals(input.ClassName))
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
                if (this.ClassName != null)
                    hashCode = hashCode * 59 + this.ClassName.GetHashCode();
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
