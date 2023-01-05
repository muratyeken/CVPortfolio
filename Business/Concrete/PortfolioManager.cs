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
    public class PortfolioManager : IPortfolioServices
    {
        IPortfolio _portfolio;

        public PortfolioManager(IPortfolio portfolio)
        {
            _portfolio = portfolio;
        }

        public void AddT(Portfolio t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(Portfolio t)
        {
            throw new NotImplementedException();
        }

        public Portfolio GetByIDT(int id)
        {
            throw new NotImplementedException();
        }

        public List<Portfolio> GetListT()
        {
            return _portfolio.GetList();
        }

        public void UpdateT(Portfolio t)
        {
            throw new NotImplementedException();
        }
    }
}
