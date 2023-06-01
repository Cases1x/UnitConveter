namespace UnitConverter
{
    public class Converter
    {
        public double convert(double value, int source, int target)
        {
            switch (source)
            {
                case 1: // Foot
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
                            return FootToMillimeter(value);
                        default:
                            break;
                    }
                    break;
                case 2: // Inches
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
                            return InchToMillimeter(value);
                        default:
                            break;
                    }
                    break;
                case 3: // Yard
                    switch (target)
                    {
                        case 1:
                            return YardToFoot(value);
                        case 2:
                            return YardToInch(value);
                        case 3:
                            return value;
                        case 4:
                            return YardToMeter(value);
                        case 5:
                            return YardToMile(value);
                        case 6:
                            return YardToKilometer(value);
                        case 7:
                            return YardToCentimeter(value);
                        case 8:
                            return YardToMillimeter(value);
                        default:
                            break;
                    }
                    break;
                case 4: // Meter
                    switch (target)
                    {
                        case 1:
                            return MeterToFoot(value);
                        case 2:
                            return MeterToInch(value);
                        case 3:
                            return MeterToYard(value);
                        case 4:
                            return value;
                        case 5:
                            return MeterToMile(value);
                        case 6:
                            return MeterToKilometer(value);
                        case 7:
                            return MeterToCentimeter(value);
                        case 8:
                            return MeterToMillimeter(value);
                        default:
                            break;
                    }
                    break;
                case 5: // Mile
                    switch (target)
                    {
                        case 1:
                            return MileToFoot(value);
                        case 2:
                            return MileToInch(value);
                        case 3:
                            return MileToYard(value);
                        case 4:
                            return MileToMeter(value);
                        case 5:
                            return value;
                        case 6:
                            return MileToKilometer(value);
                        case 7:
                            return MileToCentimeter(value);
                        case 8:
                            return MileToMillimeter(value);
                        default:
                            break;
                    }
                    break;
                case 6: //Kilometer
                    switch (target)
                    {
                        case 1:
                            return KilometerToFoot(value);
                        case 2:
                            return KilometerToInch(value);
                        case 3:
                            return KilometerToYard(value);
                        case 4:
                            return KilometerToMeter(value);
                        case 5:
                            return KilometerToMile(value);
                        case 6:
                            return value;
                        case 7:
                            return KilometerToCentimeter(value);
                        case 8:
                            return KilometerToMillimeter(value);
                        default:
                            break;
                    }
                    break;
                case 7: //Centimeter
                    switch (target)
                    {
                        case 1:
                            return CentimeterToFoot(value);
                        case 2:
                            return CentimeterToInch(value);
                        case 3:
                            return CentimeterToYard(value);
                        case 4:
                            return CentimeterToMeter(value);
                        case 5:
                            return CentimeterToMile(value);
                        case 6:
                            return CentimeterToKilometer(value);
                        case 7:
                            return value;
                        case 8:
                            return CentimeterToMillimeter(value);
                        default:
                            break;
                    }
                    break;
                case 8: //Milimeter
                    switch (target)
                    {
                        case 1:
                            return MilimeterToFoot(value);
                        case 2:
                            return MilimeterToInch(value);
                        case 3:
                            return MilimeterToYard(value);
                        case 4:
                            return MilimeterToMeter(value);
                        case 5:
                            return MilimeterToMile(value);
                        case 6:
                            return MilimeterToKilometer(value);
                        case 7:
                            return MilimeterToCentimeter(value);
                        case 8:
                            return value;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            return 0;
        }

        private double KilometerToFoot(double value)
        {
            return value * 3281;
        }

        private double KilometerToInch(double value)
        {
            return value * 39370;
        }

        private double KilometerToYard(double value)
        {
            return value * 1094;
        }

        private double KilometerToMeter(double value)
        {
            return value * 1000;
        }

        private double KilometerToMile(double value)
        {
            return value / 1.609;
        }

        private double KilometerToCentimeter(double value)
        {
            return value * 100000;
        }

        private double KilometerToMillimeter(double value)
        {
            return value * 1000000;
        }

        private double CentimeterToFoot(double value)
        {
            return value / 30.48;
        }

        private double CentimeterToInch(double value)
        {
            return value / 2.54;
        }

        private double CentimeterToYard(double value)
        {
            return value / 91.44;
        }

        private double CentimeterToMeter(double value)
        {
            return value / 100;
        }

        private double CentimeterToMile(double value)
        {
            return value / 160900;
        }

        private double CentimeterToKilometer(double value)
        {
            return value / 100000;
        }

        private double CentimeterToMillimeter(double value)
        {
            return value * 10;
        }

        private double MilimeterToFoot(double value)
        {
            return value / 304.8;
        }

        private double MilimeterToInch(double value)
        {
            return value / 25.4;
        }

        private double MilimeterToYard(double value)
        {
            return value / 914.4;
        }

        private double MilimeterToMeter(double value)
        {
            return value / 1000;
        }

        private double MilimeterToMile(double value)
        {
            return value / 1609000;
        }

        private double MilimeterToKilometer(double value)
        {
            return value / 1000000;
        }

        private double MilimeterToCentimeter(double value)
        {
            return value / 10;
        }

        private double MileToFoot(double value)
        {
            return value * 5280;
        }

        private double MileToInch(double value)
        {
            return value * 63360;
        }

        private double MileToYard(double value)
        {
            return value * 1760;
        }

        private double MileToMeter(double value)
        {
            return value * 1609;
        }

        private double MileToKilometer(double value)
        {
            return value * 1.609;
        }

        private double MileToCentimeter(double value)
        {
            return value * 160900;
        }

        private double MileToMillimeter(double value)
        {
            return value * 1609000;
        }

        private double MeterToFoot(double value)
        {
            return value * 3.281;
        }

        private double MeterToInch(double value)
        {
            return value * 39.37;
        }

        private double MeterToYard(double value)
        {
            return value * 1.094;
        }

        private double MeterToMile(double value)
        {
            return value / 1609;
        }

        private double MeterToKilometer(double value)
        {
            return value / 1000;
        }

        private double MeterToCentimeter(double value)
        {
            return value * 100;
        }

        private double MeterToMillimeter(double value)
        {
            return value * 1000;
        }

        private double YardToFoot(double value)
        {
            return value * 3;
        }

        private double YardToInch(double value)
        {
            return value * 36;
        }

        private double YardToMeter(double value)
        {
            return value / 1.094;
        }

        private double YardToMile(double value)
        {
            return value / 1760;
        }

        private double YardToKilometer(double value)
        {
            return value / 1094;
        }

        private double YardToCentimeter(double value)
        {
            return value / 91.44;
        }

        private double YardToMillimeter(double value)
        {
            return value / 914.4;
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

        public double FootToMillimeter(double foot)
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

         public double InchToMillimeter(double inch)
        {
            return inch * 25.4;
        }
        
    }
}