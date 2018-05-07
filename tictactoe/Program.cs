using System;

namespace tictactoe
{
    class Program
    {
        static string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static bool gameOver = false;
        static int turn = 1;

        static void reset()
        {
            Console.WriteLine("New Game");
            pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            gameOver = false;
            turn = 1;
        }

        static void draw()
        {
            Console.WriteLine($"{pos[0]} | {pos[1]} | {pos[2]}");
            Console.WriteLine($"{pos[3]} | {pos[4]} | {pos[5]}");
            Console.WriteLine($"{pos[6]} | {pos[7]} | {pos[8]}");

        }

        static bool checkWin()
        {
            if (
                 (pos[0] == pos[1] && pos[1] == pos[2]) ||
                 (pos[3] == pos[4] && pos[4] == pos[5]) ||
                 (pos[6] == pos[7] && pos[7] == pos[8]) ||
                 (pos[0] == pos[4] && pos[4] == pos[8]) ||
                 (pos[2] == pos[4] && pos[4] == pos[6]) ||
                 (pos[1] == pos[4] && pos[4] == pos[7]) ||
                 (pos[0] == pos[3] && pos[3] == pos[6]) ||
                 (pos[1] == pos[4] && pos[4] == pos[7]) ||
                 (pos[2] == pos[5] && pos[5] == pos[8])
                )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static bool checkOccupied(int position)
        {
            if (pos[position] == "O" || pos[position] == "X")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void Main(string[] args)
        {
            while (gameOver == false)
            {
                Console.WriteLine($"Player {turn}'s turn");
                draw();
                int input = Int32.Parse(Console.ReadLine());

                if (checkOccupied(input))
                {
                    Console.WriteLine("Pick another number");
                    continue;
                }

                if (turn == 1)
                {
                    pos[input] = "O";
                    if (checkWin())
                    {
                        gameOver = true;
                        Console.WriteLine("Player 1 Wins");
                        reset();
                        continue;
                    }
                    turn = 2;
                }
                else if (turn == 2)
                {
                    pos[input] = "X";
                    if (checkWin())
                    {
                        gameOver = true;
                        Console.WriteLine("Player 2 Wins");
                        reset();
                        continue;
                    }
                    turn = 1;
                }


            }
            
        }
        
    }
}
