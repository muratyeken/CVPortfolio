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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMedia _socialMedia;

        public SocialMediaManager(ISocialMedia socialMedia)
        {
            _socialMedia = socialMedia;
        }

        public void AddT(SocialMedia t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(SocialMedia t)
        {
            throw new NotImplementedException();
        }

        public SocialMedia GetByIDT(int id)
        {
            throw new NotImplementedException();
        }

        public List<SocialMedia> GetListT()
        {
            return _socialMedia.GetList();
        }

        public void UpdateT(SocialMedia t)
        {
            throw new NotImplementedException();
        }
    }
}
