using PruebaTestingUsing;
using Xunit;

namespace UniTestingXUnitIntro.Tests
{
    public class MainValidatorShould
    {
        //[Fact]
        //public void ValidateValidEmail() 
        //{
        //    // Arrange
        //    var mailValidator = new MainValidator();
        //    string emailAddress = "mcardonasierra1@gmail.com";

        //    //Act
        //   bool isValid=  mailValidator.IsValidEmail(emailAddress);

        //    //Assert

        //    Assert.True(isValid, $"{emailAddress} is not valid");

        //}

        //[Fact]
        //public void InValidateInvadEmail() 
        //{ 
        //    // Arrange
        //    var mailValidator = new MainValidator();
        //    string emailAddress = "mcardonasierra@gmail.com";

        //    //Act
        //    bool isValid=mailValidator.IsValidEmail(emailAddress);

        //    //Assert
        //    Assert.False(isValid);
        //}
        //[Theory]
        //[InlineData("mcardonasierra@gmail.com",false)]
        //[InlineData("mcardonasierra1@gmail.com",true)]

        //public void ValidateEmail(string emailAddres, bool excepted)
        //{
        //    var mailValidator= new MainValidator();

        //    bool isValid= mailValidator.IsValidEmail(emailAddres);
        //    Assert.Equal(isValid,excepted);
        //}

        // Este método prueba si un número de teléfono es válido
        // Comprueba si el número de teléfono tiene un mínimo de 10 dígitos
        [Theory]
        [InlineData("1234567890", true)]
        [InlineData("123456789", false)]
        public void ValidatePhoneNumber(string phoneNumber, bool expected)
        {
            // Crea una nueva instancia de la clase MainValidator
            var validator = new MainValidator();

            // Llama al método IsValidPhoneNumber y pasa el número de teléfono como parámetro
            bool isValid = validator.IsValidPhoneNumber(phoneNumber);

            // Comprueba si el resultado es el esperado
            Assert.Equal(expected, isValid);
        }
    }
}
