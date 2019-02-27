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
    /// AccessTokenResponse
    /// </summary>
    [DataContract]
    public partial class AccessTokenResponse :  IEquatable<AccessTokenResponse>
    {
        /// <summary>
        /// Active, Closed, Initiated, TemporaryLocked, UnconfirmedEmail
        /// </summary>
        /// <value>Active, Closed, Initiated, TemporaryLocked, UnconfirmedEmail</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UserStatusEnum
        {
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Closed for "Closed"
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed,
            
            /// <summary>
            /// Enum Initiated for "Initiated"
            /// </summary>
            [EnumMember(Value = "Initiated")]
            Initiated,
            
            /// <summary>
            /// Enum TemporaryLocked for "TemporaryLocked"
            /// </summary>
            [EnumMember(Value = "TemporaryLocked")]
            TemporaryLocked,
            
            /// <summary>
            /// Enum UnconfirmedEmail for "UnconfirmedEmail"
            /// </summary>
            [EnumMember(Value = "UnconfirmedEmail")]
            UnconfirmedEmail
        }

        /// <summary>
        /// Active, Closed, Initiated, TemporaryLocked, UnconfirmedEmail
        /// </summary>
        /// <value>Active, Closed, Initiated, TemporaryLocked, UnconfirmedEmail</value>
        [DataMember(Name="userStatus", EmitDefaultValue=false)]
        public UserStatusEnum? UserStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenResponse" /> class.
        /// </summary>
        /// <param name="ErrorText">Non-empty if the request failed.</param>
        /// <param name="AccessToken">AccessToken.</param>
        /// <param name="ExpirationTime">ExpirationTime.</param>
        /// <param name="PasswordExpirationTime">PasswordExpirationTime.</param>
        /// <param name="UserStatus">Active, Closed, Initiated, TemporaryLocked, UnconfirmedEmail.</param>
        /// <param name="UserId">id of User.</param>
        /// <param name="Name">Name.</param>
        /// <param name="HasLive">HasLive.</param>
        public AccessTokenResponse(string ErrorText = null, string AccessToken = null, DateTime? ExpirationTime = null, DateTime? PasswordExpirationTime = null, UserStatusEnum? UserStatus = null, int? UserId = null, string Name = null, bool? HasLive = null)
        {
            this.ErrorText = ErrorText;
            this.AccessToken = AccessToken;
            this.ExpirationTime = ExpirationTime;
            this.PasswordExpirationTime = PasswordExpirationTime;
            this.UserStatus = UserStatus;
            this.UserId = UserId;
            this.Name = Name;
            this.HasLive = HasLive;
        }
        
        /// <summary>
        /// Non-empty if the request failed
        /// </summary>
        /// <value>Non-empty if the request failed</value>
        [DataMember(Name="errorText", EmitDefaultValue=false)]
        public string ErrorText { get; set; }
        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }
        /// <summary>
        /// Gets or Sets ExpirationTime
        /// </summary>
        [DataMember(Name="expirationTime", EmitDefaultValue=false)]
        public DateTime? ExpirationTime { get; set; }
        /// <summary>
        /// Gets or Sets PasswordExpirationTime
        /// </summary>
        [DataMember(Name="passwordExpirationTime", EmitDefaultValue=false)]
        public DateTime? PasswordExpirationTime { get; set; }
        /// <summary>
        /// id of User
        /// </summary>
        /// <value>id of User</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets HasLive
        /// </summary>
        [DataMember(Name="hasLive", EmitDefaultValue=false)]
        public bool? HasLive { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessTokenResponse {\n");
            sb.Append("  ErrorText: ").Append(ErrorText).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ExpirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  PasswordExpirationTime: ").Append(PasswordExpirationTime).Append("\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HasLive: ").Append(HasLive).Append("\n");
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
            return this.Equals(obj as AccessTokenResponse);
        }

        /// <summary>
        /// Returns true if AccessTokenResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AccessTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessTokenResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ErrorText == other.ErrorText ||
                    this.ErrorText != null &&
                    this.ErrorText.Equals(other.ErrorText)
                ) && 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.ExpirationTime == other.ExpirationTime ||
                    this.ExpirationTime != null &&
                    this.ExpirationTime.Equals(other.ExpirationTime)
                ) && 
                (
                    this.PasswordExpirationTime == other.PasswordExpirationTime ||
                    this.PasswordExpirationTime != null &&
                    this.PasswordExpirationTime.Equals(other.PasswordExpirationTime)
                ) && 
                (
                    this.UserStatus == other.UserStatus ||
                    this.UserStatus != null &&
                    this.UserStatus.Equals(other.UserStatus)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.HasLive == other.HasLive ||
                    this.HasLive != null &&
                    this.HasLive.Equals(other.HasLive)
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
                if (this.ErrorText != null)
                    hash = hash * 59 + this.ErrorText.GetHashCode();
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                if (this.ExpirationTime != null)
                    hash = hash * 59 + this.ExpirationTime.GetHashCode();
                if (this.PasswordExpirationTime != null)
                    hash = hash * 59 + this.PasswordExpirationTime.GetHashCode();
                if (this.UserStatus != null)
                    hash = hash * 59 + this.UserStatus.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.HasLive != null)
                    hash = hash * 59 + this.HasLive.GetHashCode();
                return hash;
            }
        }
    }

}
