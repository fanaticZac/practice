using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0
{
    class PlayArea
    {
        internal string[,] gameBoard;

        public static string grid = @"{0} {1} {2} {3} {4}
{5} {6} {7} {8} {9}
{10} {11} {12} {13} {14}
{15} {16} {17} {18} {19}
{20} {21} {22} {23} {24}";
        
        /// <summary>
        /// default constructor for games play area builds the gameBoard using '.'
        /// </summary>
        public PlayArea()
        {
            gameBoard = new string[5,5];
            BuildGameBoard();
        }

        /// <summary>
        /// Used to create populate the gameBoard
        /// </summary>
        internal void BuildGameBoard()
        {
            for (int rows = 0; rows < 5; rows++)
            {
                for (int columns = 0; columns < 5; columns++)
                {
                    gameBoard[rows, columns] = ".";
                }
            }
        }

        /// <summary>
        /// Used to display gameBoard
        /// </summary>
        /// <returns>the game board</returns>
        internal string DisplayGameBoard()
        {

            return string.Format(grid
                                   , gameBoard[0,0], gameBoard[0,1], gameBoard[0,2], gameBoard[0,3], gameBoard[0,4]
                                   , gameBoard[1,0], gameBoard[1,1], gameBoard[1,2], gameBoard[1,3], gameBoard[1,4]
                                   , gameBoard[2, 0], gameBoard[1, 1], gameBoard[1, 2], gameBoard[1, 3], gameBoard[1, 4]
                                   , gameBoard[3, 0], gameBoard[1, 1], gameBoard[1, 2], gameBoard[1, 3], gameBoard[1, 4]
                                   , gameBoard[4, 0], gameBoard[1, 1], gameBoard[1, 2], gameBoard[1, 3], gameBoard[1, 4]);
        }


    }
}
