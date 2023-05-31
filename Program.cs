namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //mamimili muna ng from san mag cconvert and san i cconvert
            // then saka mag iinput ng i cconvert,
            // then mag cconvert unli until you decide to change whether kung ano cconvert mo, and kung san mo i cconvert. 
            // I can you parameters dito, parang ang nasa parameters whether kung ano yung unang unit and kung saan i cconvert
            
            Converter converter = new Converter();
            
            PrintLengths();    
            Console.WriteLine("Choose a unit to convert from: ");
            var source = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose a unit to convert to: ");
            var target = Convert.ToInt32(Console.ReadLine());
            var sourceunit = ReturnUnit(source);
            var targetunit = ReturnUnit(target);
            Console.WriteLine($"Converting from {sourceunit} to {targetunit}");
            Console.WriteLine("Enter the value you want to convert: ");
            var value = Convert.ToInt32(Console.ReadLine());

            double converted = converter.convert(value, source, target);

            Console.WriteLine($"{value} {sourceunit} is equal to {converted} {targetunit}");
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
