using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket_HM101
{
    public abstract class FaceCare : Product
    {
        protected FaceCare(int id, decimal price) : base(id, price) { }
    }
}
