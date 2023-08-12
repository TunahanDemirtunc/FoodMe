using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CustomerManager : ICustomerService
	{
		ICustomerDal _customerdal;

		public CustomerManager(ICustomerDal customerdal)
		{
			_customerdal = customerdal;
		}

		public List<Customer> GetCustomerById(int id)
		{
			return _customerdal.GetListAll(x=>x.CustomerID == id);	
		}

		public List<Customer> GetList()
		{
			throw new NotImplementedException();
		}

		public void TAdd(Customer t)
		{
            _customerdal.Insert(t);
        }

		public void TDelete(Customer t)
		{
			throw new NotImplementedException();
		}

		public Customer TGetById(int id)
		{
			return _customerdal.GetByID(id);
		}

		public void TUpdate(Customer t)
		{
			_customerdal.Update(t);	
		}
	}
}
