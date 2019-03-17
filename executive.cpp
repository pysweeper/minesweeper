#include "executive.h"
#include <cstdlib>
#include <string>

executive::executive()
{
	m_game_board = nullptr;
	gameover=false;
	m_show_board = nullptr;
	m_cheat_board = nullptr;
	cheating = false;
	m_row_size = 10;
	m_col_size = 10;
	m_mine_number = 10;
}


executive::~executive()
{
	if (m_game_board != nullptr)
	{
		for (int i = 0; i < m_row_size; i++)
		{
			delete [] m_game_board[i];
			delete [] m_cheat_board[i];
			delete [] m_show_board[i];
		}
		delete [] m_game_board;
		delete [] m_cheat_board;
		delete [] m_show_board;
		m_game_board = nullptr;
	}
}


void executive::StartFilesForVBA()
{
	std::ofstream outFile;
	outFile.open("board.txt");
	for (int i = 0; i < m_row_size; i++)
	{
		for (int j = 0; j < m_row_size; j++)
		{
			outFile << "H ";
		}
		outFile << "\n";
	}
	outFile.close();
}

void executive::Run()
{
	int x=0, y=0, z=0;
	CreateBoard();
	std::string command = "";
	while(!gameover)
	{
		std:: cout << "enter command: ";
		std:: cin >> command;

		//this is a key that VBA can use to end the C++ application.
		//we felt this was better than allowing the VBA application administrator privileges.
		if (command == "-9999") return;

		//Don't let the resize all command reference memory that doesn't exist
		if (command.length() == 10)
		{
			//should always be true if the gui works right
			if (command[0] == 'r' && command[3] == 'c' && command[6] == 'm')
			{
				x = std::stoi(command.substr(1, 2));
				y = std::stoi(command.substr(4, 2));
				z = std::stoi(command.substr(7, 3));
				m_row_size = x;
				m_col_size = y;
				m_mine_number = z;
				cheating = false;
				CreateBoard();
			}
		}
		else if (command[0] == 'r')
		{
			x = std::stoi(command.substr(1, 2));
			m_row_size = x;
			cheating = false;
			CreateBoard();
		}
		else if (command[0] == 'c')
		{
			y = std::stoi(command.substr(1, 2));
			m_col_size = y;
			cheating = false;
			CreateBoard();
		}
		else if (command[0] == 'm')
		{
			x = std::stoi(command.substr(1, 3));
			m_mine_number = x;
			cheating = false;
			CreateBoard();
		}
		else if (command[0] == 'g')
		{
			if (!cheating)
			{
				x = std::stoi(command.substr(1, 2));
				y = std::stoi(command.substr(4, 2));
				Read(x, y);
			}
		}
		else if (command[0] == 'f')
		{
			if (!cheating)
			{
				x = std::stoi(command.substr(1, 2));
				y = std::stoi(command.substr(4, 2));
				flag(x, y);
			}
		}
		else if (command[0] == 'h')
		{
			showCheatBoard();
		}
		else if (command[0] == 'p')
		{
			if (!cheating)
			{
				if (command[1] == '1')
				{
					power1();
				}
				else if (command[1] == '2')
				{
					power2();
				}
				else if (command[1] == '3')
				{
					power3();
				}
			}
		}

	}

}

void executive::showCheatBoard()
{
	cheating = !cheating;

	std::ofstream outFile;
	outFile.open("board.txt", std::ofstream::out | std::ofstream::trunc);
	outFile.close();
	outFile.open("board.txt");
	for (int i = 0; i < m_row_size; i++)
	{
		for (int j = 0; j < m_col_size; j++)
		{
			if (cheating)
			{
				outFile << m_cheat_board[i][j] << " ";
			}
			else
			{
				outFile << m_show_board[i][j] << " ";
			}
		}
		outFile << "\n";
	}
	outFile.close();

}


