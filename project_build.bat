@echo off
chcp 65001 > nul

rem Shipping|Test|Development|DebugGame|Debug
set State=%1
if [%State%] == [] ( set State=Shipping )

rem []|Editor|Client|Server
set Target=%2
if [%Target%] == [] ( set Target= )

for /f "tokens=2,* delims= " %%a in ("%*") do (
	set Flags=%%b
)

rem |> PREPARE PROJECT
set ProjectFolder=%cd%
set Project=Something

rem |> PREPARE TOOLS
set EnginePath=C:/Program Files/Epic Games/UE_4.27/Engine
set "PATH=%PATH%;%EnginePath%/Binaries/DotNET"

rem |> DO
set VSLANG=1033
UnrealBuildTool.exe "%ProjectFolder%/%Project%.uproject" Win64 %State% %Project%%Target% -waitmutex %Flags%
