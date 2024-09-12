namespace CalculadoraTests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(50, CalcualdoraCientifica.Formulas.Somar(25, 25));
        }
        [Fact]
        public void Subtrair()
        {
            Assert.Equal(75, CalcualdoraCientifica.Formulas.Subtrair(200, 125));
        }
        [Fact]
        public void Dividir()
        {
            Assert.Equal(27, CalcualdoraCientifica.Formulas.Dividir(81, 3));
        }
        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(552, CalcualdoraCientifica.Formulas.Multiplicar(69, 8));
        }
    }
}