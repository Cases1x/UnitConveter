namespace UnitConverter
{
    public class Converter
    {
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

        public double InchtoFoot(double inch)
        {
            return inch / 12;
        }
        public double InchtoYard(double inch)
        {
            return inch / 36;
        }
        public double InchtoMeter(double inch)
        {
            return inch / 39.37;
        }

        public double InchtoMile(double inch)
        {
            return inch / 63360;
        }
        public double InchtoKilometer(double inch)
        {
            return inch / 39370;
        }

        public double InchtoCentimeter(double inch)
        {
            return inch * 2.54;
        }

         public double InchtoMilimeter(double inch)
        {
            return inch * 25.4;
        }
    }
}





/*
Foot
Inch
Yard
Meter
Mile
Kilometer
Centimeter
Milimeter
*/