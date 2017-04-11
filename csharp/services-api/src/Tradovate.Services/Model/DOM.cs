/* 
 * Tradovate API
 *
 * Tradovate API
 *
 * OpenAPI spec version: 1.0.0
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

namespace Tradovate.Services.Model
{
    /// <summary>
    /// DOM
    /// </summary>
    [DataContract]
    public partial class DOM :  IEquatable<DOM>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DOM" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DOM() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DOM" /> class.
        /// </summary>
        /// <param name="ContractId">id of Contract (required).</param>
        /// <param name="Timestamp">Timestamp (required).</param>
        /// <param name="Bids">Bids (required).</param>
        /// <param name="Offers">Offers (required).</param>
        /// <param name="Id">Id.</param>
        public DOM(int? ContractId = default(int?), DateTime? Timestamp = default(DateTime?), List<PriceLevel> Bids = default(List<PriceLevel>), List<PriceLevel> Offers = default(List<PriceLevel>), int? Id = default(int?))
        {
            // to ensure "ContractId" is required (not null)
            if (ContractId == null)
            {
                throw new InvalidDataException("ContractId is a required property for DOM and cannot be null");
            }
            else
            {
                this.ContractId = ContractId;
            }
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for DOM and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "Bids" is required (not null)
            if (Bids == null)
            {
                throw new InvalidDataException("Bids is a required property for DOM and cannot be null");
            }
            else
            {
                this.Bids = Bids;
            }
            // to ensure "Offers" is required (not null)
            if (Offers == null)
            {
                throw new InvalidDataException("Offers is a required property for DOM and cannot be null");
            }
            else
            {
                this.Offers = Offers;
            }
            this.Id = Id;
        }
        
        /// <summary>
        /// id of Contract
        /// </summary>
        /// <value>id of Contract</value>
        [DataMember(Name="contractId", EmitDefaultValue=false)]
        public int? ContractId { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Gets or Sets Bids
        /// </summary>
        [DataMember(Name="bids", EmitDefaultValue=false)]
        public List<PriceLevel> Bids { get; set; }
        /// <summary>
        /// Gets or Sets Offers
        /// </summary>
        [DataMember(Name="offers", EmitDefaultValue=false)]
        public List<PriceLevel> Offers { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DOM {\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Bids: ").Append(Bids).Append("\n");
            sb.Append("  Offers: ").Append(Offers).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as DOM);
        }

        /// <summary>
        /// Returns true if DOM instances are equal
        /// </summary>
        /// <param name="other">Instance of DOM to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DOM other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContractId == other.ContractId ||
                    this.ContractId != null &&
                    this.ContractId.Equals(other.ContractId)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.Bids == other.Bids ||
                    this.Bids != null &&
                    this.Bids.SequenceEqual(other.Bids)
                ) && 
                (
                    this.Offers == other.Offers ||
                    this.Offers != null &&
                    this.Offers.SequenceEqual(other.Offers)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ContractId != null)
                    hash = hash * 59 + this.ContractId.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.Bids != null)
                    hash = hash * 59 + this.Bids.GetHashCode();
                if (this.Offers != null)
                    hash = hash * 59 + this.Offers.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // ContractId (int?) minimum
            if(this.ContractId < (int?)0)
            {
                yield return new ValidationResult("Invalid value for ContractId, must be a value greater than or equal to 0.", new [] { "ContractId" });
            }

            yield break;
        }
    }

}
