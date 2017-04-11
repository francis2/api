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
    /// SubscribeDOM
    /// </summary>
    [DataContract]
    public partial class SubscribeDOM :  IEquatable<SubscribeDOM>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribeDOM" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscribeDOM() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribeDOM" /> class.
        /// </summary>
        /// <param name="Symbol">Symbol (required).</param>
        /// <param name="Filter">Filter (required).</param>
        public SubscribeDOM(string Symbol = default(string), List<string> Filter = default(List<string>))
        {
            // to ensure "Symbol" is required (not null)
            if (Symbol == null)
            {
                throw new InvalidDataException("Symbol is a required property for SubscribeDOM and cannot be null");
            }
            else
            {
                this.Symbol = Symbol;
            }
            // to ensure "Filter" is required (not null)
            if (Filter == null)
            {
                throw new InvalidDataException("Filter is a required property for SubscribeDOM and cannot be null");
            }
            else
            {
                this.Filter = Filter;
            }
        }
        
        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }
        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public List<string> Filter { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscribeDOM {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
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
            return this.Equals(obj as SubscribeDOM);
        }

        /// <summary>
        /// Returns true if SubscribeDOM instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscribeDOM to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscribeDOM other)
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
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.SequenceEqual(other.Filter)
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
                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
