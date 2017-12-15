@echo off
setlocal enabledelayedexpansion

set MSBUILD="c:\bin\Microsoft Visual Studio\2017\BuildTools\MSBuild\15.0\Bin\MSBuild.exe"
set MSBUILD="c:\Program Files (x86)\MSBuild\15.0\Bin\MSBuild.exe"
@REM dotnet restore src\MSBuild.sln 

%MSBUILD% /v:m  msbuild\src\Framework\Microsoft.Build.Framework.csproj

%MSBUILD% /v:m  msbuild\src\Build\Microsoft.Build.csproj

@REM @PAUSE

dotnet build roslyn\src\Workspaces\CSharp\Portable\CSharpWorkspace.csproj 

dotnet build roslyn\src\Workspaces\Core\Desktop\Workspaces.Desktop.csproj


@PAUSE    