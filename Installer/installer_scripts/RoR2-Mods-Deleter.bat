@echo off
>nul chcp 866

title RoR2 Mods Deleter - Created by N3M1X10
echo [101;93mRemove BepInEx compatible mods from "Risk of Rain 2"[0m
echo [44mCreated by N3M1X10[0m
echo.
echo.

::::::::::::::::::
::���� �ணࠬ��::
::::::::::::::::::
::dirs
For /F "eol=; tokens=1* delims==" %%i In (RoR2Mods-unins.ini) Do Set %%i=%%j

set dirpath=BepInEx\config
echo [96m[ ���࠭�� ���䨣� ����� . . . ][0m
echo.
echo [92m��⠫�� [96m"%dirpath%" [92m��������� . . .[33m
set dirdist=%InstallerPath%Main_Mods_Setup\BepInEx\config
xcopy /v /o /e /y "%dirpath%" "%dirdist%"
IF %ERRORLEVEL%==0 (
echo.
echo [92m���䨣� ����� �� [96m"%dirpath%" [92m��࠭��� � ����� � ��⠭��騪��![33m
echo.
)
IF %ERRORLEVEL% NEQ 0 (
echo.
echo [31m���� [96m"%dirpath%" [31m�� ��⠭������, ��⠫�� �� ������ ��� ������㯥�[33m
goto end
)

set dirpath=BepInEx
echo [92m��⠫�� [96m"%dirpath%" [92m�������� . . .[31m
>nul RMDIR /q /s "%dirpath%"
IF %ERRORLEVEL%==0 (
echo [92m��⠫�� [96m"%dirpath%" [92m�������![31m
)

echo.

::files
set filepath=doorstop_config.ini
echo [92m���� [96m"%filepath%" [92m�������� . . .[31m
>nul erase "%filepath%"
IF %ERRORLEVEL% NEQ 0 (
echo [31m��⠫�� [96m"%filepath%" [31m�� ������[0m
)
echo [92m���� [96m"%filepath%" [92m�����![31m
echo.

set filepath=winhttp.dll
echo [92m���� [96m"%filepath%" [92m�������� . . .[31m
>nul erase "%filepath%"
IF %ERRORLEVEL% NEQ 0 (
echo [31m���� [96m"%filepath%" [31m�� ������[0m
)
echo [92m���� [96m"%filepath%" [92m�����![31m
echo.

set filepath=%ShortcutPath%
echo [92m���� [96m"%filepath%" [92m�������� . . .[31m
>nul erase "%filepath%"
IF %ERRORLEVEL% NEQ 0 (
echo [31m���� [96m"%filepath%" [31m�� ������[0m
)
echo [92m���� [96m"%filepath%" [92m�����![31m
echo.

set filepath=%GameShortcutPath%
echo [92m���� [96m"%filepath%" [92m�������� . . .[31m
>nul erase "%filepath%"
IF %ERRORLEVEL% NEQ 0 (
echo [31m���� [96m"%filepath%" [31m�� ������[0m
)
echo [92m���� [96m"%filepath%" [92m�����![31m
echo.

set filepath=RoR2Mods-unins.ini
echo [92m���� [96m"%filepath%" [92m�������� . . .[31m
>nul erase "%filepath%"
IF %ERRORLEVEL% NEQ 0 (
echo [31m���� [96m"%filepath%" [31m�� ������[0m
)
echo [92m���� [96m"%filepath%" [92m�����![31m
echo.

Echo [96m�� ���祭�� ⠩��� �����⠫���� [31mᠬ�㤠�����[96m.
Echo [96m������ ���� ������ �⮡� �ய����� ⠩���. ��� ...
Echo [96m�뤥��� �� ���⮪ ���᮫� �⮡� ��⠭����� ⠩���.
echo [33m
timeout /t 10

set filepath=RoR2-Mods-Deleter.bat
echo [92m���� [96m"%filepath%" [92m�������� . . .[31m
>nul erase "%filepath%"
IF %ERRORLEVEL% NEQ 0 (
echo [31m��⠫�� [96m"%filepath%" [31m�� ������[0m
)
echo [92m��⠫�� [96m"%filepath%" [92m�������![31m

:end
echo.
echo.
echo.
echo [33m[ ������ ���� ������ �⮡� ������� ���� ]
>nul pause
exit