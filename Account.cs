﻿using System;
using System.Collections.Generic;
using System.Text;

namespace iBankaBaltija
{
    class Account
    {
        public string Number { get; }
        public string Owner { get; }
        public decimal Balance { get; }
        public DateTime Created { get; }
        public Account(string owner,decimal balance)
        {
            this.Number = "1234";
            this.Owner = owner;
            this.Balance = balance;
            this.Created = DateTime.Now;
        }
    }
}
