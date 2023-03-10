namespace Snake
{
    public class Direction
    {
        // Direzioni
        public readonly static Direction Left = new Direction(0, -1);
        public readonly static Direction Right = new Direction(0, 1);
        public readonly static Direction Up = new Direction(-1, 0);
        public readonly static Direction Down = new Direction(1, 0);
        
        public int RowOffset { get; }
        public int ColOffset { get; }


        // costruttore privato per cui non ci saranno instanziazioni da altre classi

        private Direction(int rowOffset, int colOffset)
        {
            RowOffset = rowOffset;
            ColOffset = colOffset;
        }
    }
}
