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

#include "square.h"
class executive
{
private:
 square** m_game_board;
 int m_row_size;
 int m_mine_number;
protected:

public:
 executive();
 ~executive();
 void Run();
 square** CreateBoard();
 void Print();
 void UpdateAdjacents();
 bool check_bomb(int x, int y, square** arr);
 void you_lose();
};
