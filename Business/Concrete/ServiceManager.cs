using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ServiceManager : IServiceService
    {
        IService _service;

        public ServiceManager(IService service)
        {
            _service = service;
        }

        public void AddT(Service t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(Service t)
        {
            throw new NotImplementedException();
        }

        public Service GetByIDT(int id)
        {
            throw new NotImplementedException();
        }

        public List<Service> GetListT()
        {
            return _service.GetList();
        }

        public void UpdateT(Service t)
        {
            throw new NotImplementedException();
        }
    }
}
