using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_S19

{

    class Program

    {

        static void Main(string[] args)

        {

            // left rotation

            Console.WriteLine("Left Rotation");

            int d = 4;

            int[] a = { 1, 2, 3, 4, 5 };

            int[] r = rotLeft(a, d);

            displayArray(r);

            Console.ReadLine();



            // Maximum toys

            Console.WriteLine("\n\nMaximum toys");

            int k = 50;

            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };

            Console.WriteLine(maximumToys(prices, k));

            Console.ReadLine();



            // Balanced sums

            Console.WriteLine("\n\nBalanced sums");

            List<int> arr = new List<int> { 1, 2, 3 };

            Console.WriteLine(balancedSums(arr));

            Console.ReadLine();


            // Missing numbers

            Console.WriteLine("\n\nMissing numbers");

            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };

            int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };

            int[] r2 = missingNumbers(arr1, brr);

            displayArray(r2);



            // grading students

            Console.WriteLine("\n\nGrading students");

            int arrayMax = 7;
            Random RandomGrades = new Random();
            int[] grades = new int[arrayMax];
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = RandomGrades.Next(0, 100);
            }

            int[] r3 = gradingStudents(grades);
            Console.Write("\n\nFinal Grades: ");
            displayArray(r3);



            // find the median

            Console.WriteLine("\n\nFind the median");

            int arraysize = 8;
            Random Rand = new Random();
            int[] arr2 = new int[arraysize];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Rand.Next(0, 100);
            }

            Console.WriteLine(findMedian(arr2));
            Console.ReadLine();


            // closest numbers

            Console.WriteLine("\n\nClosest numbers");

            int[] arr3 = { 5, 4, 3, 2 };

            int[] r4 = closestNumbers(arr3);

            displayArray(r4);



            // Day of programmer

            Console.WriteLine("\n\nDay of Programmer");

            int year = 2017;

            Console.WriteLine(dayOfProgrammer(year));
            Console.ReadLine();
        }



        static void displayArray(int[] arr)

        {

            Console.WriteLine();

            foreach (int n in arr)

            {

                Console.Write(n + " ");

            }
            Console.ReadKey();
        }



        // Complete the rotLeft function below.

        static int[] rotLeft(int[] a, int d)

        {





            while (d != 0)

            {

                int Subs;

                Subs = a[0]; // to put the first element of the array in an auxiliary container to be moved



                for (int i = 0; i < a.Length - 1; i++) //moves all elements one unit to the left

                {

                    a[i] = a[i + 1];



                }

                a[a.Length - 1] = Subs; //puts the first element at the end

                d = d - 1; // controls the total required shifts





            }

            return a;

        }



        // Complete the maximumToys function below.

        static int maximumToys(int[] prices, int k)

        {

            int[] SortedPrices = BubbleSort(prices);



            int TotalPrice = 0;

            int Counter = 0;



            while (TotalPrice <= k)

            {



                TotalPrice = TotalPrice + SortedPrices[Counter];

                Counter = Counter + 1;

            }









            return Counter - 1;

        }



        // Complete the balancedSums function below.

        static string balancedSums(List<int> arr)

        {
            int[] array = arr.ToArray();
            int length = array.Length;

            if (length == 1)
            {
                return "Yes";
            }
            else if (length == 2)
            {
                if (array[0] == 0 | array[1] == 0)
                {
                    return "Yes";
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    if (i == length - 1)
                    {
                        int sumLeft = new ArraySegment<int>(array, 0, i).Sum();
                        int sumRight = 0;
                        if (sumLeft == sumRight)
                        {
                            return "Yes";
                        }
                    }
                    else if (i == 0)
                    {
                        int sumLeft = 0;
                        int sumRight = new ArraySegment<int>(array, i + 1, length - i - 1).Sum();
                        if (sumLeft == sumRight)
                        {
                            return "Yes";
                        }
                    }
                    else
                    {
                        int sumLeft = new ArraySegment<int>(array, 0, i).Sum();
                        int sumRight = new ArraySegment<int>(array, i + 1, length - i - 1).Sum();
                        if (sumLeft == sumRight)
                        {
                            return "Yes";
                        }
                    }
                }
            }
            return "No";
        }



        // Complete the missingNumbers function below.

        static int[] missingNumbers(int[] arr, int[] brr)

        {

            return new int[] { };

        }





        // Complete the gradingStudents function below.

        static int[] gradingStudents(int[] grades)

        {
            //print the Original Grades
            Console.Write("\nOld Grades:\n");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("{0} ", grades[i]);
            }

            //An array to hold the Final Rounded Grade
            int[] FinalGrades = new int[grades.Length];
            //Grading round number
            int multiplesof = 5;


            //calculate the final grade.
            //If the original grade is less than 38 then there is no rounding, else round it to the next multiple of 5 if the difference between the next mulltiple of 5 and the original grade is less than 3
            //If the difference is more than 3 then leave as is and dont round
            for (int i = 0; i < grades.Length; i++)
            {
                //Catch for error
                if (grades[i] < 0 || grades[i] > 100) { Console.WriteLine("Grade is not valid"); }

                else if (grades[i] >= 0 || grades[i] >= 100)
                {
                    //variable to calculate the Rounded Grades
                    int RoundedGrades = grades[i] + (multiplesof - grades[i] % multiplesof);
                    //If the origianl grade is less than 38 then leave as is
                    if (grades[i] < 38)
                    {
                        FinalGrades[i] = grades[i];
                    }
                    //if the original grade is greater than 38 then apply the rounding rule defined in the top comment above
                    if (grades[i] >= 38)
                    {
                        // if the difference is less than 3 then round
                        if (RoundedGrades - grades[i] < 3)
                        {
                            FinalGrades[i] = RoundedGrades;
                        }
                        //else dont round
                        else { FinalGrades[i] = grades[i]; }
                    }
                }
            }
            //return the final grade to the output
            return FinalGrades;

        }



        // Complete the findMedian function below.

        static int findMedian(int[] arr)

        {
            //to find the MID
            int mid;

            //Print the output of the original array
            Console.Write("Array Element is: ");
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            //sort the array using the bubble sort method
            BubbleSort(arr);

            //print the output of the bubble sort
            Console.Write("Bubble Sorted Array is: ");
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
            Console.Write("The Median is: ");

            //if the lenght of the array%2 is 1 then divide the array lenght by 2 and subtract .5 to get the mid index
            if (arr.Length % 2 == 1)
            {
                mid = (int)((arr.Length / 2) - 0.5);
                return arr[mid];
            }

            //if the lenght of the array%2==0 then compute the mid by finding the two middle numbers
            if (arr.Length % 2 == 0)
            {
                //get the two middle numbers
                int mid1, mid2;
                int GetNumber = arr.Length / 2;
                mid1 = GetNumber - 1;
                mid2 = mid1 + 1;
                //calculate the mid
                mid = (arr[mid1] + arr[mid2]) / 2;
                return mid;
            }
            return 0;

        }



        // Complete the closestNumbers function below.

        static int[] closestNumbers(int[] arr)

        {

            return new int[] { };

        }



        // Complete the dayOfProgrammer function below.

        static string dayOfProgrammer(int year)

        {

            return "";

        }



        //Sort Method

        static int[] BubbleSort(int[] arr) //sorts the array using bubble sort method

        {
            //Team comment: I really like this Bubble Sort. Nice work here. was able to use it for the findMedian #6

            int Subs;

            for (int i = 0; i < arr.Length; i++)

            {

                for (int j = 0; j < arr.Length - 1; j++)

                {

                    if (arr[j] > arr[j + 1])

                    {

                        Subs = arr[j + 1];

                        arr[j + 1] = arr[j];

                        arr[j] = Subs;

                    }

                }

            }

            return arr;



        }







    }

}