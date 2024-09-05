namespace CalculadoraTests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(4, CalcualdoraCientifica.Formulas.Somar(2, 2));
        }
        [Fact]
        public void Subtrair()
        {
            Assert.Equal(0, CalcualdoraCientifica.Formulas.Subtrair(2, 2));
        }
        [Fact]
        public void Dividir()
        {
            Assert.Equal(1, CalcualdoraCientifica.Formulas.Dividir(2, 2));
        }
        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(4, CalcualdoraCientifica.Formulas.Multiplicar(2, 2));
        }
    }
}