using System;

namespace LuxoftTask
{
    class Program
    {

        static void Main(string[] args)
        {

            // Task : 1 . Testing with inputs.
            int[] sum1 = { 1, 2, 3, 1 };
            int[] sum2 = { 2, 7, 9, 3, 1 };

            int[] sum3 = { 1, 2, 10, 40, 50 ,35 };

            Console.WriteLine(" Usecase 1: test 1 from maximum sum of subset of array elements " + Environment.NewLine +  "input { 1, 2, 3, 1 } , OutPut :" + FindSum(sum1).ToString());
            Console.WriteLine("  Usecase 1: test 2 from maximum sum of subset of array elements " + Environment.NewLine + "input { 2, 7, 9, 3, 1 } , OutPut :" + FindSum(sum2).ToString());
            Console.WriteLine("  Usecase 1: test 3 from maximum sum of subset of array elements " + Environment.NewLine + "input {  1, 2, 10, 40, 50 ,35  } , OutPut :" + FindSum(sum3).ToString());

            // Task :2 . Testing with inputs.
            int[,] input1 ={ { 1, 0, 1 },
                          { 0, 0, 0 },
                          { 1, 0, 1 } };
           

            int[,] input2 ={ { 1, 1, 1 },
                             { 1, 0, 0 },
                             { 1, 0, 1 } };

            int[,] input3 ={ { 1, 0, 0 },
                             { 1, 0, 1 },
                             { 1, 0, 1 } };

            Console.WriteLine(" Usecase 2:  test 1 from  horizontally of vertically adjacent to at least one other pixel of the same set. " + Environment.NewLine +
                        "Input { { 1, 0, 1 },{ 0, 0, 0 }, { 1, 0, 1 } } , OutPut :" + CountGroups(input1,3,3).ToString());

            Console.WriteLine(" Usecase 2 :test 2 from horizontally of vertically adjacent to at least one other pixel of the same set. " + Environment.NewLine +
                       "Input { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 0, 1 }}, OutPut :" + CountGroups(input2, 3, 3).ToString());

            Console.WriteLine(" Usecase 2 :test 3 from horizontally of vertically adjacent to at least one other pixel of the same set. " + Environment.NewLine +
                    "Input { { 1, 0, 0 }, { 1, 0, 1 }, { 1, 0, 1 }}, OutPut :" + CountGroups(input3, 3, 3).ToString());


            Console.ReadLine();
        }

        #region
        // Task : 1.Having a non-empty array of non-negative integers of length N,
        //you need to return the maximum sum of subset of array elements such that you never take any two adjacent elements.
        // Time Complexity: O(n) linear time complexity as it have highest n loop.
        #endregion
        public static int FindSum(int[] arr)
        {
            int input = arr[0];
            int output = 0;
            int excl_new;
            int i;
            for (i = 1; i < arr.Length; i++)
            {
                excl_new = (input > output) ? input : output;
                input = output + arr[i];
                output = excl_new;
            }

            return ((input > output) ? input : output);
        }


        #region
        // Task : 2. You have a map of the monitor's pixels where good pixels are marked with '0' and dead pixels are marked with '1'.
        //  Write a code that returns the number of dead pixel groups.A group is a set of pixels where one pixel is horizontally of vertically adjacent to
        //at least one other pixel of the same set.
        // Time Complexity: O(n2) Quadratic time complexity as it have highest n squar loop.
        #endregion
        public static int CountGroups(int[,] input, int row, int column)
        {
            int count = 0;
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    if (input[r, c] == 0)
                    {
                        if (r > 0)
                        {
                            if (input[r - 1, c] == 0)
                            {
                                count++;
                            }
                        }
                        if (c > 0)
                        {
                            if (input[r, c - 1] == 0)
                            {
                                count++;
                            }
                        }
                    }

                }
            }
            return count;
        }

    }
}
