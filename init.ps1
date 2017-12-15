# src2 init script
# 
[cmdletbinding()]
param(
   [string]$Action=""
)

if ($Action == "")
{
    Write-Host "init.ps1 <clone restore build run dev>"
}
else {
    if ($Action == "clone")
    {
        git clone https://github.com/akrisiun/RazorGenerator.MsBuild.git

        #REM cd d:\Sanitex\PrekesWeb\SanitexWeb.DX\
        git clone -b dx.v141 https://bitbucket.org/sanitex/snxweblib.git 
    }
}