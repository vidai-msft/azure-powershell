if(($null -eq $TestName) -or ($TestName -contains 'Update-AzElasticTagRule'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Update-AzElasticTagRule.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Update-AzElasticTagRule' {
    It 'UpdateExpanded' {
        {
            $ruleSet = Get-AzElasticTagRule -ResourceGroupName $env.resourceGroup -MonitorName $env.elasticName01
            $ruleSet.Tags = @(
                New-AzElasticFilteringTagObject -Action Include -Name Tag1Name -Value Tag1Val,
                New-AzElasticFilteringTagObject -Action Exclude -Name Tag2Name -Value Tag2Val,
                New-AzElasticFilteringTagObject -Action Exclude -Name Tag3Name -Value Tag3Val
            )
            Update-AzElasticTagRule -ResourceGroupName $env.resourceGroup -MonitorName $env.elasticName01 -TagRuleInputObject $ruleSet
        } | Should -Not -Throw
    }

    It 'UpdateViaIdentityMonitorExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateViaIdentityMonitor' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
