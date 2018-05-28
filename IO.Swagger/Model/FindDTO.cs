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
    /// Class of find data
    /// </summary>
    [DataContract]
    public partial class FindDTO :  IEquatable<FindDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindDTO" /> class.
        /// </summary>
        /// <param name="Id">Identifier.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Owner">Author.</param>
        /// <param name="OwnerDescription">Author Description.</param>
        /// <param name="Context">Possible values:  0: Dm_Profile_Search  1: Dm_ElencoPratiche_Search  2: Dm_TaskWork_Search  3: Dm_UtentiBase_Search  4: Dm_Contatti_Search  5: ExternalData  6: Dm_Profile_Search_For_Fasciculation  7: Dm_Profile_Search_For_User_Default  8: Dm_Contatti_Search_For_User_Default .</param>
        /// <param name="ShowFields">Show Fields.</param>
        /// <param name="FormOpen">Open the Form.</param>
        /// <param name="ShowOnDesktop">Show on Desktop.</param>
        /// <param name="FolderId">Folder Identifier.</param>
        /// <param name="ExternalId">External Identifier.</param>
        /// <param name="TableName">Table Name.</param>
        /// <param name="TableFieldId">Table Field Identifier.</param>
        public FindDTO(string Id = default(string), string Description = default(string), int? Owner = default(int?), string OwnerDescription = default(string), int? Context = default(int?), bool? ShowFields = default(bool?), bool? FormOpen = default(bool?), bool? ShowOnDesktop = default(bool?), int? FolderId = default(int?), string ExternalId = default(string), string TableName = default(string), string TableFieldId = default(string))
        {
            this.Id = Id;
            this.Description = Description;
            this.Owner = Owner;
            this.OwnerDescription = OwnerDescription;
            this.Context = Context;
            this.ShowFields = ShowFields;
            this.FormOpen = FormOpen;
            this.ShowOnDesktop = ShowOnDesktop;
            this.FolderId = FolderId;
            this.ExternalId = ExternalId;
            this.TableName = TableName;
            this.TableFieldId = TableFieldId;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        /// <value>Author</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public int? Owner { get; set; }

        /// <summary>
        /// Author Description
        /// </summary>
        /// <value>Author Description</value>
        [DataMember(Name="ownerDescription", EmitDefaultValue=false)]
        public string OwnerDescription { get; set; }

        /// <summary>
        /// Possible values:  0: Dm_Profile_Search  1: Dm_ElencoPratiche_Search  2: Dm_TaskWork_Search  3: Dm_UtentiBase_Search  4: Dm_Contatti_Search  5: ExternalData  6: Dm_Profile_Search_For_Fasciculation  7: Dm_Profile_Search_For_User_Default  8: Dm_Contatti_Search_For_User_Default 
        /// </summary>
        /// <value>Possible values:  0: Dm_Profile_Search  1: Dm_ElencoPratiche_Search  2: Dm_TaskWork_Search  3: Dm_UtentiBase_Search  4: Dm_Contatti_Search  5: ExternalData  6: Dm_Profile_Search_For_Fasciculation  7: Dm_Profile_Search_For_User_Default  8: Dm_Contatti_Search_For_User_Default </value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public int? Context { get; set; }

        /// <summary>
        /// Show Fields
        /// </summary>
        /// <value>Show Fields</value>
        [DataMember(Name="showFields", EmitDefaultValue=false)]
        public bool? ShowFields { get; set; }

        /// <summary>
        /// Open the Form
        /// </summary>
        /// <value>Open the Form</value>
        [DataMember(Name="formOpen", EmitDefaultValue=false)]
        public bool? FormOpen { get; set; }

        /// <summary>
        /// Show on Desktop
        /// </summary>
        /// <value>Show on Desktop</value>
        [DataMember(Name="showOnDesktop", EmitDefaultValue=false)]
        public bool? ShowOnDesktop { get; set; }

        /// <summary>
        /// Folder Identifier
        /// </summary>
        /// <value>Folder Identifier</value>
        [DataMember(Name="folderId", EmitDefaultValue=false)]
        public int? FolderId { get; set; }

        /// <summary>
        /// External Identifier
        /// </summary>
        /// <value>External Identifier</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Table Name
        /// </summary>
        /// <value>Table Name</value>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }

        /// <summary>
        /// Table Field Identifier
        /// </summary>
        /// <value>Table Field Identifier</value>
        [DataMember(Name="tableFieldId", EmitDefaultValue=false)]
        public string TableFieldId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  OwnerDescription: ").Append(OwnerDescription).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  ShowFields: ").Append(ShowFields).Append("\n");
            sb.Append("  FormOpen: ").Append(FormOpen).Append("\n");
            sb.Append("  ShowOnDesktop: ").Append(ShowOnDesktop).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  TableFieldId: ").Append(TableFieldId).Append("\n");
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
            return this.Equals(input as FindDTO);
        }

        /// <summary>
        /// Returns true if FindDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FindDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.OwnerDescription == input.OwnerDescription ||
                    (this.OwnerDescription != null &&
                    this.OwnerDescription.Equals(input.OwnerDescription))
                ) && 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.ShowFields == input.ShowFields ||
                    (this.ShowFields != null &&
                    this.ShowFields.Equals(input.ShowFields))
                ) && 
                (
                    this.FormOpen == input.FormOpen ||
                    (this.FormOpen != null &&
                    this.FormOpen.Equals(input.FormOpen))
                ) && 
                (
                    this.ShowOnDesktop == input.ShowOnDesktop ||
                    (this.ShowOnDesktop != null &&
                    this.ShowOnDesktop.Equals(input.ShowOnDesktop))
                ) && 
                (
                    this.FolderId == input.FolderId ||
                    (this.FolderId != null &&
                    this.FolderId.Equals(input.FolderId))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && 
                (
                    this.TableFieldId == input.TableFieldId ||
                    (this.TableFieldId != null &&
                    this.TableFieldId.Equals(input.TableFieldId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.OwnerDescription != null)
                    hashCode = hashCode * 59 + this.OwnerDescription.GetHashCode();
                if (this.Context != null)
                    hashCode = hashCode * 59 + this.Context.GetHashCode();
                if (this.ShowFields != null)
                    hashCode = hashCode * 59 + this.ShowFields.GetHashCode();
                if (this.FormOpen != null)
                    hashCode = hashCode * 59 + this.FormOpen.GetHashCode();
                if (this.ShowOnDesktop != null)
                    hashCode = hashCode * 59 + this.ShowOnDesktop.GetHashCode();
                if (this.FolderId != null)
                    hashCode = hashCode * 59 + this.FolderId.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.TableFieldId != null)
                    hashCode = hashCode * 59 + this.TableFieldId.GetHashCode();
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
