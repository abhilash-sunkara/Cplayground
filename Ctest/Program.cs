// See https://aka.ms/new-console-template for more information


namespace Ctest
{

    class IfLabs
    {

        static void Main()
        {
            
            Console.WriteLine("Price :: " + GetDisc(100));
            Console.WriteLine("Price :: " + GetDisc(3000));
        }

        public static double GetDisc(double price)
        {
            if(price>2000)
                return price*0.85;
            return price;
        }

        
    }
    
    
}