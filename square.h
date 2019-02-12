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
	square();
	~square();
	void Holding(int new_holding);
	int Holding();
	void CheckedRecursively(bool status);
	bool CheckedRecursively();
	void AdjacentMines(int new_mines);
	int AdjacentMines();
};



