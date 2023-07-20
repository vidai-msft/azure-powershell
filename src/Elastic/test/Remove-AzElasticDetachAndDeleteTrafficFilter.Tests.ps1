if(($null -eq $TestName) -or ($TestName -contains 'Remove-AzElasticDetachAndDeleteTrafficFilter'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Remove-AzElasticDetachAndDeleteTrafficFilter.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Remove-AzElasticDetachAndDeleteTrafficFilter' {
    It 'Delete' {
        {
            $ruleSet = Get-AzElasticListAssociatedTrafficFilter -ResourceGroupName $env.resourceGroup -MonitorName $env.elasticName01 | Where-Object Name -eq $env.ipFilterName01
            Remove-AzElasticDetachAndDeleteTrafficFilter -ResourceGroupName $env.resourceGroup -MonitorName $env.elasticName01 -RulesetId $ruleSet.Id
        } | Should -Not -Throw
    }

    It 'DeleteViaIdentity' {
        {
            $monitor = Get-AzElasticMonitor -ResourceGroupName $env.resourceGroup -Name $env.elasticName01
            $ruleSet = Get-AzElasticListAssociatedTrafficFilter -MonitorInputObject $monitor | Where-Object Name -eq $env.plFilterName01
            Remove-AzElasticDetachAndDeleteTrafficFilter -MonitorInputObject $monitor -RulesetId $ruleSet.Id
        } | Should -Not -Throw
    }
}
