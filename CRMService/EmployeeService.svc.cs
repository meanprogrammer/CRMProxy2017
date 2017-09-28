﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Xrm;

namespace CRMService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        OrgContext context = null;

        public void DoWork()
        {
            context = new OrgContext();
        }

        public IEnumerable<new_employee> Employees()
        {
            return context.new_employeeSet.ToList();
        }
    }
}
