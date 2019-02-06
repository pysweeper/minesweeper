#include "executive.h"



executive::executive()
{
}


executive::~executive()
{
}

void executive::Run()
{
	CreateBoard();
	

}

void executive::CreateBoard()
{
	srand(3);
	//This GUI will be interacted with "behind the scenes"
	//by a windows forms application.
	std::cout << "------------------------------------\n";
	std::cout << "Terminal GUI\n";
	std::cout << "------------------------------------\n";
	std::cout << "Input m_game_board size: ";
	std::cin >> m_row_size;
	std::cout << "Input m_mine_number: ";
	std::cin >> m_mine_number;
	system("CLS");
	m_game_board = new square*[m_row_size];
	for (int i = 0; i < m_row_size;i++)
	{
		m_game_board[i] = new square[m_row_size];
	}
	//now to randomize mine location
	while (m_mine_number > 0)
	{
		for (int i = 0; i < m_row_size;i++)
		{
			for (int j = 0; j < m_row_size;j++)
			{
				int result = rand() % 3;
				if (result == MINE && m_mine_number > 0 && m_game_board[i][j].Holding()!=MINE)
				{
					//place a mine
					m_game_board[i][j].Holding(MINE);
					m_mine_number--;
				}
				else
				{
					//make a blank
					m_game_board[i][j].Holding(NONE);
				}
			}//end of j for
		}//end of i for
		
	}

	//for testing purposes.
	Print();
	
}

void executive::Print()
{
	//print our 2D array
	for (int i = 0; i < m_row_size;i++)
	{
		for (int j = 0; j < m_row_size;j++)
		{
			std::cout << m_game_board[i][j].Holding() << " ";
		}
		std::cout << "\n";
	}
}
