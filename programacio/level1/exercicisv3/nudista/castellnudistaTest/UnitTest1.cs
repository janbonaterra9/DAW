namespace castellnudista;

public class UnitTest1
{
    [Fact]
    public void ComprovaQueSiNoTeProuEdatNoEntra()
    {

        // Preparar

        var edat = 12;
        var edatminima = 18;
        var espero = "Ho sento cavaller, no pots entrar al castell.";

        // Act

        var resultat = Program.ComprovaEdat(edat, edatminima);

        // Assert

        Assert.Equal(espero, resultat);

    }

    [Theory]
    [InlineData(12, 18, "Ho sento cavaller, no pots entrar al castell.")]
    [InlineData(17, 18, "Ho sento cavaller, no pots entrar al castell.")]
    [InlineData(18, 18, "Endavant cavaller! Ja pots entrar al castell.")]

    public void ComprovaSiDeixaEntrarALaGent(int edat, int edatminima, string espero)
    {
        // Arrange

        // Act
        var resultat = Program.ComprovaEdat(edat, edatminima);

        // Assert

        Assert.Equal(espero, resultat);
    }

}
