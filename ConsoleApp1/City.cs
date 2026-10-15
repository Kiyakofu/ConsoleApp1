using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp1
{
    internal class City
    {
        private string cityName;
        private string countryName;
        private int population;
        private string phoneCode;
        private string[] districts;
        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }
        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }
        public int Population
        {
            get { return population; }
            set { population = value; }
        }
        public string PhoneCode
        {
            get { return phoneCode; }
            set { phoneCode = value; }
        }
        public string[] Districts
        {
            get { return districts; }
            set { districts = value; }
        }

        public void Input()
        {
            Write("int name city: ");
            cityName = ReadLine();
            Write("int name country: ");
            countryName = ReadLine();
            Write("int population: ");
            population = int.Parse(ReadLine()); 
            Write("int phone code: ");
            phoneCode = ReadLine();
            Write("int number of districts: ");
            int count = int.Parse(ReadLine());
            districts = new string[count]; 
            for (int i = 0; i < count; i++)
            {
                Write($"int name district {i + 1}: ");
                districts[i] = ReadLine();
            }
        }

        public void OutputData()
        {
            WriteLine();
            WriteLine($"cityName: {cityName}");
            WriteLine($"CountryName: {countryName}");
            WriteLine($"Population: {population}");
            WriteLine($"PhoneCode: {phoneCode}");
            Write("Districts: ");
            if (districts != null && districts.Length > 0)
            {
                foreach (string district in districts)
                {
                    Write(district + " ");
                }
                WriteLine();
            }
            else
            {
                WriteLine("no districts");
            }
        }
    }
}
