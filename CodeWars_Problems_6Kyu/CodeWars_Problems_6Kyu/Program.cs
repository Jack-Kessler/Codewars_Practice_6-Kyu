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