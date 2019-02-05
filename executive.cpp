#include "executive.h"



executive::executive()
{
}


executive::~executive()
{
}

void executive::Run()
{
	int row_size;
	//This GUI will be interacted with "behind the scenes"
	//by a windows forms application.
	std::cout << "------------------------------------\n";
	std::cout << "Terminal GUI\n";
	std::cout << "------------------------------------\n";
	std::cout << "Input game_board size: ";
	std::cin >> row_size;
	system("CLS");
	m_game_board = new square*[row_size];
	for (int i = 0; i < row_size;i++)
	{
		m_game_board[i] = new square[row_size];
	}

}
