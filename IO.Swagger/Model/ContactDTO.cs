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
    /// Class of the Contact item
    /// </summary>
    [DataContract]
    public partial class ContactDTO :  IEquatable<ContactDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactDTO" /> class.
        /// </summary>
        /// <param name="AddressBookId">Identifier of Address Book.</param>
        /// <param name="ContactName">Name.</param>
        /// <param name="Job">Job.</param>
        /// <param name="Phone">Phone Number.</param>
        /// <param name="Fax">Fax Number.</param>
        /// <param name="CellPhone">Mobile Phone Number.</param>
        /// <param name="House">Address.</param>
        /// <param name="Department">Department.</param>
        /// <param name="Office">Office.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Id">Identifier.</param>
        public ContactDTO(int? AddressBookId = default(int?), string ContactName = default(string), string Job = default(string), string Phone = default(string), string Fax = default(string), string CellPhone = default(string), string House = default(string), string Department = default(string), string Office = default(string), string Email = default(string), int? Id = default(int?))
        {
            this.AddressBookId = AddressBookId;
            this.ContactName = ContactName;
            this.Job = Job;
            this.Phone = Phone;
            this.Fax = Fax;
            this.CellPhone = CellPhone;
            this.House = House;
            this.Department = Department;
            this.Office = Office;
            this.Email = Email;
            this.Id = Id;
        }
        
        /// <summary>
        /// Identifier of Address Book
        /// </summary>
        /// <value>Identifier of Address Book</value>
        [DataMember(Name="addressBookId", EmitDefaultValue=false)]
        public int? AddressBookId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="contactName", EmitDefaultValue=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// Job
        /// </summary>
        /// <value>Job</value>
        [DataMember(Name="job", EmitDefaultValue=false)]
        public string Job { get; set; }

        /// <summary>
        /// Phone Number
        /// </summary>
        /// <value>Phone Number</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Fax Number
        /// </summary>
        /// <value>Fax Number</value>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }

        /// <summary>
        /// Mobile Phone Number
        /// </summary>
        /// <value>Mobile Phone Number</value>
        [DataMember(Name="cellPhone", EmitDefaultValue=false)]
        public string CellPhone { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        /// <value>Address</value>
        [DataMember(Name="house", EmitDefaultValue=false)]
        public string House { get; set; }

        /// <summary>
        /// Department
        /// </summary>
        /// <value>Department</value>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }

        /// <summary>
        /// Office
        /// </summary>
        /// <value>Office</value>
        [DataMember(Name="office", EmitDefaultValue=false)]
        public string Office { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactDTO {\n");
            sb.Append("  AddressBookId: ").Append(AddressBookId).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  Job: ").Append(Job).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  CellPhone: ").Append(CellPhone).Append("\n");
            sb.Append("  House: ").Append(House).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Office: ").Append(Office).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as ContactDTO);
        }

        /// <summary>
        /// Returns true if ContactDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressBookId == input.AddressBookId ||
                    (this.AddressBookId != null &&
                    this.AddressBookId.Equals(input.AddressBookId))
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.Job == input.Job ||
                    (this.Job != null &&
                    this.Job.Equals(input.Job))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.CellPhone == input.CellPhone ||
                    (this.CellPhone != null &&
                    this.CellPhone.Equals(input.CellPhone))
                ) && 
                (
                    this.House == input.House ||
                    (this.House != null &&
                    this.House.Equals(input.House))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.Office == input.Office ||
                    (this.Office != null &&
                    this.Office.Equals(input.Office))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.AddressBookId != null)
                    hashCode = hashCode * 59 + this.AddressBookId.GetHashCode();
                if (this.ContactName != null)
                    hashCode = hashCode * 59 + this.ContactName.GetHashCode();
                if (this.Job != null)
                    hashCode = hashCode * 59 + this.Job.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.CellPhone != null)
                    hashCode = hashCode * 59 + this.CellPhone.GetHashCode();
                if (this.House != null)
                    hashCode = hashCode * 59 + this.House.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.Office != null)
                    hashCode = hashCode * 59 + this.Office.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
