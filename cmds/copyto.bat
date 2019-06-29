@echo off
title ADBManager - Copy file to Desktop
color 0f
echo Enter file path:
set /p path=
adb\adb.exe pull -a %path% %USERPROFILE%\Desktop
pause
exit