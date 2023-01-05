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
    public class MessageManager : IMessageService
    {
        IMessage _message;

        public MessageManager(IMessage message)
        {
            _message = message;
        }

        public void AddT(Message t)
        {
            _message.Insert(t);
        }

        public void DeleteT(Message t)
        {
            throw new NotImplementedException();
        }

        public Message GetByIDT(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetListT()
        {
            throw new NotImplementedException();
        }

        public void UpdateT(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
