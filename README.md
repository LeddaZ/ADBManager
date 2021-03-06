# ADBManager
Windows Forms applications written in Visual Basic to run some basic ADB commands from a GUI.

# Usage
Download the [latest release](https://github.com/LeddaZ/ADBManager/releases/latest) and extract the archive in an empty folder, then run `ADBManager.exe`. The application will start with the following screen:

![adb](https://github.com/LeddaZ/ADBManager/blob/master/pics/adb.png)

## adb commands
- List connected devices > `adb devices`
- Open shell > `adb shell`
- Reboot > `adb reboot`
- Reboot to recovery > `adb reboot recovery`
- Reboot to fastboot > `adb reboot bootloader`
- Record screen > `adb shell screenrecord /sdcard/%name%.mp4` (`%name%` is the filename; max. 3 minutes due to adb limitations)
- Copy file to device > `adb push -a %source% %dest%` (`%source%` is the source file and `%dest%` is the destination path)
- Copy file to PC > `adb pull -a %source% %dest%` (same as the above)
- Connect over network > `adb connect %ip%:5555` (`%ip%` is the IP address of your device; you have to connect your device via USB, run `adb tcpip 5555`, disconnect the device and click on the button)
- Disconnect from network > `adb disconnect`
- Install APK file > `adb install %apk%` (`%apk%` is the APK file path)
- Terminate ADB > `adb kill-server`
- Grab a logcat > `adb logcat %file%.txt` (`%file%` is the logcat file path)
- Sideload a package > `adb sideload %zip%` (`%zip%` is the zip file path)

## fastboot commands
- List connected devices > `fastboot devices`
- Check bootloader status > `fastboot oem device-info`
- Flash an image > `fastboot flash %part% %img%` (`%part` is the partition and `%img%` is the image path)
- Boot an image > `fastboot boot %boot%` (`%boot%` is the image path)
- Reboot > `fastboot reboot`
