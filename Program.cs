namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();
            Welcome();


            var foot = 12.00;
            var inch = 12.00;
            var yard = 12.00;
            var cm = 12.00;
                
            


            Console.WriteLine($"{inch} in = {InchesToFoot(inch):N2} ft" );
            Console.WriteLine($"{foot} ft = {FootToInches(foot):N2} in" );
            Console.WriteLine($"{foot} ft = {FootToYard(foot):N2} yd");
            Console.WriteLine($"{inch} in = {InchToCM(inch):N2} cm");
            Console.WriteLine($"{yard} yd = {YardToFoot(yard):N2} ft");
            Console.WriteLine($"{cm} cm = {CMToInch(cm):N2} in");
        }

        private static void Welcome()
        {
            Console.WriteLine("1. Foot");
            Console.WriteLine("2. Inch");
            Console.WriteLine("3. Yard");
            Console.WriteLine("4. CM");
        }

        private static void Header()
        {
            Console.WriteLine("=============================== Unit Converter ===============================");
        }

        private static double CMToInch(double cm)
        {
            var inch = cm / 2.54;
            return inch;
        }

        private static double YardToFoot(double yard)
        {
            var foot = yard * 3;
            return foot;
        }

        private static double InchToCM(double inch)
        {
            var centimeter = inch * 2.54;
            return centimeter;
        }

        private static double FootToYard(double foot)
        {
            var yard = foot / 3;
            return yard;
        }

        private static double InchesToFoot(double inches)
        {
            var foot = inches / 12;
            return foot;
        }

        private static double FootToInches(double foot)
        {
            var inches = foot * 12;
            return inches;
        }
    }
}


// 1 ft = 12 in
// 3 ft = 1 yd
// 1 in = 2.54 cm
// 1km = 1000m