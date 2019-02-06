#pragma once

enum SquareType{MINE,ADJACENT,NONE};
class square
{
private:
	int m_holding;
	int m_adjacent_mines;
protected:

public:
	square();
	~square();
	void Holding(int new_holding);
	int Holding();
<<<<<<< HEAD
=======
	void AdjacentMines(int new_mines);
	int AdjacentMines();
};
>>>>>>> dcf8ab7b145b039f7a02b562a259f57fcee6d77f

};
