# Tradovate.Services.Model.CashBalanceLog
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**AccountId** | **int?** | id of Account | 
**Timestamp** | **DateTime?** |  | 
**TradeDate** | [**TradeDate**](TradeDate.md) |  | 
**CurrencyId** | **int?** | id of Currency | 
**Amount** | **double?** |  | 
**RealizedPnL** | **double?** |  | [optional] 
**WeekRealizedPnL** | **double?** |  | [optional] 
**CashChangeType** | **string** | AutomaticReconciliation, BrokerageFee, CancelledPairedTrade, ClearingFee, DeskFee, EntitlementSubscription, ExchangeFee, FundTransaction, FundTransactionFee, IPFee, LiquidationFee, ManualAdjustment, MarketDataSubscription, NewSession, NfaFee, OptionsTrade, TradePaired, TradovateSubscription | 
**FillPairId** | **int?** | id of FillPair | [optional] 
**FillId** | **int?** | id of Fill | [optional] 
**FundTransactionId** | **int?** | id of FundTransaction | [optional] 
**Comment** | **string** |  | [optional] 
**Delta** | **double?** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

