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
