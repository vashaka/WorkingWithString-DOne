﻿using System;

namespace WorkingWithStrings
{
    public static class SplittingStrings
    {
        /// <summary>
        /// Splits a comma-separated string into substrings that are based on the comma character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitCommaSeparatedString(string str)
        {
            return str.Split(',');
        }

        /// <summary>
        /// Splits a colon-separated string into substrings that are based on the colon character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitColonSeparatedString(string str)
        {
            // TODO #5-1. Analyze unit tests for the method, and add the method implementation.
            // Use String.Split method: https://docs.microsoft.com/en-us/dotnet/api/system.string.split
            throw new NotImplementedException();
        }

        /// <summary>
        /// Splits a comma-separated string into substrings that are based on the comma character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitCommaSeparatedStringMaxTwoElements(string str)
        {
            // TODO #5-2. Analyze unit tests for the method, and add the method implementation.
            // Use String.Split method: https://docs.microsoft.com/en-us/dotnet/api/system.string.split
            throw new NotImplementedException();
        }

        /// <summary>
        /// Splits a colon-separated string into substrings that are based on the colon character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitColonSeparatedStringMaxThreeElements(string str)
        {
            // TODO #5-3. Analyze unit tests for the method, and add the method implementation.
            // Use String.Split method: https://docs.microsoft.com/en-us/dotnet/api/system.string.split
            throw new NotImplementedException();
        }

        /// <summary>
        /// Splits a hyphen-separated string into substrings that are based on the hyphen character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitHyphenSeparatedStringMaxThreeElementsRemoveEmptyStrings(string str)
        {
            // TODO #5-4. Analyze unit tests for the method, and add the method implementation.
            // Use String.Split method: https://docs.microsoft.com/en-us/dotnet/api/system.string.split
            throw new NotImplementedException();
        }

        /// <summary>
        /// Splits a separated string that is separated with colon and comma characters into substrings, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitColonAndCommaSeparatedStringMaxFourElementsRemoveEmptyStrings(string str)
        {
            // TODO #5-5. Analyze unit tests for the method, and add the method implementation.
            // Use String.Split method: https://docs.microsoft.com/en-us/dotnet/api/system.string.split
            throw new NotImplementedException();
        }

        /// <summary>
        /// Splits a sentence into substrings, and return an array whose elements contain only words.
        /// </summary>
        public static string[] GetOnlyWords(string str)
        {
            // TODO #5-6. Analyze unit tests for the method, and add the method implementation.
            // Use String.Split method: https://docs.microsoft.com/en-us/dotnet/api/system.string.split
            throw new NotImplementedException();
        }

        /// <summary>
        /// Splits a CSV (comma-separated values) string into substrings that are based on the comma character, and return an array of the CSV line elements.
        /// </summary>
        public static string[] GetDataFromCsvLine(string str)
        {
            // TODO #5-7. Analyze unit tests for the method, and add the method implementation.
            // Use String.Split method: https://docs.microsoft.com/en-us/dotnet/api/system.string.split
            throw new NotImplementedException();
        }
    }
}
