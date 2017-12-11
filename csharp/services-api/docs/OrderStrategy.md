# Tradovate.Services.Model.OrderStrategy
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**AccountId** | **int?** | id of Account | 
**Timestamp** | **DateTime?** |  | 
**ContractId** | **int?** | id of Contract | 
**OrderStrategyTypeId** | **int?** | id of OrderStrategyType | 
**InitiatorId** | **int?** | id of OrderStrategy | [optional] 
**Action** | **string** | Buy, Sell | 
**_Params** | **string** |  | [optional] 
**Uuid** | **string** |  | [optional] 
**Status** | **string** | ActiveStrategy, ExecutionFailed, ExecutionFinished, ExecutionInterrupted, InactiveStrategy, NotEnoughLiquidity, StoppedByUser | 
**FailureMessage** | **string** |  | [optional] 
**SenderId** | **int?** | id of User | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

