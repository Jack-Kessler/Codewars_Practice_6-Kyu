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

//Simple Fun #52: Pair Of Shoes (completed 2/3/2023 - 10th day of bootcamp)

//using System;
//using System.Diagnostics.Metrics;
//using System.Globalization;
//using System.Transactions;

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

//**** Example below for two dimensional Jagged Array ****

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

//**** End of example ****

//Instructions:
//Min. number of rows = shoes.Length = 2
//Max. number of rows = shoes.Length = 50
//Min size of a possible shoe (element position [i][1]) is 1
//Max size of a possible shoe (element position [i][1]) is 100

//int[][] shoes =
//    {
//    new int[] { 0, 21 },
//    new int[] { 1, 23 },
//    new int[] { 1, 21 },
//    new int[] { 0, 23 },
//    new int[] { 1, 22 },
//    new int[] { 1, 22 },
//    };

//int g = 0;
//int h = 0;
//int i = 0;
//int counter = 0;
//int checkTrue = 0;
//int one = 0;
//int zero = 0;
//bool result = false;


//for (i = 0; i < shoes.Length; i++) //calculating how many right and left shoes there are
//{
//    if (shoes[i][0] == 0)
//    {
//        zero++;
//    }
//    else
//    {
//        one++;
//    }
//}

//if (zero != one) //checking to see if there are the same number of right and left shoes. If not, impossible.
//{
//    Console.WriteLine("false");
//}


//for (g = 0; g < shoes.Length; g++) // shoes.Length is # of rows in shoes.
//{
//    counter = g;
//    for (i = 0; i < shoes.Length; i++)
//    {
//        if (shoes[i][0] == 101)
//        {
//            checkTrue++;
//            if (checkTrue == shoes.Length)
//            {
//                Console.WriteLine("True");
//                result = true;
//            }
//        }
//        else
//        {
//            checkTrue = 0; //need to reset to 0 every time so next time through loop is valid (since start at element 0).
//            break;
//        }
//    }
//    if (shoes[g][0] == 101) // possible that some shoes already found a match with another shoe checked earlier in process
//    {
//        continue;
//    }
//    else //shoes that haven't found a match yet will fall into this case.
//    {
//        for (h = g+1; h < shoes.Length; h++) // h always starts at g+1. This avoids going over shoes that were already checked.
//        {
//            if (shoes[g][1] == shoes[h][1]) // Checking for shoe size match
//            {
//                if (shoes[g][0] == 1 && shoes[h][0] == 0 || shoes[g][0] == 0 && shoes[h][0] == 1) // checking if one left, one right
//                {                       //if one of the above is true, this means that there was a match.
//                    shoes[g][0] = 101; //need to reset both elements to 101 in each shoe so  we can ignore moving forward
//                    shoes[g][1] = 101; //had to do this way since I could not find how to remove the array (i.e. row) entirely
//                    shoes[h][0] = 101;
//                    shoes[h][1] = 101;
//                    break;              //Breaks back to original "for (g=0..)" statement
//                }
//             counter++; //shoe size matched but two of the same foot shoe
//            }
//            else
//            {
//                counter++; //shoe size did not match
//            }

//        }
//        if (counter == shoes.Length - 1) //this condition will only be true if there is a shoe with no match.
//        {
//            Console.WriteLine("false");
//        }
//    }
//}

//return result;

//-----------------------------------------------------------------------------------------------------------------------------

//Example below of where break goes until

//int counter = 0;
//int k = 0;
//int h = 0;

//for (int g = 0; g < 3; g++) // for statement 1
//{
//    if (k == 10) // if statement 1
//    {
//        Console.WriteLine("If statement 1");
//    }
//    else
//    {
//        for (h = 0; h < 4; h++) // for statement 2
//        {
//            if (k == 10) // if statement 2
//            {
//                Console.WriteLine("If statement 2");
//            }
//            else
//            {
//                if (g == h) // if statement 3
//                {
//                    Console.WriteLine($"g: {g} is equal to h: {h}");
//                }
//                else if (g != h)
//                {
//                    if (g <= h) // if statement 4
//                    {
//                        Console.WriteLine("Break will happen: what is after?");
//                        break;
//                    }
//                    Console.WriteLine("Only broke out of if loop break was in");
//                    counter++;
//                }
//                else
//                {
//                    Console.WriteLine("Should never run this else statement");
//                    counter++;
//                }
//            }
//            Console.WriteLine("broke out of inner most if and second if but not closest for loop");
//        }
//        Console.WriteLine("broke out of inner most if, second if, and closest for loop, but NOT out of outside most if");
//    }
//    Console.WriteLine("broke out to outer most for loop");
//}



//-----------------------------------------------------------------------------------------------------------------------------

//Simple Reversed Parenthesis (6-Kyu) (Completed 2/3/2023 - 10th Day of Bootcamp)

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

//Sudoku board validator (6-Kyu) (Completed 2/2/2023 - 9th day of bootcamp)
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