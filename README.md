# RoR2-Mods-Installer

Скачать установщик модов: https://github.com/NEMIX10/RoR2-Mods-Installer/releases/tag/RoR2-Mods-Installer

RoR2Mods-Installer v1.0
Инструкции к установщику модов

1. Указать путь к папке с игрой в файле "install-config.ini".
Пример: GameFolderPath=С:\Games\Risk of Rain 2\
Обязательно без кавычек и с бэкслэшем на конце!

2. Если моды уже установлены, то сначала удалите их("RoR2-Mods-Deleter.bat" в папке с игрой), если желаете то сохраните свои конфиги модов из каталога "BepInEx/configs" в папку с установщиком "Main_Mods_Setup/BepInEx/config".

3. Запустить "RoR2-Install-Mods.bat".
----------------------------------------------------
### Прочие советы

- Каталог "Main_Mod_Setup" используется установщиком для копирования модов в папку с игрой.

- В состав этой сборки входят только каталог "BepInEx"(+ всё внутри) и два файла: "doorstop_config.ini" и "winhttp.dll", то есть деинсталлятор удалит только эти элементы из корневой папки игры.

- В каталоге "Main_Mods_Setup/BepInEx/plugins" можно редактировать состав модов как вам угодно.

- !!! При удалении модов, конфиги модов сохраняются, то есть копируются из папки с игрой: "BepInEx/config", в папку с установщиком: "Main_Mods_Setup/BepInEx/config".

- Чтобы удалить моды - в папке с установщиком запустите ярлык "Delete Mods" или в папке с игрой "RoR2-Mods-Deleter.bat".

- Если не копируются файлы - попробуйте запустить установщик от имени администратора или отключить контроль учётных записей.

- Перед каждой установкой убедитесь что моды НЕ установлены, что в папке с игрой нет деинсталлятора, в случае если есть - запустите его, чтобы наверняка удалить всё лишнее и не создавать проблем с установкой.

- Каталог "installer_scripts" это вспомогательные сценарии установщика, действий пользователя тут не требуется.

- В случае запуска удаления модов, если деинсталлятор не начал обратный отсчёт для самоудаления - значит в файлах деинсталлятора что-то не так. Повторите установку модов и убедитесь что всё прошло успешно.
