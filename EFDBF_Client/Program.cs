using System;
using EFCOREDBFirst;
using EFCOREDBFirst.Models;


namespace EFDBF_Client
{
    class Program
    {
        static void Main(string[] args)
        {
           using(PracticeDBContext db=new PracticeDBContext())
            {
                Product p = new Product() {  Id="3",Name = "sss", Price = 10000, Stock = 2 ,Gst=12};
                db.Add(p);
                db.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}
