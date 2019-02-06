#include "square.h"



square::square()
{
}


square::~square()
{
}

void square::Holding(int new_holding)
{
	m_holding = new_holding;
}

int square::Holding()
{
	return m_holding;
}

void square::AdjacentMines(int new_mines)
{
	m_adjacent_mines = new_mines;
}

int square::AdjacentMines()
{
	return m_adjacent_mines;
}
