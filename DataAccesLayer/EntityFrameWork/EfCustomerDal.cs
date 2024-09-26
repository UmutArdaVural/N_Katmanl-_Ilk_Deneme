using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFrameWork
{
    public class EfCustomerDal : GenericRepostry<Customer>, ICustumerDal
    {
        public List<Customer> GetCustomerListWithJob()
        {
            using (var c = new Context())
            {
                return  c.Customers.Include(x=>x.Job).ToList();

            }
        }
    }
}
