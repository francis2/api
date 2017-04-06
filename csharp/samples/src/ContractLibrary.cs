/*
 *
 * Tradovate API, Samples.
 * Contract specifications
 *
*/

using System;
using System.Collections.Generic;
using System.Linq;
using Tradovate.Services.Api;
using Tradovate.Services.Model;

namespace Tradovate
{
    class ContractLibrary
    {
        public static async void PrepopulateCache()
        {
            // Cache pre-populating can save some latency at trading time, but not recommended for short-term connections
            Log.Write("PRE-POPULATING CONTRACT LIBRARY");

            var contractLibraryApi = new ContractLibraryApi();
            await contractLibraryApi.GetAllContractGroupsAsync();
            await contractLibraryApi.GetAllExchangesAsync();
            await contractLibraryApi.GetAllCurrenciesAsync();
            await contractLibraryApi.GetAllCurrencyRatesAsync();

            var riskApi = new RisksApi();
            await riskApi.GetAllProductMarginsAsync();

            var products = await contractLibraryApi.GetAllProductsAsync();

            // Highly not recommended for short-term connections
            foreach (var product in products)
            {
                await contractLibraryApi.GetOwnedContractMaturitiesAsync(product.Id)
                    .ContinueWith(contractMaturities => {
                        return contractLibraryApi.GetOwnedContractsBatchAsync(contractMaturities.Result.Select(contractMaturity => contractMaturity.Id).ToList());
                    });
            }
        }

        public static void ContractSpec(string symbol)
        {
            var contractLibraryApi = new ContractLibraryApi();
            Contract contract = contractLibraryApi.FindContract(symbol);
            Log.Write(contract);
            ContractMaturity contractMaturity = contractLibraryApi.GetContractMaturity(contract.ContractMaturityId);
            Log.Write(contractMaturity);
            Product product = contractLibraryApi.GetProduct(contractMaturity.ProductId);
            Log.Write(product);
            Exchange exchange = contractLibraryApi.GetExchange(product.ExchangeId);
            Log.Write(exchange);
            ContractGroup contractGroup = contractLibraryApi.GetContractGroup(product.ContractGroupId);
            Log.Write(contractGroup);
            Currency currency = contractLibraryApi.GetCurrency(product.CurrencyId);
            Log.Write(currency);
            CurrencyRate currencyRate = contractLibraryApi.GetCurrencyRate(product.CurrencyId);
            Log.Write(currencyRate);
            ProductSession productSession = contractLibraryApi.GetProductSession(product.Id);
            Log.Write(productSession);
            ProductFeeParamsResponse productFees = contractLibraryApi.GetProductFeeParams(new GetProductFeeParams(new List<int?> { product.Id }));
            foreach(var fee in productFees._Params) {
                Log.Write(fee);
            }
            var riskApi = new RisksApi();
            ProductMargin productMargin = riskApi.GetProductMargin(product.Id);
            Log.Write(productMargin);
            try
            {
                ContractMargin contractMargin = riskApi.GetContractMargin(contract.Id);
                Log.Write(contractMargin);
            }
            catch
            {
                Log.Write("Per-contract margin is not specified");
            }
        }
    }
}
