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
    /// PlaceOsoResult
    /// </summary>
    [DataContract]
    public partial class PlaceOsoResult :  IEquatable<PlaceOsoResult>
    {
        /// <summary>
        /// AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported
        /// </summary>
        /// <value>AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FailureReasonEnum
        {
            
            /// <summary>
            /// Enum AccountClosed for "AccountClosed"
            /// </summary>
            [EnumMember(Value = "AccountClosed")]
            AccountClosed,
            
            /// <summary>
            /// Enum AdvancedTrailingStopUnsupported for "AdvancedTrailingStopUnsupported"
            /// </summary>
            [EnumMember(Value = "AdvancedTrailingStopUnsupported")]
            AdvancedTrailingStopUnsupported,
            
            /// <summary>
            /// Enum AnotherCommandPending for "AnotherCommandPending"
            /// </summary>
            [EnumMember(Value = "AnotherCommandPending")]
            AnotherCommandPending,
            
            /// <summary>
            /// Enum BackMonthProhibited for "BackMonthProhibited"
            /// </summary>
            [EnumMember(Value = "BackMonthProhibited")]
            BackMonthProhibited,
            
            /// <summary>
            /// Enum ExecutionProviderNotConfigured for "ExecutionProviderNotConfigured"
            /// </summary>
            [EnumMember(Value = "ExecutionProviderNotConfigured")]
            ExecutionProviderNotConfigured,
            
            /// <summary>
            /// Enum ExecutionProviderUnavailable for "ExecutionProviderUnavailable"
            /// </summary>
            [EnumMember(Value = "ExecutionProviderUnavailable")]
            ExecutionProviderUnavailable,
            
            /// <summary>
            /// Enum InvalidContract for "InvalidContract"
            /// </summary>
            [EnumMember(Value = "InvalidContract")]
            InvalidContract,
            
            /// <summary>
            /// Enum InvalidPrice for "InvalidPrice"
            /// </summary>
            [EnumMember(Value = "InvalidPrice")]
            InvalidPrice,
            
            /// <summary>
            /// Enum LiquidationOnly for "LiquidationOnly"
            /// </summary>
            [EnumMember(Value = "LiquidationOnly")]
            LiquidationOnly,
            
            /// <summary>
            /// Enum LiquidationOnlyBeforeExpiration for "LiquidationOnlyBeforeExpiration"
            /// </summary>
            [EnumMember(Value = "LiquidationOnlyBeforeExpiration")]
            LiquidationOnlyBeforeExpiration,
            
            /// <summary>
            /// Enum MaxOrderQtyIsNotSpecified for "MaxOrderQtyIsNotSpecified"
            /// </summary>
            [EnumMember(Value = "MaxOrderQtyIsNotSpecified")]
            MaxOrderQtyIsNotSpecified,
            
            /// <summary>
            /// Enum MaxOrderQtyLimitReached for "MaxOrderQtyLimitReached"
            /// </summary>
            [EnumMember(Value = "MaxOrderQtyLimitReached")]
            MaxOrderQtyLimitReached,
            
            /// <summary>
            /// Enum MaxPosLimitMisconfigured for "MaxPosLimitMisconfigured"
            /// </summary>
            [EnumMember(Value = "MaxPosLimitMisconfigured")]
            MaxPosLimitMisconfigured,
            
            /// <summary>
            /// Enum MaxPosLimitReached for "MaxPosLimitReached"
            /// </summary>
            [EnumMember(Value = "MaxPosLimitReached")]
            MaxPosLimitReached,
            
            /// <summary>
            /// Enum MaxTotalPosLimitReached for "MaxTotalPosLimitReached"
            /// </summary>
            [EnumMember(Value = "MaxTotalPosLimitReached")]
            MaxTotalPosLimitReached,
            
            /// <summary>
            /// Enum MultipleAccountPlanRequired for "MultipleAccountPlanRequired"
            /// </summary>
            [EnumMember(Value = "MultipleAccountPlanRequired")]
            MultipleAccountPlanRequired,
            
            /// <summary>
            /// Enum NoQuote for "NoQuote"
            /// </summary>
            [EnumMember(Value = "NoQuote")]
            NoQuote,
            
            /// <summary>
            /// Enum NotEnoughLiquidity for "NotEnoughLiquidity"
            /// </summary>
            [EnumMember(Value = "NotEnoughLiquidity")]
            NotEnoughLiquidity,
            
            /// <summary>
            /// Enum OtherExecutionRelated for "OtherExecutionRelated"
            /// </summary>
            [EnumMember(Value = "OtherExecutionRelated")]
            OtherExecutionRelated,
            
            /// <summary>
            /// Enum ParentRejected for "ParentRejected"
            /// </summary>
            [EnumMember(Value = "ParentRejected")]
            ParentRejected,
            
            /// <summary>
            /// Enum RiskCheckTimeout for "RiskCheckTimeout"
            /// </summary>
            [EnumMember(Value = "RiskCheckTimeout")]
            RiskCheckTimeout,
            
            /// <summary>
            /// Enum SessionClosed for "SessionClosed"
            /// </summary>
            [EnumMember(Value = "SessionClosed")]
            SessionClosed,
            
            /// <summary>
            /// Enum Success for "Success"
            /// </summary>
            [EnumMember(Value = "Success")]
            Success,
            
            /// <summary>
            /// Enum TooLate for "TooLate"
            /// </summary>
            [EnumMember(Value = "TooLate")]
            TooLate,
            
            /// <summary>
            /// Enum TradingLocked for "TradingLocked"
            /// </summary>
            [EnumMember(Value = "TradingLocked")]
            TradingLocked,
            
            /// <summary>
            /// Enum TrailingStopNonOrderQtyModify for "TrailingStopNonOrderQtyModify"
            /// </summary>
            [EnumMember(Value = "TrailingStopNonOrderQtyModify")]
            TrailingStopNonOrderQtyModify,
            
            /// <summary>
            /// Enum Unauthorized for "Unauthorized"
            /// </summary>
            [EnumMember(Value = "Unauthorized")]
            Unauthorized,
            
            /// <summary>
            /// Enum UnknownReason for "UnknownReason"
            /// </summary>
            [EnumMember(Value = "UnknownReason")]
            UnknownReason,
            
            /// <summary>
            /// Enum Unsupported for "Unsupported"
            /// </summary>
            [EnumMember(Value = "Unsupported")]
            Unsupported
        }

        /// <summary>
        /// AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported
        /// </summary>
        /// <value>AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReasonEnum? FailureReason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceOsoResult" /> class.
        /// </summary>
        /// <param name="FailureReason">AccountClosed, AdvancedTrailingStopUnsupported, AnotherCommandPending, BackMonthProhibited, ExecutionProviderNotConfigured, ExecutionProviderUnavailable, InvalidContract, InvalidPrice, LiquidationOnly, LiquidationOnlyBeforeExpiration, MaxOrderQtyIsNotSpecified, MaxOrderQtyLimitReached, MaxPosLimitMisconfigured, MaxPosLimitReached, MaxTotalPosLimitReached, MultipleAccountPlanRequired, NoQuote, NotEnoughLiquidity, OtherExecutionRelated, ParentRejected, RiskCheckTimeout, SessionClosed, Success, TooLate, TradingLocked, TrailingStopNonOrderQtyModify, Unauthorized, UnknownReason, Unsupported.</param>
        /// <param name="FailureText">FailureText.</param>
        /// <param name="OrderId">id of Order.</param>
        /// <param name="Oso1Id">id of Order.</param>
        /// <param name="Oso2Id">id of Order.</param>
        public PlaceOsoResult(FailureReasonEnum? FailureReason = null, string FailureText = null, int? OrderId = null, int? Oso1Id = null, int? Oso2Id = null)
        {
            this.FailureReason = FailureReason;
            this.FailureText = FailureText;
            this.OrderId = OrderId;
            this.Oso1Id = Oso1Id;
            this.Oso2Id = Oso2Id;
        }
        
        /// <summary>
        /// Gets or Sets FailureText
        /// </summary>
        [DataMember(Name="failureText", EmitDefaultValue=false)]
        public string FailureText { get; set; }
        /// <summary>
        /// id of Order
        /// </summary>
        /// <value>id of Order</value>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public int? OrderId { get; set; }
        /// <summary>
        /// id of Order
        /// </summary>
        /// <value>id of Order</value>
        [DataMember(Name="oso1Id", EmitDefaultValue=false)]
        public int? Oso1Id { get; set; }
        /// <summary>
        /// id of Order
        /// </summary>
        /// <value>id of Order</value>
        [DataMember(Name="oso2Id", EmitDefaultValue=false)]
        public int? Oso2Id { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlaceOsoResult {\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  FailureText: ").Append(FailureText).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Oso1Id: ").Append(Oso1Id).Append("\n");
            sb.Append("  Oso2Id: ").Append(Oso2Id).Append("\n");
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
            return this.Equals(obj as PlaceOsoResult);
        }

        /// <summary>
        /// Returns true if PlaceOsoResult instances are equal
        /// </summary>
        /// <param name="other">Instance of PlaceOsoResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlaceOsoResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FailureReason == other.FailureReason ||
                    this.FailureReason != null &&
                    this.FailureReason.Equals(other.FailureReason)
                ) && 
                (
                    this.FailureText == other.FailureText ||
                    this.FailureText != null &&
                    this.FailureText.Equals(other.FailureText)
                ) && 
                (
                    this.OrderId == other.OrderId ||
                    this.OrderId != null &&
                    this.OrderId.Equals(other.OrderId)
                ) && 
                (
                    this.Oso1Id == other.Oso1Id ||
                    this.Oso1Id != null &&
                    this.Oso1Id.Equals(other.Oso1Id)
                ) && 
                (
                    this.Oso2Id == other.Oso2Id ||
                    this.Oso2Id != null &&
                    this.Oso2Id.Equals(other.Oso2Id)
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
                if (this.FailureReason != null)
                    hash = hash * 59 + this.FailureReason.GetHashCode();
                if (this.FailureText != null)
                    hash = hash * 59 + this.FailureText.GetHashCode();
                if (this.OrderId != null)
                    hash = hash * 59 + this.OrderId.GetHashCode();
                if (this.Oso1Id != null)
                    hash = hash * 59 + this.Oso1Id.GetHashCode();
                if (this.Oso2Id != null)
                    hash = hash * 59 + this.Oso2Id.GetHashCode();
                return hash;
            }
        }
    }

}
