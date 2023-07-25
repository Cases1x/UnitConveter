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
            
            Menu();        
        }

        private static void Menu()
        {
            Converter converter = new Converter();
            var source = 0; 
            var target = 0;
            var sourceunit = "";
            var targetunit = "";

            while(true)
            {
                PrintLengths();    
                source = ChooseUnit(1);
                if(source == 9) break;
                sourceunit = ReturnUnit(source);
                target = ChooseUnit(2);
                if(target == 9) break;
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

                            try
                            {
                                int option = int.Parse(input);
                                if (option == 1)
                                {
                                    PrintLengths();
                                    source = ChooseUnit(option);
                                    if (source == 9) break;
                                    sourceunit = ReturnUnit(source);

                                }
                                if (option == 2)
                                {
                                    PrintLengths();
                                    target = ChooseUnit(option);
                                    if (source == 9) break;
                                    targetunit = ReturnUnit(target);
                                }
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Input! Try Again \n\n");
                                Console.ResetColor();
                            }
                            catch(FormatException ex)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Input! Try Again \n\n");
                                Console.ResetColor();
                            }


                            //int option;
                            //if(int.TryParse(input, out option))
                            //{

                            //    if(option == 1)
                            //    {
                            //        PrintLengths();
                            //        source = ChooseUnit(option);
                            //        if(source == 9) break;
                            //        sourceunit = ReturnUnit(source);

                            //    }if (option == 2)
                            //    {
                            //        PrintLengths();
                            //        target = ChooseUnit(option);
                            //        if(source == 9) break;
                            //        targetunit = ReturnUnit(target);
                            //    }
                            //}else
                            //{
                            //    Console.WriteLine("Invalid Input, Please Input a Number");
                            //}

                        }
                        Console.WriteLine($"Converting from {sourceunit} to {targetunit}");
                    }
                    

                    try
                    {
                        double value = double.Parse(input);
                        double converted = converter.convert(value, source, target);
                        Console.WriteLine($"{value} {sourceunit} is equal to {converted} {targetunit} \n\n");

                    }
                    catch (FormatException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Input! Try Again \n\n");
                        Console.ResetColor();
                    }



                 
                }
            }
        }

        

        private static int ChooseUnit(int option)
        {
            while(true)
            {
                if(option == 1)Console.WriteLine("Choose a unit to convert from: ");
                if(option == 2)Console.WriteLine("Choose a unit to convert to: ");
                
                    var input = Console.ReadLine();
                    if (input == "Q") return 9;
                try
                {
                    int target = int.Parse(input);
                    if (target < 9 && target != 0) return target;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input! Try Again \n\n");
                    Console.ResetColor();
                    continue;
                }catch(FormatException ex) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input! Try Again \n\n");
                    Console.ResetColor();
                }


                //if(int.TryParse(input, out target))
                //{
                //    if(target < 9 && target != 0)
                //    return target;
                //    Console.WriteLine("Invalid Input. Try Again");
                //    continue;
                //}if(input == "Q")
                //{
                //    return 9;
                //}
                //else
                //{
                //Console.WriteLine("Invalid Input. Try Again");
                //}
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
