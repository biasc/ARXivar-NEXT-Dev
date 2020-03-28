/* 
 * WebAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: data
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
    /// Sharing receiver informations.
    /// </summary>
    [DataContract]
    public partial class SharingReceiverDTO :  IEquatable<SharingReceiverDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharingReceiverDTO" /> class.
        /// </summary>
        /// <param name="sharingReceiverId">Unique identifier for sharing receiver.</param>
        /// <param name="sharingId">Unique identifier for sharing..</param>
        /// <param name="email">email address..</param>
        /// <param name="address">Postal Address..</param>
        /// <param name="cap">Postal code..</param>
        /// <param name="location">Location.</param>
        /// <param name="province">Provincia..</param>
        /// <param name="country">Country..</param>
        /// <param name="addressBookId">Unique identifier for AddressBook.</param>
        /// <param name="contactId">Unique identifier for Contact.</param>
        /// <param name="sharingReadingTime">Number of read operations..</param>
        /// <param name="sharingReadingLastTime">Last reading DateTIme..</param>
        /// <param name="lang">Lang code..</param>
        /// <param name="receiverName">Name of the receiver..</param>
        /// <param name="processed">Number of sharing elaboration.</param>
        public SharingReceiverDTO(string sharingReceiverId = default(string), string sharingId = default(string), string email = default(string), string address = default(string), string cap = default(string), string location = default(string), string province = default(string), string country = default(string), int? addressBookId = default(int?), int? contactId = default(int?), int? sharingReadingTime = default(int?), DateTime? sharingReadingLastTime = default(DateTime?), string lang = default(string), string receiverName = default(string), int? processed = default(int?))
        {
            this.SharingReceiverId = sharingReceiverId;
            this.SharingId = sharingId;
            this.Email = email;
            this.Address = address;
            this.Cap = cap;
            this.Location = location;
            this.Province = province;
            this.Country = country;
            this.AddressBookId = addressBookId;
            this.ContactId = contactId;
            this.SharingReadingTime = sharingReadingTime;
            this.SharingReadingLastTime = sharingReadingLastTime;
            this.Lang = lang;
            this.ReceiverName = receiverName;
            this.Processed = processed;
        }
        
        /// <summary>
        /// Unique identifier for sharing receiver
        /// </summary>
        /// <value>Unique identifier for sharing receiver</value>
        [DataMember(Name="sharingReceiverId", EmitDefaultValue=false)]
        public string SharingReceiverId { get; set; }

        /// <summary>
        /// Unique identifier for sharing.
        /// </summary>
        /// <value>Unique identifier for sharing.</value>
        [DataMember(Name="sharingId", EmitDefaultValue=false)]
        public string SharingId { get; set; }

        /// <summary>
        /// email address.
        /// </summary>
        /// <value>email address.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Postal Address.
        /// </summary>
        /// <value>Postal Address.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        /// <value>Postal code.</value>
        [DataMember(Name="cap", EmitDefaultValue=false)]
        public string Cap { get; set; }

        /// <summary>
        /// Location
        /// </summary>
        /// <value>Location</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Provincia.
        /// </summary>
        /// <value>Provincia.</value>
        [DataMember(Name="province", EmitDefaultValue=false)]
        public string Province { get; set; }

        /// <summary>
        /// Country.
        /// </summary>
        /// <value>Country.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Unique identifier for AddressBook
        /// </summary>
        /// <value>Unique identifier for AddressBook</value>
        [DataMember(Name="addressBookId", EmitDefaultValue=false)]
        public int? AddressBookId { get; set; }

        /// <summary>
        /// Unique identifier for Contact
        /// </summary>
        /// <value>Unique identifier for Contact</value>
        [DataMember(Name="contactId", EmitDefaultValue=false)]
        public int? ContactId { get; set; }

        /// <summary>
        /// Number of read operations.
        /// </summary>
        /// <value>Number of read operations.</value>
        [DataMember(Name="sharingReadingTime", EmitDefaultValue=false)]
        public int? SharingReadingTime { get; set; }

        /// <summary>
        /// Last reading DateTIme.
        /// </summary>
        /// <value>Last reading DateTIme.</value>
        [DataMember(Name="sharingReadingLastTime", EmitDefaultValue=false)]
        public DateTime? SharingReadingLastTime { get; set; }

        /// <summary>
        /// Lang code.
        /// </summary>
        /// <value>Lang code.</value>
        [DataMember(Name="lang", EmitDefaultValue=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Name of the receiver.
        /// </summary>
        /// <value>Name of the receiver.</value>
        [DataMember(Name="receiverName", EmitDefaultValue=false)]
        public string ReceiverName { get; set; }

        /// <summary>
        /// Number of sharing elaboration
        /// </summary>
        /// <value>Number of sharing elaboration</value>
        [DataMember(Name="processed", EmitDefaultValue=false)]
        public int? Processed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharingReceiverDTO {\n");
            sb.Append("  SharingReceiverId: ").Append(SharingReceiverId).Append("\n");
            sb.Append("  SharingId: ").Append(SharingId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Cap: ").Append(Cap).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  AddressBookId: ").Append(AddressBookId).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  SharingReadingTime: ").Append(SharingReadingTime).Append("\n");
            sb.Append("  SharingReadingLastTime: ").Append(SharingReadingLastTime).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("  ReceiverName: ").Append(ReceiverName).Append("\n");
            sb.Append("  Processed: ").Append(Processed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as SharingReceiverDTO);
        }

        /// <summary>
        /// Returns true if SharingReceiverDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SharingReceiverDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharingReceiverDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SharingReceiverId == input.SharingReceiverId ||
                    (this.SharingReceiverId != null &&
                    this.SharingReceiverId.Equals(input.SharingReceiverId))
                ) && 
                (
                    this.SharingId == input.SharingId ||
                    (this.SharingId != null &&
                    this.SharingId.Equals(input.SharingId))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Cap == input.Cap ||
                    (this.Cap != null &&
                    this.Cap.Equals(input.Cap))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.AddressBookId == input.AddressBookId ||
                    (this.AddressBookId != null &&
                    this.AddressBookId.Equals(input.AddressBookId))
                ) && 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.SharingReadingTime == input.SharingReadingTime ||
                    (this.SharingReadingTime != null &&
                    this.SharingReadingTime.Equals(input.SharingReadingTime))
                ) && 
                (
                    this.SharingReadingLastTime == input.SharingReadingLastTime ||
                    (this.SharingReadingLastTime != null &&
                    this.SharingReadingLastTime.Equals(input.SharingReadingLastTime))
                ) && 
                (
                    this.Lang == input.Lang ||
                    (this.Lang != null &&
                    this.Lang.Equals(input.Lang))
                ) && 
                (
                    this.ReceiverName == input.ReceiverName ||
                    (this.ReceiverName != null &&
                    this.ReceiverName.Equals(input.ReceiverName))
                ) && 
                (
                    this.Processed == input.Processed ||
                    (this.Processed != null &&
                    this.Processed.Equals(input.Processed))
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
                if (this.SharingReceiverId != null)
                    hashCode = hashCode * 59 + this.SharingReceiverId.GetHashCode();
                if (this.SharingId != null)
                    hashCode = hashCode * 59 + this.SharingId.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Cap != null)
                    hashCode = hashCode * 59 + this.Cap.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.AddressBookId != null)
                    hashCode = hashCode * 59 + this.AddressBookId.GetHashCode();
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                if (this.SharingReadingTime != null)
                    hashCode = hashCode * 59 + this.SharingReadingTime.GetHashCode();
                if (this.SharingReadingLastTime != null)
                    hashCode = hashCode * 59 + this.SharingReadingLastTime.GetHashCode();
                if (this.Lang != null)
                    hashCode = hashCode * 59 + this.Lang.GetHashCode();
                if (this.ReceiverName != null)
                    hashCode = hashCode * 59 + this.ReceiverName.GetHashCode();
                if (this.Processed != null)
                    hashCode = hashCode * 59 + this.Processed.GetHashCode();
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
