using System;
using SolidGoldApp.BusinessLogic;
using Xunit;

namespace SolidGoldApp.Test
{
    public class PasswordValidationTest
    {
        PasswordValidation validationLibrary;
        string goodPassword = "P@ssw0rd";        

        public PasswordValidationTest()
        {
            validationLibrary = new PasswordValidation();
        }

        [Fact]
        public void Meets_Minimum_Length_Test()
        {
            var result = validationLibrary.IsValid(goodPassword, goodPassword);
            Assert.True(result);
        }

        [Fact]
        public void Meets_Maximum_Length_Test()
        {
            var result = validationLibrary.IsValid(goodPassword, goodPassword);
            Assert.True(result);
        }

        [Fact]
        public void Meets_Capital_Letter_Test()
        {
            var result = validationLibrary.IsValid(goodPassword, goodPassword);
            Assert.True(result);
        }

        [Fact]
        public void Meets_Lowercase_Letter_Test()
        {
            var result = validationLibrary.IsValid(goodPassword, goodPassword);
            Assert.True(result);
        }

        [Fact]
        public void Meets_Special_Character_Test()
        {
            var result = validationLibrary.IsValid(goodPassword, goodPassword);
            Assert.True(result);
        }

        [Fact]
        public void Meets_Number_Test()
        {
            var result = validationLibrary.IsValid(goodPassword, goodPassword);
            Assert.True(result);
        }

        [Fact]
        public void Meets_Matching_Password_Test()
        {
            var result = validationLibrary.IsValid(goodPassword, goodPassword);
            Assert.True(result);
        }

        [Fact]
        public void Fails_Minimum_Length_Test()
        {
            var shortPassword = "$h0rt";
            var result = validationLibrary.IsValid(shortPassword, shortPassword);
            Assert.False(result);
        }

        [Fact]
        public void Fails_Maximum_Length_Test()
        {
            var longPassword = "ThisP@ssw0rdIsTooLong";
            var result = validationLibrary.IsValid(longPassword, longPassword);
            Assert.False(result);
        }

        [Fact]
        public void Fails_Capital_Letter_Test()
        {
            var missingCapitalPassword = "m1ssing_c@pital";
            var result = validationLibrary.IsValid(missingCapitalPassword, missingCapitalPassword);
            Assert.False(result);
        }

        [Fact]
        public void Fails_Lowercase_Letter_Test()
        {
            var missingLowercasePassword = "M1$$ING_L0WER";
            var result = validationLibrary.IsValid(missingLowercasePassword, missingLowercasePassword);
            Assert.False(result);
        }

        [Fact]
        public void Fails_Special_Character_Test()
        {
            var missingSpecialCharPassword = "Sp3cialChar";
            var result = validationLibrary.IsValid(missingSpecialCharPassword, missingSpecialCharPassword);
            Assert.False(result);
        }

        [Fact]
        public void Fails_Number_Test()
        {
            var missingNumberPassword = "NoNumber$";
            var result = validationLibrary.IsValid(missingNumberPassword, missingNumberPassword);
            Assert.False(result);
        }

        [Fact]
        public void Fails_Matching_Password_Test()
        {
            var nonMatchingPassword = "Pa$$w0rd";
            var result = validationLibrary.IsValid(goodPassword, nonMatchingPassword);
            Assert.False(result);
        }
    }
}
