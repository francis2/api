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
    /// CancelChart
    /// </summary>
    [DataContract]
    public partial class CancelChart :  IEquatable<CancelChart>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelChart" /> class.
        /// </summary>
        /// <param name="SubscriptionId">SubscriptionId.</param>
        public CancelChart(int? SubscriptionId = default(int?))
        {
            this.SubscriptionId = SubscriptionId;
        }
        
        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name="subscriptionId", EmitDefaultValue=false)]
        public int? SubscriptionId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelChart {\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
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
            return this.Equals(obj as CancelChart);
        }

        /// <summary>
        /// Returns true if CancelChart instances are equal
        /// </summary>
        /// <param name="other">Instance of CancelChart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelChart other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SubscriptionId == other.SubscriptionId ||
                    this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(other.SubscriptionId)
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
                if (this.SubscriptionId != null)
                    hash = hash * 59 + this.SubscriptionId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
