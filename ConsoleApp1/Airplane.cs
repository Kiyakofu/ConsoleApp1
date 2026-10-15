using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp1
{
    internal class Airplane
    {
        private string name;
        private string manufacturer;
        private int year;
        private string type;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
       
        public Airplane()
        {
        }
        public Airplane(string name, string manufacturer)
        {
            this.name = name;
            this.manufacturer = manufacturer;
        }
        public Airplane(string name, string manufacturer, int year, string type)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.year = year;
            this.type = type;
        }

        public void Input()
        {
            Write("int name: ");
            name = ReadLine();
            Write("int manufacturer: ");
            manufacturer = ReadLine();
            Write("int year: ");
            year = int.Parse(ReadLine());
            Write("int type: ");
            type = ReadLine();
        }

        public void Input(string inputName, string inputManufacturer, int inputYear, string inputType)
        {
            name = inputName;
            manufacturer = inputManufacturer;
            year = inputYear;
            type = inputType;
        }

        public void Output()
        {
            WriteLine($"name: {name}");
            WriteLine($"manufacturer: {manufacturer}");
            WriteLine($"year: {year}");
            WriteLine($"type: {type}");
        }
    }
}
