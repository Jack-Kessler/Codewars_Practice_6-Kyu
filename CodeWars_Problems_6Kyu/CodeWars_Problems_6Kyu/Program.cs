// Learning Recurssion

//int Factorial(int number)
//{
//    var factorialProduct = 1;

//    return number < 0 ? throw new ArgumentOutOfRangeException() //short hand way
//        : number == 0 ? factorialProduct
//        : number * Factorial(number -1);

//    //if (number < 0) // More basic way
//    //{
//    //    throw new ArgumentOutOfRangeException();
//    //}

//    //return number == 0 ? factorialProduct : number * Factorial (number - 1);
//}

//int x = Factorial(4);
//Console.WriteLine(x);

//-----------------------------------------------------------------------------------------------------------------------------

//Simple Fun #52: Pair Of Shoes

using System;
using System.Diagnostics.Metrics;
using System.Globalization;

/*                                      ****IMPORTANT: Note on jagged array vs. 2D array****
                                   First, a jagged array and a 2D array are NOT the same thing
                                   
                                   Jagged array: https://www.programiz.com/csharp-programming/jagged-array
                                                int[][] shoes =
                                                {
                                                new int[] { 0, 21 },
                                                new int[] { 1, 23 },
                                                new int[] { 1, 21 },
                                                new int[] { 0, 23 }
                                                };

                                   2D array: https://www.programiz.com/csharp-programming/multidimensional-arrays
                                                int[ , ] x = { { 1, 2 ,3}, { 3, 4, 5 } }; // 2 Rows x 3 colmumns

                                   IS THIS TRUE??????????? (see links above)
                                   Technically speaking, both the jaggard array and 2d array have only one column. 
                                   Within each element of that column, however, another array exists.

                                   If it is true, then why does .getLength(1) should work for both but it doesn't...

                                   **Where these two differ though, is when you want to get the width (i.e. # of columns) of the jagged/2D array.**

                                   for jagged...

                                     
                                     // assume there is a jagged array called "jaggedArray" defined and initialized

                                     for (int i = 0; i < jaggedArray.Length; i++) 
                                     {
                                            for (int j = 0; j < jaggedArray[i].Length; j++) 
                                            {
                                                Console.Write(jaggedArray[i][j] + " ");
                                            }
                                     }
                                    
                                     IMPORTANT: Notice the ".Length" 

                                   for 2D...
                                    // assume there is a 2D array called "numbers" defined and initialized

                                    for(int i = 0; i < numbers.GetLength(0); i++)  { 
                                            Console.Write("Row "+ i+": ");

                                    for(int j = 0; j < numbers.GetLength(1); j++)  { 
                                            Console.Write(numbers[i, j]+" ");

                                    IMPORTANT: Notice the ".GetLength"
                                
                                    TAKEAWAY: jagged arrays use just ".Length" while 2D (multi-dimensional) arrays use ".GetLength"

                                    The .Length property returns the number of elements in an array... 
                                    whether it be one dimensional or multidimensional. 
                                    (ex. 2x6 array = 12.;   5 x 2 x 3 array = 30)

                                    The .GetLength(0) method returns number of rows in a multidimensional array (i.e. y axis)
                                    (ex. for a 5x2x3 array, that is  5.)

                                    The .GetLength(1) method returns number of columns in a multidimensional array (i.e. x axis)
                                    (ex. for a 5x2x3 array, that is 2.)

                                    The .GetLength(2) method returns number of elements within each sub-array (i.e. y axis)
                                    (ex. for a 5x2x3 array, that is 3.)

                                    The pattern holds for more dimensions as well. 

                                    See full exmaple below:
                                
                                            int[,,] threeDimArray = new int[2, 3, 4]
                                            {
                                                { { 1, 2, 3, 4}, { 5, 6, 7, 8}, { 9, 10, 11, 12}},
                                                { { 13, 14, 15, 16}, {17, 18, 19, 20 }, {21, 22, 23, 24 } }
                                            };

                                            int x = threeDimArray.Length;
                                            int y = threeDimArray.GetLength(0);
                                            int z = threeDimArray.GetLength(1);
                                            int w = threeDimArray.GetLength(2);

                                            Console.WriteLine($"Should be 24: {x}"); //total number of elements = x*y*z
                                            Console.WriteLine($"Should be 2: {y}"); //total number of rows (y axis)
                                            Console.WriteLine($"Should be 3: {z}"); //total number of columns (x axis)
                                            Console.WriteLine($"Should be 4: {w}"); //total number of elements in each sub array (z axis)

*/

                                            //int[][] twoDimJaggedArray = 
                                            //{
                                            //    new int[] { 0, 21 },
                                            //    new int[] { 1, 23 },
                                            //    new int[] { 1, 21 },
                                            //    new int[] { 0, 23 }
                                            //};

                                            //int x = twoDimJaggedArray.Length;
                                            //int y = twoDimJaggedArray.GetLength(0);
                                            //int z = twoDimJaggedArray.GetLength(1);

                                            //Console.WriteLine($"Should be 8: {x}"); //total number of elements = x*y*z
                                            //Console.WriteLine($"Should be 4: {y}"); //total number of rows (y axis)
                                            //Console.WriteLine($"Should be 2: {z}"); //total number of columns (x axis)


