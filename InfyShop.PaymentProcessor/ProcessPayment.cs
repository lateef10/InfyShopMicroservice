﻿using System;

namespace InfyShop.PaymentProcessor
{
    public class ProcessPayment : IProcessPayment
    {
        public bool PaymentProcessor()
        {
            //implement custom logic and get card details etc
            return true;
        }
    }
}
