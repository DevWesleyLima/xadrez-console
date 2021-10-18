
namespace tabuleiro
{
    class Posicao
    {
        public int Line { get; set; }
        public int Column { get; set; }

        public Posicao()
        {
            Line = 0;
            Column = 0;
        }

        public Posicao(int line, int column)
        {
            Line = line;
            Column = column;
        }

        public override string ToString()
        {

            return Line
                + ", "
                + Column;
        }
    }
}
