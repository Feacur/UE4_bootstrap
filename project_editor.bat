@echo off
chcp 65001 > nul

rem Development|DebugGame|Debug
set State=%1
if [%State%] == [] ( set State=Development )

for /f "tokens=1,* delims= " %%a in ("%*") do (
	set Flags=%%b
)

rem |> PREPARE PROJECT
set ProjectFolder=%cd%
set Project=Something

rem |> PREPARE TOOLS
set EnginePath=C:/Program Files/Epic Games/UE_4.27/Engine
set "PATH=%PATH%;%EnginePath%/Binaries/Win64"

if %State% == Development (
	set Action=UE4Editor
) else if %State% == Debug (
	set Action=UE4Editor-Win64-DebugGame
) else if %State% == Debug (
	set Action=UE4Editor-Win64-Debug
)

rem |> DO
%Action%.exe "%ProjectFolder%/%Project%.uproject" %Flags%
