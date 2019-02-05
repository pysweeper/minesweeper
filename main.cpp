/*###################################################
#@File: main.cpp									#
#@Date: 2/4/2019									#
#@File Description: Program Start					#
#@Program Description: This C++ program is to be	#
# used as a backend to link to a windows forms		#
# minesweeper app. The board will be represented	#
# as a 2D array that users interact with via		#
# right and left clicks in a windows form.			#
###################################################*/

#include<iostream>

#include"executive.h"

int main()
{
	executive* exec = new executive();
	exec->Run();


	return(0);
}