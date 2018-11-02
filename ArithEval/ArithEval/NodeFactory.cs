using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithEval
{
    class NodeFactory : INodeFactory
    {
        public Expr Add(Expr e1, Expr e2)
        {
			// TODO
			return new TwoNumber(1, e1, e2);
            throw new NotImplementedException();
        }

        public Expr Multiply(Expr e1, Expr e2)
        {
			// TODO
			return new TwoNumber(3, e1, e2);
			throw new NotImplementedException();
        }

        public Expr Negate(Expr e1)
        {
			// TODO
			return new Number(e1);
            throw new NotImplementedException();
        }

        public Expr Number(int n)
        {
			// TODO
			return new Number(n);
            throw new NotImplementedException();
        }

        public Expr Subtract(Expr e1, Expr e2)
        {
			// TODO
			return new TwoNumber(2, e1, e2);
			throw new NotImplementedException();
        }
    }
}
