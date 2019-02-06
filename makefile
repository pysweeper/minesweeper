minesweeper: main.o executive.o square.o
	g++ -std=c++11 -g -Wall main.o executive.o square.o -o minesweeper
main.o: main.cpp executive.cpp square.cpp
	g++ -std=c++11 -g -Wall -c main.cpp
executive.o: executive.h executive.cpp
	g++ -std=c++11 -g -Wall -c executive.cpp
square.o: square.h square.cpp
	g++ -std=c++11 -g -Wall -c square.cpp
clean:
	rm *.o minesweeper
