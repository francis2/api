/* 
 * Tradovate API
 *
 * Tradovate API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tradovate.Services.Model
{
    /// <summary>
    /// OrderStrategyLink
    /// </summary>
    [DataContract]
    public partial class OrderStrategyLink :  IEquatable<OrderStrategyLink>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderStrategyLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderStrategyLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderStrategyLink" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="OrderStrategyId">id of OrderStrategy (required).</param>
        /// <param name="OrderId">id of Order (required).</param>
        /// <param name="Label">Label (required).</param>
        public OrderStrategyLink(int? Id = null, int? OrderStrategyId = null, int? OrderId = null, string Label = null)
        {
            // to ensure "OrderStrategyId" is required (not null)
            if (OrderStrategyId == null)
            {
                throw new InvalidDataException("OrderStrategyId is a required property for OrderStrategyLink and cannot be null");
            }
            else
            {
                this.OrderStrategyId = OrderStrategyId;
            }
            // to ensure "OrderId" is required (not null)
            if (OrderId == null)
            {
                throw new InvalidDataException("OrderId is a required property for OrderStrategyLink and cannot be null");
            }
            else
            {
                this.OrderId = OrderId;
            }
            // to ensure "Label" is required (not null)
            if (Label == null)
            {
                throw new InvalidDataException("Label is a required property for OrderStrategyLink and cannot be null");
            }
            else
            {
                this.Label = Label;
            }
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// id of OrderStrategy
        /// </summary>
        /// <value>id of OrderStrategy</value>
        [DataMember(Name="orderStrategyId", EmitDefaultValue=false)]
        public int? OrderStrategyId { get; set; }
        /// <summary>
        /// id of Order
        /// </summary>
        /// <value>id of Order</value>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public int? OrderId { get; set; }
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderStrategyLink {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderStrategyId: ").Append(OrderStrategyId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(obj as OrderStrategyLink);
        }

        /// <summary>
        /// Returns true if OrderStrategyLink instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderStrategyLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderStrategyLink other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.OrderStrategyId == other.OrderStrategyId ||
                    this.OrderStrategyId != null &&
                    this.OrderStrategyId.Equals(other.OrderStrategyId)
                ) && 
                (
                    this.OrderId == other.OrderId ||
                    this.OrderId != null &&
                    this.OrderId.Equals(other.OrderId)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.OrderStrategyId != null)
                    hash = hash * 59 + this.OrderStrategyId.GetHashCode();
                if (this.OrderId != null)
                    hash = hash * 59 + this.OrderId.GetHashCode();
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                return hash;
            }
        }
    }

}