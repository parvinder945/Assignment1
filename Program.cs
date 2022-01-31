﻿/*
 * Name: Sardar Parvinder Singh
 * Date: 01/23/2022
 * Description: Solution for 6 questions mentioned in DIS:Assignment 1
 * Self Reflection: It took me around 10 hrs to complete the assignment, The new concepts that I learned where throwing custom exceptions and
 * It was a great oppurtinity to learn and explore the concepts of strings and arrays.
 */
using System;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //NEXT

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            Console.WriteLine("Q2");
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //NEXT

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();

            //NEXT

            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is: {0}", diagSum);
            Console.WriteLine();

            //NEXT

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0};
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is: {0}", rotated_string);
            Console.WriteLine();

            //NEXT

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            Console.WriteLine("Q6:");
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Resultant string are reversing the prefix: {0}", reversed_string);
            Console.WriteLine();
        }
        /*Self Reflection: It took me around 15 mins to complete the assignment, The new concepts that I learned where throwing custom exceptions and
        * It was a great oppurtinity to learn and explore the concepts of strings*/
        private static string RemoveVowels(string s)
        {
            try
            {
                // write your code here
                int len = s.Length;//get length of string
                if (len > 10000)//user defined exceptions
                {
                    throw new MaxLength(len);
                }
                String final_string = "";
                foreach (char z in s)
                {
                    if (z != 'a' && z != 'e' && z != 'i' && z != 'o' && z != 'u' && z != 'A' && z != 'E' && z != 'I' && z != 'O' && z != 'U')//checking for vowels
                    {
                        final_string = final_string + z;
                    }
                }
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*Self Reflection: It took me around 15 mins to complete the assignment, The new concepts that I learned where throwing custom exceptions and
* It was a great oppurtinity to learn and explore the concepts of strings*/
        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                string b1 = "";
                foreach (string s in bulls_string1)
                {
                    b1 = b1 + s;//concat all the strings in the first array
                }
                string b2 = "";
                foreach (string s in bulls_string2)
                {
                    b2 = b2 + s;//concat all the strings in second array
                }
                if (b1 == b2)//comparing the final strings
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*Self Reflection: It took me around 30 mins to complete the assignment, The new concepts that I learned where throwing custom exceptions and
* It was a great oppurtinity to learn and explore the concepts of strings*/
        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                int len = bull_bucks.Length;//get length of string
                int[] x = bull_bucks;
                if (len > 100)//user defined exceptions
                {
                    throw new MaxLength(len);
                }
                foreach(int i in bull_bucks)//user defined exceptions
                {
                    if(i > 100)
                    {
                        throw new MaxValue(i);
                    }
                }
                int[] sample = new int[len];//creating new array
                int count = 0;
                for (int i = 0; i < len; i++)
                {
                    int n = bull_bucks[i];
                    if (sample.Contains(n))
                    {
                        count = count - n;//substracting repeating elements
                    }
                    else
                    {
                        count = count + n;//adding unique elements
                        sample[i] = bull_bucks[i];//adding all unique elements to the new array
                    }
                }
                return count;
            }
            catch
            {
                throw;
            }
        }
        /*Self Reflection: It took me around 15 mins to complete the assignment, The new concepts that I learned where throwing custom exceptions and
* It was a great oppurtinity to learn and explore the concepts of 2D arrays*/
        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                // write your code here.
                int len = Convert.ToInt32(Math.Sqrt(bulls_grid.Length));//get length/width of the matrix
                int sum = 0;
                for (int i = 0; i < len; i++)//getting the diagnol elements
                {
                    for (int j = 0; j < len; j++)
                    {
                        if (i == j)
                        {
                            sum = sum + bulls_grid[i, j];//adding all left diagnol elements first
                        }
                        else if (i + j == (len - 1))
                        {
                            sum = sum + bulls_grid[i, j];//adding the right diagnol elements later
                        }
                    }
                }
                return sum;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }
        /*Self Reflection: It took me around 15 mins to complete the assignment, The new concepts that I learned where throwing custom exceptions and
* It was a great oppurtinity to learn and explore the concepts of arrays and strings*/
        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                int len = indices.Length;//get length of array
                if (len>100)//user defined exceptions
                {
                    throw new MaxLength(len);
                }
                if (bulls_string.Length != indices.Length)//user defined exceptions
                {
                    throw new NotSame();
                }
                if (bulls_string.Any(char.IsUpper))//user defined exceptions
                {
                    throw new Upper();
                }
                if (indices.Distinct().Count() != indices.Length)//user defined exceptions
                {
                    throw new Repeat();
                }
                foreach(int i in indices)
                {
                    if(i > bulls_string.Length)
                    {
                        throw new OutOflength();
                    }
                }
                string result = "";
                for (int i = 0; i < len; i++)
                {
                    int n = Array.IndexOf(indices, i);//getting index value from indices
                    result = result + bulls_string[n];//adding the char from the bull_string to the final string at the index we got earlier
                }
                return result;//return string
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        /*Self Reflection: It took me around 15 mins to complete the assignment, The new concepts that I learned where throwing custom exceptions and
* It was a great oppurtinity to learn and explore the concepts of strings*/
        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                String prefix_string = "";
                int len = bulls_string6.Length;//get length of string
                if (bulls_string6.Any(char.IsUpper))//user defined exceptions
                {
                    throw new Upper();
                }
                if (len > 250)//user defined exceptions
                {
                    throw new MaxLength(len);
                }
                int n = bulls_string6.IndexOf(ch, 0, len);//getting the index of the input char
                for (int i = n; i >= 0; i--)
                {
                    prefix_string = prefix_string + bulls_string6[i];//concat reverse part of the string
                }
                for (int i = n + 1; i < len; i++)
                {
                    prefix_string = prefix_string + bulls_string6[i];//concat the remaining part of string
                }
                return prefix_string;//return string
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
[Serializable]
public class MaxLength : Exception//user defined exceptions
{
    public MaxLength(int l) {
        Console.WriteLine("Lenght of input string should be less than "+ l);
    }
}
public class MaxValue : Exception//user defined exceptions
{
    public MaxValue(int i)
    {
        Console.WriteLine("Value of the input should not exceed 100, current value: "+ i);
    }
}
public class Upper : Exception//user defined exceptions
{
    public Upper()
    {
        Console.WriteLine("Input string contains Upper case letter");
    }
}

public class Repeat : Exception//user defined exceptions
{
    public Repeat()
    {
        Console.WriteLine("All the values in indices array should be unique");
    }
}

public class NotSame : Exception//user defined exceptions
{
    public NotSame()
    {
        Console.WriteLine("Indices length and bull_string length are not same");
    }
}
public class OutOflength : Exception//user defined exceptions
{
    public OutOflength()
    {
        Console.WriteLine("Value in indices is exceeding the number of characters in the string");
    }
}