param(
[Parameter(Mandatory=$true)]
[string]$packageVersion 
)

if(Test-Path ../NugetRepository/HealthcarePortalBackendApi.$packageVersion* -PathType Leaf)
{
    "Package with version " + $packageVersion + " already exists!" 
    exit
}

$currentDate = Get-Date -UFormat "%Y%m%d%H%M%S"
dotnet pack ./HealthcarePortalBackendApi.csproj -c Release /p:PackageVersion=$packageVersion-rc$currentDate -o ../NugetRepository
