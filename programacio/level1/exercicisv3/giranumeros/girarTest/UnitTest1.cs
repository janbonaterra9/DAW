namespace gira;

public class UnitTest1
{
    [Theory]
    [InlineData("123", "123,231,312")]
    [InlineData("1", "1")]
    [InlineData("11", "11")]
    [InlineData("1111111", "1111111")]
    public void comprovaQueElResultatEsCorrecte(string numero, string esperat)
    {
        // Arrange

        // Act
        var resultat = Program.GirarNumero(numero);

        // Assert
        Assert.Equal(esperat, resultat);

    }


    [Theory]
    [InlineData("321", "213")]
    [InlineData("12", "21")]
    public void comprovaQueGiraLesXifresBe(string numero, string espero)
    {
        // Arrange

        // Act
        var resultat = Program.giraLaXifra(numero);
        Assert.Equal(espero, resultat);
    }
}