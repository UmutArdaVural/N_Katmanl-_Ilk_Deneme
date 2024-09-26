using BussinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFrameWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class ProductManeger : IProductService
    {
        IProductDal _productDal;
        public EfProductlDal efProductlDal;

        public ProductManeger(IProductDal productDal)
        {
            _productDal = productDal;
        }

      

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void TInsert(Product t)  
        {
            _productDal.Insert(t);        
        }
     

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList(); 
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
