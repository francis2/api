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
    /// Order
    /// </summary>
    [DataContract]
    public partial class Order :  IEquatable<Order>
    {
        /// <summary>
        /// Buy, Sell
        /// </summary>
        /// <value>Buy, Sell</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum Buy for "Buy"
            /// </summary>
            [EnumMember(Value = "Buy")]
            Buy,
            
            /// <summary>
            /// Enum Sell for "Sell"
            /// </summary>
            [EnumMember(Value = "Sell")]
            Sell
        }

        /// <summary>
        /// Canceled, Completed, Expired, Filled, PendingCancel, PendingNew, PendingReplace, Rejected, Suspended, Unknown, Working
        /// </summary>
        /// <value>Canceled, Completed, Expired, Filled, PendingCancel, PendingNew, PendingReplace, Rejected, Suspended, Unknown, Working</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrdStatusEnum
        {
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Expired for "Expired"
            /// </summary>
            [EnumMember(Value = "Expired")]
            Expired,
            
            /// <summary>
            /// Enum Filled for "Filled"
            /// </summary>
            [EnumMember(Value = "Filled")]
            Filled,
            
            /// <summary>
            /// Enum PendingCancel for "PendingCancel"
            /// </summary>
            [EnumMember(Value = "PendingCancel")]
            PendingCancel,
            
            /// <summary>
            /// Enum PendingNew for "PendingNew"
            /// </summary>
            [EnumMember(Value = "PendingNew")]
            PendingNew,
            
            /// <summary>
            /// Enum PendingReplace for "PendingReplace"
            /// </summary>
            [EnumMember(Value = "PendingReplace")]
            PendingReplace,
            
            /// <summary>
            /// Enum Rejected for "Rejected"
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected,
            
            /// <summary>
            /// Enum Suspended for "Suspended"
            /// </summary>
            [EnumMember(Value = "Suspended")]
            Suspended,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Working for "Working"
            /// </summary>
            [EnumMember(Value = "Working")]
            Working
        }

        /// <summary>
        /// Buy, Sell
        /// </summary>
        /// <value>Buy, Sell</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Canceled, Completed, Expired, Filled, PendingCancel, PendingNew, PendingReplace, Rejected, Suspended, Unknown, Working
        /// </summary>
        /// <value>Canceled, Completed, Expired, Filled, PendingCancel, PendingNew, PendingReplace, Rejected, Suspended, Unknown, Working</value>
        [DataMember(Name="ordStatus", EmitDefaultValue=false)]
        public OrdStatusEnum? OrdStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Order() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="AccountId">id of Account (required).</param>
        /// <param name="ContractId">id of Contract.</param>
        /// <param name="SpreadDefinitionId">id of SpreadDefinition.</param>
        /// <param name="Timestamp">Create Time (required).</param>
        /// <param name="Action">Buy, Sell (required).</param>
        /// <param name="OrdStatus">Canceled, Completed, Expired, Filled, PendingCancel, PendingNew, PendingReplace, Rejected, Suspended, Unknown, Working (required).</param>
        /// <param name="OcoId">id of Order.</param>
        /// <param name="ParentId">id of Order.</param>
        /// <param name="LinkedId">id of Order.</param>
        /// <param name="Admin">Admin (required).</param>
        public Order(int? Id = null, int? AccountId = null, int? ContractId = null, int? SpreadDefinitionId = null, DateTime? Timestamp = null, ActionEnum? Action = null, OrdStatusEnum? OrdStatus = null, int? OcoId = null, int? ParentId = null, int? LinkedId = null, bool? Admin = null)
        {
            // to ensure "AccountId" is required (not null)
            if (AccountId == null)
            {
                throw new InvalidDataException("AccountId is a required property for Order and cannot be null");
            }
            else
            {
                this.AccountId = AccountId;
            }
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for Order and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "Action" is required (not null)
            if (Action == null)
            {
                throw new InvalidDataException("Action is a required property for Order and cannot be null");
            }
            else
            {
                this.Action = Action;
            }
            // to ensure "OrdStatus" is required (not null)
            if (OrdStatus == null)
            {
                throw new InvalidDataException("OrdStatus is a required property for Order and cannot be null");
            }
            else
            {
                this.OrdStatus = OrdStatus;
            }
            // to ensure "Admin" is required (not null)
            if (Admin == null)
            {
                throw new InvalidDataException("Admin is a required property for Order and cannot be null");
            }
            else
            {
                this.Admin = Admin;
            }
            this.Id = Id;
            this.ContractId = ContractId;
            this.SpreadDefinitionId = SpreadDefinitionId;
            this.OcoId = OcoId;
            this.ParentId = ParentId;
            this.LinkedId = LinkedId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// id of Account
        /// </summary>
        /// <value>id of Account</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int? AccountId { get; set; }
        /// <summary>
        /// id of Contract
        /// </summary>
        /// <value>id of Contract</value>
        [DataMember(Name="contractId", EmitDefaultValue=false)]
        public int? ContractId { get; set; }
        /// <summary>
        /// id of SpreadDefinition
        /// </summary>
        /// <value>id of SpreadDefinition</value>
        [DataMember(Name="spreadDefinitionId", EmitDefaultValue=false)]
        public int? SpreadDefinitionId { get; set; }
        /// <summary>
        /// Create Time
        /// </summary>
        /// <value>Create Time</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// id of Order
        /// </summary>
        /// <value>id of Order</value>
        [DataMember(Name="ocoId", EmitDefaultValue=false)]
        public int? OcoId { get; set; }
        /// <summary>
        /// id of Order
        /// </summary>
        /// <value>id of Order</value>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public int? ParentId { get; set; }
        /// <summary>
        /// id of Order
        /// </summary>
        /// <value>id of Order</value>
        [DataMember(Name="linkedId", EmitDefaultValue=false)]
        public int? LinkedId { get; set; }
        /// <summary>
        /// Gets or Sets Admin
        /// </summary>
        [DataMember(Name="admin", EmitDefaultValue=false)]
        public bool? Admin { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  SpreadDefinitionId: ").Append(SpreadDefinitionId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  OrdStatus: ").Append(OrdStatus).Append("\n");
            sb.Append("  OcoId: ").Append(OcoId).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  LinkedId: ").Append(LinkedId).Append("\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
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
            return this.Equals(obj as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="other">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order other)
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
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.ContractId == other.ContractId ||
                    this.ContractId != null &&
                    this.ContractId.Equals(other.ContractId)
                ) && 
                (
                    this.SpreadDefinitionId == other.SpreadDefinitionId ||
                    this.SpreadDefinitionId != null &&
                    this.SpreadDefinitionId.Equals(other.SpreadDefinitionId)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.OrdStatus == other.OrdStatus ||
                    this.OrdStatus != null &&
                    this.OrdStatus.Equals(other.OrdStatus)
                ) && 
                (
                    this.OcoId == other.OcoId ||
                    this.OcoId != null &&
                    this.OcoId.Equals(other.OcoId)
                ) && 
                (
                    this.ParentId == other.ParentId ||
                    this.ParentId != null &&
                    this.ParentId.Equals(other.ParentId)
                ) && 
                (
                    this.LinkedId == other.LinkedId ||
                    this.LinkedId != null &&
                    this.LinkedId.Equals(other.LinkedId)
                ) && 
                (
                    this.Admin == other.Admin ||
                    this.Admin != null &&
                    this.Admin.Equals(other.Admin)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.ContractId != null)
                    hash = hash * 59 + this.ContractId.GetHashCode();
                if (this.SpreadDefinitionId != null)
                    hash = hash * 59 + this.SpreadDefinitionId.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.OrdStatus != null)
                    hash = hash * 59 + this.OrdStatus.GetHashCode();
                if (this.OcoId != null)
                    hash = hash * 59 + this.OcoId.GetHashCode();
                if (this.ParentId != null)
                    hash = hash * 59 + this.ParentId.GetHashCode();
                if (this.LinkedId != null)
                    hash = hash * 59 + this.LinkedId.GetHashCode();
                if (this.Admin != null)
                    hash = hash * 59 + this.Admin.GetHashCode();
                return hash;
            }
        }
    }

}
