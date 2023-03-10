using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class GameState
    {
        public int Rows { get; } // numero di righe e di colonne nella griglia
        public int Col { get; }
        public GridValue[,] Grid { get; } // griglia
        public Direction Dir { get; private set; } //direzione
        public int Score {get; private set; } //punteggio
        public bool GameOver { get; private set; } //game over
        
        private readonly LinkedList<Position> snakePositions = new LinkedList<Position>(); //posizione occupata dalsnake
        private readonly Random random = new Random(); // casuale per far apparire il cibo

        public GameState(int rows, int col)
        {
            Rows = rows;
            Col = col;
            Grid = new GridValue[rows, col];
            Dir = Direction.Right;
        }
    }
}
