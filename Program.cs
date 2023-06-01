namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //mamimili muna ng from san mag cconvert and san i cconvert
            // then saka mag iinput ng i cconvert,
            // then mag cconvert unli until you decide to change whether kung ano cconvert mo, and kung san mo i cconvert. 
            // I can use parameters dito, parang ang nasa parameters whether kung ano yung unang unit and kung saan i cconvert
            
            Converter converter = new Converter();
            int source, target;
            string sourceunit, targetunit;




            PrintLengths();    
            source = ChooseUnit(1);
            sourceunit = ReturnUnit(source);
            target = ChooseUnit(2);
            targetunit = ReturnUnit(target);
            Console.WriteLine($"Converting from {sourceunit} to {targetunit}");
            


            while(true)
            {
                Console.WriteLine("Input 'Q' to Quit");
                Console.WriteLine("Input 'E' to change units");
                Console.WriteLine("Enter the value you want to convert: "); 
                var input = Console.ReadLine();
                if(input == "Q") break;
                if(input == "E")
                {
                    while (input != "3")
                    {
                        Console.WriteLine("1. Change the unit to convert from");
                        Console.WriteLine("2. Change the unit to convert to");
                        Console.WriteLine("3. Done");
                        Console.WriteLine("Enter your option: ");
                        input = Console.ReadLine();
                        if(CheckInt(input))
                        {
                        var option = Convert.ToInt32(input);
                        if(option == 1)
                        {
                            PrintLengths();
                            source = ChooseUnit(option);
                            if(source == 9) break;
                            sourceunit = ReturnUnit(source);
            
                        }if (option == 2)
                        {
                            PrintLengths();
                            target = ChooseUnit(option);
                            if(source == 9) break;
                            targetunit = ReturnUnit(target);
                        }
                        }else
                        {
                            Console.WriteLine("Invalid Input, Please Input a Number");
                        }
                        
                    }
                   Console.WriteLine($"Converting from {sourceunit} to {targetunit}");
                }if(CheckInt(input))
                {
                double value = Convert.ToDouble(input);
                double converted = converter.convert(value, source, target);
                Console.WriteLine($"{value} {sourceunit} is equal to {converted} {targetunit}");
                }else
                {
                    Console.WriteLine("Invalid Input Try Again!!!");
                    continue;
                }
            }            
        }

        private static bool CheckInt(string input)
        {
            int temp;
            return int.TryParse(input, out temp);
        }

        private static int ChooseUnit(int option)
        {
            while(true)
            {
                if(option == 1)
                {   
                    Console.WriteLine("Choose a unit to convert from: ");
                }if(option == 2)
                {
                    Console.WriteLine("Choose a unit to convert to: ");
                }
                    var input = Console.ReadLine();
                if(CheckInt(input))
                {
                    var target = Convert.ToInt32(input);
                    return target;
                }if(input == "Q")
                {
                    return 9;
                }
                else
                {
                Console.WriteLine("Invalid Input. Try Again");
                }
            }
           
            
        }

        

        private static string ReturnUnit(int unit)
        {
         
            switch (unit)
            {
                case 1:
                    return "Foot";
                case 2:
                    return "Inch";
                case 3:
                    return "Yard";
                case 4:
                    return "Meter";
                case 5:
                    return "Mile";
                case 6:
                    return "Kilometer";
                case 7:
                    return "Centimeter";
                case 8:
                    return "Millimeter";
                default:
                    return "";
            }   
        }
        private static void PrintLengths()
        {
            Console.WriteLine("1. Foot");
            Console.WriteLine("2. Inch");
            Console.WriteLine("3. Yard");
            Console.WriteLine("4. Meter");
            Console.WriteLine("5. Mile");
            Console.WriteLine("6. Kilometer");
            Console.WriteLine("7. Centimeter");
            Console.WriteLine("8. Milimeter");
            Console.WriteLine("Q. Quit");
        }
    }
}
