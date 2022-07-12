using System;

namespace CS23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool canExitApp = true;
            string userInput;
            int[] array = new int[0];
            
            while (canExitApp)
            {
                Console.Write("Введите числа: ");
                userInput = Console.ReadLine();

                if (userInput == "sum")
                {
                    int amount = 0;

                    for (int i = 0; i < array.Length; i++)
                    {
                        amount += array[i];
                    }

                    Console.WriteLine("Сумма введённых чисел равна " + amount);
                }
                else if (userInput == "exit")
                {
                    canExitApp = false;
                }
                else if (userInput != "sum" && userInput != "exit")
                {
                    int[] addArray = new int[array.Length + 1];

                    for (int i = 0; i < array.Length; i++)
                    {
                        addArray[i] = array[i];
                    }

                    addArray[addArray.LongLength - 1] = Convert.ToInt32(userInput);
                    array = addArray;
                }
            }
        }
    }
}
