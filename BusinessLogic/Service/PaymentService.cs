﻿using BusinessLogic.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public class PaymentService:IPaymentService
    {
        public IPaymentRepository paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository)
        {
            this.paymentRepository = paymentRepository;
            
        }
    }
}
