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
    public class ContactManager : IContactService
    {
        IContact _contact;

        public ContactManager(IContact contact)
        {
            _contact = contact;
        }

        public void AddT(Contact t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact GetByIDT(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetListT()
        {
            return _contact.GetList();
        }

        public void UpdateT(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
