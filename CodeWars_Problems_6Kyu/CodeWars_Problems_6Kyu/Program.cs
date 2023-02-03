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



//Simple Fun #52: Pair Of Shoes

//int[][] shoes =
//    {
//    new int[] { 0, 21 },
//    new int[] { 1, 23 },
//    new int[] { 1, 21 },
//    new int[] { 0, 23 }
//    };

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

//for (g = 0; g < x; g++) // Check for zeros
//{
//    for (h = 0; h < x; h++)
//    {
//        finalResult = (board[g][h] == 0) ? false : true;
//        if (finalResult == false)
//        {
//            Console.WriteLine(finalResult);
//            return finalResult;
//        }
//    }
//}

// Checks all horizontal
//for (g = 0; g < x; g++) // h tells us which array we are in (vertical)
//{
//    for (h = 0; h < x; h++) // i tells us which position in array #h we are looking at
//    {
//        for (i = h + 1; i < x; i++) // j is used for comparison purposes
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
//for (g = 0; g < x; g++) // h tells us which array we are in (vertical)
//{
//    for (h = 0; h < x; h++) // i tells us which position in array #h we are looking at
//    {
//        for (i = h + 1; i < x; i++) // j is used for comparison purposes
//        {
//            if (board[h][g] == board[i][g])
//            {
//                Console.WriteLine("Duplicate");
//                finalResult = false;
//            }
//        }
//    }
//}

// check's each sub-cube of 9

//for (int f = 0; f < y; f++)
//{
//    for (g = 0; g < y; g++) // h tells us which array we are in (vertical)
//    {
//        for (h = 0; h < y; h++)
//        {
//            for (i = 0; i < y; i++) // i tells us which position in array #h we are looking at
//            {
//                for (j = i + 1; j < y; j++) // j is used for comparison purposes
//                {
//                    if (g == i && h == j)
//                    {
//                        continue;
//                    }
//                    else if (board[g + (3*f)][h + (3*f)] == board[i + (3*f)][j + (3*f)])
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