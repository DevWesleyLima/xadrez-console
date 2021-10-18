
namespace tabuleiro
{
    class Peca
    {
        public Posicao Position { get; set; }
        public Cor Colour { get; protected set; }
        public int MovQuantity { get; protected set; }
        public Tabuleiro Chessboard { get; set; }

        public Peca()
        {
            Colour = 0;
            MovQuantity = 0;
            
        }

        public Peca(Posicao position, Cor colour, Tabuleiro chessboard)
        {
            this.Position = position;
            this.Colour = colour;
            this.MovQuantity = 0;
            Chessboard = chessboard;
        }
    }
}
