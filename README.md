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

Turn your wallpaper into an OpenRGB device. You can now control the RGB lighting on your wallpaper and synchronize wallpaper with other OpenRGB compatible devices by  [OpenRGB](https://gitlab.com/CalcProgrammer1/OpenRGB). This application currently only works on Windows OS, tested on Windows 10 ver 21H1 and Windows 11 ver 21H2.
 
### Screenshots 
![IMG_6915](https://user-images.githubusercontent.com/11488961/202174752-3ecf4780-be04-40de-9382-d5ad14732104.JPG)
![IMG_6916](https://user-images.githubusercontent.com/11488961/202174762-a31ea030-35ec-47d6-a1b7-d8cee2229893.JPG)
![IMG_6917](https://user-images.githubusercontent.com/11488961/202174765-5b2bbdfc-581e-4bf2-ab65-979c0533dd4b.JPG)
![IMG_6919](https://user-images.githubusercontent.com/11488961/202174769-6164a88d-039d-4922-a501-51649a4a2da6.JPG)

### Download
- [My Github](https://github.com/qiangqiang101/OpenRGB-Wallpaper/releases)
- [OpenRGB Deverloper Gitlab](https://gitlab.com/OpenRGBDevelopers/OpenRGB-Wallpaper/-/releases)
- [Wallpaper Engine version](https://steamcommunity.com/sharedfiles/filedetails/?id=2942091593)

### Prerequisite
- [OpenRGB by CalcProgrammer1](https://gitlab.com/CalcProgrammer1/OpenRGB)
- [.NET 8.0 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

### About Virus
From the latest release [test result](https://www.virustotal.com/gui/file/34a2b0d40e1ae37f1184a6c3e52a1a207f5456cbdc6ecfa9f0539e864461043b/detection) shows that 2 out of 70 vendors detected as Malicious, it's false positive, you're safe, if you have doubts, you can build the project by yourself, build instructions can be found below.

### Build yourself
You need Visual Studio 2022 or newer, run Wallpaper.sln to begin. Click the Build on menu, select Build Solution.

### How To
1. Download OpenRGB Wallpaper, extract all files to your Hard Drive.
2. Run OpenRGB, go to Settings tab, Click E1.31 Devices.
3. Click Add button at bottom, Enter:

<table>
<tr>
<td><b>Name</b></td>
<td>Wallpaper1</td>
<td><b>IP (Unicast)</b></td>
<td>127.0.0.254</td>
</tr>
<tr>
<td><b>Start Universe</b></td>
<td>1</td>
<td><b>Start Channel</b></td>
<td>1</td>
</tr>
<tr>
<td><b>Number of LEDs</b></td>
<td>2304</td>
<td><b>Type</b></td>
<td>Matrix</td>
</tr>
<tr>
<td><b>Matrix Width</b></td>
<td>64</td>
<td><b>Matrix Height</b></td>
<td>36</td>
</tr>
<tr>
<td><b>Matrix Order</b></td>
<td>Horizon Top Left</td>
<td><b>RGB Order</b></td>
<td>RGB</td>
</tr>
<tr>
<td><b>Universe Size</b></td>
<td>510</td>
<td><b>Keepalive Time</b></td>
<td>1000</td>
</tr>
</table>

4. Save Settings, Restart OpenRGB.
5. On OpenRGB, go to SDK Server, click Start Server.
6. Run OpenRGB Wallpaper, check the settings by right click on tray icon, modify it if you want.
7. Now run OpenRGB Wallpaper.

Note: 
1. The name of Wallpaper Device must matching with the name on E1.31.
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

### Special Thanks
- [OpenRGB by CalcProgrammer1](https://gitlab.com/CalcProgrammer1/OpenRGB)
- [OpenRGB.NET SDK by diogotr7](https://github.com/diogotr7/OpenRGB.NET)

### Video
<video src='https://user-images.githubusercontent.com/11488961/202005200-335f0e59-1bc4-46fa-bd34-ecd81395707b.mov' width=180 />
<video src='https://user-images.githubusercontent.com/11488961/202003013-ad6310d6-2cd6-4228-b41c-40690122471a.mov' width=180 />
