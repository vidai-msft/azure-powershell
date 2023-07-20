function RandomString([bool]$allChars, [int32]$len) {
    if ($allChars) {
        return -join ((33..126) | Get-Random -Count $len | ForEach-Object {[char]$_})
    } else {
        return -join ((48..57) + (97..122) | Get-Random -Count $len | ForEach-Object {[char]$_})
    }
}
$env = @{}
if ($UsePreviousConfigForRecord) {
    $previousEnv = Get-Content (Join-Path $PSScriptRoot 'env.json') | ConvertFrom-Json
    $previousEnv.psobject.properties | Foreach-Object { $env[$_.Name] = $_.Value }
}
# Add script method called AddWithCache to $env, when useCache is set true, it will try to get the value from the $env first.
# example: $val = $env.AddWithCache('key', $val, $true)
$env | Add-Member -Type ScriptMethod -Value { param( [string]$key, [object]$val, [bool]$useCache) if ($this.Contains($key) -and $useCache) { return $this[$key] } else { $this[$key] = $val; return $val } } -Name 'AddWithCache'
function setupEnv() {
    # Preload subscriptionId and tenant from context, which will be used in test
    # as default. You could change them if needed.
    $env.SubscriptionId = (Get-AzContext).Subscription.Id
    $env.TenantId = (Get-AzContext).Tenant.Id
    # For any resources you created for test, you should add it to $env here.

    $env.location = "eastus"
    $env.userEmail = (Get-AzContext).Account.Id
    $env.sku = "ess-monthly-consumption_Monthly"

    $env.elasticName01 = 'elastic-' + (RandomString -allChars $false -len 6)
    $env.elasticName02 = 'elastic-' + (RandomString -allChars $false -len 6)
    $env.elasticName03 = 'elastic-' + (RandomString -allChars $false -len 6)
    $env.elasticName04 = 'elastic-' + (RandomString -allChars $false -len 6)
    $env.elasticName05 = 'elastic-' + (RandomString -allChars $false -len 6)

    $env.ipFilterName01 = 'ip-filter-' + (RandomString -allChars $false -len 6)
    $env.ipFilterName02 = 'ip-filter-' + (RandomString -allChars $false -len 6)

    $env.plFilterName01 = 'pl-filter-' + (RandomString -allChars $false -len 6)
    $env.plFilterName02 = 'pl-filter-' + (RandomString -allChars $false -len 6)

    # Create the test group
    Write-Host -ForegroundColor Green "Start to create resource group"
    $env.resourceGroup = 'elastic-rg-' + (RandomString -allChars $false -len 6)
    New-AzResourceGroup -Name $env.resourceGroup -Location $env.location

    # Create two elastics for use in the test.
    Write-Host -ForegroundColor Green "Create two elastics for use in the test"
    New-AzElasticMonitor -ResourceGroupName $env.resourceGroup -Name $env.elasticName01 -Location $env.location -Sku $env.sku -UserInfoEmailAddress $env.userEmail
    New-AzElasticMonitor -ResourceGroupName $env.resourceGroup -Name $env.elasticName02 -Location $env.location -Sku $env.sku -UserInfoEmailAddress $env.userEmail

    Write-Host -ForegroundColor Green "Create two tag rules for use in the test"
    Write-Host -ForegroundColor Yellow "The only name allowed for a rule set is 'default'"
    New-AzElasticTagRule -ResourceGroupName $env.resourceGroup -MonitorName $env.elasticName01
    New-AzElasticTagRule -ResourceGroupName $env.resourceGroup -MonitorName $env.elasticName02

    # Create
    $envFile = 'env.json'
    if ($TestMode -eq 'live') {
        $envFile = 'localEnv.json'
    }
    Set-Content -Path (Join-Path $PSScriptRoot $envFile) -Value (ConvertTo-Json $env)
}
function cleanupEnv() {
    # Clean resources you create for testing
    Remove-AzResourceGroup -Name $env.resourceGroup
}
