using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
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



namespace ConsoleApp1{
    class Assignment{
        static void Main(string[] args){
            //ApplyForWork();
            //PasswordChecking();
            //VerifyHolidays();
            //ShippingCosts();
            //LeapYear_Checking();
            //CalculateTaxes();
            //TemperatureUnitConverter();
            //CalculaTeheFare();
            //FindingTwinPrimes();
            //DrawTheNumber();
            //TemperatureConverter();
            //Testing();
            //Calculator();
            //PalindromeChecking();
            //InputNumbers();
            //EntryPoint_01();
            //StringManipulation();
            //();




            //employee management system****************************************************************start//
            // EmployeeManagementSystem ems = new EmployeeManagementSystem();
        
            // while (true){
            //     Console.WriteLine("\nEmployee Management System");
            //     Console.WriteLine("1. Add new employee");
            //     Console.WriteLine("2. Remove employee");
            //     Console.WriteLine("3. Update employee information");
            //     Console.WriteLine("4. Display all employees");
            //     Console.WriteLine("5. Exit program");
            //     Console.Write("Choose an operation (1-5): ");

            //     string choice = Console.ReadLine();

            //     switch (choice){
            //         case "1":
            //             Console.Write("Enter employee ID: ");
            //             int id = int.Parse(Console.ReadLine());
            //             Console.Write("Enter employee name: ");
            //             string name = Console.ReadLine();
            //             Console.Write("Enter employee position: ");
            //             string position = Console.ReadLine();
            //             ems.AddEmployee(id, name, position);
            //             break;
            //         case "2":
            //             Console.Write("Enter ID of employee to remove: ");
            //             int removeId = int.Parse(Console.ReadLine());
            //             ems.RemoveEmployee(removeId);
            //             break;
            //         case "3":
            //             Console.Write("Enter ID of employee to update: ");
            //             int updateId = int.Parse(Console.ReadLine());
            //             Console.Write("Enter new name: ");
            //             string newName = Console.ReadLine();
            //             Console.Write("Enter new position: ");
            //             string newPosition = Console.ReadLine();
            //             ems.UpdateEmployee(updateId, newName, newPosition);
            //             break;
            //         case "4":
            //             ems.DisplayAllEmployees();
            //             break;
            //         case "5":
            //             Console.WriteLine("Thank you for using the service");
            //             return;
            //         default:
            //             Console.WriteLine("Please choose menu 1-5 only");
            //             break;
            //     }
            // }
            //employee management system****************************************************************end//



            //inventory management system****************************************************************start//
            Inventory inventory = new Inventory();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nInventory Management System");
                Console.WriteLine("1. Add a new product");
                Console.WriteLine("2. Remove an existing product");
                Console.WriteLine("3. Search for a product by name");
                Console.WriteLine("4. Display all products in the inventory");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Enter product quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        Product newProduct = new Product(name, price, quantity);
                        inventory.AddProduct(newProduct);
                        break;
                    case 2:
                        Console.Write("Enter product name to remove: ");
                        string nameToRemove = Console.ReadLine();
                        inventory.RemoveProduct(nameToRemove);
                        break;
                    case 3:
                        Console.Write("Enter product name to search: ");
                        string nameToSearch = Console.ReadLine();
                        inventory.SearchProduct(nameToSearch);
                        break;
                    case 4:
                        inventory.DisplayAllProducts();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            //inventory management system****************************************************************end//
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





        static void PasswordChecking(){
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
            DateTime[] publicHolidays={
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
            DateTime[] specialHolidays={
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
                Console.WriteLine($"{temperature} C = {fahrenheit} F = {kelvin} K");
            }
            else if (unit == "F"){
                double celsius = (temperature - 32) * 5/9;
                double kelvin = celsius + 273.15;
                Console.WriteLine($"{temperature} F = {celsius} C = {kelvin} K");
            }
            else if (unit == "K"){
                double celcius = temperature - 273.15;
                double fahrenheit = (celcius * 9 / 5) + 32;
                Console.WriteLine($"{temperature} K = {celcius} C = {fahrenheit} F");
            }
            else{
                Console.WriteLine("Invalid temperature unit");
            }
        }





        static void CalculateTheFare(){
            Console.Write("Please enter the number of stations traveled: ");
            int stations = int.Parse(Console.ReadLine());

            int fare = 0;

            if(stations >= 1 && stations <= 3){
                fare = 16;
            }
            else if(stations >= 4 && stations <= 8){
                fare = 23;
            }
            else if(stations >= 9){
                fare = 31;
            }
            else{
                Console. WriteLine("Invalid number of stations");
                return;
            }
            Console.WriteLine($"The fare is: {fare} THB");
        }





        static void FindingTwinPrimes(){
            Console.Write("Please enter the upper limit n: ");
            int n = int.Parse(Console.ReadLine());

            bool IsPrime(int number){
                if(number <= 1) return false;
                if(number == 2) return true;
                if(number % 2 == 0) return false;
                for(int i = 3; i <= Math.Sqrt(number); i += 2){
                    if(number % i == 0) return false;
                }
                return true;
            }
                List<(int,int)> twinPrimes = new List<(int, int)>();
                for(int i = 2; i <= n - 2; i++){
                    if(IsPrime(i) && IsPrime(i+2)){
                        twinPrimes.Add((i, i + 2));
                    }
                }
                Console.WriteLine("The twin primes found are:");
                foreach(var pair in twinPrimes){
                    Console.WriteLine($"({pair.Item1}, {pair.Item2})");
                }
                Console.WriteLine($"The total number of pairs is: {twinPrimes.Count}");
        }





        static void DrawTheNumber(){
            int height = 0;

            while(true){
                Console.Write("Please enter the height of the number 8 (must be greater than 5): ");
                height = int.Parse(Console.ReadLine());

                if(height > 5){
                    break;
                }
                else{
                    Console.WriteLine("Invalid input. Please enter again.");
                }
            }
            for(int i = 0; i < height; i++){
                for(int j = 0; j < height; j++){
                    if(i == 0 || i == height / 2 || i == height - 1 || j == 0 || j == height - 1){
                        Console.Write("*");
                    }
                    else{
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }





        //ASSIGNMENT4 STARTING BELOW





        static void Testing(){
            Console.WriteLine("Enter temperature value:");
            double temperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the unit of the given temperature (C/F/K):");
            char unit = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.WriteLine("Enter the unit to convert to (C/F/K):");
            char targetUnit = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            double convertedTemp = ConvertTemperature(temperature, unit, targetUnit);

            Console.WriteLine($"The converted temperature is {convertedTemp} {targetUnit}");
        }





        static void TemperatureConverter(){
            Console.WriteLine("Enter temperature value:");
            double temperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the unit of the given temperature (C/F/K):");
            char unit = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.WriteLine("Enter the unit to convert to (C/F/K):");
            char targetUnit = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            double convertedTemp = ConvertTemperature(temperature, unit, targetUnit);

            Console.WriteLine($"The converted temperature is {convertedTemp} {targetUnit}");
        }

        static double ConvertTemperature(double temperature, char fromUnit, char toUnit){
            switch (fromUnit){
                case 'C':
                    if (toUnit == 'F')
                        return (temperature * 9 / 5) + 32;
                    else if (toUnit == 'K')
                        return temperature + 273.15;
                    break;
                case 'F':
                    if (toUnit == 'C')
                        return (temperature - 32) * 5 / 9;
                    else if (toUnit == 'K')
                        return (temperature - 32) * 5 / 9 + 273.15;
                    break;
                case 'K':
                    if (toUnit == 'C')
                        return temperature - 273.15;
                    else if (toUnit == 'F')
                        return (temperature - 273.15) * 9 / 5 + 32;
                    break;
            }
            return temperature;
        }





        static void Calculator(){
            Console.WriteLine("Enter first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation (+, -, *, /):");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double result = PerformOperation(num1, num2, operation);
            Console.WriteLine($"The result is: {result}");
        }

        static double PerformOperation(double num1, double num2, char operation){
            switch (operation){
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 != 0)
                        return num1 / num2;
                    else
                        throw new DivideByZeroException("Cannot divide by zero");
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }





        static void PalindromeChecking(){
            Console.Write("Please enter the text: ");
            string input = Console.ReadLine();
        
            if (IsPalindrome(input)){
                Console.WriteLine($"'{input}' Is palindrome");
            }
            else{
                Console.WriteLine($"'{input}' Is not palindrome");
            }
        }

        static bool IsPalindrome(string text){
            text = text.Replace(" ", "").ToLower();
        
            int left = 0;
            int right = text.Length - 1;
        
            while (left < right){
                if (text[left] != text[right]){
                    return false;
                }
                left++;
                right--;
            }
        
            return true;
        }





        static bool IsPrime(int number){
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++){
                if (number % i == 0) return false;
            }
            return true;
        }

        static int[] GetPrimeNumbers(int[] inputArray){
            List<int> primes = new List<int>();
            foreach (int num in inputArray){
                if (IsPrime(num)){
                primes.Add(num);
                }
            }
            return primes.ToArray();
        }

        static void InputNumbers(){
            Console.Write("Please enter the required number of numbers: ");
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++){
                Console.Write($"Enter the numbers at {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[] primeNumbers = GetPrimeNumbers(numbers);

            Console.Write("The specific number found: ");
            foreach (int prime in primeNumbers){
                Console.Write(prime + " ");
            }

            int sumOfPrimes = primeNumbers.Sum();
            Console.Write($"\nSum of prime numbers is: {sumOfPrimes}");
        }
    




        static void EntryPoint_01(){
            Console.Write("Please enter a mathematical equation: ");
            string input = Console.ReadLine();
            // ex.(10 - 5) * 3 + 8 / 2, sqrt(16) + 3 * (4 - 2)^2 / 2, 2^3 + 5^2
        
            try{
                double result = EvaluateExpression(input);
                Console.WriteLine($"Sum: {result}");
            }
            catch (Exception ex){
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        //***debug***//

        static double EvaluateExpression(string expression){
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            double result = double.Parse((string)row["expression"]);
            return result;
        }





        static void StringManipulation(){
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            //กรอกคำอะไรก็ได้ เช่น Manipulation, Lays Original, Nammon409

            Console.WriteLine($"Original string: {input}");
            Console.WriteLine($"Reversed string: {Reverse(input)}");
            Console.WriteLine($"Number of vowels: {CountVowels(input)}");
            Console.WriteLine($"Uppercase string: {ToUpper(input)}");
        }

        static string Reverse(string str){
            return new string(str.Reverse().ToArray());
        }

        static int CountVowels(string str){
            return str.Count(c => "aeiouAEIOU".Contains(c));
        }

        static string ToUpper(string str){
            return str.ToUpper();
        }






    }
    //employee management system****************************************************************//
    class Employee{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(int id, string name, string position){
            Id = id;
            Name = name;
            Position = position;
        }
    }

    class EmployeeManagementSystem{
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(int id, string name, string position){
            employees.Add(new Employee(id, name, position));
            Console.WriteLine("Employee added successfully");
        }

        public void RemoveEmployee(int id){
            Employee employeeToRemove = employees.Find(e => e.Id == id);
            if (employeeToRemove != null){
                employees.Remove(employeeToRemove);
                Console.WriteLine("Employee removed from the system");
            }
            else{
                Console.WriteLine("Employee not found for removal");
            }
        }

        public void UpdateEmployee(int id, string newName, string newPosition){
            Employee employeeToUpdate = employees.Find(e => e.Id == id);
            if (employeeToUpdate != null){
                employeeToUpdate.Name = newName;
                employeeToUpdate.Position = newPosition;
                Console.WriteLine("Employee information updated successfully");
            }
            else{
                Console.WriteLine("Employee not found for update");
            }
        }

        public void DisplayAllEmployees(){
            if (employees.Count == 0){
                Console.WriteLine("No employee data in the system");
                return;
            }

            Console.WriteLine("List of all employees:");
            foreach (var employee in employees){
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Position: {employee.Position}");
            }
        }
    }
    //employee management system****************************************************************//





    class Product{
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity){
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString(){
            return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}";
        }
    }

    class Inventory{
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product){
            products.Add(product);
            Console.WriteLine("Product added successfully.");
        }

        public void RemoveProduct(string name){
            Product productToRemove = products.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (productToRemove != null){
                products.Remove(productToRemove);
                Console.WriteLine("Product removed successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void SearchProduct(string name){
            Product productToFind = products.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (productToFind != null){
                Console.WriteLine(productToFind);
            }
            else{
                Console.WriteLine("Product not found.");
            }
        }

        public void DisplayAllProducts(){
            if (products.Count > 0){
                Console.WriteLine("Products in inventory:");
                foreach (var product in products){
                    Console.WriteLine(product);
                }
            }
            else{
                Console.WriteLine("No products in inventory.");
            }
        }
    }
}