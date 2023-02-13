﻿using System;

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

            source.CopyTo(0, destinationArray, 4, source.Length);

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
            // TODO #8-3. Analyze unit tests for the method, and add the method implementation.
            char[] destinationArray = destination.ToCharArray();
            source.CopyTo(2, destinationArray, 5, 6);

            return new string(destinationArray);
        }

        /// <summary>
        /// Gets a production code by copying substrings of the <paramref name="regionCode"/>, <paramref name="locationCode"/>, <paramref name="dateCode"/> and <paramref name="factoryCode"/> parameters to the <paramref name="template"/>.
        /// </summary>
        public static string GetProductionCode(string template, string regionCode, string locationCode, string dateCode, string factoryCode)
        {
            // TODO #8-4. Analyze unit tests for the method, and add the method implementation.
            char[] destinationArr = template.ToCharArray();

         
            regionCode.CopyTo(1, destinationArr, 0, 1);
            locationCode.CopyTo(4, destinationArr, 3, 2);
            dateCode.CopyTo(3, destinationArr, 7, 3);
            factoryCode.CopyTo(2, destinationArr, 12, 4);


            return new string(destinationArr);
        }
    }
}
