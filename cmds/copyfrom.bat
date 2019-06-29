@echo off
tile ADBManager - Copy file to internal storage
color 0f
echo Enter file path:
set /p path=
adb\adb.exe push -a %path% /sdcard
pause
exit