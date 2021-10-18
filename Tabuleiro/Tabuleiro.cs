
namespace tabuleiro
{
    class Tabuleiro
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        public Peca[,] Pecas;

        public Tabuleiro()
        {
            Lines = 0;
            Columns = 0;
        }


        public Tabuleiro(int lines, int columns)
        {
            this.Lines = lines;
            this.Columns = columns;
            Pecas = new Peca[lines, columns];
        }

        public override string ToString()
        {

            return Lines
                + ", "
                + Columns;
        }
    }
}
