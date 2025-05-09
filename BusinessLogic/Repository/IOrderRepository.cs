﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repository
{
    public interface IOrderRepository:IRepository<Order>
    {
        public Task<Order> SaveOrderAsc(Order order);
        public Task<Order> GetOrderByUserIdASC(string userId);
    }
}
