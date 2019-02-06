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
#include<direct.h>

#include "square.h"
class executive
{
private:
 square** m_game_board;
 int m_row_size;
 int m_mine_number;
protected:

public:
<<<<<<< HEAD
 executive();
 ~executive();
 void Run();
 void CreateBoard();
 void Print();
=======
	executive();
	~executive();
	void Run();
	void CreateBoard();
	void UpdateAdjacents();
	void Print();
	void CreateFile();
>>>>>>> dcf8ab7b145b039f7a02b562a259f57fcee6d77f
};
