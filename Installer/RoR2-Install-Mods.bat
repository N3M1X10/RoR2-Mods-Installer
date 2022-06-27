@echo off
>nul chcp 866

title RoR2 Mods Installer - Created by N3M1X10
echo [101;93mУстановщик BepInEx модов для "Risk of Rain 2"[0m
echo [44mCreated by N3M1X10[0m
echo.
::::::::::::::::::
::Тело программы::
::::::::::::::::::
::dirs
For /F "eol=; tokens=1* delims==" %%i In (install-config.ini) Do Set %%i=%%j

set dirdist=%GameFolderPath%

set dirpath=Main_Mods_Setup
echo [96m[ Начало установки модов ][0m
echo.
echo [92mКаталог [96m"%dirpath%" [92mКопируется . . .[33m
xcopy /v /o /e /y "%dirpath%" "%dirdist%"
IF %ERRORLEVEL%==0 (
echo.
echo [92mМоды [96m"%dirpath%" [92mУстановлены![33m
)
IF %ERRORLEVEL% NEQ 0 (
echo.
echo [31m[ОШИБКА] Моды [96m"%dirpath%" [31mНе установлены. [33mКаталог [96mигры[33m или [96mмодов[33m не найден или недоступен.
echo [33m[СОВЕТ] Проверьте правильность значения [96m"GameFolderPath"[33m указанного в [96m"install-config.ini".[33m
echo Или обратитесь к [96m"README.txt"[33m в папке с установщиком.
echo.
goto end
)

echo.

::files
set scriptpath=installer_scripts\
echo [92mФайл [96m"%scriptpath%RoR2-Mods-Deleter.bat" [92mКопируется . . .[33m
Copy /v "%scriptpath%RoR2-Mods-Deleter.bat" "%dirdist%"
IF %ERRORLEVEL% NEQ 0 (
echo [31mКаталог [96m"%scriptpath%\RoR2-Mods-Deleter.bat" [31mНе найден[0m
goto end
)
echo [92mДеинсталлятор скопирован![33m
echo.
@mshta vbscript:Execute("Set x=CreateObject(""WScript.Shell"").CreateShortcut(""Delete Mods.lnk""):x.TargetPath=""%dirdist%\RoR2-Mods-Deleter.bat"":x.WorkingDirectory = ""%dirdist%\"":x.HotKey="""":x.Save():Close()")
@mshta vbscript:Execute("Set x=CreateObject(""WScript.Shell"").CreateShortcut(""Risk of Rain 2.lnk""):x.TargetPath=""%dirdist%\Risk of Rain 2"":x.WorkingDirectory = ""%dirdist%\"":x.HotKey="""":x.Save():Close()")
>"%dirdist%\RoR2Mods-unins.ini" (
    echo ShortcutPath=%~dp0Delete Mods.lnk
    echo GameShortcutPath=%~dp0Risk of Rain 2.lnk
    echo InstallerPath=%~dp0
)
echo [92mЯрлыки [96mдеинсталлятора[92m и [96mигры[92m созданы в папке с установщиком![0m
echo.
echo [33m[СОВЕТ][92m Чтобы удалить моды:
echo [92m Запустите ярлык [96m"Delete Mods"[92m в папке с установщиком или [96m"RoR2-Mods-Deleter.bat"[92m в папке с игрой
echo.
echo.
:end
echo [33m[ Нажмите любую кнопку чтобы закрыть программу ]
>nul pause
exit