using System;

namespace WorkingWithStrings
{
    public static class CopyingStrings
    {
        /// <summary>
        /// Copies one character from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyOneChar(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();
            source.CopyTo(0, destinationArray, 4, 1);
            return new string(destinationArray);
        }

        /// <summary>
        /// Copies three characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyThreeChars(string source, string destination)
        {
            // TODO #8-1. Analyze unit tests for the method, and add the method implementation.
            // Use String.CopyTo method to copy characters: https://docs.microsoft.com/en-us/dotnet/api/system.string.copyto
            char[] destinationArray = destination.ToCharArray();

            // Copy 3 characters starting from index 0 of source to index 0 of destinationArray
            source.CopyTo(0, destinationArray, 0, 3);

            return new string(destinationArray);
        }

        /// <summary>
        /// Copies five characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyFiveChars(string source, string destination)
        {
            // TODO #8-2. Analyze unit tests for the method, and add the method implementation.
            char[] destinationArray = destination.ToCharArray();
            source.CopyTo(0, destinationArray, 4, 5);
            return new string(destinationArray);
        }

        /// <summary>
        /// Copies six characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopySixChars(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();
            source.CopyTo(0, destinationArray, 4, 6);
            return new string(destinationArray);
        }

        /// <summary>
        /// Gets a production code by copying substrings of the <paramref name="regionCode"/>, <paramref name="locationCode"/>, <paramref name="dateCode"/> and <paramref name="factoryCode"/> parameters to the <paramref name="template"/>.
        /// </summary>
        public static string GetProductionCode(string template, string regionCode, string locationCode, string dateCode, string factoryCode)
        {
            char[] templateArray = template.ToCharArray();

            if (regionCode.Length + 0 <= templateArray.Length)
            {
                regionCode.CopyTo(0, templateArray, 0, regionCode.Length);  // Copy regionCode into the start.
            }

            if (locationCode.Length + 4 <= templateArray.Length)
            {
                locationCode.CopyTo(0, templateArray, 4, locationCode.Length);  // Copy locationCode starting at index 4.
            }

            if (dateCode.Length + 8 <= templateArray.Length)
            {
                dateCode.CopyTo(0, templateArray, 8, dateCode.Length);  // Copy dateCode starting at index 8.
            }

            if (factoryCode.Length + 12 <= templateArray.Length)
            {
                factoryCode.CopyTo(0, templateArray, 12, factoryCode.Length);  // Copy factoryCode starting at index 12.
            }

            return new string(templateArray);
        }
    }
}
