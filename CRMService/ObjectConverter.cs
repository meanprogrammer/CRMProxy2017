using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xrm;

namespace CRMService
{
    public static class ObjectConverter
    {
        public static IEnumerable<ProxyEmployee> ConvertToProxyEmployee(IEnumerable<new_employee> emps, OrgContext context)
        {
            List<ProxyEmployee> list = new List<ProxyEmployee>();
            foreach (var emp in emps)
            {
                ProxyEmployee p = new ProxyEmployee();
                p.BirthDate = emp.new_birthdate;
                p.Name = emp.new_name;
                list.Add(p);
            }
            return list;
        }
    }
}