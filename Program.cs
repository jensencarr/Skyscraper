using System.Diagnostics;

namespace Skyscraper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  var floor = 1;

            while (floor != 200)
            {
                if (floor % 10 == 4)
                {
                    Console.WriteLine(floor + 1);
                    floor = floor + 2;
                }
                else if (floor % 100 == 13)
                {
                    Console.WriteLine(floor + 2);
                    floor = floor + 3;
                }
                else
                {
                    Console.WriteLine(floor);
                    floor = floor + 1;
                }
                */





            
                int realFloor = 14;
                int fakeFloor = 0;


            for (int count = 1; count <= realFloor + fakeFloor; count++)
            {

                if (count % 10 == 4)
                {
                    fakeFloor++;
                }
                if (count % 100 == 13)
                {
                    fakeFloor++;
                }

            }
           
             Console.WriteLine("Your floor is: " + (realFloor + fakeFloor));
            


                /*
                int realFloor = 14;                
                int while_fake_floors = 0;
                int while_count = 1;
            while(while_count <= realFloor + while_fake_floors)
            {
                if(while_count % 10 == 4)
                {
                    while_fake_floors++;
                }
                if(while_count % 100 == 13)
                {
                    while_fake_floors++;
                }
            }
                */
            




        }
    }
}