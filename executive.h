/*##################################################
-#@File: executive.h                               #
-#@Date: 2/4/2019                                  #
-#@File Description: The executive class manages   #
-# interaction between the windows form app and    #
-# the game board object.                          #
-###################################################*/


#pragma once
#include<iostream>
#include<string>
#include<cstdlib>
#include<fstream>
#include<time.h>
// #include<experimental/filesystem>

#include "square.h"
class executive
{
private:
 square** m_game_board;
 char** m_show_board;
 char** m_cheat_board;
 int m_row_size;
 int m_col_size;
 int m_mine_number;
 bool gameover;
 bool cheating;
protected:

public:
/**
#Pre - None
#Param - None
#Post - Constructs an executive object
*/
 executive();
 /**
 #Pre - None
 #Param - None
 #Post - Destructs an executive object
 */
 ~executive();
 /**
 #Pre - None
 #Param - None
 #Post - Launches the program
 */
 void Run();
 /**
 #Pre - Run has been called
 #Param - None
 #Post - Creates a randomized game board.
 */
 void CreateBoard();
 /**
 #Pre - None
 #Param - None
 #Post - Prints the game board, for test purposes.
 */
 void Print();
 /**
 #Pre - CreateBoard has been called
 #Param - None
 #Post - Updates the game board to include locations of tiles adjacent to bombs.
 */
 void UpdateAdjacents();
 /**
 #Pre - CreateBoard has been called
 #Param x - the x coordinate of the tile the user has clicked.
 #Param y - the y coordinate of the tile the user has clicked.
 #Post - Checks the type of tile the user has clicked and runs the corresponding method.
 */
 void Read(int x, int y);
 /**
 #Pre - CreateBoard has been called
 #Param x - the x coordinate of the tile the user has clicked.
 #Param y - the y coordinate of the tile the user has clicked.
 #Post - Reveals the tile clicked by the user to be adjacent. Updates board.txt.
 */
 void AdjacentReveal(int x, int y);
 /**
 #Pre - CreateBoard has been called
 #Param - None
 #Post - Writes to you_lose.txt. The VBA GUI checks for this, and ends the game when it is done.
 */
 void BombReveal();
 /**
 #Pre - CreateBoard has been called
 #Param x - the x coordinate of the tile the user has clicked.
 #Param y - the y coordinate of the tile the user has clicked.
 #Post - If it is within the bounds of the array and the tile is not a bomb, this method will call recReveal(x,y)
 #       for all 8 tiles adjacent to the tile (x,y).
 */
 void NoneReveal(int x, int y);
 /**
 #Pre - CreateBoard has been called
 #Param x - the x coordinate of the tile the user has clicked.
 #Param y - the y coordinate of the tile the user has clicked.
 #Post - Calls NoneReveal for the original clicked tile. Updates board.txt after recursion is complete.
 */
 void NoneRevealMaster(int x, int y);
 /**
 #Pre - CreateBoard has been called
 #Param x - the x coordinate of the tile the user has clicked.
 #Param y - the y coordinate of the tile the user has clicked.
 #Post - Marks each tile for backtracking. Updates the show array before NoneRevealMaster writes the results to board.txt.
 */
 void recReveal(int x, int y);
 /**
 #Pre - CreateBoard has been called
 #Param - None
 #Post = Creates board.txt, fills it with hidden tiles. Creates map.txt; fills it with bomb, adjacent, and none tile locations.
 */
 void StartFilesForVBA();

 /**
 #Pre - CreateBoard has been called and main game loop has started
 #Param - None
 #Post = Creates board.txt, fills it with all tiles shown
 */
 void showCheatBoard();

 /**
 #Pre - CreateBoard has been called
 #Param x - the x coordinate of the tile the user has clicked to flag.
 #Param y - the y coordinate of the tile the user has clicked flag.
 #Post - Flags the tile clicked by the user if it is unrevealed and updates board.txt
 */
 void flag(int x, int y);

};