void executive::CreateBoard()
{
	srand(time(NULL));
	//This GUI will be interacted with "behind the scenes"
	//by a windows forms application.

	std::ofstream resetFiles;
	resetFiles.open("you_lose.txt", std::ofstream::out | std::ofstream::trunc);
	resetFiles.close();
	resetFiles.open("board.txt", std::ofstream::out | std::ofstream::trunc);
	resetFiles.close();

	if (m_row_size < 2)
	{
		m_row_size = 2;
	}
	if (m_col_size < 2)
	{
		m_col_size = 2;
	}
	if (m_mine_number < 1)
	{
		m_mine_number = 1;
	}
	if (m_mine_number >= m_row_size * m_col_size)
	{
		m_mine_number = m_row_size * m_col_size - 1;
	}

	if (m_game_board != nullptr)
	{
		for (int i = 0; i < m_row_size; i++)
		{
			delete [] m_game_board[i];
			delete [] m_cheat_board[i];
			delete [] m_show_board[i];
		}
		delete [] m_game_board;
		delete [] m_cheat_board;
		delete [] m_show_board;
		m_game_board = nullptr;
	}

	m_game_board = new square*[m_row_size];
	for (int i = 0; i < m_row_size;i++)
	{
		m_game_board[i] = new square[m_col_size];
	}
	//now to randomize mine location
	int result = 0;
	int mines_to_place = m_mine_number;
	while (mines_to_place > 0)
	{
		for (int i = 0; i < m_row_size;i++)
		{
			for (int j = 0; j < m_col_size;j++)
			{
				result = rand() % (m_row_size + m_col_size);
				if (result == MINE && mines_to_place > 0 && m_game_board[i][j].Holding()!=MINE)
				{
					//place a mine
					m_game_board[i][j].Holding(MINE);
					mines_to_place--;
				}
				else if(m_game_board[i][j].Holding() != MINE)
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

	m_show_board = new char*[m_row_size];
	//occupy the show array
	for (int i = 0; i < m_row_size; i++)
	{
		m_show_board[i] = new char[m_col_size];
	}
	for (int i = 0; i < m_row_size; i++)
	{
		for (int j = 0; j < m_col_size; j++)
		{
			m_show_board[i][j] = 'H';
		}
	}

	m_cheat_board = new char*[m_row_size];
	for (int i = 0; i < m_row_size; i++)
	{
		m_cheat_board[i] = new char[m_col_size];
	}
	for (int i = 0; i < m_row_size; i++)
	{
		for (int j = 0; j < m_col_size; j++)
		{
			if (m_game_board[i][j].Holding() == MINE)
			{
				m_cheat_board[i][j] = 'M';
			}
			else if (m_game_board[i][j].Holding() == ADJACENT)
			{
				m_cheat_board[i][j] = std::to_string(m_game_board[i][j].AdjacentMines()).at(0);
			}
			else
			{
				m_cheat_board[i][j] = '-';
			}
		}
	}

	StartFilesForVBA();

}

void executive::UpdateAdjacents()
{
	for (int i = 0; i < m_row_size; i++)
	{
		for (int j = 0; j < m_col_size; j++)
		{

			int counter = 0;
			if (m_game_board[i][j].Holding() == NONE)
			{
				//check up-right
				if (((i + 1) < m_row_size && (j + 1) < m_col_size))
				{
					if (m_game_board[i + 1][j + 1].Holding() == MINE)
					{
						counter++;
					}
				}


				//check right
				if (((i + 1) < m_row_size && (j) < m_col_size))
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
				if (((i)<m_row_size && (j + 1)<m_col_size))
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
				if (((i - 1) >= 0 && (j)<m_col_size))
				{
					if (m_game_board[i - 1][j].Holding() == MINE)
					{
						counter++;
					}
				}

				//check up-left
				if (((i - 1)>=0 && (j + 1)<m_col_size))
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


	}





void executive::Print()
{
	std::cout << "\n\n";
	//print our 2D array
	for (int i = 0; i < m_row_size;i++)
	{
		for (int j = 0; j < m_col_size;j++)
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
		//std::cout << "BOMB";
		BombReveal();
	}
	if (m_game_board[x][y].Holding() == NONE)
	{
		//call recursive reveal function 'NoneReveal'
		NoneRevealMaster(x, y);
	}
	if (m_game_board[x][y].Holding() == ADJACENT)
	{
		AdjacentReveal(x,y);
	}

	//check if game is won
	bool winner = true;
	for(int i = 0; i < m_row_size; i++)
	{
		for(int j = 0; j < m_col_size; j++)
		{
			if (m_show_board[i][j] != m_cheat_board[i][j])
			{
				if(!(m_cheat_board[i][j] == 'M' && (m_show_board[i][j] == 'F' || m_show_board[i][j] == 'H')))
				{
					winner = false;
				}
			}
		}
	}

	if (winner)
	{
		gameWin();
	}

}

void executive::flag(int x, int y)
{
	if (m_show_board[x][y] == 'H')
	{
		m_show_board[x][y] = 'F';
	}
	else if (m_show_board[x][y] == 'F')
	{
		m_show_board[x][y] = 'H';
	}

	m_game_board[x][y].flag();

	//update the text file
	std::ofstream outFile;
	outFile.open("board.txt", std::ofstream::out | std::ofstream::trunc);
	outFile.close();
	outFile.open("board.txt");
	for (int i = 0; i < m_row_size; i++)
	{
		for (int j = 0; j < m_col_size; j++)
		{
			outFile << m_show_board[i][j] << " ";
		}
		outFile << "\n";
	}
	outFile.close();

}

void executive::AdjacentReveal(int x, int y)
{
	m_show_board[x][y] = std::to_string(m_game_board[x][y].AdjacentMines()).at(0);

	//update the text file
	std::ofstream outFile;
	outFile.open("board.txt", std::ofstream::out | std::ofstream::trunc);
	outFile.close();
	outFile.open("board.txt");
	for (int i = 0; i < m_row_size; i++)
	{
		for (int j = 0; j < m_col_size; j++)
		{
			outFile << m_show_board[i][j] << " ";
		}
		outFile << "\n";
	}
	outFile.close();
}

void executive::BombReveal()
{

	std::string newFile = "you_lose.txt";
	std::ofstream outFile;
	outFile.open(newFile);
	outFile << "L\n";
	outFile.close();

	showCheatBoard();

}

void executive::gameWin()
{
	std::string newFile = "you_lose.txt";
	std::ofstream outFile;
	outFile.open(newFile);
	outFile << "W\n";
	outFile.close();
}

void executive::NoneReveal(int x, int y)
{

	if (m_game_board[x][y].Holding() == ADJACENT)
	{
		return;
	}

	//recurse up-right
	if (((x + 1) < m_row_size && (y + 1) < m_col_size))
	{

		recReveal(x + 1, y + 1);
	}
	//recurse right
	if (((x + 1) < m_row_size && (y) < m_col_size))
	{
		recReveal(x + 1, y);
	}
	//recurse down-right
	if ((x + 1) < m_row_size && (y - 1) >= 0)
	{
		recReveal(x + 1, y - 1);
	}
	//recurse up
	if (((x) < m_row_size && (y + 1) < m_col_size))
	{
		recReveal(x, y + 1);
	}
	//recurse down
	if (((x) < m_row_size && (y - 1) >= 0))
	{
		recReveal(x, y - 1);
	}
	//recurse left
	if (((x - 1) >= 0 && (y) < m_col_size))
	{
		recReveal(x-1, y);
	}
	//recurse up-left
	if (((x - 1) >= 0 && (y + 1) < m_col_size))
	{
		recReveal(x - 1, y+1);
	}
	//recurse down-left
	if ((x - 1) >= 0 && (y - 1) >= 0)
	{
		recReveal(x - 1, y - 1);
	}



}

void executive::NoneRevealMaster(int x, int y)
{
	m_show_board[x][y] = '-';
	m_game_board[x][y].CheckedRecursively(true);
	NoneReveal(x, y);
	//update a file;
	std::ofstream outFile;
	outFile.open("board.txt", std::ofstream::out | std::ofstream::trunc);
	outFile.close();
	outFile.open("board.txt");
	for (int i = 0; i < m_row_size; i++)
	{
		for (int j = 0; j < m_col_size; j++)
		{
			outFile << m_show_board[i][j] << " ";
		}
		outFile << "\n";
	}
	//reset the recursive checks.
	for (int i = 0; i < m_row_size; i++)
	{
		for (int j = 0; j < m_col_size; j++)
		{
			m_game_board[i][j].CheckedRecursively(false);
		}
	}
	outFile.close();
}

void executive::recReveal(int x, int y)
{
	if (m_game_board[x][y].CheckedRecursively() == true)
	{
		return;
	}
	if (m_game_board[x][y].Holding() == ADJACENT)
	{
			if (m_show_board[x][y] != 'F')
			{
				m_show_board[x][y] = std::to_string(m_game_board[x][y].AdjacentMines()).at(0);
			}
	}
	else if (m_game_board[x][y].Holding() == NONE)
	{
			m_game_board[x][y].CheckedRecursively(true);
			if (m_show_board[x][y] != 'F')
			{
				m_show_board[x][y] = '-';
				NoneReveal(x, y);
			}

	}
}

void executive::power1()
{
	for(int i = 0; i < m_row_size; i++)
	{
		for(int j = 0; j < m_col_size; j++)
		{
			if (m_game_board[i][j].Holding() == ADJACENT && m_show_board[i][j] == 'H')
			{
				//Adjacent space not alredy revealed found
				Read(i, j);
				return;
			}
		}
	}
}

void executive::power2()
{
	for(int i = 0; i < m_row_size; i++)
	{
		for(int j = 0; j < m_col_size; j++)
		{
			if (m_game_board[i][j].Holding() == NONE && m_show_board[i][j] == 'H')
			{
				//empty space not alredy revealed found
				Read(i, j);
				return;
			}
		}
	}
}

void executive::power3()
{
	for(int i = 0; i < m_row_size; i++)
	{
		for(int j = 0; j < m_col_size; j++)
		{
			if (m_game_board[i][j].Holding() == MINE && m_show_board[i][j] == 'H')
			{
				//mine space not alredy flagged found
				flag(i, j);
				return;
			}
		}
	}
}
