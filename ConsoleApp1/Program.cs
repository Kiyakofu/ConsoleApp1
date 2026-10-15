using System.Numerics;
using static System.Console;
namespace ConsoleApp1
{
    internal class Program
    {
        #region #1
        static int DobutocNum(int start, int end)
        {
            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }
            int product = 1;
            for (int i = start; i <= end; i++)
            {
                product *= i;
            }
            return product;
        }
        #endregion
        #region #3
        static void SortArr(int[] arr, bool a)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    bool needSwap = a ? (arr[j] > arr[j + 1]) : (arr[j] < arr[j + 1]);
                    if (needSwap)
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }   
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region class practic
            //    //Bank bank = new Bank(1000.0);
            //    //bank.CurrentBalance = 2000.0; // setter
            //    //double balance = bank.CurrentBalance; // getter

            //    int num1 = 10;
            //    int num2 = 20;

            //    WriteLine($"Before Swap: num1 = {num1}, num2 = {num2}");
            //    Swap(ref num1, ref num2);
            //    WriteLine($"After Swap: num1 = {num1}, num2 = {num2}");

            //    string input = "15";
            //    if (TryExtractAndDouble(input, out int result))
            //    {
            //        WriteLine($"Extracted and doubled value: {result}");
            //    }
            //    else
            //    {
            //        WriteLine("Failed to extract an integer from the input.");
            //    }
            //}



            //static void Swap(ref int a, ref int b)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp;
            //}

            //static bool TryExtractAndDouble(string input, out int result)
            //{
            //    if (int.TryParse(input, out result))
            //    {
            //        result *= 2;
            //        return true;
            //    }
            //    else
            //    {
            //        result = 0;
            //        return false;
            //    }
            #endregion
            #region practic
            WriteLine("#1");
            WriteLine(DobutocNum(1, 5));

            WriteLine("\n#3");
            int[] myArr = { 5, 2, 8, 1, 9 };
            SortArr(myArr, false);
            foreach (int x in myArr) Write(x + " ");
            WriteLine();
            #endregion
            #region #4
            WriteLine("\n#4");
            City myCity = new City();
            myCity.Input();
            myCity.OutputData();
            myCity.Population = 1000;
            WriteLine($"New Population: {myCity.Population}");
            #endregion

            #region #5
            WriteLine("\n#5");
            Employee emp = new Employee();
            emp.Input();
            emp.OutputData();
            WriteLine($"\ngetter full name: {emp.FullName}");
            emp.Position = "admin";
            WriteLine($"setter : {emp.Position}");
            #endregion

            #region #6
            WriteLine("\n#6");
            Airplane plane1 = new Airplane("Boeing 737", "Boeing");
            Airplane plane2 = new Airplane("Мрія", "Антонов", 1988, "Cargo");

            plane1.Output(); 
            plane2.Output(); 

            Airplane plane3 = new Airplane();
            plane3.Input();
            plane3.Output();
            WriteLine();
            plane3.Input("Airbus A320", "Airbus", 2015, "Passenger");
            plane3.Output();
            #endregion

        }

    }
}
