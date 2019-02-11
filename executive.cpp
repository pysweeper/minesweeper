#include "executive.h"


executive::executive()
{
	m_game_board = nullptr;
	gameover=false;
}


executive::~executive()
{
}




void executive::Run()
{
	int x=0, y=0;
	CreateBoard();
	while(!gameover)
	{
		std:: cout << "Where would you like to check?\n" << "Please enter row you would like to check: ";
		std:: cin >> x;
		std:: cout << "\n Please enter column you would ike to check: ";
		std:: cin >> y;
		Read(x,y);
	}

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
	UpdateAdjacents();
}

void executive::UpdateAdjacents()
{
	for (int i = 0; i < m_row_size; i++)
	{
		for (int j = 0; j < m_row_size; j++)
		{

			int counter = 0;
			if (m_game_board[i][j].Holding() == NONE)
			{
				//check up-right
				if (((i + 1) < m_row_size && (j + 1) < m_row_size))
				{
					if (m_game_board[i + 1][j + 1].Holding() == MINE)
					{
						counter++;
					}
				}


				//check right
				if (((i + 1) < m_row_size && (j) < m_row_size))
				{
					if (m_game_board[i + 1][j].Holding() == MINE)
					{
						counter++;
					}
				}

				//check down-right
				if ((i + 1) < m_row_size && (j - 1) >=0)
				{
					if (m_game_board[i + 1][j - 1].Holding() == MINE)
					{
						counter++;
					}
				}

				//check up
				if (((i)<m_row_size && (j + 1)<m_row_size))
				{
					if (m_game_board[i][j + 1].Holding() == MINE)
					{
						counter++;
					}
				}

				//check down
				if (((i)<m_row_size && (j - 1)>=0))
				{
					if (m_game_board[i][j - 1].Holding() == MINE)
					{
						counter++;
					}
				}

				//check left
				if (((i - 1) >= 0 && (j)<m_row_size))
				{
					if (m_game_board[i - 1][j].Holding() == MINE)
					{
						counter++;
					}
				}

				//check up-left
				if (((i - 1)>=0 && (j + 1)<m_row_size))
				{
					if (m_game_board[i - 1][j + 1].Holding() == MINE)
					{
						counter++;
					}
				}

				//check down-left
				if ((i - 1)>=0 && (j - 1)>=0)
				{
					if (m_game_board[i - 1][j - 1].Holding() == MINE)
					{
						counter++;
					}
				}

				//update the adjacency number
				m_game_board[i][j].AdjacentMines(counter);
				if (counter > 0)
				{
					m_game_board[i][j].Holding(ADJACENT);
				}
			}
		}

		}

	//for testing purposes
	Print();
	//while (1)
	//{

	//}

	}

	bool executive::BoB(int col, int row)
	{
		if ((((col+1) < m_row_size) && ((row +1) < m_row_size)) && (((col-1) >= 0) && ((row+1) < m_row_size)) && (((col-1) >=0) && ((row-1) >=0)) && (((col+1) < m_row_size) && ((row -1) >=0))) {
			return(true);
		}
		else
		{
			return(false);
		}
	}
	void executive::NotAdjacent(int col, int row)
	{
		NotAdjacentHelper(col, row);
	}

	void executive::NotAdjacentHelper(int col, int row)
	{
		//checks if current square is blank
		if (!(m_game_board[col][row].Holding() == ADJACENT))
		{
			if (BoB(col, row) == true) {
				NotAdjacentHelper(col+1, row+1);
				NotAdjacentHelper(col+1, row);
				NotAdjacentHelper(col+1, row-1);
				NotAdjacentHelper(col, row-1);
				NotAdjacentHelper(col-1, row-1);
				NotAdjacentHelper(col-1, row);
				NotAdjacentHelper(col-1, row+1);
			}
			else
			{
				//blank else to force backtracking
			}

		}
		else
		{
			//stops recursion
		}
	}

void executive::Print()
{
	std::cout << "\n\n";
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


//Used to read in coordinate values and decide which button path to choose.
void executive::Read(int x, int y)
{
	if (m_game_board[x][y].Holding() == MINE)
	{
		BombReveal();
	}
	if (m_game_board[x][y].Holding() == NONE)
	{
		//call recursive reveal function 'NoneReveal'
	}
	if (m_game_board[x][y].Holding() == ADJACENT)
	{
		AdjacentReveal(x,y);
	}
}

void executive::AdjacentReveal(int x, int y)
{
	//edit text file coordinate location and change value from hidden to corresponding adjacent value
}

void executive::BombReveal()
{
	gameover=true;
	std::string newFile = "you_lose.txt";
	std::ofstream outFile;
	outFile.open(newFile);
	outFile << "You suck!\n";
	outFile.close();
}

void executive::NoneReveal()
{
	//Find coordinate within the array
	//Call recRevea
}

void executive::recReveal()
{
	//Recursively reveal all the nearby 'none' and 'adjacent' values
}
