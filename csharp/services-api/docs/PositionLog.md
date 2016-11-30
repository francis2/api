# Tradovate.Services.Model.PositionLog
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**AccountId** | **int?** | id of Account | 
**ContractId** | **int?** | id of Contract | 
**Timestamp** | **DateTime?** |  | 
**TradeDate** | [**TradeDate**](TradeDate.md) |  | 
**NetPos** | **int?** |  | 
**NetPrice** | **double?** |  | [optional] 
**Bought** | **int?** |  | 
**BoughtValue** | **double?** |  | 
**Sold** | **int?** |  | 
**SoldValue** | **double?** |  | 
**PositionChangeType** | **string** | CancelledTrade, NewSession, PriceAdjustment, Reconciliation, Trade | 
**FillId** | **int?** | id of Fill | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

