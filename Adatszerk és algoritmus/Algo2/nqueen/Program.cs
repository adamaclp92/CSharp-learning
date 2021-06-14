using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nqueen
{

    class Program
    {
        static int N;
        static bool boardSolver(int[,] board, int col)
        {
            if (col >= N) 
                return true;
            for (int i = 0; i < N; i++)
            {
                if (toPlaceOrNotToPlace(board, i, col))
                {
                    board[i, col] = 1;
                    if (boardSolver(board, col + 1))
                        return true;
                    board[i, col] = 0;
                }
            }
            return false;
        }

        static bool toPlaceOrNotToPlace(int[,] board, int row, int col)
        {
            int i, j;

            for (i = 0; i < col; i++)
            {
                if (board[row, i] == 1)
                    return false;
            }

            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1)
                    return false;
            }

            for (i = row, j = col; j >= 0 && i < N; i++, j--)
            {
                if (board[i, j] == 1)
                    return false;
            }
            return true;
        }

        static void printBoard(int[,] board)
        {
            int i;
            for (i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(board[i,j] == 1)
                        Console.Write("Q\t");
                    else
                        Console.Write("_\t");


                }
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Add meg a királynők számát:");
            N = int.Parse(Console.ReadLine());

            int[,] board = new int[N,N];

            if (!boardSolver(board, 0))
                Console.WriteLine("Nincs eredmény!");
            else
                printBoard(board);

            Console.ReadLine();
            
        }
    }
}
