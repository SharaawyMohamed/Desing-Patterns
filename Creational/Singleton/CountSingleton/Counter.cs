using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.CountSingleton
{
	public class Counter
	{
		public  int count { get; set; }
		private static Counter instance= new Counter();
		private Counter() {
			count = 0;
		}

		public void Increment()
		{
			lock (instance){
				instance.count++;
			}
		}

		public void Decrement()
		{
			lock (instance)
			{
				instance.count--;
			}
		}

		public static Counter GetInstance()
		{
			return instance;
		}
	}
}
