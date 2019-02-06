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
#include <fstream>
#include "square.h"
class executive
{
private:
 square** m_game_board;
 int m_row_size;
 int m_mine_number;
 fstream adjacentCoordinates;
protected:

public:
 executive();
 ~executive();
 void Run();
 void CreateBoard();
 void Print();
 void UpdateAdjacents();
 void NotAdjacent(int row, int col);
 void NotAdjacentHelper(int row, int col);

};
