using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using PizzaPan.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.BusinessLayer.Concrete
{
    public class ReferanceManager : IReferanceService
    {
        private readonly IReferanceDal _referanceDal;

        public ReferanceManager(IReferanceDal referanceDal)
        {
            _referanceDal = referanceDal;
        }

        public void TDelete(Referance t)
        {
            _referanceDal.Delete(t);
        }

        public Referance TGetByID(int id)
        {
            return _referanceDal.GetByID(id);
        }

        public List<Referance> TGetList()
        {
            return _referanceDal.GetList();
        }

        public void TInsert(Referance t)
        {
            _referanceDal.Insert(t);
        }

        public void TUpdate(Referance t)
        {
            _referanceDal.Update(t);
        }
    }
}
