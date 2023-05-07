﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Menager:Employee
    {
        public Menager(int id, string firstName, string lastName, string email)
        : base(id, firstName, lastName, email)
        {
            Type = EmployeeType.Menager;
        }

        public override bool IsMenager()
        {
            return true;
        }

        public override bool IsCeo()
        {
            return false;
        }

        public override bool IsRepresentative()
        {
            return false;
        }
    }
}
