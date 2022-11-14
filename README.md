# OpenRGB Wallpaper
[![HitCount](https://hits.dwyl.com/qiangqiang101/OpenRGB-Wallpaper.svg?style=flat-square&show=unique)](http://hits.dwyl.com/qiangqiang101/OpenRGB-Wallpaper)
![Github All Releases](https://img.shields.io/github/downloads/qiangqiang101/OpenRGB-Wallpaper/total.svg)
![GitHub release (latest by date)](https://img.shields.io/github/v/release/qiangqiang101/OpenRGB-Wallpaper)
![GitHub](https://img.shields.io/github/license/qiangqiang101/OpenRGB-Wallpaper)
![GitHub branch checks state](https://img.shields.io/github/checks-status/qiangqiang101/OpenRGB-Wallpaper/master)
![GitHub issues](https://img.shields.io/github/issues/qiangqiang101/OpenRGB-Wallpaper)
![GitHub forks](https://img.shields.io/github/forks/qiangqiang101/OpenRGB-Wallpaper?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/qiangqiang101/OpenRGB-Wallpaper?style=social)
![YouTube Channel Subscribers](https://img.shields.io/youtube/channel/subscribers/UCAZlasvEy1euunP1M7nwj5Q?style=social)
[![Donate via PayPal](https://img.shields.io/badge/Donate-Paypal-brightgreen)](https://paypal.me/imnotmental)
[![Follow on Patreon](https://img.shields.io/badge/Donate-Patreon-orange)](https://www.patreon.com/imnotmental)

 ![image](https://user-images.githubusercontent.com/11488961/201601205-465ca003-1300-4caa-a7e5-1897fb00119f.png)

Trying to sync your display with your RGB peripherals? You got it!
This application allows you to emulate your wallpaper like a LED Matrix and sync with your other RGB devices using [OpenRGB](https://gitlab.com/CalcProgrammer1/OpenRGB). This application currently only works on Windows OS, tested on Windows 10 ver 21H1 and Windows 11.
 
## Screenshots 
 ![0ECE82BCE3726BBEBD66EDAAD31DA2CE](https://user-images.githubusercontent.com/11488961/201486325-d19da505-4772-4ead-9985-83800e4a2582.png)
 ![C77368CA92B597AB0DB0F6580C13C43D](https://user-images.githubusercontent.com/11488961/201486328-6dc75e04-df6c-45e4-95e2-71cc54fbe34a.png)
 ![C4515847EF2CF131A3B40A05EB31CCCC](https://user-images.githubusercontent.com/11488961/201486330-6346c5ba-2877-40b1-bf58-04e820bb7667.png)

## Video
[<img src="https://i.ytimg.com/vi/kz963sRInoQ/maxresdefault.jpg" width="50%">](https://www.youtube.com/watch?v=kz963sRInoQ "OpenRGB Wallpaper")

# Download
https://github.com/qiangqiang101/OpenRGB-Wallpaper/releases

# Prerequisite
- [OpenRGB by CalcProgrammer1](https://gitlab.com/CalcProgrammer1/OpenRGB)
- [.NET Framework 4.8](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)

# Build yourself
You need Visual Studio 2022 or newer, run Wallpaper.sln to begin.

# How To
1. Download OpenRGB Wallpaper, extract all files to your Hard Drive.
2. Run OpenRGB, go to Settings tab, Click E1.31 Devices.
3. Click Add button at bottom, Enter:
```
Name: Wallpaper1
IP: Put a bogus IP
Start Universe: 1
Start Channel: 1
Number of LEDs: 576
Type: Matrix
Matrix Width: 36
Matrix Height: 18
Matrix Order: Horizontal Top Left
RGB Order: GRB
Universe Size: 510
Keepalive Time: 1000
```
![image](https://user-images.githubusercontent.com/11488961/201520080-4f8fc71e-c041-4509-87f4-c31f5819d11f.png)

4. Save Settings, Restart OpenRGB.
5. On OpenRGB, go to SDK Server, click Start Server.
6. Run OpenRGB Wallpaper, check the settings by right click on tray icon, modify it if you want.
7. Now run OpenRGB Wallpaper.

Note: 
1. The name of Screen must matching with the name on E1.31.
2. The Connect on the Toolbox menu only works if wallpaper is setting to Autoconnect false.
3. You are allow to change the Matrix Size, but make sure your LED count is matching the size, IE: 
```
Width  Height  LEDs
  16  x  9   = 144
  32  x  18  = 576
  64  x  36  = 2304
  256 x  144 = 36864
```
* The higher the LED count, the higher the CPU usage used.

# Special Thanks
- [OpenRGB by CalcProgrammer1](https://gitlab.com/CalcProgrammer1/OpenRGB)
- [OpenRGB.NET SDK by diogotr7](https://github.com/diogotr7/OpenRGB.NET)
