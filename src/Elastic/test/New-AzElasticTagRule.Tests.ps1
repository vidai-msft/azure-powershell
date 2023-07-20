if(($null -eq $TestName) -or ($TestName -contains 'New-AzElasticTagRule'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'New-AzElasticTagRule.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-AzElasticTagRule' {
    It 'CreateExpanded' {
        $tagRule = New-AzElasticTagRule -ResourceGroupName $env.resourceGroup -MonitorName $env.elasticName01
        $tagRule.Name | Should -Be 'default'
        $tagRule.LogRuleSendAadLog | Should -Be $false
        $tagRule.LogRuleSendActivityLog | Should -Be $false
        $tagRule.LogRuleSendSubscriptionLog | Should -Be $false
        $tagRule.LogRuleFilteringTag.Count | Should -Be 0
    }

    It 'CreateViaJsonString' {
        $ruleProps = @{
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
        $rulePropsJson = ConvertTo-Json -InputObject $ruleProps -Depth 5
        $tagRule = New-AzElasticTagRule -ResourceGroupName $env.resourceGroup -MonitorName $env.elasticName01 -JsonString $rulePropsJson
        $tagRule.Name | Should -Be 'default'
        $tagRule.LogRuleSendAadLog | Should -Be $true
        $tagRule.LogRuleSendActivityLog | Should -Be $true
        $tagRule.LogRuleSendSubscriptionLog | Should -Be $false
        $tagRule.LogRuleFilteringTag.Count | Should -Be 2
    }

    It 'CreateViaJsonFilePath' -Skip {

    }

    It 'CreateViaIdentityMonitorExpanded' {
        $monitor = Get-AzElasticMonitor -ResourceGroupName $env.resourceGroup -Name $env.elasticName01
        $tagRule = New-AzElasticTagRule -MonitorInputObject $monitor -LogRuleSendActivityLog
        $tagRule.Name | Should -Be 'default'
        $tagRule.LogRuleSendAadLog | Should -Be $false
        $tagRule.LogRuleSendActivityLog | Should -Be $true
        $tagRule.LogRuleSendSubscriptionLog | Should -Be $false
        $tagRule.LogRuleFilteringTag.Count | Should -Be 0
    }

    It 'CreateViaIdentityMonitor' {
        $monitor = Get-AzElasticMonitor -ResourceGroupName $env.resourceGroup -Name $env.elasticName01
        $tagRuleBody = @{
            LogRuleSendAadLog          = $false
            LogRuleSendActivityLog     = $true
            LogRuleSendSubscriptionLog = $false
            LogRuleFilteringTag        = @(
                @{
                    Action = "Exclude"
                    Name   = "Tag3Name"
                    Value  = "Tag3Val"
                }
            )
        }
        $tagRule = New-AzElasticTagRule -MonitorInputObject $monitor -Body $tagRuleBody
        $tagRule.Name | Should -Be 'default'
        $tagRule.LogRuleSendAadLog | Should -Be $false
        $tagRule.LogRuleSendActivityLog | Should -Be $true
        $tagRule.LogRuleSendSubscriptionLog | Should -Be $false
        $tagRule.LogRuleFilteringTag.Count | Should -Be 1
    }
}
