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
    /// Class of profiling mask schema
    /// </summary>
    [DataContract]
    public partial class MaskProfileSchemaDTO :  IEquatable<MaskProfileSchemaDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaskProfileSchemaDTO" /> class.
        /// </summary>
        /// <param name="MaskId">Mask Identifier.</param>
        /// <param name="PredefinedProfileId">Predefined Profile Identifier.</param>
        /// <param name="Options">Options.</param>
        /// <param name="Behaviour">Behaviour.</param>
        /// <param name="Id">Identifier.</param>
        /// <param name="Document">File data.</param>
        /// <param name="Fields">Fields.</param>
        /// <param name="PostProfilationActions">Post Profilation Actions.</param>
        /// <param name="ConstrainRoleBehaviour">Possible values:  0: None  1: ForceInsert  2: State .</param>
        /// <param name="Attachments">Attachments.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="PaNotes">Public Amministration Notes.</param>
        /// <param name="AuthorityData">Authority Data.</param>
        /// <param name="GeneratePaProtocol">Defines if a protocol has been generated.</param>
        public MaskProfileSchemaDTO(string MaskId = default(string), int? PredefinedProfileId = default(int?), ProfileMaskOptionsDTO Options = default(ProfileMaskOptionsDTO), ProfileMaskBehaviourDTO Behaviour = default(ProfileMaskBehaviourDTO), int? Id = default(int?), FileDTO Document = default(FileDTO), List<FieldBaseDTO> Fields = default(List<FieldBaseDTO>), List<PostProfilationActionDTO> PostProfilationActions = default(List<PostProfilationActionDTO>), int? ConstrainRoleBehaviour = default(int?), List<string> Attachments = default(List<string>), List<NoteDTO> Notes = default(List<NoteDTO>), List<string> PaNotes = default(List<string>), AuthorityDataDTO AuthorityData = default(AuthorityDataDTO), bool? GeneratePaProtocol = default(bool?))
        {
            this.MaskId = MaskId;
            this.PredefinedProfileId = PredefinedProfileId;
            this.Options = Options;
            this.Behaviour = Behaviour;
            this.Id = Id;
            this.Document = Document;
            this.Fields = Fields;
            this.PostProfilationActions = PostProfilationActions;
            this.ConstrainRoleBehaviour = ConstrainRoleBehaviour;
            this.Attachments = Attachments;
            this.Notes = Notes;
            this.PaNotes = PaNotes;
            this.AuthorityData = AuthorityData;
            this.GeneratePaProtocol = GeneratePaProtocol;
        }
        
        /// <summary>
        /// Mask Identifier
        /// </summary>
        /// <value>Mask Identifier</value>
        [DataMember(Name="maskId", EmitDefaultValue=false)]
        public string MaskId { get; set; }

        /// <summary>
        /// Predefined Profile Identifier
        /// </summary>
        /// <value>Predefined Profile Identifier</value>
        [DataMember(Name="predefinedProfileId", EmitDefaultValue=false)]
        public int? PredefinedProfileId { get; set; }

        /// <summary>
        /// Options
        /// </summary>
        /// <value>Options</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public ProfileMaskOptionsDTO Options { get; set; }

        /// <summary>
        /// Behaviour
        /// </summary>
        /// <value>Behaviour</value>
        [DataMember(Name="behaviour", EmitDefaultValue=false)]
        public ProfileMaskBehaviourDTO Behaviour { get; set; }

        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// File data
        /// </summary>
        /// <value>File data</value>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public FileDTO Document { get; set; }

        /// <summary>
        /// Fields
        /// </summary>
        /// <value>Fields</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldBaseDTO> Fields { get; set; }

        /// <summary>
        /// Post Profilation Actions
        /// </summary>
        /// <value>Post Profilation Actions</value>
        [DataMember(Name="postProfilationActions", EmitDefaultValue=false)]
        public List<PostProfilationActionDTO> PostProfilationActions { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: ForceInsert  2: State 
        /// </summary>
        /// <value>Possible values:  0: None  1: ForceInsert  2: State </value>
        [DataMember(Name="constrainRoleBehaviour", EmitDefaultValue=false)]
        public int? ConstrainRoleBehaviour { get; set; }

        /// <summary>
        /// Attachments
        /// </summary>
        /// <value>Attachments</value>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        /// <value>Notes</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public List<NoteDTO> Notes { get; set; }

        /// <summary>
        /// Public Amministration Notes
        /// </summary>
        /// <value>Public Amministration Notes</value>
        [DataMember(Name="paNotes", EmitDefaultValue=false)]
        public List<string> PaNotes { get; set; }

        /// <summary>
        /// Authority Data
        /// </summary>
        /// <value>Authority Data</value>
        [DataMember(Name="authorityData", EmitDefaultValue=false)]
        public AuthorityDataDTO AuthorityData { get; set; }

        /// <summary>
        /// Defines if a protocol has been generated
        /// </summary>
        /// <value>Defines if a protocol has been generated</value>
        [DataMember(Name="generatePaProtocol", EmitDefaultValue=false)]
        public bool? GeneratePaProtocol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaskProfileSchemaDTO {\n");
            sb.Append("  MaskId: ").Append(MaskId).Append("\n");
            sb.Append("  PredefinedProfileId: ").Append(PredefinedProfileId).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Behaviour: ").Append(Behaviour).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  PostProfilationActions: ").Append(PostProfilationActions).Append("\n");
            sb.Append("  ConstrainRoleBehaviour: ").Append(ConstrainRoleBehaviour).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  PaNotes: ").Append(PaNotes).Append("\n");
            sb.Append("  AuthorityData: ").Append(AuthorityData).Append("\n");
            sb.Append("  GeneratePaProtocol: ").Append(GeneratePaProtocol).Append("\n");
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
            return this.Equals(input as MaskProfileSchemaDTO);
        }

        /// <summary>
        /// Returns true if MaskProfileSchemaDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MaskProfileSchemaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaskProfileSchemaDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaskId == input.MaskId ||
                    (this.MaskId != null &&
                    this.MaskId.Equals(input.MaskId))
                ) && 
                (
                    this.PredefinedProfileId == input.PredefinedProfileId ||
                    (this.PredefinedProfileId != null &&
                    this.PredefinedProfileId.Equals(input.PredefinedProfileId))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
                ) && 
                (
                    this.Behaviour == input.Behaviour ||
                    (this.Behaviour != null &&
                    this.Behaviour.Equals(input.Behaviour))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.PostProfilationActions == input.PostProfilationActions ||
                    this.PostProfilationActions != null &&
                    this.PostProfilationActions.SequenceEqual(input.PostProfilationActions)
                ) && 
                (
                    this.ConstrainRoleBehaviour == input.ConstrainRoleBehaviour ||
                    (this.ConstrainRoleBehaviour != null &&
                    this.ConstrainRoleBehaviour.Equals(input.ConstrainRoleBehaviour))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Notes == input.Notes ||
                    this.Notes != null &&
                    this.Notes.SequenceEqual(input.Notes)
                ) && 
                (
                    this.PaNotes == input.PaNotes ||
                    this.PaNotes != null &&
                    this.PaNotes.SequenceEqual(input.PaNotes)
                ) && 
                (
                    this.AuthorityData == input.AuthorityData ||
                    (this.AuthorityData != null &&
                    this.AuthorityData.Equals(input.AuthorityData))
                ) && 
                (
                    this.GeneratePaProtocol == input.GeneratePaProtocol ||
                    (this.GeneratePaProtocol != null &&
                    this.GeneratePaProtocol.Equals(input.GeneratePaProtocol))
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
                if (this.MaskId != null)
                    hashCode = hashCode * 59 + this.MaskId.GetHashCode();
                if (this.PredefinedProfileId != null)
                    hashCode = hashCode * 59 + this.PredefinedProfileId.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Behaviour != null)
                    hashCode = hashCode * 59 + this.Behaviour.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Document != null)
                    hashCode = hashCode * 59 + this.Document.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.PostProfilationActions != null)
                    hashCode = hashCode * 59 + this.PostProfilationActions.GetHashCode();
                if (this.ConstrainRoleBehaviour != null)
                    hashCode = hashCode * 59 + this.ConstrainRoleBehaviour.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.PaNotes != null)
                    hashCode = hashCode * 59 + this.PaNotes.GetHashCode();
                if (this.AuthorityData != null)
                    hashCode = hashCode * 59 + this.AuthorityData.GetHashCode();
                if (this.GeneratePaProtocol != null)
                    hashCode = hashCode * 59 + this.GeneratePaProtocol.GetHashCode();
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
