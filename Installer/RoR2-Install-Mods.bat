@echo off
>nul chcp 866

title RoR2 Mods Installer - Created by N3M1X10
echo [101;93m��⠭��騪 BepInEx ����� ��� "Risk of Rain 2"[0m
echo [44mCreated by N3M1X10[0m
echo.
::::::::::::::::::
::���� �ணࠬ��::
::::::::::::::::::
::dirs
For /F "eol=; tokens=1* delims==" %%i In (install-config.ini) Do Set %%i=%%j

set dirdist=%GameFolderPath%

set dirpath=Main_Mods_Setup
echo [96m[ ��砫� ��⠭���� ����� ][0m
echo.
echo [92m��⠫�� [96m"%dirpath%" [92m��������� . . .[33m
xcopy /v /o /e /y "%dirpath%" "%dirdist%"
IF %ERRORLEVEL%==0 (
echo.
echo [92m���� [96m"%dirpath%" [92m��⠭������![33m
)
IF %ERRORLEVEL% NEQ 0 (
echo.
echo [31m[������] ���� [96m"%dirpath%" [31m�� ��⠭������. [33m��⠫�� [96m����[33m ��� [96m�����[33m �� ������ ��� ������㯥�.
echo [33m[�����] �஢���� �ࠢ��쭮��� ���祭�� [96m"GameFolderPath"[33m 㪠������� � [96m"install-config.ini".[33m
echo ��� ������� � [96m"README.txt"[33m � ����� � ��⠭��騪��.
echo.
goto end
)

echo.

::files
set scriptpath=installer_scripts\
echo [92m���� [96m"%scriptpath%RoR2-Mods-Deleter.bat" [92m��������� . . .[33m
Copy /v "%scriptpath%RoR2-Mods-Deleter.bat" "%dirdist%"
IF %ERRORLEVEL% NEQ 0 (
echo [31m��⠫�� [96m"%scriptpath%\RoR2-Mods-Deleter.bat" [31m�� ������[0m
goto end
)
echo [92m�����⠫���� ᪮��஢��![33m
echo.
@mshta vbscript:Execute("Set x=CreateObject(""WScript.Shell"").CreateShortcut(""Delete Mods.lnk""):x.TargetPath=""%dirdist%\RoR2-Mods-Deleter.bat"":x.WorkingDirectory = ""%dirdist%\"":x.HotKey="""":x.Save():Close()")
@mshta vbscript:Execute("Set x=CreateObject(""WScript.Shell"").CreateShortcut(""Risk of Rain 2.lnk""):x.TargetPath=""%dirdist%\Risk of Rain 2"":x.WorkingDirectory = ""%dirdist%\"":x.HotKey="""":x.Save():Close()")
>"%dirdist%\RoR2Mods-unins.ini" (
    echo ShortcutPath=%~dp0Delete Mods.lnk
    echo GameShortcutPath=%~dp0Risk of Rain 2.lnk
    echo InstallerPath=%~dp0
)
echo [92m��모 [96m�����⠫����[92m � [96m����[92m ᮧ���� � ����� � ��⠭��騪��![0m
echo.
echo [33m[�����][92m �⮡� 㤠���� ����:
echo [92m ������� ��� [96m"Delete Mods"[92m � ����� � ��⠭��騪�� ��� [96m"RoR2-Mods-Deleter.bat"[92m � ����� � ��ன
echo.
echo.
:end
echo [33m[ ������ ���� ������ �⮡� ������� �ணࠬ�� ]
>nul pause
exit