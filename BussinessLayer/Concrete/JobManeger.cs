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
    public class JobManeger : IJobService
    {
        IJobsDal _jobsDal;

        public JobManeger(IJobsDal jobsDal) 
        {
            _jobsDal= jobsDal;
        }

        public Job TGetById(int id)
        {
            return _jobsDal.GetById(id);
        }

        public void TInsert(Job t)
        {
            _jobsDal.Insert(t);
        }


        public void TDelete(Job t)
        {
            _jobsDal.Delete(t);
        }

        public List<Job> TGetList()
        {
            return _jobsDal.GetList();
        }

        public void TUpdate(Job t)
        {
            _jobsDal.Update(t);
        }
    }
}
