@echo off
echo Enter file path:
set /p path=
adb\adb.exe push %path% /sdcard
pause
exit