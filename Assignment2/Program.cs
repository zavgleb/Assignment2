
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_S19

{

    class Program

    {

        static void Main(string[] args)

        {
            //random variable to be used to generate random numbers for some of the executions
            Random Rand = new Random();

            //formatting
            Console.Write("Group 7 Assignment 2:\n......................... \nMembers:\tRichmond Mensah\n\t\tMoez Farokhniahamedani\n\t\tGleb Zavadskiy");
            Console.Write("\n----------------------------------------------\n");
            Console.WriteLine("Press Enter to Execute next method");
            Console.ReadLine();
            // 1. left rotation

            Console.WriteLine("\nLeft Rotation");
            //specify a random array legnht
            int arrayLenght = Rand.Next(5, 7);
            //create an array to store the array values
            int[] arraylist = new int[arrayLenght];
            //fill the array with random numbers
            for(int i =0;i< arraylist.Length;i++)
            {
                arraylist[i] = Rand.Next(1, 10);
            }
            //Pick a random number to perfrom rotation
            int rotateCount = Rand.Next(1,5);
            //write the random number selected to the screen
            Console.Write("\nPerform {0} Left Rotate\n", rotateCount);
            //print the array element
            Console.Write("Array Element: ");
            //print the unique array element to the array
            foreach(var i in arraylist)//.Distinct().ToArray())
            {
                Console.Write("{0} ", i);
            }

            int[] r = rotLeft(arraylist, rotateCount);
            Console.Write("\nAfter Rotating: ");
            displayArray(r);
            Console.Write("\n----------------------------------------------");
            Console.ReadLine();


            //2.  Maximum toys
            Console.Write("\n----------------------------------------------");
            Console.WriteLine("\nMaximum toys");

            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));
            Console.Write("\n----------------------------------------------");
            Console.ReadLine();


            //3. Balanced sums
            Console.Write("\n----------------------------------------------");
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));
            Console.Write("\n----------------------------------------------");
            Console.ReadLine();


            //4. Missing numbers
            Console.Write("\n----------------------------------------------");
            Console.WriteLine("\nMissing numbers");

            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] r2 = missingNumbers(arr1, brr);

            displayArray(r2);
            Console.Write("\n----------------------------------------------");
            Console.ReadLine();


            // 5. grading students
            Console.Write("\n----------------------------------------------");
            Console.WriteLine("\n\nGrading students");
            //Generate an array lenght
            int arrayMax = Rand.Next(1,20);
            //create a new array and set the lenght to arrayMax variable
            int[] grades = new int[arrayMax];
            //Fill the array with random numbers
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = Rand.Next(0, 100);
            }
            //call the gradestudent method
            int[] r3 = gradingStudents(grades);
            Console.Write("\nFinal Grades: ");
            displayArray(r3);
            Console.Write("\n----------------------------------------------");
            Console.ReadLine();


            // 6. find the median: this method executes the median of a range. if there are two middle numbers then it computes then it takes the two middle numbers and calculate the median
            Console.Write("\n----------------------------------------------");
            Console.WriteLine("\n\nFind the median\n");
            //Generate an array lenght
            int arraysize =Rand.Next(1,11);
            //create a new array and set the lenght to arrayMax variable
            int[] arr2 = new int[arraysize];
            //Fill the array with random numbers
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Rand.Next(0, 100);
            }
            //call the findmedian method
            Console.WriteLine(findMedian(arr2));
            Console.Write("\n----------------------------------------------");
            Console.ReadLine();


            // 7. closest numbers
            Console.Write("\n----------------------------------------------");
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { 5, 4, 3, 2 };

            int[] r4 = closestNumbers(arr3);

            displayArray(r4);
            Console.Write("\n----------------------------------------------");
            Console.ReadLine();

            // 8. Day of programmer
            Console.Write("\n----------------------------------------------");
            Console.WriteLine("\n\nDay of Programmer");
            
            int year = Rand.Next(1700,2700);
            Console.Write("Random Year {0}", year);
            Console.WriteLine(dayOfProgrammer(year));
            Console.Write("\n----------------------------------------------\n");
            Console.WriteLine("End of the Program. Prease Any Key to Exit...");
            Console.ReadLine();

            /*Self Relection:
             * 
             * ***********Please note that the self reflection comment should be removed and added as a comment when submitting the link on canvas.************ 
             * 
             * Richmond: Added as a comment to the assignment submission on canvas as per assignment document
             * 
             * 
             * 
             * 
             * Moez: Algorithmic problem Solving can be applied to all aspects of our research and helps us to solve problems in a more disciplined manner
             * 
             * 
             * 
             * 
             * Gleb: Algorithms increase programs performance and speed. Additionally, it allows programmers to reuse, update, and fix them once written.
             * 
             * 
             * 
             * 
             * */
        }



        static void displayArray(int[] arr)
        {
            Console.WriteLine();

            foreach (int n in arr)

            {
                Console.Write(n + " ");
            }
        }

        //the custom bubble sort method built for sorting the  unsorted arrays is att the very buttom

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

            int[] a_Sorted = BubbleSort(arr);
            List<int> b_Sorted = new List<int>(BubbleSort(brr));
            int lengthA = a_Sorted.Length;
            
            List<int> output = new List<int> { };
            
            for (int i=0; i < lengthA; i++)
            {
                for (int j = 0; j < b_Sorted.ToArray().Length; j++)
                {
                    if (b_Sorted[j] > a_Sorted[i])
                    {
                        break;
                    }
                    else if (a_Sorted[i] == b_Sorted[j])
                    {
                        b_Sorted.RemoveAt(j);
                        break;
                    }
                }
                
            }
            return b_Sorted.ToArray<int>();
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
                mid = ((arr.Length / 2) - 1/2);
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
            int[] SortedArr = BubbleSort(arr); // array must be ordered to reduce the search number
            int arrlength = SortedArr.Length; // finding the array length to control the iteration
            List<int> closeNumbersList = new List<int>(); //define a new list since arrays are immutable
            int sub = Math.Abs( SortedArr[1]-SortedArr[0]); // initial subtraction threshold
            closeNumbersList.Add(SortedArr[0]);
            closeNumbersList.Add(SortedArr[1]);
                  

            for (int i=2; i<arrlength;i++)
            {
                if (Math.Abs(SortedArr[i]-SortedArr[i-1])<sub) //updating smallest distance
                {
                    sub = Math.Abs(SortedArr[i] - SortedArr[i-1]);
                    closeNumbersList.Clear(); // removing existing elements from the list
                    closeNumbersList.Add(SortedArr[i-1]);
                    closeNumbersList.Add(SortedArr[i]);
                }
                else if(Math.Abs(SortedArr[i] - SortedArr[i-1])==sub) // expanding a list of the same distance
                {
                    closeNumbersList.Add(SortedArr[i-1]);
                    closeNumbersList.Add(SortedArr[i]);
                }
            }

            int[] ReturnedValues = closeNumbersList.ToArray(); // converting the list to array

            return ReturnedValues;

        }


        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            //Leap Year Rules:
            //Divisible by 400
            //divisble by 4 and not by 100
            //Output format dd.mm.yyyy
            bool MinYear_Check = year < 1700;
            bool MaxYearCheck = year > 2700;

            if (!MinYear_Check && !MaxYearCheck) //check for invalid year
            {

                int[] leapYeardays = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; //hold leap year days of each month
                int[] NonLeapYear = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; //hold non leap year days of each month
                int sum = 0; //to hold the value of the sum of the first 8 months
                int dayleft; //to hold the value of the days left after subtractinf 256 from the sum variable
                const int programmerday = 256; //constant programmer
                string CalenderDate; //to hold the value for the formated date

                //if leap year then do the following
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 == 0))
                {
                    var First8Months = new ArraySegment<int>(leapYeardays, 0, 8); //take the first 8 element
                    foreach (var day in First8Months)
                    {
                        sum += day; //sum up the first 8 months days
                    }
                    dayleft = (programmerday - sum); //get the remainder of days left by subtracting 256 from the sum variable
                    CalenderDate = dayleft + "." + "09." + year; //output format
                    Console.WriteLine();
                    return CalenderDate.ToString(); //return the ooutput
                }

                //else if its not a leap year then calculate the date
                else
                {
                    var First8Months = new ArraySegment<int>(NonLeapYear, 0, 8); //take the first 8 element
                    foreach (var day in First8Months)
                    {
                        sum += day; //sum up the first 8 months days
                    }
                    dayleft = (programmerday - sum); //get the remainder of days left by subtracting 256 from the sum variable
                    CalenderDate = dayleft + "." + "09." + year; //output format
                    Console.WriteLine();
                    return CalenderDate.ToString(); //return the output
                }

            }
            else //if the year is invalid then
            {
                Console.WriteLine("Input Validation");
               
            }
            return "";
        }

        //Sort Method
        static int[] BubbleSort(int[] arr) //sorts the array using bubble sort method
        {
            //Richmond's Comment: I really like this Bubble Sort. Nice work here. was able to use it for the findMedian #6
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