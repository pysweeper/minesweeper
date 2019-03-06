# Pysweeper Joins the Battle!

## Py Enthusiasts:

1. Benjamin Wyss
2. Jeff Kissick
3. Jon Volden
4. Thomas Smithey

### Goals as laid out by [Project 2](https://canvas.instructure.com/courses/1516832/assignments/10826093)

#### Goal 1: Up to Code

Code Requirements and how they pertain to our adopted project:
1. Must use C++/VBA
2. Attempt two phases of refactoring prior to feature implimentation
    * Minimize - Write it once.
    * Optimize - Write it better.
3. Any other drastic changes? Ask Kline.

#### Goal 2: Cheat Mode

Reveal then hide board via button press.

#### Goal 3: Custom Addition:

Professor approval by Wednesday? __No later than Friday__

__Ideas from each team member:__

Jon - Power ups. When you win a game in 'normal' mode, you get a one time use "reveal a cell near a mine." After you win again, it becomes "reveal a cell not next to a mine." The third time you can "auto flag" a mine.

Benjamin - 

Jeff - 

Thomas - 

## TODO:

1. Migrate FormSmall/SmallPickBomb into Module1.vb.
2. Make single UI form with complete functionality.
3. Adjust C++ backend to accept updated commands.
   1. Rows & Columns & Mines
   2. Cheat Mode
   3. Game mode
   4. Quit/Start over during any state.
4. Refactor
5. Refactor
6. ...

## Interface Between Front and Back End:

r## //set number of rows to ## and recreate board

c## //set number of columns to ## and recreate board

m### //set number of mines to ### and recreate 

g##.## //reveal space at row ##. and column .##

h //activate or deactivate cheat mode and reveal board

p //use powerup (need to finalize how powerups work)

----

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
