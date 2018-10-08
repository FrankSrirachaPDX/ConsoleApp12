using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main()
        {
            int[] num = { 14, 27, 69, 420, 503 };
            int div = 0;
            int index = 0;
            string holder;
            bool end = false;


            try
            {
                Console.WriteLine("Enter the index for the number in the list.(0-4)");
                holder = Console.ReadLine();
                index = Convert.ToInt32(holder);

                Console.WriteLine("Now enter a whole number to divide by");
                holder = Console.ReadLine();
                div = Convert.ToInt32(holder);



                Console.WriteLine(num[index] + "/" + div + "=" + (num[index] / div));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Don't divide by zero.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();

        }
    }
}
