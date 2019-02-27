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
    /// SyncMessage
    /// </summary>
    [DataContract]
    public partial class SyncMessage :  IEquatable<SyncMessage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SyncMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncMessage" /> class.
        /// </summary>
        /// <param name="Users">Users (required).</param>
        /// <param name="Accounts">Accounts.</param>
        /// <param name="CashBalances">CashBalances.</param>
        /// <param name="Currencies">Currencies.</param>
        /// <param name="Positions">Positions.</param>
        /// <param name="FillPairs">FillPairs.</param>
        /// <param name="Orders">Orders.</param>
        /// <param name="Contracts">Contracts.</param>
        /// <param name="ContractMaturities">ContractMaturities.</param>
        /// <param name="Products">Products.</param>
        /// <param name="Exchanges">Exchanges.</param>
        /// <param name="SpreadDefinitions">SpreadDefinitions.</param>
        /// <param name="Commands">Commands.</param>
        /// <param name="CommandReports">CommandReports.</param>
        /// <param name="ExecutionReports">ExecutionReports.</param>
        /// <param name="OrderVersions">OrderVersions.</param>
        /// <param name="Fills">Fills.</param>
        /// <param name="OrderStrategies">OrderStrategies.</param>
        /// <param name="OrderStrategyLinks">OrderStrategyLinks.</param>
        /// <param name="UserProperties">UserProperties.</param>
        /// <param name="Properties">Properties.</param>
        /// <param name="UserPlugins">UserPlugins.</param>
        /// <param name="ContractGroups">ContractGroups (required).</param>
        /// <param name="OrderStrategyTypes">OrderStrategyTypes.</param>
        public SyncMessage(List<User> Users = null, List<Account> Accounts = null, List<CashBalance> CashBalances = null, List<Currency> Currencies = null, List<Position> Positions = null, List<FillPair> FillPairs = null, List<Order> Orders = null, List<Contract> Contracts = null, List<ContractMaturity> ContractMaturities = null, List<Product> Products = null, List<Exchange> Exchanges = null, List<SpreadDefinition> SpreadDefinitions = null, List<Command> Commands = null, List<CommandReport> CommandReports = null, List<ExecutionReport> ExecutionReports = null, List<OrderVersion> OrderVersions = null, List<Fill> Fills = null, List<OrderStrategy> OrderStrategies = null, List<OrderStrategyLink> OrderStrategyLinks = null, List<UserProperty> UserProperties = null, List<Property> Properties = null, List<UserPlugin> UserPlugins = null, List<ContractGroup> ContractGroups = null, List<OrderStrategyType> OrderStrategyTypes = null)
        {
            // to ensure "Users" is required (not null)
            if (Users == null)
            {
                throw new InvalidDataException("Users is a required property for SyncMessage and cannot be null");
            }
            else
            {
                this.Users = Users;
            }
            // to ensure "ContractGroups" is required (not null)
            if (ContractGroups == null)
            {
                throw new InvalidDataException("ContractGroups is a required property for SyncMessage and cannot be null");
            }
            else
            {
                this.ContractGroups = ContractGroups;
            }
            this.Accounts = Accounts;
            this.CashBalances = CashBalances;
            this.Currencies = Currencies;
            this.Positions = Positions;
            this.FillPairs = FillPairs;
            this.Orders = Orders;
            this.Contracts = Contracts;
            this.ContractMaturities = ContractMaturities;
            this.Products = Products;
            this.Exchanges = Exchanges;
            this.SpreadDefinitions = SpreadDefinitions;
            this.Commands = Commands;
            this.CommandReports = CommandReports;
            this.ExecutionReports = ExecutionReports;
            this.OrderVersions = OrderVersions;
            this.Fills = Fills;
            this.OrderStrategies = OrderStrategies;
            this.OrderStrategyLinks = OrderStrategyLinks;
            this.UserProperties = UserProperties;
            this.Properties = Properties;
            this.UserPlugins = UserPlugins;
            this.OrderStrategyTypes = OrderStrategyTypes;
        }
        
        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<User> Users { get; set; }
        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<Account> Accounts { get; set; }
        /// <summary>
        /// Gets or Sets CashBalances
        /// </summary>
        [DataMember(Name="cashBalances", EmitDefaultValue=false)]
        public List<CashBalance> CashBalances { get; set; }
        /// <summary>
        /// Gets or Sets Currencies
        /// </summary>
        [DataMember(Name="currencies", EmitDefaultValue=false)]
        public List<Currency> Currencies { get; set; }
        /// <summary>
        /// Gets or Sets Positions
        /// </summary>
        [DataMember(Name="positions", EmitDefaultValue=false)]
        public List<Position> Positions { get; set; }
        /// <summary>
        /// Gets or Sets FillPairs
        /// </summary>
        [DataMember(Name="fillPairs", EmitDefaultValue=false)]
        public List<FillPair> FillPairs { get; set; }
        /// <summary>
        /// Gets or Sets Orders
        /// </summary>
        [DataMember(Name="orders", EmitDefaultValue=false)]
        public List<Order> Orders { get; set; }
        /// <summary>
        /// Gets or Sets Contracts
        /// </summary>
        [DataMember(Name="contracts", EmitDefaultValue=false)]
        public List<Contract> Contracts { get; set; }
        /// <summary>
        /// Gets or Sets ContractMaturities
        /// </summary>
        [DataMember(Name="contractMaturities", EmitDefaultValue=false)]
        public List<ContractMaturity> ContractMaturities { get; set; }
        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name="products", EmitDefaultValue=false)]
        public List<Product> Products { get; set; }
        /// <summary>
        /// Gets or Sets Exchanges
        /// </summary>
        [DataMember(Name="exchanges", EmitDefaultValue=false)]
        public List<Exchange> Exchanges { get; set; }
        /// <summary>
        /// Gets or Sets SpreadDefinitions
        /// </summary>
        [DataMember(Name="spreadDefinitions", EmitDefaultValue=false)]
        public List<SpreadDefinition> SpreadDefinitions { get; set; }
        /// <summary>
        /// Gets or Sets Commands
        /// </summary>
        [DataMember(Name="commands", EmitDefaultValue=false)]
        public List<Command> Commands { get; set; }
        /// <summary>
        /// Gets or Sets CommandReports
        /// </summary>
        [DataMember(Name="commandReports", EmitDefaultValue=false)]
        public List<CommandReport> CommandReports { get; set; }
        /// <summary>
        /// Gets or Sets ExecutionReports
        /// </summary>
        [DataMember(Name="executionReports", EmitDefaultValue=false)]
        public List<ExecutionReport> ExecutionReports { get; set; }
        /// <summary>
        /// Gets or Sets OrderVersions
        /// </summary>
        [DataMember(Name="orderVersions", EmitDefaultValue=false)]
        public List<OrderVersion> OrderVersions { get; set; }
        /// <summary>
        /// Gets or Sets Fills
        /// </summary>
        [DataMember(Name="fills", EmitDefaultValue=false)]
        public List<Fill> Fills { get; set; }
        /// <summary>
        /// Gets or Sets OrderStrategies
        /// </summary>
        [DataMember(Name="orderStrategies", EmitDefaultValue=false)]
        public List<OrderStrategy> OrderStrategies { get; set; }
        /// <summary>
        /// Gets or Sets OrderStrategyLinks
        /// </summary>
        [DataMember(Name="orderStrategyLinks", EmitDefaultValue=false)]
        public List<OrderStrategyLink> OrderStrategyLinks { get; set; }
        /// <summary>
        /// Gets or Sets UserProperties
        /// </summary>
        [DataMember(Name="userProperties", EmitDefaultValue=false)]
        public List<UserProperty> UserProperties { get; set; }
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<Property> Properties { get; set; }
        /// <summary>
        /// Gets or Sets UserPlugins
        /// </summary>
        [DataMember(Name="userPlugins", EmitDefaultValue=false)]
        public List<UserPlugin> UserPlugins { get; set; }
        /// <summary>
        /// Gets or Sets ContractGroups
        /// </summary>
        [DataMember(Name="contractGroups", EmitDefaultValue=false)]
        public List<ContractGroup> ContractGroups { get; set; }
        /// <summary>
        /// Gets or Sets OrderStrategyTypes
        /// </summary>
        [DataMember(Name="orderStrategyTypes", EmitDefaultValue=false)]
        public List<OrderStrategyType> OrderStrategyTypes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SyncMessage {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  CashBalances: ").Append(CashBalances).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
            sb.Append("  Positions: ").Append(Positions).Append("\n");
            sb.Append("  FillPairs: ").Append(FillPairs).Append("\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
            sb.Append("  Contracts: ").Append(Contracts).Append("\n");
            sb.Append("  ContractMaturities: ").Append(ContractMaturities).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  Exchanges: ").Append(Exchanges).Append("\n");
            sb.Append("  SpreadDefinitions: ").Append(SpreadDefinitions).Append("\n");
            sb.Append("  Commands: ").Append(Commands).Append("\n");
            sb.Append("  CommandReports: ").Append(CommandReports).Append("\n");
            sb.Append("  ExecutionReports: ").Append(ExecutionReports).Append("\n");
            sb.Append("  OrderVersions: ").Append(OrderVersions).Append("\n");
            sb.Append("  Fills: ").Append(Fills).Append("\n");
            sb.Append("  OrderStrategies: ").Append(OrderStrategies).Append("\n");
            sb.Append("  OrderStrategyLinks: ").Append(OrderStrategyLinks).Append("\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  UserPlugins: ").Append(UserPlugins).Append("\n");
            sb.Append("  ContractGroups: ").Append(ContractGroups).Append("\n");
            sb.Append("  OrderStrategyTypes: ").Append(OrderStrategyTypes).Append("\n");
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
            return this.Equals(obj as SyncMessage);
        }

        /// <summary>
        /// Returns true if SyncMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of SyncMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyncMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
                ) && 
                (
                    this.Accounts == other.Accounts ||
                    this.Accounts != null &&
                    this.Accounts.SequenceEqual(other.Accounts)
                ) && 
                (
                    this.CashBalances == other.CashBalances ||
                    this.CashBalances != null &&
                    this.CashBalances.SequenceEqual(other.CashBalances)
                ) && 
                (
                    this.Currencies == other.Currencies ||
                    this.Currencies != null &&
                    this.Currencies.SequenceEqual(other.Currencies)
                ) && 
                (
                    this.Positions == other.Positions ||
                    this.Positions != null &&
                    this.Positions.SequenceEqual(other.Positions)
                ) && 
                (
                    this.FillPairs == other.FillPairs ||
                    this.FillPairs != null &&
                    this.FillPairs.SequenceEqual(other.FillPairs)
                ) && 
                (
                    this.Orders == other.Orders ||
                    this.Orders != null &&
                    this.Orders.SequenceEqual(other.Orders)
                ) && 
                (
                    this.Contracts == other.Contracts ||
                    this.Contracts != null &&
                    this.Contracts.SequenceEqual(other.Contracts)
                ) && 
                (
                    this.ContractMaturities == other.ContractMaturities ||
                    this.ContractMaturities != null &&
                    this.ContractMaturities.SequenceEqual(other.ContractMaturities)
                ) && 
                (
                    this.Products == other.Products ||
                    this.Products != null &&
                    this.Products.SequenceEqual(other.Products)
                ) && 
                (
                    this.Exchanges == other.Exchanges ||
                    this.Exchanges != null &&
                    this.Exchanges.SequenceEqual(other.Exchanges)
                ) && 
                (
                    this.SpreadDefinitions == other.SpreadDefinitions ||
                    this.SpreadDefinitions != null &&
                    this.SpreadDefinitions.SequenceEqual(other.SpreadDefinitions)
                ) && 
                (
                    this.Commands == other.Commands ||
                    this.Commands != null &&
                    this.Commands.SequenceEqual(other.Commands)
                ) && 
                (
                    this.CommandReports == other.CommandReports ||
                    this.CommandReports != null &&
                    this.CommandReports.SequenceEqual(other.CommandReports)
                ) && 
                (
                    this.ExecutionReports == other.ExecutionReports ||
                    this.ExecutionReports != null &&
                    this.ExecutionReports.SequenceEqual(other.ExecutionReports)
                ) && 
                (
                    this.OrderVersions == other.OrderVersions ||
                    this.OrderVersions != null &&
                    this.OrderVersions.SequenceEqual(other.OrderVersions)
                ) && 
                (
                    this.Fills == other.Fills ||
                    this.Fills != null &&
                    this.Fills.SequenceEqual(other.Fills)
                ) && 
                (
                    this.OrderStrategies == other.OrderStrategies ||
                    this.OrderStrategies != null &&
                    this.OrderStrategies.SequenceEqual(other.OrderStrategies)
                ) && 
                (
                    this.OrderStrategyLinks == other.OrderStrategyLinks ||
                    this.OrderStrategyLinks != null &&
                    this.OrderStrategyLinks.SequenceEqual(other.OrderStrategyLinks)
                ) && 
                (
                    this.UserProperties == other.UserProperties ||
                    this.UserProperties != null &&
                    this.UserProperties.SequenceEqual(other.UserProperties)
                ) && 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
                ) && 
                (
                    this.UserPlugins == other.UserPlugins ||
                    this.UserPlugins != null &&
                    this.UserPlugins.SequenceEqual(other.UserPlugins)
                ) && 
                (
                    this.ContractGroups == other.ContractGroups ||
                    this.ContractGroups != null &&
                    this.ContractGroups.SequenceEqual(other.ContractGroups)
                ) && 
                (
                    this.OrderStrategyTypes == other.OrderStrategyTypes ||
                    this.OrderStrategyTypes != null &&
                    this.OrderStrategyTypes.SequenceEqual(other.OrderStrategyTypes)
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
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                if (this.Accounts != null)
                    hash = hash * 59 + this.Accounts.GetHashCode();
                if (this.CashBalances != null)
                    hash = hash * 59 + this.CashBalances.GetHashCode();
                if (this.Currencies != null)
                    hash = hash * 59 + this.Currencies.GetHashCode();
                if (this.Positions != null)
                    hash = hash * 59 + this.Positions.GetHashCode();
                if (this.FillPairs != null)
                    hash = hash * 59 + this.FillPairs.GetHashCode();
                if (this.Orders != null)
                    hash = hash * 59 + this.Orders.GetHashCode();
                if (this.Contracts != null)
                    hash = hash * 59 + this.Contracts.GetHashCode();
                if (this.ContractMaturities != null)
                    hash = hash * 59 + this.ContractMaturities.GetHashCode();
                if (this.Products != null)
                    hash = hash * 59 + this.Products.GetHashCode();
                if (this.Exchanges != null)
                    hash = hash * 59 + this.Exchanges.GetHashCode();
                if (this.SpreadDefinitions != null)
                    hash = hash * 59 + this.SpreadDefinitions.GetHashCode();
                if (this.Commands != null)
                    hash = hash * 59 + this.Commands.GetHashCode();
                if (this.CommandReports != null)
                    hash = hash * 59 + this.CommandReports.GetHashCode();
                if (this.ExecutionReports != null)
                    hash = hash * 59 + this.ExecutionReports.GetHashCode();
                if (this.OrderVersions != null)
                    hash = hash * 59 + this.OrderVersions.GetHashCode();
                if (this.Fills != null)
                    hash = hash * 59 + this.Fills.GetHashCode();
                if (this.OrderStrategies != null)
                    hash = hash * 59 + this.OrderStrategies.GetHashCode();
                if (this.OrderStrategyLinks != null)
                    hash = hash * 59 + this.OrderStrategyLinks.GetHashCode();
                if (this.UserProperties != null)
                    hash = hash * 59 + this.UserProperties.GetHashCode();
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                if (this.UserPlugins != null)
                    hash = hash * 59 + this.UserPlugins.GetHashCode();
                if (this.ContractGroups != null)
                    hash = hash * 59 + this.ContractGroups.GetHashCode();
                if (this.OrderStrategyTypes != null)
                    hash = hash * 59 + this.OrderStrategyTypes.GetHashCode();
                return hash;
            }
        }
    }

}
