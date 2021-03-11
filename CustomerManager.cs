using System;
using System.Collections.Generic;
using System.Text;

namespace İnterfaces._2
{
	class CustomerManager
	{
		public void Add(ICustomerDal customerDal)
		{
			customerDal.Add();
		}			
	}
}
