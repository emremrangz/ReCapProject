using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarProductDal
    {
        List<Cars> GetAll();
        void Add(Cars cars);
        void Update(Cars cars);
        void Delete(Cars cars);
    }
}