int[][] shoes =
    {
    new int[] { 0, 21 },
    new int[] { 1, 23 },
    new int[] { 1, 21 },
    new int[] { 0, 23 }
    };

int counter = 0;

for (int i = 0; i < 1; i++)
{
    for (int j =0; j < shoes[i].Length; j++)
    {
        counter++;
    }
}


//int g = 0;
//int h = 0;
//int i = 0;
////Checks all horizontal
//for (g = 0; g < x; g++) // g tells us which array we are in (vertical)
//{
//    for (h = 0; h < x; h++) // h tells us which position in array #h we are looking at
//    {
//        for (i = h + 1; i < x; i++) // i is used for comparison purposes
//        {
//            if (board[g][h] == board[g][i])
//            {
//                Console.WriteLine("Duplicate");
//                finalResult = false;
//            }
//        }

//    }
//}

//// checks all vertical
//for (g = 0; g < x; g++) // g tells us which array we are in (vertical)
//{
//    for (h = 0; h < x; h++) // h tells us which position in array #h we are looking at
//    {
//        for (i = h + 1; i < x; i++) // i is used for comparison purposes
//        {
//            if (board[h][g] == board[i][g])
//            {
//                Console.WriteLine("Duplicate");
//                finalResult = false;
//            }
//        }
//    }
//}

//-----------------------------------------------------------------------------------------------------------------------------

//Simple Reversed Parenthesis (6-Kyu)

//string s = "())(((";
//int counter = 0;
//int i = 0;
//int isEven = s.Length % 2;

//if (isEven != 0)
//{
//    Console.WriteLine(-1);
//    //return -1;
//}

//for (i = 0; i < s.Length - 1; i++) // Will truncate string to either only '(' or ')' with the exception of possibly first or last element
//{
//    if (s[0] == ')')
//    {
//        s = '(' + s.Substring(1);
//        counter++;
//        i = -1;
//    }
//    else if (s[s.Length - 1] == '(')
//    {
//        s = s.Remove(s.Length - 1);
//        s = s + ")";
//        counter++;
//        i = -1;
//    }
//    else if (s[i] == '(' && s[i + 1] == ')')
//    {
//        s = s.Remove(i, 2);
//        i = -1;
//    }
//}

//Console.WriteLine(counter);
//return counter;


//better solution below

//int solve(string s)
//{
//    if (string.IsNullOrEmpty(s)) return 0;                                // Line 1
//    else if (s.Length % 2 == 1) return -1;                                // Line 2
//    else if (s.Contains("()")) return solve(s.Replace("()", ""));         // Line 3
//    return (s.Substring(0, 2) == ")(" ? 2 : 1) + solve(s.Substring(2));   // Line 4

//         *** Below is the general flow of what is happening above: ***
//      A string is read in.
//      If the string is empty or null, line 1 code will be implemented and return o. Done.

//      If the string length is odd, this challenge of having all parentheses be balanced is impossible.
//      Line 2 code will be implemented and return -1. Done.

//      If the string is non-empty and even length, then code on Line 3 will be implemented. 
//          Line 3 code removes all "()" from original string.

//      After Line 3, C# will move on to Line 4.
//          Line 4 will first check to see if the 1st and 2nd character in the string are ")(". If so, return 2 + (following part)...
//              ... If not, return 1 + (following part).

