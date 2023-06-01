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
            
            PrintLengths();    
            var source = ChooseSource();
            var sourceunit = ReturnUnit(source);
            var target = ChooseTarget();
            var targetunit = ReturnUnit(target);

            Console.WriteLine($"Converting from {sourceunit} to {targetunit}");
            




            while(true)
            {
                Console.WriteLine("Enter the value you want to convert (q to quit): "); 
                var input = Console.ReadLine();
                if(input == "q")
                {
                    break;
                }if(input == "w")
                {
                    while (input != "3")
                    {
                        Console.WriteLine("1. Change the unit to convert from");
                        Console.WriteLine("2. Change the unit to convert to");
                        Console.WriteLine("3. Done");
                        Console.WriteLine("Enter your option: ");
                        input = Console.ReadLine();
                        if(input == "1")
                        {
                            PrintLengths();
                            source = ChooseSource();
                            sourceunit = ReturnUnit(source);
            
                        }if (input == "2")
                        {
                            PrintLengths();
                            target = ChooseTarget();
                            targetunit = ReturnUnit(target);
                        }
                    }
                   Console.WriteLine($"Converting from {sourceunit} to {targetunit}"); 
                }else
                {
                double value = Convert.ToDouble(input);
                double converted = converter.convert(value, source, target);
                Console.WriteLine($"{value} {sourceunit} is equal to {converted} {targetunit}");
                }
                
            }
            
            
            
           
            
           
            

            

            
        }

        private static int ChooseTarget()
        {
            Console.WriteLine("Choose a unit to convert to: ");
            var target = Convert.ToInt32(Console.ReadLine());
            return target;
        }

        private static int ChooseSource()
        {
            Console.WriteLine("Choose a unit to convert from: ");
            var source = Convert.ToInt32(Console.ReadLine());
            return source;
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
        }
    }
}
