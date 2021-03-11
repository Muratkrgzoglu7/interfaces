using System;
using System.Collections.Generic;
using System.Text;

namespace İnterfaces._2
{
	class MySqlServerCustomerDal:ICustomerDal
	{
		public void Add()
		{
			Console.WriteLine("MySqlAdded");
		}

		public void Deleted()
		{
			Console.WriteLine("MySql Deleted");
		}

		public void Updated()
		{
			Console.WriteLine("MySql Updated");
		}
	}
}
