@echo off
echo Enter file path:
set /p path=
adb\adb.exe push -a %path% /sdcard
pause
exit