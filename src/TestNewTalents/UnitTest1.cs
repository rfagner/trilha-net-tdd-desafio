using NewTalents.models;
namespace TestNewTalents;

public class UnitTest1
{
    public Calculadora ConstruirClasse()
    {
        string data = DateTime.Now.ToString("aaaa-MM-dd");
        Calculadora calc = new Calculadora(data);
        return calc;
    }

    [Theory]
    [InlineData(1,2,3)]
    [InlineData(5, 5, 10)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultadoCalculadora = calc.Somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultadoCalculadora = calc.Multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(10, 2, 8)]
    [InlineData(40, 5, 35)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultadoCalculadora = calc.Subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(40, 5, 8)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = ConstruirClasse();

        int resultadoCalculadora = calc.Dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TesteDivisaoPorZero()
    {
        Calculadora calc = ConstruirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(3,0)
        );
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = ConstruirClasse();
        calc.Somar(1, 2);
        calc.Subtrair(5, 2);
        calc.Multiplicar(3, 6);
        calc.Dividir(8, 4);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}