/*
 *
 * Tradovate API, Samples.
 * Contract specifications
 *
*/

using System;
using System.Collections.Generic;
using Tradovate.Services.Api;
using Tradovate.Services.Model;

namespace Tradovate
{
    class ContractLibrary
    {
        public static void ContractSpec(string symbol)
        {
            var contractLibraryApi = new ContractLibraryApi();
            Contract contract = contractLibraryApi.FindContract(symbol);
            Console.WriteLine(contract);
            ContractMaturity contractMaturity = contractLibraryApi.GetContractMaturity(contract.ContractMaturityId);
            Console.WriteLine(contractMaturity);
            Product product = contractLibraryApi.GetProduct(contractMaturity.ProductId);
            Console.WriteLine(product);
            Exchange exchange = contractLibraryApi.GetExchange(product.ExchangeId);
            Console.WriteLine(exchange);
            ContractGroup contractGroup = contractLibraryApi.GetContractGroup(product.ContractGroupId);
            Console.WriteLine(contractGroup);
            Currency currency = contractLibraryApi.GetCurrency(product.CurrencyId);
            Console.WriteLine(currency);
            CurrencyRate currencyRate = contractLibraryApi.GetCurrencyRate(product.CurrencyId);
            Console.WriteLine(currencyRate);
            ProductSession productSession = contractLibraryApi.GetProductSession(product.Id);
            Console.WriteLine(productSession);
            ProductFeeParamsResponse productFees = contractLibraryApi.GetProductFeeParams(new GetProductFeeParams(new List<int?> { product.Id }));
            foreach(var fee in productFees._Params) {
                Console.WriteLine(fee);
            }
            var riskApi = new RisksApi();
            ProductMargin productMargin = riskApi.GetProductMargin(product.Id);
            Console.WriteLine(productMargin);
            try
            {
                ContractMargin contractMargin = riskApi.GetContractMargin(contract.Id);
            }
            catch
            {
                Console.WriteLine("Per-contract margin is not specified");
            }
        }
    }
}
