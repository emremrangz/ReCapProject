using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarProductManager carProductManager = new CarProductManager(new InMemoryProductDal());

            foreach (var car in carProductManager.GetAll())
            {
                Console.WriteLine(car.BrandId);
            }
        }
    }
}
