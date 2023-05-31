namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            PrintUnits();
        }
        private static void PrintUnits()
        {
            Console.WriteLine("1. Length");
            Console.WriteLine("2. Temperature");
            Console.WriteLine("3. Area");
            Console.WriteLine("4. Volume");
            Console.WriteLine("5. Weight");
            Console.WriteLine("6. Time");
            Console.WriteLine("7. Quit");  
            ChooseUnit();
        }

        private static void ChooseUnit()
        {
            var option = GetOption();
            
            switch (option)
            {
                case 1:
                    Console.WriteLine("Choose a Unit to Convert From");
                    PrintLenghts();
                    OriginUnit();
                    break;
                case 2:
                    Console.WriteLine("Choose a Unit to Convert From");
                    TemperatureUnits();
                    break;
                case 3:
                    Console.WriteLine("Choose a Unit to Convert From");
                    AreaUnits();
                    break;
                case 4:
                    Console.WriteLine("Choose a Unit to Convert From");
                    VolumeUnits();
                    break;
                case 5:
                    Console.WriteLine("Choose a Unit to Convert From");
                    WeightUnits();
                    break;
                case 6:
                    Console.WriteLine("Choose a Unit to Convert From");
                    TimeUnits();
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("Invalid Input Try Again");
                    PrintUnits();
                    break;
            }
        }

       
        private static void PrintLenghts()
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

        private static void OriginUnit()
        {
            Converter converter = new Converter();
             var option = GetOption();
            
            switch (option)
            {
                case 1:
                    Console.WriteLine("Input the value you want to convert: ");
                    var value = Convert.ToInt32(Console.ReadLine());
                    PrintLenghts();
                    System.Console.WriteLine("Choose the Unit to Convert to: ");
                    double convertTo = GetOption();
                    System.Console.WriteLine(convertTo);
                    switch (convertTo)
                    {
                        case 1:
                            break;
                        case 2:
                            double converted = converter.FootToInch(value); 
                            Console.WriteLine($"{value} ft is = {converted} in");
                            Console.WriteLine("Press any key to convert again: ");
                            Console.ReadKey(true);
                            PrintHeader();
                            break;
                        default:
                            break;
                    }
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
                case 6:
                
                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:
                
                    break;
                default:
                    Console.WriteLine("Invalid Input Try Again");
                    PrintUnits();
                    break;
            }
        }


        


        private static int GetOption()
        {
            Console.WriteLine("Input your option here: ");
            var val = Console.ReadLine();
            var option = Convert.ToInt32(val);
            //Console.Clear();
            return option;
        }


        private static void PrintHeader()
        {
            Console.WriteLine("=============================== Unit Converter ===============================");
        }



        private static void TimeUnits()
        {
            throw new NotImplementedException();
        }

        private static void WeightUnits()
        {
            throw new NotImplementedException();
        }

        private static void VolumeUnits()
        {
            throw new NotImplementedException();
        }

        private static void AreaUnits()
        {
            throw new NotImplementedException();
        }

        private static void TemperatureUnits()
        {
            throw new NotImplementedException();
        }        
    }
}
