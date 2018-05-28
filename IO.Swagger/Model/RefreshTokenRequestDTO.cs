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
    /// Refresh token request
    /// </summary>
    [DataContract]
    public partial class RefreshTokenRequestDTO :  IEquatable<RefreshTokenRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokenRequestDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RefreshTokenRequestDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshTokenRequestDTO" /> class.
        /// </summary>
        /// <param name="ClientId">Client id (required).</param>
        /// <param name="ClientSecret">Client secret (required).</param>
        /// <param name="RefreshToken">Refresh token to be refreshed (required).</param>
        public RefreshTokenRequestDTO(string ClientId = default(string), string ClientSecret = default(string), string RefreshToken = default(string))
        {
            // to ensure "ClientId" is required (not null)
            if (ClientId == null)
            {
                throw new InvalidDataException("ClientId is a required property for RefreshTokenRequestDTO and cannot be null");
            }
            else
            {
                this.ClientId = ClientId;
            }
            // to ensure "ClientSecret" is required (not null)
            if (ClientSecret == null)
            {
                throw new InvalidDataException("ClientSecret is a required property for RefreshTokenRequestDTO and cannot be null");
            }
            else
            {
                this.ClientSecret = ClientSecret;
            }
            // to ensure "RefreshToken" is required (not null)
            if (RefreshToken == null)
            {
                throw new InvalidDataException("RefreshToken is a required property for RefreshTokenRequestDTO and cannot be null");
            }
            else
            {
                this.RefreshToken = RefreshToken;
            }
        }
        
        /// <summary>
        /// Client id
        /// </summary>
        /// <value>Client id</value>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Client secret
        /// </summary>
        /// <value>Client secret</value>
        [DataMember(Name="clientSecret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Refresh token to be refreshed
        /// </summary>
        /// <value>Refresh token to be refreshed</value>
        [DataMember(Name="refreshToken", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefreshTokenRequestDTO {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
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
            return this.Equals(input as RefreshTokenRequestDTO);
        }

        /// <summary>
        /// Returns true if RefreshTokenRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RefreshTokenRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefreshTokenRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
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
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.RefreshToken != null)
                    hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
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
