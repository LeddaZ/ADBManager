@echo off
echo Enter file path:
set /p path=
adb\adb.exe pull %path% %USERPROFILE%\Desktop
pause
exit