# OpenRGB Wallpaper
 Trying to sync your display with your RGB peripherals? You got it!
 
![0ECE82BCE3726BBEBD66EDAAD31DA2CE](https://user-images.githubusercontent.com/11488961/201486325-d19da505-4772-4ead-9985-83800e4a2582.png)
![C77368CA92B597AB0DB0F6580C13C43D](https://user-images.githubusercontent.com/11488961/201486328-6dc75e04-df6c-45e4-95e2-71cc54fbe34a.png)
![C4515847EF2CF131A3B40A05EB31CCCC](https://user-images.githubusercontent.com/11488961/201486330-6346c5ba-2877-40b1-bf58-04e820bb7667.png)

## Video
[<img src="https://i.ytimg.com/vi/kz963sRInoQ/maxresdefault.jpg" width="50%">](https://www.youtube.com/watch?v=kz963sRInoQ "OpenRGB Wallpaper")

# Download
https://github.com/qiangqiang101/OpenRGB-Wallpaper

# Build yourself
You need Visual Studio 2022 or newer, run Wallpaper.sln to begin.

# How To
1. Download OpenRGB Wallpaper, extract all files to your Hard Drive.
2. Run OpenRGB, go to Settings tab, Click E1.31 Devices.
3. Click Add button at bottom, Enter:
```
Name: Wallpaper1
IP: Any IP address doesn't matter
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

4. Save Settings, Restart OpenRGB.
5. On OpenRGB, go to SDK Server, click Start Server.
6. Run OpenRGB Wallpaper, Open UserSettings.xml.
7. Check the settings, modify it if you want.
8. Now run OpenRGB Wallpaper.

Note: 
1. The name of Screen must matching with the name on E1.31.
2. The Connect on the Toolbox menu only works if wallpaper is setting to Autoconnect false.
3. You can have more than one screen at a time, just add another <Screen></Screen> into Screens.
