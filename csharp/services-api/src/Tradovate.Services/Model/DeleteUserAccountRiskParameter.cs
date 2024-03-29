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
    /// DeleteUserAccountRiskParameter
    /// </summary>
    [DataContract]
    public partial class DeleteUserAccountRiskParameter :  IEquatable<DeleteUserAccountRiskParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUserAccountRiskParameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteUserAccountRiskParameter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUserAccountRiskParameter" /> class.
        /// </summary>
        /// <param name="UserAccountRiskParameterId">id of UserAccountRiskParameter (required).</param>
        public DeleteUserAccountRiskParameter(int? UserAccountRiskParameterId = null)
        {
            // to ensure "UserAccountRiskParameterId" is required (not null)
            if (UserAccountRiskParameterId == null)
            {
                throw new InvalidDataException("UserAccountRiskParameterId is a required property for DeleteUserAccountRiskParameter and cannot be null");
            }
            else
            {
                this.UserAccountRiskParameterId = UserAccountRiskParameterId;
            }
        }
        
        /// <summary>
        /// id of UserAccountRiskParameter
        /// </summary>
        /// <value>id of UserAccountRiskParameter</value>
        [DataMember(Name="userAccountRiskParameterId", EmitDefaultValue=false)]
        public int? UserAccountRiskParameterId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteUserAccountRiskParameter {\n");
            sb.Append("  UserAccountRiskParameterId: ").Append(UserAccountRiskParameterId).Append("\n");
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
            return this.Equals(obj as DeleteUserAccountRiskParameter);
        }

        /// <summary>
        /// Returns true if DeleteUserAccountRiskParameter instances are equal
        /// </summary>
        /// <param name="other">Instance of DeleteUserAccountRiskParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteUserAccountRiskParameter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserAccountRiskParameterId == other.UserAccountRiskParameterId ||
                    this.UserAccountRiskParameterId != null &&
                    this.UserAccountRiskParameterId.Equals(other.UserAccountRiskParameterId)
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
                if (this.UserAccountRiskParameterId != null)
                    hash = hash * 59 + this.UserAccountRiskParameterId.GetHashCode();
                return hash;
            }
        }
    }

}