//          following part: The first go through of line 4 only looked at 1st and 2nd position in string
//                              ... but there are potentially more than just two characters in the string at this point.
//                              ... therefore, the second half of Line 4 code redoes the whole process explained above...
//                              ... starting from position 3 (i.e. s[2]).
//                              ... Eventually there will only be 2 characters and when the 2nd half runs one more time...
//                              ... Line 1 will activate (because it will be null / empty) and return 0.
//                              ... At this point, solve will add up all the 1s and 2s from Line 4 to return one final int.

//}

//-----------------------------------------------------------------------------------------------------------------------------
//Sudoku board validator (6-Kyu)
//using System.Collections.Concurrent;
//using System.Reflection.Metadata.Ecma335;

//int[][] board = {
//            new[]{8,4,7,2,6,5,1,0,3},
//            new[]{1,3,6,7,0,8,2,4,5},
//            new[]{0,5,2,1,4,3,8,6,7},
//            new[]{4,2,0,6,7,1,5,3,8},
//            new[]{6,7,8,5,3,2,0,1,4},
//            new[]{3,1,5,4,8,0,7,2,6},
//            new[]{5,6,4,0,1,7,3,8,2},
//            new[]{7,8,1,3,2,4,6,5,0},
//            new[]{2,0,3,8,5,6,4,7,1}
//                };

//int x = 9; //full row / column length
//int y = 3; // length of sub-cube

//int g = 0;
//int h = 0;
//int i = 0;
//int j = 0;

//bool finalResult = true;

// Check for any zeros in 2D array
//for (g = 0; g < x; g++) // g tells us which row we are in
//{
//    for (h = 0; h < x; h++) // h tells us which column we are in
//    {
//        finalResult = (board[g][h] == 0) ? false : true; // if element at row g, column h is zero, return false. Otherwise, return true.
//        if (finalResult == false)
//        {
//            Console.WriteLine(finalResult);
//            return finalResult;
//        }
//    }
//}

// Checks every row for duplicate numbers
//for (g = 0; g < x; g++) // g tells us which row we are in (NOTE: same row for both elements being compared)
//{
//    for (h = 0; h < x; h++) // h tells us which column we are in
//    {
//        for (i = h + 1; i < x; i++) // i is used to alter column position (by difference of i) from original column position h
//        {
//            if (board[g][h] == board[g][i]) // holding row constant, checking for duplicates within the row
//            {
//                Console.WriteLine("Duplicate");
//                finalResult = false;
//            }
//        }

//    }
//}

//// checks every column for duplicate numbers
//for (g = 0; g < x; g++) // g tells us which column we are in (NOTE: same column for both elements being compared)
//{
//    for (h = 0; h < x; h++) // h tells us which row we are in
//    {
//        for (i = h + 1; i < x; i++) // i is used to alter row position (by difference of i) from original row position h
//        {
//            if (board[h][g] == board[i][g]) // holding column constant, checking for duplicates within the column
//            {
//                Console.WriteLine("Duplicate");
//                finalResult = false;
//            }
//        }
//    }
//}

// check's each sub-cube of 9

//for (int f = 0; f < y; f++) // f is used as a counter to go through each of the 9 sub-squares of 3 x 3
//{
//    for (g = 0; g < y; g++) // g tells us column of 1st element.
//    {
//        for (h = 0; h < y; h++) // h tells us column of 1st element.
//        {
//            for (i = 0; i < y; i++) // i tells us row of 2nd element.
//            {
//                for (j = i + 1; j < y; j++) // j tells us column of 2nd element.
//                {
//                    if (g == i && h == j) // case where you are comparing same element against itself - obvi want to ignore
//                    {
//                        continue;
//                    }
//                    else if (board[g + (3*f)][h + (3*f)] == board[i + (3*f)][j + (3*f)])
// code above checks each position in sub 3x3 square against other elements in 3x3 square to see if duplicates exist
//                    {
//                          Console.WriteLine("Duplicate");
//                        finalResult = false;
//                    }
//                }
//            }
//        }
//    }
//}
//Console.WriteLine(finalResult);
//return finalResult;

//-----------------------------------------------------------------------------------------------------------------------------