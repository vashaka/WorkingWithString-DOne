using NUnit.Framework;

// ReSharper disable StringLiteralTypo
namespace WorkingWithStrings.Tests
{
    [TestFixture]
    public sealed class UsingRangesTests
    {
        [TestCase("", ExpectedResult = "")]
        [TestCase("abcdefghijk", ExpectedResult = "abcdefghijk")]
        public string GetStringWithAllChars_StrIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingRanges.GetStringWithAllChars(str);
        }

        [TestCase("abcdefghijk", ExpectedResult = "bcdefghijk")]
        public string GetStringWithoutFirstChar_StrIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingRanges.GetStringWithoutFirstChar(str);
        }

        [TestCase("abcdefghijk", ExpectedResult = "cdefghijk")]
        public string GetStringWithoutTwoFirstChars_StrIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingRanges.GetStringWithoutTwoFirstChars(str);
        }

        [TestCase("abcdefghijk", ExpectedResult = "defghijk")]
        public string GetStringWithoutThreeFirstChars_StrIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingRanges.GetStringWithoutThreeFirstChars(str);
        }

        [TestCase("abcdefghijk", ExpectedResult = "abcdefghij")]
        public string GetStringWithoutLastChar_StrIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingRanges.GetStringWithoutLastChar(str);
        }

        [TestCase("abcdefghijk", ExpectedResult = "abcdefghi")]
        public string GetStringWithoutTwoLastChars_StrIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingRanges.GetStringWithoutTwoLastChars(str);
        }

        [TestCase("abcdefghijk", ExpectedResult = "abcdefgh")]
        public string GetStringWithoutThreeLastChars_StrIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingRanges.GetStringWithoutThreeLastChars(str);
        }

        [TestCase("abcdefghijk", ExpectedResult = "bcdefghij")]
        public string GetStringWithoutFirstAndLastChars_StrIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingRanges.GetStringWithoutFirstAndLastChars(str);
        }

        [TestCase("abcdefghijk", ExpectedResult = "cdefghi")]
        public string GetStringWithoutTwoFirstAndTwoLastChars_StrIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingRanges.GetStringWithoutTwoFirstAndTwoLastChars(str);
        }

        [TestCase("abcdefghijk", ExpectedResult = "defgh")]
        public string GetStringWithoutThreeFirstAndThreeLastChars_StrIsValid_ReturnsResult(string str)
        {
            // Act
            return UsingRanges.GetStringWithoutThreeFirstAndThreeLastChars(str);
        }

        [TestCase("9M431Z0DDQLL75Q2", "9", "M4", "31Z", "0DDQLL75Q2")]
        [TestCase("1912784DKF007384", "1", "91", "278", "4DKF007384")]
        public void GetProductionCodeDetails_ParametersAreValid_ReturnsResult(string productionCode, string expectedRegionCode, string expectedLocationCode, string expectedDateCode, string expectedFactoryCode)
        {
            // Act
            UsingRanges.GetProductionCodeDetails(productionCode, out string regionCode, out string locationCode, out string dateCode, out string factoryCode);

            // Assert
            Assert.AreEqual(expectedRegionCode, regionCode);
            Assert.AreEqual(expectedLocationCode, locationCode);
            Assert.AreEqual(expectedDateCode, dateCode);
            Assert.AreEqual(expectedFactoryCode, factoryCode);
        }

        [TestCase("P2W12P1937A", "2", "W1", "2P19", "37A")]
        [TestCase("P02K13P8732D", "0", "2K", "13P8", "732D")]
        [TestCase("P002Z14P3573B", "0", "02", "Z14P", "3573B")]
        public void GetSerialNumberDetails(string serialNumber, string expectedCountryCode, string expectedManufacturerCode, string expectedFactoryCode, string expectedStationCode)
        {
            // Act
            UsingRanges.GetSerialNumberDetails(serialNumber, out string countryCode, out string manufacturerCode, out string factoryCode, out string stationCode);

            // Assert
            Assert.AreEqual(expectedCountryCode, countryCode);
            Assert.AreEqual(expectedManufacturerCode, manufacturerCode);
            Assert.AreEqual(expectedFactoryCode, factoryCode);
            Assert.AreEqual(expectedStationCode, stationCode);
        }
    }
}
