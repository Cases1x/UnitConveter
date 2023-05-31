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
            PrintUnit();    
            Console.WriteLine("Choose a unit to convert from: ");
            var sourceunit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose a unit to convert to: ");
            var targetunit = Convert.ToInt32(Console.ReadLine());
            


        }
    }
}
