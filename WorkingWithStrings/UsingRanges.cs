﻿using System;

namespace WorkingWithStrings
{
    public static class UsingRanges
    {
        /// <summary>
        /// Gets a string with all characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithAllChars(string str)
        {
            return str[..];
        }

        /// <summary>
        /// Gets a string without first character of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutFirstChar(string str)
        {
            // TODO #4-1. Analyze unit tests for the method, and add the method implementation.
            // Use range to get a substring: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            return str[1..];
        }

        /// <summary>
        /// Gets a string without two first character of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutTwoFirstChars(string str)
        {
            // TODO #4-2. Analyze unit tests for the method, and add the method implementation.
            // Use range to get a substring: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            return str[2..];
        }

        /// <summary>
        /// Gets a string without three first character of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutThreeFirstChars(string str)
        {
            // TODO #4-3. Analyze unit tests for the method, and add the method implementation.
            // Use range to get a substring: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            return str[3..];
        }

        /// <summary>
        /// Gets a string without a last character of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutLastChar(string str)
        {
            // TODO #4-4. Analyze unit tests for the method, and add the method implementation.
            // Use range to get a substring: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            int lastIndex = str.Length - 1;
            return str[..lastIndex];
        }

        /// <summary>
        /// Gets a string without a two last characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutTwoLastChars(string str)
        {
            // TODO #4-5. Analyze unit tests for the method, and add the method implementation.
            // Use range to get a substring: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            int beforeLastIndex = str.Length - 2;
            return str[..beforeLastIndex];
        }

        /// <summary>
        /// Gets a string without a three last characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutThreeLastChars(string str)
        {
            // TODO #4-6. Analyze unit tests for the method, and add the method implementation.
            // Use range to get a substring: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            int thirdFromLastIndex = str.Length - 3;
            return str[..thirdFromLastIndex];
        }

        /// <summary>
        /// Gets a string without the first and the last characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutFirstAndLastChars(string str)
        {
            // TODO #4-7. Analyze unit tests for the method, and add the method implementation.
            // Use range to get a substring: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            int lastIndex = str.Length - 1;
            return str[1..lastIndex];
        }

        /// <summary>
        /// Gets a string without the first two and the last two characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutTwoFirstAndTwoLastChars(string str)
        {
            // TODO #4-8. Analyze unit tests for the method, and add the method implementation.
            // Use range to get a substring: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            int beforeLastIndex = str.Length - 2;
            return str[2..beforeLastIndex];
        }

        /// <summary>
        /// Gets a string without the first three and the last three characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutThreeFirstAndThreeLastChars(string str)
        {
            // TODO #4-9. Analyze unit tests for the method, and add the method implementation.
            // Use range to get a substring: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            int thirdFromLastIndex = str.Length - 3;
            return str[3..thirdFromLastIndex];
        }

        /// <summary>
        /// Gets details of the production code.
        /// </summary>
        public static void GetProductionCodeDetails(string productionCode, out string regionCode, out string locationCode, out string dateCode, out string factoryCode)
        {
            // TODO #4-10. Analyze unit tests for the method, and add the method implementation.
            regionCode = productionCode[0].ToString();
            locationCode = productionCode[3..5].ToString();
            dateCode = productionCode[7..10].ToString();
            factoryCode = productionCode[12..].ToString();

        }

        /// <summary>
        /// Gets details of the production code.
        /// </summary>
        public static void GetSerialNumberDetails(string serialNumber, out string countryCode, out string manufacturerCode, out string factoryCode, out string stationCode)
        {
            // TODO #4-11. Analyze unit tests for the method, and add the method implementation.
            countryCode = serialNumber[^9].ToString();
            manufacturerCode = serialNumber[^8..^6].ToString();
            factoryCode = serialNumber[^5..^1].ToString();
            stationCode = serialNumber[^1].ToString();



        }
    }
}
