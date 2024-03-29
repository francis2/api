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
    /// AddTradovateSubscription
    /// </summary>
    [DataContract]
    public partial class AddTradovateSubscription :  IEquatable<AddTradovateSubscription>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddTradovateSubscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddTradovateSubscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddTradovateSubscription" /> class.
        /// </summary>
        /// <param name="TradovateSubscriptionPlanId">id of TradovateSubscriptionPlan (required).</param>
        /// <param name="AccountId">id of Account.</param>
        /// <param name="UserId">id of User.</param>
        public AddTradovateSubscription(int? TradovateSubscriptionPlanId = null, int? AccountId = null, int? UserId = null)
        {
            // to ensure "TradovateSubscriptionPlanId" is required (not null)
            if (TradovateSubscriptionPlanId == null)
            {
                throw new InvalidDataException("TradovateSubscriptionPlanId is a required property for AddTradovateSubscription and cannot be null");
            }
            else
            {
                this.TradovateSubscriptionPlanId = TradovateSubscriptionPlanId;
            }
            this.AccountId = AccountId;
            this.UserId = UserId;
        }
        
        /// <summary>
        /// id of TradovateSubscriptionPlan
        /// </summary>
        /// <value>id of TradovateSubscriptionPlan</value>
        [DataMember(Name="tradovateSubscriptionPlanId", EmitDefaultValue=false)]
        public int? TradovateSubscriptionPlanId { get; set; }
        /// <summary>
        /// id of Account
        /// </summary>
        /// <value>id of Account</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int? AccountId { get; set; }
        /// <summary>
        /// id of User
        /// </summary>
        /// <value>id of User</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddTradovateSubscription {\n");
            sb.Append("  TradovateSubscriptionPlanId: ").Append(TradovateSubscriptionPlanId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(obj as AddTradovateSubscription);
        }

        /// <summary>
        /// Returns true if AddTradovateSubscription instances are equal
        /// </summary>
        /// <param name="other">Instance of AddTradovateSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddTradovateSubscription other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TradovateSubscriptionPlanId == other.TradovateSubscriptionPlanId ||
                    this.TradovateSubscriptionPlanId != null &&
                    this.TradovateSubscriptionPlanId.Equals(other.TradovateSubscriptionPlanId)
                ) && 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
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
                if (this.TradovateSubscriptionPlanId != null)
                    hash = hash * 59 + this.TradovateSubscriptionPlanId.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                return hash;
            }
        }
    }

}
