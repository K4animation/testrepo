using Xunit;

namespace PierwiastkiTesty
{
    public class PierwiastkiTesty
    {
        [Theory]
        [InlineData(1, -6, 9, 3, Double.NaN)] // Równanie ma jeden pierwiastek podwójny: x = 3
        [InlineData(1, -5, 6, 2, 3)] // Pierwiastki równania to: x1 = 2, x2 = 3
        [InlineData(2, 3, 4, Double.NaN, Double.NaN)] // Równanie nie ma pierwiastków rzeczywistych
        public void ObliczPierwiastki_Test(double a, double b, double c, double prawdziweX1, double prawdziweX2)
        {
            // Act
            var wynik = Pierwiastki.ObliczPierwiastki(a, b, c);

            // Assert
            Assert.Equal(prawdziweX1, wynik.x1);
            Assert.Equal(prawdziweX2, wynik.x2);
        }
    }
}
