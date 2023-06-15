using System;

namespace benimuzayım  // okul 
{
    class karehesapla // sınıflar
    {
        static void Main(string[] args)
        {

            string[] cars = {"Volvo", "BMW", "Ford", "Mazda","Peugeot","honda"};


            Console.WriteLine("dizinin değişkenleri aşağıda listelenmiştir :" +cars[0] +" "+ cars[1] + " " + cars[2] + " " + cars[3]);
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);

            }

            char[] karakter = { 'a', 'b', 'c', 'x', 'z','a' };

            foreach (var  a in cars)
            {
                Console.WriteLine(a);
            }

            foreach (var item in karakter)
            {
                Console.WriteLine(item);
            }




            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}


            //foreach (string a in cars)
            //{
            //    Console.WriteLine(a);   

            //}
            
            //int[] odev = {1, 9,2, 3,6,12,18};
            //for (int i = 0; i < odev.Length; i++)
            //{
            //    Console.WriteLine(odev[i]);
                
            //}
        }
    }

}