# Tradovate.Services.Model.Command
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | [optional] 
**OrderId** | **int?** | id of Order | 
**Timestamp** | **DateTime?** |  | 
**ClOrdId** | **string** |  | [optional] 
**CommandType** | **string** | Cancel, Modify, New | 
**CommandStatus** | **string** | AtExecution, ExecutionRejected, ExecutionStopped, ExecutionSuspended, OnHold, Pending, PendingExecution, Replaced, RiskPassed, RiskRejected | 
**SenderId** | **int?** | id of User | [optional] 
**UserSessionId** | **int?** | id of UserSession | [optional] 
**ActivationTime** | **DateTime?** |  | [optional] 
**CustomTag50** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

