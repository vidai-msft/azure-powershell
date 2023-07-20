### Example 1: Create and associate private link traffic filter for the given monitor
```powershell
New-AzElasticCreateAndAssociatePlFilter -ResourceGroupName ElasticResourceGroup01 -MonitorName Monitor01 -Name PlFilter01 -PrivateEndpointName PrivateEndpoint01
```

Create and associate private link traffic filter for the given monitor.

### Example 2: Create and associate private link traffic filter for the given monitor via pipeline
```powershell
Get-AzElasticMonitor -ResourceGroupName ElasticResourceGroup01 -Name Monitor02 | New-AzElasticCreateAndAssociatePlFilter -Name PlFilter02 -PrivateEndpointName PrivateEndpoint01
```

Create and associate private link traffic filter for the given monitor via pipeline.
