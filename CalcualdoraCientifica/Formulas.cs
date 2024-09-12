using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalcualdoraCientifica
{
    public static class Formulas
    {
        //INICIO - CONTAS BÁSICAS
        public static int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Dividir(int n1, int n2)
        {
            if (n2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por 0.");
            }

            return n1 / n2;
        }
        public static int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }
        //FIM - CONTAS BÁSICAS


    }
}
