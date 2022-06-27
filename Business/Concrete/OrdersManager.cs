using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrdersManager : IOrdersService
    {
        private IOrdersDal _ordersDal;
        public OrdersManager(IOrdersDal ordersDal)
        {
            _ordersDal = ordersDal;
        }
    }
}
