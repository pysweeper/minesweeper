#include "square.h"



square::square()
{
	m_holding = NONE;
	m_checked_recursively = false;
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

void square::CheckedRecursively(bool status)
{
	m_checked_recursively = status;
}

bool square::CheckedRecursively()
{
	return m_checked_recursively;
}

void square::AdjacentMines(int new_mines)
{
	m_adjacent_mines = new_mines;
}

int square::AdjacentMines()
{
	return m_adjacent_mines;
}
