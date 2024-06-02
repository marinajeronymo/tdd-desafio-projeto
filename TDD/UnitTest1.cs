using TDD.models;

namespace TDD;

public class UnitTest1
{
    public Calculadora construirClasse()
    {
        string data = "02/06/2024";
        Calculadora calculadora= new Calculadora("02/06/2024");
        return calculadora;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]

    public void Test1(int val1, int val2, int resultado)
    {
        Calculadora calculadora= construirClasse();

        int resultadoCalculadora = calculadora.Somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]

    public void Test2(int val1, int val2, int resultado)
    {
        Calculadora calculadora= construirClasse();

        int resultadoCalculadora = calculadora.Multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]

    public void Test3(int val1, int val2, int resultado)
    {
        Calculadora calculadora= construirClasse();

        int resultadoCalculadora = calculadora.Dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

     [Theory]
    [InlineData(6, 2, 4)]
    [InlineData(5, 5, 0)]

    public void Test4(int val1, int val2, int resultado)
    {
        Calculadora calculadora= construirClasse();

        int resultadoCalculadora = calculadora.Subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
         Calculadora calculadora= construirClasse();
         
         Assert.Throws<DivideByZeroException>(
            () => calculadora.Dividir(3,0)
            );
    }

    [Fact]
    public void TestarHistorico()
    {
         Calculadora calculadora= construirClasse();
         calculadora.Somar(1,2);
         calculadora.Somar(5,2);
         calculadora.Somar(10,3);
         calculadora.Somar(8,2);

        var lista = calculadora.historico();
        
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);

    }







    
}