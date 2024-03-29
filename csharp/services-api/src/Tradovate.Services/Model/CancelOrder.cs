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
    /// CancelOrder
    /// </summary>
    [DataContract]
    public partial class CancelOrder :  IEquatable<CancelOrder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CancelOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelOrder" /> class.
        /// </summary>
        /// <param name="OrderId">id of Order (required).</param>
        /// <param name="ClOrdId">ClOrdId.</param>
        /// <param name="ActivationTime">ActivationTime.</param>
        /// <param name="CustomTag50">CustomTag50.</param>
        public CancelOrder(int? OrderId = null, string ClOrdId = null, DateTime? ActivationTime = null, string CustomTag50 = null)
        {
            // to ensure "OrderId" is required (not null)
            if (OrderId == null)
            {
                throw new InvalidDataException("OrderId is a required property for CancelOrder and cannot be null");
            }
            else
            {
                this.OrderId = OrderId;
            }
            this.ClOrdId = ClOrdId;
            this.ActivationTime = ActivationTime;
            this.CustomTag50 = CustomTag50;
        }
        
        /// <summary>
        /// id of Order
        /// </summary>
        /// <value>id of Order</value>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public int? OrderId { get; set; }
        /// <summary>
        /// Gets or Sets ClOrdId
        /// </summary>
        [DataMember(Name="clOrdId", EmitDefaultValue=false)]
        public string ClOrdId { get; set; }
        /// <summary>
        /// Gets or Sets ActivationTime
        /// </summary>
        [DataMember(Name="activationTime", EmitDefaultValue=false)]
        public DateTime? ActivationTime { get; set; }
        /// <summary>
        /// Gets or Sets CustomTag50
        /// </summary>
        [DataMember(Name="customTag50", EmitDefaultValue=false)]
        public string CustomTag50 { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelOrder {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  ClOrdId: ").Append(ClOrdId).Append("\n");
            sb.Append("  ActivationTime: ").Append(ActivationTime).Append("\n");
            sb.Append("  CustomTag50: ").Append(CustomTag50).Append("\n");
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
            return this.Equals(obj as CancelOrder);
        }

        /// <summary>
        /// Returns true if CancelOrder instances are equal
        /// </summary>
        /// <param name="other">Instance of CancelOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelOrder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrderId == other.OrderId ||
                    this.OrderId != null &&
                    this.OrderId.Equals(other.OrderId)
                ) && 
                (
                    this.ClOrdId == other.ClOrdId ||
                    this.ClOrdId != null &&
                    this.ClOrdId.Equals(other.ClOrdId)
                ) && 
                (
                    this.ActivationTime == other.ActivationTime ||
                    this.ActivationTime != null &&
                    this.ActivationTime.Equals(other.ActivationTime)
                ) && 
                (
                    this.CustomTag50 == other.CustomTag50 ||
                    this.CustomTag50 != null &&
                    this.CustomTag50.Equals(other.CustomTag50)
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
                if (this.OrderId != null)
                    hash = hash * 59 + this.OrderId.GetHashCode();
                if (this.ClOrdId != null)
                    hash = hash * 59 + this.ClOrdId.GetHashCode();
                if (this.ActivationTime != null)
                    hash = hash * 59 + this.ActivationTime.GetHashCode();
                if (this.CustomTag50 != null)
                    hash = hash * 59 + this.CustomTag50.GetHashCode();
                return hash;
            }
        }
    }

}
