using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
//.....
//64020653 Nammon Ongkakas

enum DayOfWeek{
    Sunday,
    Monday,
    Thuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}



namespace ConsoleApp1
{
    class Assignment03 
    {
        static void Main(string[] args){
            //ApplyForWork();
            //PasswordChecking();
            //VerifyHolidays();
            //ShippingCosts();
            //LeapYear_Checking();
            //CalculateTaxes();
        }





        static void ApplyForWork(){
        double age;
        string eq;
        double exp;
        Console.Write("Enter your age: ");
        age = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your eq(Bachelor's degree/Master's degree/Doctoral degree): ");
        eq = Convert.ToString(Console.ReadLine());
        Console.Write("Enter your exp: ");
        exp = Convert.ToDouble(Console.ReadLine());
 
        if((age>=22 && age<=35) && (eq=="Bachelor's degree" || eq=="Master's degree" || eq=="Doctoral degree")){
            Console.WriteLine("Pass");
        }
        else if(((age>=35) && ((eq=="Bachelor's degree" || eq=="Master's degree" || eq=="Doctoral degree") || (exp>=5)))){
            Console.WriteLine("Pass");
        }
        else{
            Console.WriteLine("Not pass");
        }
        }





         static void PasswordChecking()
         {
             string specialCharacters = "!@#$%^&*";
             string pwd;
             Console.Write("Create your Password: ");
             pwd = Convert.ToString(Console.ReadLine());
             int characterCount = pwd.Length;
             int uppercaseCount = pwd.Count(char.IsUpper);
             int lowercaseCount = pwd.Count(char.IsLower);
             int digitCount = pwd.Count(char.IsDigit);
             int specialCharactersCount = pwd.Count(c => specialCharacters.Contains(c));

             if((characterCount >= 8) && (uppercaseCount >= 1) && (lowercaseCount >= 1) && (digitCount >= 1) && (specialCharactersCount >= 1)){
                Console.WriteLine("Password created successfully");
             }
             else if((characterCount < 8) || (uppercaseCount < 1) || (lowercaseCount < 1) || (digitCount < 1) || (specialCharactersCount < 1)){
                Console.WriteLine("Password can not create, Please try again.");
             }
         }





         static void VerifyHolidays(){
            Console.Write("Enter a date to check (YYYY-MM-DD): ");
            string InputDate = Console.ReadLine();
            
            DateTime date;
            if(DateTime.TryParse(InputDate, out date)){
                if(IsPublicHoliday(date)){
                    Console.WriteLine($"{date.ToShortDateString()} is a public holiday.");
                }
                if(IsSpecialHoliday(date)){
                    Console.WriteLine($"{date.ToShortDateString()} is a special holiday.");
                }
                else{
                    Console.WriteLine($"{date.ToShortDateString()} is not a holiday.");
                }
            }
            else{
            Console.WriteLine("Invalid date format.");
            }
        }

        static bool IsPublicHoliday(DateTime date){
            DateTime[] publicHolidays = {
            new DateTime(date.Year, 1, 1),
            new DateTime(date.Year, 7, 4),
            };

            foreach (DateTime holiday in publicHolidays){
                if (date.Date == holiday.Date){
                return true;
                }
            }
            return false;
        }        
        static bool IsSpecialHoliday(DateTime date){
            DateTime[] specialHolidays = {
            new DateTime(date.Year, 10, 22),
            new DateTime(date.Year, 9, 14),
            };

            foreach (DateTime holiday in specialHolidays){
                if (date.Date == holiday.Date){
                return true;
                }
            }
            return false;
        }





        static void ShippingCosts(){
            Console.Write("Please enter the weight of the product (kg.): ");
            double weight = double.Parse(Console.ReadLine());

            double shippingCosts;
            if (weight >= 0 && weight <= 1){
                shippingCosts = 50;
            }
            else if (weight > 1 && weight <= 5){
                shippingCosts = 100;
            }
            else if (weight > 5 && weight <= 10){
                shippingCosts = 200;
            }
            else if (weight > 10){
                shippingCosts = 250;
            }
            else{
                Console.WriteLine("Invalid product weight");
                return;
            }

            Console.WriteLine($"The shipping cost is: {shippingCosts} THB");
         }





         static void LeapYear_Checking(){
            Console.Write("Please enter the year: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeapYear = false;

            if (year % 4 == 0){
                if (year % 100 == 0){
                    if (year % 400 == 0){
                        isLeapYear = true;
                    }
                }
                else{
                    isLeapYear = true;
                }
            }

            if (isLeapYear){
                Console.WriteLine($"{year} is a leap year");
            }
            else{
                Console.WriteLine($"{year} is not a leap year");
            }
         }





         static void CalculateTaxes(){
            Console.Write("Please enter your annual income (THB): ");
            double income = double.Parse(Console.ReadLine());

            double tax = 0;

            if (income > 500000){
                tax = (income - 500000) * 0.15 + (500000 - 300000) * 0.10 + (300000 - 150000) * 0.05;
            }
            else if (income > 300000){
                tax = (income - 300000) * 0.10 + (300000 - 150000) * 0.05;
            }
            else if (income > 150000){
                tax = (income - 150000)* 0.05;
            }

            Console.WriteLine($"The tax to be paid is: {tax} THB");
         }





         static void TemperatureUnitConverter(){
            Console.Write("Please enter the temperature value: ");
            double temperature = double.Parse(Console.ReadLine());

            Console.Write("Please enter the temperature unit (C, F, K): ");
            string unit =  Console.ReadLine().ToUpper();

            if (unit == "C"){
                double fahrenheit = (temperature * 9 / 5) + 32;
                double kelvin = temperature + 273.15;
                Console.WriteLine(${temperature} C)
            }
         }
    }
}