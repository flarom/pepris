<a href="https://flarom.github.io/pepris-page">
  <img align="left" src="Resources/fullLogo1.png" width="203px"/>
</a>

---

Pepris is a free to play opensource stacker made on Windows Forms!

## How to build
To build Pepris for Windows (7 or later), use the latest version of Visual Studio and the provided `Pepris.sln` solution file.
Simply open the solution file on Visual Studio and press F5 to compile it.

Please note that the game may not run correctly due to the missing `settings.xml` file.
You can simply fix it by opening the ingame settings menu and adjusting the board size and opacity.
Or by creating the `settings.xml` file manually, in the directory where `pepris.exe` is located, and pasting the following:
```xml
<?xml version="1.0" encoding="utf-8"?>
<Settings>
  <pointSize>20</pointSize>
  <boardOpacity>1</boardOpacity>
</Settings>
```

*Thank you for playing!*
