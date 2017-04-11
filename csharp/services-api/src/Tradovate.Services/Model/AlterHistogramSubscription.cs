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
    /// AlterHistogramSubscription
    /// </summary>
    [DataContract]
    public partial class AlterHistogramSubscription :  IEquatable<AlterHistogramSubscription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlterHistogramSubscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlterHistogramSubscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlterHistogramSubscription" /> class.
        /// </summary>
        /// <param name="Symbol">Symbol (required).</param>
        /// <param name="Subscribe">Subscribe (required).</param>
        public AlterHistogramSubscription(string Symbol = default(string), bool? Subscribe = default(bool?))
        {
            // to ensure "Symbol" is required (not null)
            if (Symbol == null)
            {
                throw new InvalidDataException("Symbol is a required property for AlterHistogramSubscription and cannot be null");
            }
            else
            {
                this.Symbol = Symbol;
            }
            // to ensure "Subscribe" is required (not null)
            if (Subscribe == null)
            {
                throw new InvalidDataException("Subscribe is a required property for AlterHistogramSubscription and cannot be null");
            }
            else
            {
                this.Subscribe = Subscribe;
            }
        }
        
        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }
        /// <summary>
        /// Gets or Sets Subscribe
        /// </summary>
        [DataMember(Name="subscribe", EmitDefaultValue=false)]
        public bool? Subscribe { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlterHistogramSubscription {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Subscribe: ").Append(Subscribe).Append("\n");
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
            return this.Equals(obj as AlterHistogramSubscription);
        }

        /// <summary>
        /// Returns true if AlterHistogramSubscription instances are equal
        /// </summary>
        /// <param name="other">Instance of AlterHistogramSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlterHistogramSubscription other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Symbol == other.Symbol ||
                    this.Symbol != null &&
                    this.Symbol.Equals(other.Symbol)
                ) && 
                (
                    this.Subscribe == other.Subscribe ||
                    this.Subscribe != null &&
                    this.Subscribe.Equals(other.Subscribe)
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
                if (this.Symbol != null)
                    hash = hash * 59 + this.Symbol.GetHashCode();
                if (this.Subscribe != null)
                    hash = hash * 59 + this.Subscribe.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
