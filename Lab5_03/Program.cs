﻿using System;

namespace Lab5_03
{
    public class InvalidInput : ApplicationException
    {
        public InvalidInput(): base("Enter a number greater than zero"){}
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            int intCnt;
            int intNum = 0;
            Console.WriteLine("Enter a number :");
            try
            {
                intNum = Convert.ToInt32(Console.ReadLine());
                if (intNum <= 0)
                {
                    throw new InvalidInput();
                }
            }
            catch (InvalidInput objInvalidInput)
            {
                Console.WriteLine(objInvalidInput.Message);
            }
            catch (System.FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            }
            finally
            {
                if (intNum > 0)
                {
                    for (intCnt = 1; intCnt <= 10; intCnt++)
                        Console.WriteLine(intCnt * intNum);
                }
            }
            Console.ReadLine();
        }
    }
}