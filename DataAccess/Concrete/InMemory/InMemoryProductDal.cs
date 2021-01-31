using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryProductDal : ICarProductDal
    {
        // added List of _cars
        List<Cars> _cars;

        public InMemoryProductDal()
        {

            _cars = new List<Cars>() {

                new Cars { Id = 1 , BrandId = 1 , ColorId = 1 , ModelYear = 2017 , DailyPrice = 150 , Description = "İstanbul"} ,
                new Cars { Id = 2 , BrandId = 2 , ColorId = 4 , ModelYear = 2019 , DailyPrice = 200 , Description = "İzmir"},
                new Cars { Id = 3 , BrandId = 2 , ColorId = 2 , ModelYear = 2020 , DailyPrice = 350 , Description = "Ankara"},
                new Cars { Id = 4 , BrandId = 3 , ColorId = 1 , ModelYear = 2021 , DailyPrice = 450 , Description = "İstanbul"}

            };

        }

        // Cars Added
        public void Add(Cars cars)
        {
            _cars.Add(cars);
        }

        // Cars Deleted
        public void Delete(Cars cars)
        {
            //Gönderdiğim ürün id 'sine sahip listedeki ürünü bul. Linq İşlemi
            Cars carsToDelete = _cars.SingleOrDefault(c => c.Id == c.Id);
            _cars.Remove(carsToDelete);
        }

        // Cars Updated
        public void Update(Cars cars)
        {
            //Gönderdiğim ürün id 'sine sahip listedeki ürünü bul. Linq İşlemi
            Cars carsToUpdate = _cars.SingleOrDefault(c => c.Id == c.Id);

            carsToUpdate.BrandId = cars.BrandId;
            carsToUpdate.ColorId = cars.ColorId;
            carsToUpdate.DailyPrice = cars.DailyPrice;
            carsToUpdate.ModelYear = cars.ModelYear;
            carsToUpdate.Description = cars.Description;
        }

        // Cars List
        public List<Cars> GetAll()
        {
            return _cars;
        }

       
    }
}
