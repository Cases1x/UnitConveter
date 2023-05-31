namespace UnitConverter
{
    public class Converter
    {
        public double convert(double value, int source, int target)
        {
            switch (source)
            {
                case 1:
                    switch (target)
                    {
                        case 1:
                            return value;
                            
                        case 2:
                            return FootToInch(value);
                        case 3:
                            return FootToYard(value);
                        case 4:
                            return FootToMeter(value);
                        case 5:
                            return FootToMile(value);
                        case 6:
                            return FootToKilometer(value);
                        case 7:
                            return FootToCentimeter(value);
                        case 8:
                            return FootToCentimeter(value);
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (target)
                    {
                        case 1:
                            return InchToFoot(value);
                        case 2:
                            return value;
                        case 3:
                            return InchToYard(value);
                        case 4:
                            return InchToMeter(value);
                        case 5:
                            return InchToMile(value);
                        case 6:
                            return InchToKilometer(value);
                        case 7:
                            return InchToCentimeter(value);
                        case 8:
                            return InchToCentimeter(value);
                        default:
                            break;
                    }
                    break;
                case 3:
                    switch (target)
                    {
                        case 1:
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
                        default:
                            break;
                    }
                    break;
                case 4:
                    switch (target)
                    {
                        case 1:
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
                        default:
                            break;
                    }
                    break;
                case 5:
                    switch (target)
                    {
                        case 1:
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
                        default:
                            break;
                    }
                    break;
                case 6:
                    switch (target)
                    {
                        case 1:
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
                        default:
                            break;
                    }
                    break;
                case 7:
                    switch (target)
                    {
                        case 1:
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
                        default:
                            break;
                    }
                    break;
                case 8:
                    switch (target)
                    {
                        case 1:
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
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            return 0;
        }


        public double FootToInch(double foot)
        {
            return foot * 12;
        }

        public double FootToYard(double foot)
        {
            return foot / 3;
        }

        public double FootToMeter(double foot)
        {
            return foot / 3.281;
        }
        public double FootToMile(double foot)
        {
            return foot / 5280;
        }
        public double FootToKilometer(double foot)
        {
            return foot / 3281;
        }

        public double FootToCentimeter(double foot)
        {
            return foot * 30.48;
        }

        public double FootToMilimeter(double foot)
        {
            return foot * 304.8;
        }

        public double InchToFoot(double inch)
        {
            return inch / 12;
        }
        public double InchToYard(double inch)
        {
            return inch / 36;
        }
        public double InchToMeter(double inch)
        {
            return inch / 39.37;
        }

        public double InchToMile(double inch)
        {
            return inch / 63360;
        }
        public double InchToKilometer(double inch)
        {
            return inch / 39370;
        }

        public double InchToCentimeter(double inch)
        {
            return inch * 2.54;
        }

         public double InchToMilimeter(double inch)
        {
            return inch * 25.4;
        }
        
    }
}













