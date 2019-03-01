Pysweeper Joins the Battle!
1. Benjaman Wiss
2. Jeff Kissick
3. John Voldon
4. Tomaas Smythie



# minesweeper
## Team Rocket's Minesweeper (Alex, Sandy, Clay, Evan)

## Welcome to our project! 

### To Play:
Inside the "PLAY" folder is a .zip. Inside this .zip are the most recent compiled executables and resource files for
this version of Minesweeper. To play, extract the .zip somewhere, open the folder, and click MineSweeperGUI.exe.
Now you're playing!

### Documentation:
To view our documentation please go to the Documentation folder > HTML > and click any of the files ending in .html.
(Do this on your local machine after cloning the repo, if you do that from github it will just show you the
HTML code.)

### From the creators
You'll find that this program is actually **TWO** programs. There is a **C++ component**, and a **VBA component**.
VBA handles all of the user interface. C++ is more of a backend. To launch the program, the user would launch the
VBA executable on a Windows machine. The VBA executable will automatically open and close the C++ backend as it is needed.
VBA communicates with C++ through the VB.NET SendKeys method. When the user clicks a button, the VB executable gives focus to the
minimized C++ terminal, and types user input to it (dependant upon which button the user has clicked). In reality, this game could be a
standalone C++ terminal app. VBA exists in this application for the sole purpose of creating a more attractive user interface. 

In the final release of the application it is necessary that the following be in a folder together :
* 1.png
* 2.png
* 3.png
* 4.png
* 5.png
* 6.png
* 7.png
* 8.png
* flag.jpg
* board.txt
* map.txt
* you_lose.txt
* MineSweeper.exe (This is the C++ application)
* MineSweeperGUI.exe (This is the VBA application)

All that is needed to launch and run the program is for the user to click MineSweeperGUI.exe
If we had more time, we would have liked to have created an installer that automatically places these files somewhere *safe* and
creates a link to the MineSweeperGUI.exe.

Hope that's helpful.
