using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithEval
{
	class TwoNumber : Expr
	{
		string num;
		public override string ToString()
		{
			return num.ToString();
		}

		public TwoNumber(int typeoper, Expr e1, Expr e2)
		{
			num = Opernumber(typeoper,e1,e2).ToString();
		}

		public string Opernumber(int typeoper,Expr e1,Expr e2)
		{
			string result = "(" + e1.ToString();
			if (typeoper == 1) result += "+";
			else if (typeoper == 2) result += "-";
			else if (typeoper == 3) result += "*";

			result += e2.ToString() + ")";
			return result;
		}
	}
}
