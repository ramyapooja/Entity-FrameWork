using System;
using EFProject;
using EFProject.Models;
using EFProject.Context;
namespace EF_Client1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
                Item p = new Item()
                {
                    item_name = "BFS",
                    item_price = 1300
                };
                Order o = new Order()
                {
                    order_date=Convert.ToDateTime("2.10.2020"),
                    delivery_date=Convert.ToDateTime("2.20.2020")
                };
                db.Add(p);
                db.Add(o);
                db.SaveChanges();
            }
        }
    }
}
