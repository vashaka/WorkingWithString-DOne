﻿using System;

namespace WorkingWithStrings
{
    public static class CreatingStrings
    {
        /// <summary>
        /// Returns a new string that contains a specified string.
        /// </summary>
        public static string ReturnNewString(string str)
        {
            return new string(str);
        }

        /// <summary>
        /// Returns a new string that contains a specified character repeated a specified number of times.
        /// </summary>
        public static string ReturnStringWithRepeatedChars(char c, int count)
        {
            // TODO #2-1. Implement the method using String(Char, Int32) constructor
            // See the constructor documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.-ctor#System_String__ctor_System_Char_System_Int32_
            return new string(c, count);
        }

        /// <summary>
        /// Returns a new string that contains a specified character array.
        /// </summary>
        public static string ReturnStringFromCharArray(char[] c)
        {
            // TODO #2-2. Implement the method using String(Char[]) constructor
            // See the constructor documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.-ctor#System_String__ctor_System_Char___
            return new string(c);
        }

        /// <summary>
        /// Returns a new string that contains a part of a specified character array.
        /// </summary>
        public static string ReturnStringFromCharArray(char[] c, int startIndex, int length)
        {
            // TODO #2-3. Implement the method using String(Char[], Int32, Int32) constructor
            // See the constructor documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.string.-ctor#System_String__ctor_System_Char___System_Int32_System_Int32_
            return new string(c, startIndex, length);
        }
    }
}
