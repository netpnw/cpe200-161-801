using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithEval
{
	class Number : Expr
	{
		string num;

		public override string ToString()
		{
			return num.ToString();
		}

		
		public Number(int n)
		{
			num = OneNumber(n).ToString();
		}

		public Number(Expr e1)
		{
			num = NegateNumber(e1).ToString();
		}

		public int OneNumber(int n)
		{
			return n;
			
		}

		public string NegateNumber(Expr e1)
		{
			string negate = e1.ToString();
			return "-" + negate;
		}
	}
}
