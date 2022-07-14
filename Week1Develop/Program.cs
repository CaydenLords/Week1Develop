using System;
using System.Collections.Generic;
namespace Unit1Develop{
    class Program{
        static void Main(string[] args){
            List<string> gameBoard = GetNewBoard();
            int turnCount = 0;
            string currentPlayer = "o";
            while (!CheckGameOver(gameBoard, turnCount, currentPlayer)){
                if (currentPlayer == "x"){
                    currentPlayer = "o";
                } else {
                    currentPlayer = "x";
                }
                PrintBoard(gameBoard);
                Console.Write("Next Choice: ");
                int move = int.Parse(Console.ReadLine());
                EditBoard(gameBoard, move, currentPlayer);
                turnCount += 1;   
            }
            PrintBoard(gameBoard);
            Console.WriteLine("Thanks for playing!");
        }
        static public bool CheckGameOver(List<string> board, int count, string player){
            
            if((board[0] == player && board[1] == player && board[2] == player)
                || (board[3] == player && board[4] == player && board[5] == player)
                || (board[6] == player && board[7] == player && board[8] == player)
                || (board[0] == player && board[3] == player && board[6] == player)
                || (board[1] == player && board[4] == player && board[7] == player)
                || (board[2] == player && board[5] == player && board[8] == player)
                || (board[0] == player && board[4] == player && board[8] == player)
                || (board[2] == player && board[4] == player && board[6] == player)
                ){
                    return true;
                }
            else if (count == 9){
                return true;
            }
            else{
                return false;
            }
        }
        static public void PrintBoard(List<string> board){
            Console.WriteLine(board[0] + "|" + board[1] + "|" + board[2]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(board[3] + "|" + board[4] + "|" + board[5]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(board[6] + "|" + board[7] + "|" + board[8]);
        }
        static public void EditBoard(List<string> board, int move, string player){
            int index = move-1;
            board[index] = player;
        }
        static public List<string> GetNewBoard()
        {
            List<string> board = new List<string>();

            for (int i = 1; i <= 9; i++)
            {
                board.Add(i.ToString());
            }

            return board;
        }
    }
}