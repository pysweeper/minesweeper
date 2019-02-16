/*##################################################
-#@File: square.h                                  #
-#@Date: 2/4/2019                                  #
-#@File Description: The square class is used      #
-# to identify a tile's type: MINE or ADJACENT     #
-# or NONE. Squares occupy a game board in the     #
-# executive class.                                #
-###################################################*/


#pragma once

enum SquareType{MINE,ADJACENT,NONE};
class square
{
private:
	int m_holding;
	int m_adjacent_mines;
	bool m_checked_recursively;
protected:

public:
	/*
	#Pre - None
	#Param - None
	#Post - Constructs a square object.
	*/
	square();
	/*
	#Pre - None
	#Param - None
	#Post - Destructs a square object.
	*/
	~square();
	/*
	#Pre - None
	#Param new_holding - The ID to set the new holding for the square. Please see SquareType enum.
	#Post - Sets the square's holding to new_holding.
	*/
	void Holding(int new_holding);
	/*
	#Pre - None
	#Param - None
	#Post - Returns the square's current holding.
	*/
	int Holding();
	/*
	#Pre - None
	#Param - status
	#Post - sets m_checked_recursively to status. (For backtracking).
	*/
	void CheckedRecursively(bool status);
	/*
	#Pre - None
	#Param - None
	#Post - returns m_checked_recursively.
	*/
	bool CheckedRecursively();
	/*
	#Pre - None
	#Param new_mines - the new number of mines adjacent to the square.
	#Post - Sets m_adjacent_mines.
	*/
	void AdjacentMines(int new_mines);
	/*
	#Pre - None
	#Param - None
	#Post - returns m_adjacent_mines
	*/
	int AdjacentMines();
};



