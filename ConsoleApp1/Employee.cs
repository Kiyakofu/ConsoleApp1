using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp1
{
    internal class Employee
    {
        private string fullName;
        private string birthDate; 
        private string phoneNumber;
        private string workEmail;
        private string position;
        private string jobDescription;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string WorkEmail
        {
            get { return workEmail; }
            set { workEmail = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public string JobDescription
        {
            get { return jobDescription; }
            set { jobDescription = value; }
        }
        public void Input()
        {
            Write("int fullName: ");
            fullName = ReadLine();
            Write("int birthDate: ");
            birthDate = ReadLine();
            Write("int phoneNumber: ");
            phoneNumber = ReadLine();
            Write("int workEmail: ");
            workEmail = ReadLine();
            Write("int position: ");
            position = ReadLine();
            Write("int jobDescription: ");
            jobDescription = ReadLine();
        }

        public void OutputData()
        {
            WriteLine();
            WriteLine($"fullName: {fullName}");
            WriteLine($"birthDate: {birthDate}"); 
            WriteLine($"phoneNumber: {phoneNumber}");
            WriteLine($"workEmail: {workEmail}");
            WriteLine($"position: {position}");
            WriteLine($"jobDescription  : {jobDescription}");
        }
    }
}
