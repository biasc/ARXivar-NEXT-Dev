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
    /// This class contain information about avaible filters for a given additional field
    /// </summary>
    [DataContract]
    public partial class FieldFilterConcreteDTO :  IEquatable<FieldFilterConcreteDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldFilterConcreteDTO" /> class.
        /// </summary>
        /// <param name="KeyField">The column name of the property that the client have to use for set the value of the additional field.</param>
        /// <param name="SelectField">The column name of the property that the client have to use for display the value of the additional field.</param>
        /// <param name="DateTimeFields">Array of avaible filters for the additional field DateTime.</param>
        /// <param name="StringFields">Array of avaible filters for the additional field string.</param>
        /// <param name="IntFields">Array of avaible filters for the additional field int.</param>
        /// <param name="BoolFields">Array of avaible filters for the additional field bool.</param>
        /// <param name="DoubleFields">Array of avaible filters for the additional field double.</param>
        /// <param name="StringListFields">Array of avaible filters for the additional field stringlist.</param>
        /// <param name="ShowFilled">This property show to client if the search for this field has to be prefilled or not.</param>
        /// <param name="DefaultField">The name of filter to use for this field by default.</param>
        public FieldFilterConcreteDTO(string KeyField = default(string), string SelectField = default(string), List<FieldBaseForSearchDateTimeDto> DateTimeFields = default(List<FieldBaseForSearchDateTimeDto>), List<FieldBaseForSearchStringDto> StringFields = default(List<FieldBaseForSearchStringDto>), List<FieldBaseForSearchIntDto> IntFields = default(List<FieldBaseForSearchIntDto>), List<FieldBaseForSearchBoolDto> BoolFields = default(List<FieldBaseForSearchBoolDto>), List<FieldBaseForSearchDoubleDto> DoubleFields = default(List<FieldBaseForSearchDoubleDto>), List<FieldBaseForSearchListDto> StringListFields = default(List<FieldBaseForSearchListDto>), bool? ShowFilled = default(bool?), string DefaultField = default(string))
        {
            this.KeyField = KeyField;
            this.SelectField = SelectField;
            this.DateTimeFields = DateTimeFields;
            this.StringFields = StringFields;
            this.IntFields = IntFields;
            this.BoolFields = BoolFields;
            this.DoubleFields = DoubleFields;
            this.StringListFields = StringListFields;
            this.ShowFilled = ShowFilled;
            this.DefaultField = DefaultField;
        }
        
        /// <summary>
        /// The column name of the property that the client have to use for set the value of the additional field
        /// </summary>
        /// <value>The column name of the property that the client have to use for set the value of the additional field</value>
        [DataMember(Name="keyField", EmitDefaultValue=false)]
        public string KeyField { get; set; }

        /// <summary>
        /// The column name of the property that the client have to use for display the value of the additional field
        /// </summary>
        /// <value>The column name of the property that the client have to use for display the value of the additional field</value>
        [DataMember(Name="selectField", EmitDefaultValue=false)]
        public string SelectField { get; set; }

        /// <summary>
        /// Array of avaible filters for the additional field DateTime
        /// </summary>
        /// <value>Array of avaible filters for the additional field DateTime</value>
        [DataMember(Name="dateTimeFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchDateTimeDto> DateTimeFields { get; set; }

        /// <summary>
        /// Array of avaible filters for the additional field string
        /// </summary>
        /// <value>Array of avaible filters for the additional field string</value>
        [DataMember(Name="stringFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchStringDto> StringFields { get; set; }

        /// <summary>
        /// Array of avaible filters for the additional field int
        /// </summary>
        /// <value>Array of avaible filters for the additional field int</value>
        [DataMember(Name="intFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchIntDto> IntFields { get; set; }

        /// <summary>
        /// Array of avaible filters for the additional field bool
        /// </summary>
        /// <value>Array of avaible filters for the additional field bool</value>
        [DataMember(Name="boolFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchBoolDto> BoolFields { get; set; }

        /// <summary>
        /// Array of avaible filters for the additional field double
        /// </summary>
        /// <value>Array of avaible filters for the additional field double</value>
        [DataMember(Name="doubleFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchDoubleDto> DoubleFields { get; set; }

        /// <summary>
        /// Array of avaible filters for the additional field stringlist
        /// </summary>
        /// <value>Array of avaible filters for the additional field stringlist</value>
        [DataMember(Name="stringListFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchListDto> StringListFields { get; set; }

        /// <summary>
        /// This property show to client if the search for this field has to be prefilled or not
        /// </summary>
        /// <value>This property show to client if the search for this field has to be prefilled or not</value>
        [DataMember(Name="showFilled", EmitDefaultValue=false)]
        public bool? ShowFilled { get; set; }

        /// <summary>
        /// The name of filter to use for this field by default
        /// </summary>
        /// <value>The name of filter to use for this field by default</value>
        [DataMember(Name="defaultField", EmitDefaultValue=false)]
        public string DefaultField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldFilterConcreteDTO {\n");
            sb.Append("  KeyField: ").Append(KeyField).Append("\n");
            sb.Append("  SelectField: ").Append(SelectField).Append("\n");
            sb.Append("  DateTimeFields: ").Append(DateTimeFields).Append("\n");
            sb.Append("  StringFields: ").Append(StringFields).Append("\n");
            sb.Append("  IntFields: ").Append(IntFields).Append("\n");
            sb.Append("  BoolFields: ").Append(BoolFields).Append("\n");
            sb.Append("  DoubleFields: ").Append(DoubleFields).Append("\n");
            sb.Append("  StringListFields: ").Append(StringListFields).Append("\n");
            sb.Append("  ShowFilled: ").Append(ShowFilled).Append("\n");
            sb.Append("  DefaultField: ").Append(DefaultField).Append("\n");
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
            return this.Equals(input as FieldFilterConcreteDTO);
        }

        /// <summary>
        /// Returns true if FieldFilterConcreteDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldFilterConcreteDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldFilterConcreteDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyField == input.KeyField ||
                    (this.KeyField != null &&
                    this.KeyField.Equals(input.KeyField))
                ) && 
                (
                    this.SelectField == input.SelectField ||
                    (this.SelectField != null &&
                    this.SelectField.Equals(input.SelectField))
                ) && 
                (
                    this.DateTimeFields == input.DateTimeFields ||
                    this.DateTimeFields != null &&
                    this.DateTimeFields.SequenceEqual(input.DateTimeFields)
                ) && 
                (
                    this.StringFields == input.StringFields ||
                    this.StringFields != null &&
                    this.StringFields.SequenceEqual(input.StringFields)
                ) && 
                (
                    this.IntFields == input.IntFields ||
                    this.IntFields != null &&
                    this.IntFields.SequenceEqual(input.IntFields)
                ) && 
                (
                    this.BoolFields == input.BoolFields ||
                    this.BoolFields != null &&
                    this.BoolFields.SequenceEqual(input.BoolFields)
                ) && 
                (
                    this.DoubleFields == input.DoubleFields ||
                    this.DoubleFields != null &&
                    this.DoubleFields.SequenceEqual(input.DoubleFields)
                ) && 
                (
                    this.StringListFields == input.StringListFields ||
                    this.StringListFields != null &&
                    this.StringListFields.SequenceEqual(input.StringListFields)
                ) && 
                (
                    this.ShowFilled == input.ShowFilled ||
                    (this.ShowFilled != null &&
                    this.ShowFilled.Equals(input.ShowFilled))
                ) && 
                (
                    this.DefaultField == input.DefaultField ||
                    (this.DefaultField != null &&
                    this.DefaultField.Equals(input.DefaultField))
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
                if (this.KeyField != null)
                    hashCode = hashCode * 59 + this.KeyField.GetHashCode();
                if (this.SelectField != null)
                    hashCode = hashCode * 59 + this.SelectField.GetHashCode();
                if (this.DateTimeFields != null)
                    hashCode = hashCode * 59 + this.DateTimeFields.GetHashCode();
                if (this.StringFields != null)
                    hashCode = hashCode * 59 + this.StringFields.GetHashCode();
                if (this.IntFields != null)
                    hashCode = hashCode * 59 + this.IntFields.GetHashCode();
                if (this.BoolFields != null)
                    hashCode = hashCode * 59 + this.BoolFields.GetHashCode();
                if (this.DoubleFields != null)
                    hashCode = hashCode * 59 + this.DoubleFields.GetHashCode();
                if (this.StringListFields != null)
                    hashCode = hashCode * 59 + this.StringListFields.GetHashCode();
                if (this.ShowFilled != null)
                    hashCode = hashCode * 59 + this.ShowFilled.GetHashCode();
                if (this.DefaultField != null)
                    hashCode = hashCode * 59 + this.DefaultField.GetHashCode();
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
