if(($null -eq $TestName) -or ($TestName -contains 'New-AzElasticMonitor'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'New-AzElasticMonitor.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-AzElasticMonitor' {
    It 'CreateExpanded' {
        $monitor = New-AzElasticMonitor -ResourceGroupName $env.resourceGroup -Name $env.elasticName03 -Location $env.location -Sku $env.sku -UserInfoEmailAddress $env.userEmail
        $monitor.ProvisioningState | Should -Be 'Succeeded'
    }

    It 'CreateViaJsonString' {
        $monitorProps = @{
            location   = $env.location
            sku        = @{
                name = $env.sku
            }
            properties = @{
                userInfo = @{
                    emailAddress = $env.userEmail
                    companyName  = "Contoso"
                    companyInfo  = @{
                        country = "United States"
                        state   = "WA"
                    }
                }
            }
        }
        $monitorPropsJson = ConvertTo-Json -InputObject $monitorProps -Depth 5
        $monitor = New-AzElasticMonitor -ResourceGroupName $env.resourceGroup -Name $env.elasticName04 -JsonString $monitorPropsJson
        $monitor.ProvisioningState | Should -Be 'Succeeded'
    }

    It 'CreateViaJsonFilePath' -Skip {

    }
}
