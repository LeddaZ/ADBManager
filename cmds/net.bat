@echo off
echo Enter IP address:
set /p ip=
adb\adb.exe connect %ip%:5555
pause
exit