@echo off
>nul chcp 866

title RoR2 Mods Deleter - Created by N3M1X10
echo [101;93mRemove BepInEx compatible mods from "Risk of Rain 2"[0m
echo [44mCreated by N3M1X10[0m
echo.
echo.

::::::::::::::::::
::Тело программы::
::::::::::::::::::
::dirs
For /F "eol=; tokens=1* delims==" %%i In (RoR2Mods-unins.ini) Do Set %%i=%%j

set dirpath=BepInEx\config
echo [96m[ Сохраняю конфиги модов . . . ][0m
echo.
echo [92mКаталог [96m"%dirpath%" [92mКопируется . . .[33m
set dirdist=%InstallerPath%Main_Mods_Setup\BepInEx\config
xcopy /v /o /e /y "%dirpath%" "%dirdist%"
IF %ERRORLEVEL%==0 (
echo.
echo [92mКонфиги модов из [96m"%dirpath%" [92mсохранены в папку с установщиком![33m
echo.
)
IF %ERRORLEVEL% NEQ 0 (
echo.
echo [31mМоды [96m"%dirpath%" [31mне установлены, каталог не найден или недоступен[33m
goto end
)

set dirpath=BepInEx
echo [92mКаталог [96m"%dirpath%" [92mУдаляется . . .[31m
>nul RMDIR /q /s "%dirpath%"
IF %ERRORLEVEL%==0 (
echo [92mКаталог [96m"%dirpath%" [92mУдалено![31m
)

echo.

::files
set filepath=doorstop_config.ini
echo [92mФайл [96m"%filepath%" [92mУдаляется . . .[31m
>nul erase "%filepath%"
IF %ERRORLEVEL% NEQ 0 (
echo [31mКаталог [96m"%filepath%" [31mНе найден[0m
)
echo [92mФайл [96m"%filepath%" [92mУдалён![31m
echo.

set filepath=winhttp.dll
echo [92mФайл [96m"%filepath%" [92mУдаляется . . .[31m
>nul erase "%filepath%"
IF %ERRORLEVEL% NEQ 0 (
echo [31mФайл [96m"%filepath%" [31mНе найден[0m
)
echo [92mФайл [96m"%filepath%" [92mУдалён![31m
echo.

set filepath=%ShortcutPath%
echo [92mФайл [96m"%filepath%" [92mУдаляется . . .[31m
>nul erase "%filepath%"
IF %ERRORLEVEL% NEQ 0 (
echo [31mФайл [96m"%filepath%" [31mНе найден[0m
)
echo [92mФайл [96m"%filepath%" [92mУдалён![31m
echo.

set filepath=%GameShortcutPath%
echo [92mФайл [96m"%filepath%" [92mУдаляется . . .[31m
>nul erase "%filepath%"
IF %ERRORLEVEL% NEQ 0 (
echo [31mФайл [96m"%filepath%" [31mНе найден[0m
)
echo [92mФайл [96m"%filepath%" [92mУдалён![31m
echo.

set filepath=RoR2Mods-unins.ini
echo [92mФайл [96m"%filepath%" [92mУдаляется . . .[31m
>nul erase "%filepath%"
IF %ERRORLEVEL% NEQ 0 (
echo [31mФайл [96m"%filepath%" [31mНе найден[0m
)
echo [92mФайл [96m"%filepath%" [92mУдалён![31m
echo.

Echo [96mПо истечению таймера деинсталлятор [31mсамоудалится[96m.
Echo [96mНажмите любую кнопку чтобы пропустить таймер. Или ...
Echo [96mВыделите любой участок консоли чтобы остановить таймер.
echo [33m
timeout /t 10

set filepath=RoR2-Mods-Deleter.bat
echo [92mФайл [96m"%filepath%" [92mУдаляется . . .[31m
>nul erase "%filepath%"
IF %ERRORLEVEL% NEQ 0 (
echo [31mКаталог [96m"%filepath%" [31mНе найден[0m
)
echo [92mКаталог [96m"%filepath%" [92mУдалено![31m

:end
echo.
echo.
echo.
echo [33m[ Нажмите любую кнопку чтобы закрыть окно ]
>nul pause
exit