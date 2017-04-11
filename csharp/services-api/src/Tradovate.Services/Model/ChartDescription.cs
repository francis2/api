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
    /// ChartDescription
    /// </summary>
    [DataContract]
    public partial class ChartDescription :  IEquatable<ChartDescription>, IValidatableObject
    {
        /// <summary>
        /// Custom, DOM, DailyBar, MinuteBar, Tick
        /// </summary>
        /// <value>Custom, DOM, DailyBar, MinuteBar, Tick</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnderlyingTypeEnum
        {
            
            /// <summary>
            /// Enum Tick for "Tick"
            /// </summary>
            [EnumMember(Value = "Tick")]
            Tick,
            
            /// <summary>
            /// Enum DailyBar for "DailyBar"
            /// </summary>
            [EnumMember(Value = "DailyBar")]
            DailyBar,
            
            /// <summary>
            /// Enum MinuteBar for "MinuteBar"
            /// </summary>
            [EnumMember(Value = "MinuteBar")]
            MinuteBar,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom,
            
            /// <summary>
            /// Enum DOM for "DOM"
            /// </summary>
            [EnumMember(Value = "DOM")]
            DOM
        }

        /// <summary>
        /// MomentumRange, OFARange, PointAndFigure, Range, Renko, UnderlyingUnits, Volume
        /// </summary>
        /// <value>MomentumRange, OFARange, PointAndFigure, Range, Renko, UnderlyingUnits, Volume</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ElementSizeUnitEnum
        {
            
            /// <summary>
            /// Enum Volume for "Volume"
            /// </summary>
            [EnumMember(Value = "Volume")]
            Volume,
            
            /// <summary>
            /// Enum Range for "Range"
            /// </summary>
            [EnumMember(Value = "Range")]
            Range,
            
            /// <summary>
            /// Enum UnderlyingUnits for "UnderlyingUnits"
            /// </summary>
            [EnumMember(Value = "UnderlyingUnits")]
            UnderlyingUnits,
            
            /// <summary>
            /// Enum Renko for "Renko"
            /// </summary>
            [EnumMember(Value = "Renko")]
            Renko,
            
            /// <summary>
            /// Enum MomentumRange for "MomentumRange"
            /// </summary>
            [EnumMember(Value = "MomentumRange")]
            MomentumRange,
            
            /// <summary>
            /// Enum PointAndFigure for "PointAndFigure"
            /// </summary>
            [EnumMember(Value = "PointAndFigure")]
            PointAndFigure,
            
            /// <summary>
            /// Enum OFARange for "OFARange"
            /// </summary>
            [EnumMember(Value = "OFARange")]
            OFARange
        }

        /// <summary>
        /// Custom, DOM, DailyBar, MinuteBar, Tick
        /// </summary>
        /// <value>Custom, DOM, DailyBar, MinuteBar, Tick</value>
        [DataMember(Name="underlyingType", EmitDefaultValue=false)]
        public UnderlyingTypeEnum? UnderlyingType { get; set; }
        /// <summary>
        /// MomentumRange, OFARange, PointAndFigure, Range, Renko, UnderlyingUnits, Volume
        /// </summary>
        /// <value>MomentumRange, OFARange, PointAndFigure, Range, Renko, UnderlyingUnits, Volume</value>
        [DataMember(Name="elementSizeUnit", EmitDefaultValue=false)]
        public ElementSizeUnitEnum? ElementSizeUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartDescription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChartDescription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartDescription" /> class.
        /// </summary>
        /// <param name="UnderlyingType">Custom, DOM, DailyBar, MinuteBar, Tick (required).</param>
        /// <param name="ElementSize">ElementSize (required).</param>
        /// <param name="ElementSizeUnit">MomentumRange, OFARange, PointAndFigure, Range, Renko, UnderlyingUnits, Volume (required).</param>
        /// <param name="ElementSize2">ElementSize2.</param>
        /// <param name="CustomUnderlying">CustomUnderlying.</param>
        /// <param name="WithHistogram">WithHistogram.</param>
        public ChartDescription(UnderlyingTypeEnum? UnderlyingType = default(UnderlyingTypeEnum?), int? ElementSize = default(int?), ElementSizeUnitEnum? ElementSizeUnit = default(ElementSizeUnitEnum?), int? ElementSize2 = default(int?), BasicChartDescription CustomUnderlying = default(BasicChartDescription), bool? WithHistogram = default(bool?))
        {
            // to ensure "UnderlyingType" is required (not null)
            if (UnderlyingType == null)
            {
                throw new InvalidDataException("UnderlyingType is a required property for ChartDescription and cannot be null");
            }
            else
            {
                this.UnderlyingType = UnderlyingType;
            }
            // to ensure "ElementSize" is required (not null)
            if (ElementSize == null)
            {
                throw new InvalidDataException("ElementSize is a required property for ChartDescription and cannot be null");
            }
            else
            {
                this.ElementSize = ElementSize;
            }
            // to ensure "ElementSizeUnit" is required (not null)
            if (ElementSizeUnit == null)
            {
                throw new InvalidDataException("ElementSizeUnit is a required property for ChartDescription and cannot be null");
            }
            else
            {
                this.ElementSizeUnit = ElementSizeUnit;
            }
            this.ElementSize2 = ElementSize2;
            this.CustomUnderlying = CustomUnderlying;
            this.WithHistogram = WithHistogram;
        }
        
        /// <summary>
        /// Gets or Sets ElementSize
        /// </summary>
        [DataMember(Name="elementSize", EmitDefaultValue=false)]
        public int? ElementSize { get; set; }
        /// <summary>
        /// Gets or Sets ElementSize2
        /// </summary>
        [DataMember(Name="elementSize2", EmitDefaultValue=false)]
        public int? ElementSize2 { get; set; }
        /// <summary>
        /// Gets or Sets CustomUnderlying
        /// </summary>
        [DataMember(Name="customUnderlying", EmitDefaultValue=false)]
        public BasicChartDescription CustomUnderlying { get; set; }
        /// <summary>
        /// Gets or Sets WithHistogram
        /// </summary>
        [DataMember(Name="withHistogram", EmitDefaultValue=false)]
        public bool? WithHistogram { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartDescription {\n");
            sb.Append("  UnderlyingType: ").Append(UnderlyingType).Append("\n");
            sb.Append("  ElementSize: ").Append(ElementSize).Append("\n");
            sb.Append("  ElementSizeUnit: ").Append(ElementSizeUnit).Append("\n");
            sb.Append("  ElementSize2: ").Append(ElementSize2).Append("\n");
            sb.Append("  CustomUnderlying: ").Append(CustomUnderlying).Append("\n");
            sb.Append("  WithHistogram: ").Append(WithHistogram).Append("\n");
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
            return this.Equals(obj as ChartDescription);
        }

        /// <summary>
        /// Returns true if ChartDescription instances are equal
        /// </summary>
        /// <param name="other">Instance of ChartDescription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChartDescription other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UnderlyingType == other.UnderlyingType ||
                    this.UnderlyingType != null &&
                    this.UnderlyingType.Equals(other.UnderlyingType)
                ) && 
                (
                    this.ElementSize == other.ElementSize ||
                    this.ElementSize != null &&
                    this.ElementSize.Equals(other.ElementSize)
                ) && 
                (
                    this.ElementSizeUnit == other.ElementSizeUnit ||
                    this.ElementSizeUnit != null &&
                    this.ElementSizeUnit.Equals(other.ElementSizeUnit)
                ) && 
                (
                    this.ElementSize2 == other.ElementSize2 ||
                    this.ElementSize2 != null &&
                    this.ElementSize2.Equals(other.ElementSize2)
                ) && 
                (
                    this.CustomUnderlying == other.CustomUnderlying ||
                    this.CustomUnderlying != null &&
                    this.CustomUnderlying.Equals(other.CustomUnderlying)
                ) && 
                (
                    this.WithHistogram == other.WithHistogram ||
                    this.WithHistogram != null &&
                    this.WithHistogram.Equals(other.WithHistogram)
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
                if (this.UnderlyingType != null)
                    hash = hash * 59 + this.UnderlyingType.GetHashCode();
                if (this.ElementSize != null)
                    hash = hash * 59 + this.ElementSize.GetHashCode();
                if (this.ElementSizeUnit != null)
                    hash = hash * 59 + this.ElementSizeUnit.GetHashCode();
                if (this.ElementSize2 != null)
                    hash = hash * 59 + this.ElementSize2.GetHashCode();
                if (this.CustomUnderlying != null)
                    hash = hash * 59 + this.CustomUnderlying.GetHashCode();
                if (this.WithHistogram != null)
                    hash = hash * 59 + this.WithHistogram.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
