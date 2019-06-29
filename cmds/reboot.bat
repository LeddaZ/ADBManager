@echo off
title ADBManager - Reboot
color 0f
echo How do you want to reboot?
echo 1) Normal
echo 2) Recovery
echo 3) Fastboot
set /p reboot=
if %reboot%==1
adb\adb.exe reboot
if %reboot%==2
adb\adb.exe reboot recovery
if %reboot%==3
adb\adb.exe reboot bootloader
pause
exit