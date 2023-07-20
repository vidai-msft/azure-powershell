### Example 1: Create or update a tag rule set for a given monitor resource
```powershell
New-AzElasticTagRule -ResourceGroupName ElasticResourceGroup01 -MonitorName Monitor01 -LogRuleSendSubscriptionLog -LogRuleSendAadLog -LogRuleSendActivityLog
```

```output
Id                           : /subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/ElasticResourceGr
                               oup01/providers/Microsoft.Elastic/monitors/Monitor01/tagRules/default
LogRuleFilteringTag          : {}
LogRuleSendAadLog            : True
LogRuleSendActivityLog       : True
LogRuleSendSubscriptionLog   : True
Name                         : default
ProvisioningState            : Succeeded
ResourceGroupName            : ElasticResourceGroup01
SystemDataCreatedAt          : 07/19/2023 06:42:52
SystemDataCreatedBy          : user@contoso.com
SystemDataCreatedByType      : User
SystemDataLastModifiedAt     : 07/19/2023 09:26:48
SystemDataLastModifiedBy     : user@contoso.com
SystemDataLastModifiedByType : User
Type                         : microsoft.elastic/monitors/tagrules
```

Create or update a tag rule set for a given monitor resource.

### Example 2: Create or update a tag rule set for a given monitor resource via JSON string
```powershell
$ruleSetProps = @{
    properties = @{
        logRules = @{
            sendAadLogs          = $true
            sendActivityLogs     = $true
            sendSubscriptionLogs = $false
            filteringTags        = @(
                @{
                    action = "Include"
                    name   = "Tag1Name"
                    value  = "Tag1Val"
                }, @{
                    action = "Exclude"
                    name   = "Tag2Name"
                    value  = "Tag2Val"
                }
            )
        }
    }
}
$ruleSetPropsJson = ConvertTo-Json -InputObject $ruleSetProps -Depth 5
New-AzElasticTagRule -ResourceGroupName ElasticResourceGroup01 -MonitorName Monitor02 -JsonString $ruleSetPropsJson
```

```output
Id                           : /subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/ElasticResourceGr
                               oup01/providers/Microsoft.Elastic/monitors/Monitor02/tagRules/default
LogRuleFilteringTag          : {{
                                 "name": "Tag1Name",
                                 "value": "Tag1Val",
                                 "action": "Include"
                               }, {
                                 "name": "Tag2Name",
                                 "value": "Tag2Val",
                                 "action": "Exclude"
                               }}
LogRuleSendAadLog            : True
LogRuleSendActivityLog       : True
LogRuleSendSubscriptionLog   : False
Name                         : default
ProvisioningState            : Succeeded
ResourceGroupName            : ElasticResourceGroup01
SystemDataCreatedAt          : 07/19/2023 09:38:28
SystemDataCreatedBy          : user@contoso.com
SystemDataCreatedByType      : User
SystemDataLastModifiedAt     : 07/19/2023 09:38:28
SystemDataLastModifiedBy     : user@contoso.com
SystemDataLastModifiedByType : User
Type                         : microsoft.elastic/monitors/tagrules
```

Create or update a tag rule set for a given monitor resource via JSON string.

### Example 3: Create or update a tag rule set for a given monitor resource via pipeline
```powershell
Get-AzElasticMonitor -ResourceGroupName ElasticResourceGroup01 -Name Monitor03 | New-AzElasticTagRule -LogRuleSendSubscriptionLog
```

```output
Id                           : /subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/ElasticResourceGr
                               oup01/providers/Microsoft.Elastic/monitors/Monitor03/tagRules/default
LogRuleFilteringTag          : {}
LogRuleSendAadLog            : False
LogRuleSendActivityLog       : False
LogRuleSendSubscriptionLog   : True
Name                         : default
ProvisioningState            : Succeeded
ResourceGroupName            : ElasticResourceGroup01
SystemDataCreatedAt          : 07/19/2023 09:50:14
SystemDataCreatedBy          : user@contoso.com
SystemDataCreatedByType      : User
SystemDataLastModifiedAt     : 07/19/2023 13:11:28
SystemDataLastModifiedBy     : user@contoso.com
SystemDataLastModifiedByType : User
Type                         : microsoft.elastic/monitors/tagrules
```

Create or update a tag rule set for a given monitor resource via pipeline.

### Example 4: Create or update a tag rule set for a given monitor resource via body
```powershell
$monitor = Get-AzElasticMonitor -ResourceGroupName ElasticResourceGroup01 -Name Monitor04
$ruleSetBody = @{
    LogRuleSendAadLog          = $false
    LogRuleSendActivityLog     = $true
    LogRuleSendSubscriptionLog = $false
    LogRuleFilteringTag        = @(
        (New-AzElasticFilteringTagObject -Action Exclude -Name TagObj1Name -Value TagObj1Val),
        (New-AzElasticFilteringTagObject -Action Include -Name TagObj2Name -Value TagObj2Val)
    )
}
New-AzElasticTagRule -MonitorInputObject $monitor -Body $ruleSetBody
```

```output
Id                           : /subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/ElasticResourceGr
                               oup01/providers/Microsoft.Elastic/monitors/Monitor04/tagRules/default
LogRuleFilteringTag          : {{
                                 "name": "TagObj1Name",
                                 "value": "TagObj1Val",
                                 "action": "Exclude"
                               }, {
                                 "name": "TagObj2Name",
                                 "value": "TagObj2Val",
                                 "action": "Include"
                               }}
LogRuleSendAadLog            : False
LogRuleSendActivityLog       : True
LogRuleSendSubscriptionLog   : False
Name                         : default
ProvisioningState            : Succeeded
ResourceGroupName            : ElasticResourceGroup01
SystemDataCreatedAt          : 07/19/2023 09:50:14
SystemDataCreatedBy          : user@contoso.com
SystemDataCreatedByType      : User
SystemDataLastModifiedAt     : 07/19/2023 09:50:14
SystemDataLastModifiedBy     : user@contoso.com
SystemDataLastModifiedByType : User
Type                         : microsoft.elastic/monitors/tagrules
```

Create or update a tag rule set for a given monitor resource via body.
