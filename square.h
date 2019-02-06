#pragma once

enum SquareType{MINE,ADJACENT,NONE};
class square
{
private:
	int m_holding;
protected:

public:
	square();
	~square();
	void Holding(int new_holding);
	int Holding();
	
};

