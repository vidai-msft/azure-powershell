if(($null -eq $TestName) -or ($TestName -contains 'New-AzElasticCreateAndAssociateIPFilter'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'New-AzElasticCreateAndAssociateIPFilter.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-AzElasticCreateAndAssociateIPFilter' {
    It 'Create' {
        { New-AzElasticCreateAndAssociateIPFilter -ResourceGroupName $env.resourceGroup -MonitorName $env.elasticName01 -Name $env.ipFilterName01 -IP 10.10.10.0/24 } | Should -Not -Throw
    }

    It 'CreateViaIdentity' {
        {
            $monitor = Get-AzElasticMonitor -ResourceGroupName $env.resourceGroup -Name $env.elasticName01
            New-AzElasticCreateAndAssociateIPFilter -MonitorInputObject $monitor -Name $env.ipFilterName02 -IP 10.10.11.0/24
        } | Should -Not -Throw
    }
}
