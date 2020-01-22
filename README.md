# SG Transfer Tool

SG Transfer Tool is a simple tool created for Windows that let *The Messenger* players easily maintain and switch between different **SaveGame** files. It stores every **SaveGame** you select in the app for later use (these stored files are called saves in this document).

### Installation

[Installation video guide](https://www.youtube.com/watch?v=WeSExqamJ_U)

**Important:** You must run *SG Transfer Tool* as an administrator for the app to work. The reason this is necessary is because *The Messenger* save data is stored in the *C:* drive of computers. Apps cannot access this location without being run as an administrator. To run *SG Transfer Tool,* right click the shortcut (or search result if you used the Windows search bar) then click *Run as administrator.* Click *Yes* on the following pop-up.

**Also important:** Make sure to read *Usage* or watch the *Usage video guide.*

*How to install:*

1) Download and run *SG Transfer Tool.msi.*
2) The install wizard will open, click *next*.
3) Make sure *Just me* in the bottom left hand corner is checked and click *next* again (if *Just me* isn't visible, don't worry about, just click *next.*)
4) Click *next.* You will get a pop-up asking if you want the app to make changes to your PC. Click *Yes.*
5) After installation, click *Close* on the *installation complete* window.


*How to uninstall:*
1) Search and open *Control Panel* in the Windows search bar.
2) Click *Uninstall a program* (bottom left hand corner).
3) Scroll to *SG Transfer Tool Setup* and right click it.
4) Select *Remove* and then click *Yes* on the pop-up.
5) You will get a pop-up asking if you want the app to make changes to your PC. Click *Yes.*

### Usage:

[Usage video guide](https://www.youtube.com/watch?v=sPzSnVX1o3s)

##### Settings tab:

Before you start, make sure that *Hidden items* is checked in *View* in the Windows file explorer.

The settings window will allow you to set two paths that are necessary for *SG Transfer Tool* to work. The first is **Save game folder path.** In this field, you mast provide the location of the **folder** where the **SaveGame.txt** file of your game is. It should be the following path: *C:\Users\YourUserName\AppData\LocalLow\Sabotage Studio\The Messenger.* Make sure to replace *YourUserName* with the name of your user. For example, my user is named Jacob. So the path for me would be: *C:\Users\Jacob\AppData\LocalLow\Sabotage Studio\The Messenger.* You can click the **Browse** button under the text box to browse for the folder instead of typing the path. The other is the **Game .exe or shortcut.** In this field you mast provide the location of the game's .exe OR the location of a shortcut to the game. Once again, you can click the **Browse** button under the text box to browse for the file.

Notes:
1) The app will already have the default paths for the Steam version of the game loaded. You will, however, need to put in the name of your user in **Save game folder path.** ***If you do not have the steam version of the game,*** you will need to find out where the .exe or where a shortcut of the game is, and use that path.

2) You must click the **Save** button for the changes you make to take place.

3) If you are going to browse for the **SaveGame.txt** folder, make sure you have *Hidden Items* checked in the windows file explorer.

4) If you set *SG Transfer Tool* to use a shortcut in **Game .exe or shortcut,** DO NOT MOVE THE SHORTCUT. Or, if you need to: set to app to use the .exe of the game, move your shortcut, then set the app to use the new location of the shortcut

##### Create tab:

There are two options for creating a new save in *SG Transfer Tool.*

*New from file:* This option lets you browse your computer for a **SaveGame** file. Simply find the **SaveGame.txt** file you want to save, then click open.

*New from current save:* This options lets you create a save from your current game in *The Messenger.*

After you select either option, an **Add new** window will appear. The path of the **SaveGame** file you selected will be under **Save file path.** You do not need to change it. It's there is case you might need to change it for some reason. Under **Name:** give the save a name. It cannot be the same name as an already existing save. Click **Add** to add the save to the app.

##### Remove tab:

There are two options for removing a save in *SG Transfer Tool.*

*All:* Lets you remove all saves from the app. You will be asked if you are sure before the action goes through.

*Selected save:* Lets you remove the selected save.

##### Load selected save button:

The **Load selected save** button will automatically change your current **SaveGame** of *The Messenger* with the save you have selected. *SG Transfer Tool* will start the game automatically after the transfer is finished. If the game is running, it will be restarted automatically.
