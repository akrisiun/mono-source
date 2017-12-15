# src2 init script
# powershell -file init.ps1 clone
[cmdletbinding()]
param(
   [string]$Action=""
)

if ($Action -eq "")
{
    Write-Host "powershell init.ps1 <clone restore build run>"
}
else { if ($Action -eq "clone")
{
    git clone -b master https://github.com/akrisiun/mono-source
} }