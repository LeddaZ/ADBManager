@echo off
echo Enter file path:
set /p path=
adb\adb.exe pull -a %path% %USERPROFILE%\Desktop
pause
exit