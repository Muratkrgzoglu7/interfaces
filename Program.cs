using System;

namespace İnterfaces._2
{
	class Program
	{
		static void Main(string[] args)
		{
			//CustomerManager customerManager = new CustomerManager();
			//customerManager.Add(new SqlServerCustomerDal());

			ICustomerDal[] customerDals = new ICustomerDal [3] {new OracleICustomerDal(),new SqlServerCustomerDal(),
				
				new MySqlServerCustomerDal()};

			foreach (var customerDal in customerDals )
			{
				customerDal.Deleted();
			}

		}
	}
}
