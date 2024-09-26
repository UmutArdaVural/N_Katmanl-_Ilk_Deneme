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
    public class CatagoryManagercs : ICatagoryService
    {   
        ICatagoryDal _Catagorydal;
         public CatagoryManagercs(ICatagoryDal catagorydal)
        {
            _Catagorydal = catagorydal;
        }

        public Catagory TGetById(int id)
        {
            return _Catagorydal.GetById(id);
        }

        public void TDelete(Catagory t)
        {
            _Catagorydal.Delete(t);

        }       

        public List<Catagory> TGetList()
        {
           return _Catagorydal.GetList();
        }

        public void TInsert(Catagory t)
        {
            _Catagorydal.Insert(t);
        }

        public void TUpdate(Catagory t)
        {
            _Catagorydal.Update(t);
        }
    }
}
