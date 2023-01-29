param (
    [Parameter(Mandatory)]
    [ValidateNotNull()]
    [ValidateScript({ Test-Path -LiteralPath $_ -PathType Container })]
    [string] $RepoLocation,

    [Parameter(Mandatory)]
    [ValidateNotNull()]
    [ValidateScript({ Test-Path -LiteralPath $_ -PathType Container })]
    [string] $DataLocation,

    [Parameter(Mandatory)]
    [ValidateNotNullOrEmpty()]
    [string] $BuildId
)

function RemoveModule {
    param(
        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [string] $ModuleName
    )

    $module = Get-Module -Name $ModuleName -ListAvailable
    if ($null -ne $module) {
        $Module.Path | ForEach-Object {
            $moduleDir = $_ | Split-Path | Split-Path
            if (Test-Path $moduleDir -PathType Container) {
                Remove-Item -Path $moduleDir -Recurse -Force
            }
        }
    }
}

function ImportLocalAzModules {
    param (
        [Parameter(Mandatory)]
        [ValidateScript({ Test-Path -LiteralPath $_ -PathType Container })]
        [string] $RepoLocation
    )

    $debugDirectory = Join-Path -Path $RepoLocation -ChildPath "artifacts" | Join-Path -ChildPath "Debug"
    $accountsModuleDirectory = Join-Path -Path $debugDirectory -ChildPath "Az.Accounts"

    Write-Host "Start to import Azure PowerShell modules from artifacts/Debug." -ForegroundColor Green

    Write-Host "##[section]Importing Az.Accounts" -ForegroundColor Green
    Import-Module (Join-Path -Path $accountsModuleDirectory -ChildPath "Az.Accounts.psd1")

    Get-ChildItem -Path $debugDirectory -Directory -Exclude "Az.Accounts" | Get-ChildItem -File -Filter "*.psd1" | ForEach-Object {
        Write-Host "##[section]Importing $($_.FullName)" -ForegroundColor Green
        Import-Module $_.FullName -Force
    }
    Write-Host "Successfully imported Azure PowerShell modules from artifacts/Debug" -ForegroundColor Green
}

RemoveModule -ModuleName "Azure"
RemoveModule -ModuleName "Azure.*"
RemoveModule -ModuleName "AzureRM"
RemoveModule -ModuleName "AzureRM.*"
RemoveModule -ModuleName "Az"
RemoveModule -ModuleName "Az.*"

ImportLocalAzModules -RepoLocation $RepoLocation

Import-Module (Join-path -Path $PSScriptRoot -ChildPath "TestCoverageUtility.psd1") -Force
Add-TestCoverageAdditionalInfo -DataLocation $DataLocation -Source CITest -BuildId $BuildId
