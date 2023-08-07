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

		public void CustomerAdd(Customer customer)
		{
			_customerdal.Insert(customer);	
		}
	}
}
