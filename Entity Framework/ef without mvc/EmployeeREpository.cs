using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ef_without_mvc
{
    public class EmployeeREpository
    {
        EmployeeDBcontext edb = new EmployeeDBcontext();
        public List<Employee> getEmployee()
        {
            return edb.emp.ToList();
        }
        public void insert(Employee e)
        {
            edb.emp.Add(e);
            edb.SaveChanges();
        }
        public void update(Employee e)
        {
            Employee ee =  edb.emp.FirstOrDefault(x => x.ID == e.ID);
            ee.name = e.name;
            ee.salary = e.salary;
            edb.SaveChanges();
        }
        public void delete(Employee e)
        {
           Employee ed =  edb.emp.FirstOrDefault(x => x.ID == e.ID);
            edb.emp.Remove(ed);
            edb.SaveChanges();
        }
    }
   
}