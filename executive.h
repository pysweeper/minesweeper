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
// #include<experimental/filesystem>

#include "square.h"
class executive
{
private:
 square** m_game_board;
 char** m_show_board;
 int m_row_size;
 int m_mine_number;
 bool gameover;
protected:

public:
 executive();
 ~executive();
 void Run();
 void CreateBoard();
 void Print();
 void UpdateAdjacents();
 void Read(int x, int y);
 void AdjacentReveal(int x, int y);
 void BombReveal();

 void NoneReveal(int x, int y);
 void NoneRevealMaster(int x, int y);
 void recReveal(int x, int y);
 void StartFilesForVBA();

};
