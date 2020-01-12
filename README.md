# ADBManager
Windows Forms applications written in Visual Basic to run some basic ADB commands from a GUI.

# Usage
Download the [latest release](https://github.com/LeddaZ/ADBManager/releases/latest) and extract the archive to an empty folder, then run `ADBManager.exe`. The application will start with the following screen:

![adb](https://github.com/LeddaZ/ADBManager/blob/master/pics/adb.png)

## adb commands
- List connected devices > `adb devices`
- Open shell > `adb shell`
- Reboot > See [Reboot commands](https://github.com/LeddaZ/ADBManager/blob/master/README.md#reboot-commands)
- Record screen > `adb shell screenrecord /sdcard/%name%.mp4` (`%name%` is the filename; max. 3 minutes due to adb limitations)
- Copy file to device > `adb push -a %source% %dest%` (`%source%` is the source file and `%dest%` is the destination path)
- Copy file to PC > `adb pull -a %source% %dest%` (same as the above)
- Connect over network > `adb connect %ip%:5555` (`%ip%` is the IP address of your device; you have to connect your device via USB, run `adb tcpip 5555`, disconnect the device and click on the button)
- Disconnect from network > `adb disconnect`
- Install APK file > `adb install %apk%` (`%apk%` is the APK file path)
- Terminate ADB > `adb kill-server`
- Grab a logcat > `adb logcat %file%.txt` (`%file%` is the logcat file path)

## Reboot commands
- Normal > `adb reboot`
- Recovery > `adb reboot recovery`
- Fastboot > `adb reboot bootloader`

## fastboot commands
- List connected devices > `fastboot devices`
- Check bootloader status > `fastboot oem device-info`
- Flash a recovery image > `fastboot flash recovery %img%` (`%img%` is the recovery image path)
- Boot an image > `fastboot boot %boot%` (`%boot%` is the image path)
- Reboot > `fastboot reboot`
