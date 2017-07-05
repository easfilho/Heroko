namespace Heroko.Models
{
    public class Calculadora
    {
        private int Numero1;
        private int Numero2;

        public Calculadora(int Numero1, int Numero2)
        {
            this.Numero1 = Numero1;
            this.Numero2 = Numero2;
        }

        public int Somar()
        {
            return Numero1 + Numero2;
        }

    }
}