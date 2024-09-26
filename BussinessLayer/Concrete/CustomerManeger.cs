using BussinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CustomerManeger : ICustomerService
    {   
        ICustumerDal _catagoryDal;

        public CustomerManeger( ICustumerDal catagoryDal)
        {
            _catagoryDal = catagoryDal;
        }


        public Customer TGetById(int id)
        {
            return _catagoryDal.GetById(id);
        }

        public void TDelete(Customer t)
        {
            _catagoryDal.Delete(t);
        }

        public List<Customer> TGetList()
        {
           return _catagoryDal.GetList();
        }

        public void TInsert(Customer t)
        {
            _catagoryDal.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            _catagoryDal.Update(t);
        }

        public List<Customer> GetCustomersListWithJob()
        {
            return _catagoryDal.GetCustomerListWithJob();
        }
    }
}
