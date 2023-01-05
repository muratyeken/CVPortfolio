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
    public class FeatureManager : IGenericService<Feature>
    {
        IFeature _feature;

        public FeatureManager(IFeature feature)
        {
            _feature = feature;
        }

        public void AddT(Feature t)
        {
            _feature.Insert(t);
        }

        public void DeleteT(Feature t)
        {
            _feature.Delete(t);
        }

        public Feature GetByIDT(int id)
        {
            return _feature.GetByID(id);
        }

        public List<Feature> GetListT()
        {
            return _feature.GetList();
        }

        public void UpdateT(Feature t)
        {
            _feature.Update(t);
        }
    }
}
