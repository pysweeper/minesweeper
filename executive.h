/*###################################################
#@File: executive.h									#
#@Date: 2/4/2019									#
#@File Description: The executive class manages		#
# interaction between the windows form app and		#
# the game board object.							#
###################################################*/


#pragma once
#include<iostream>
#include<string>

#include "square.h"
class executive
{
private:
	square** m_game_board;
protected:

public:
	executive();
	~executive();
	void Run();

};

