using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ef_without_mvc
{
    public class EmployeeDBcontext : DbContext
    {
        public DbSet<Employee> emp { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Map(m =>
                {
                    m.Properties(p => new
                    {
                        p.ID,
                        p.name
                    });
                    m.ToTable("Employees");

                })
                .Map(m =>
                {
                    m.Properties(p => new
                    {
                        p.salary
                    });
                    m.ToTable("Employeessalarydetails");

                });





            //modelBuilder.Entity<Employee>().MapToStoredProcedures
            //    (p => p.Insert(g => g.HasName("insertemployees")
            //                            .Parameter(n => n.name, "EmployeeName")
            //                            .Parameter(n => n.salary, "EmployeeSalary"))
            //           .Update(v => v.HasName("updateemployees")
            //                            .Parameter(n => n.ID, "EmployeeID" )
            //                            .Parameter(n => n.name, "EmployeeName")
            //                            .Parameter(n => n.salary, "EmployeeSalary"))
            //           .Delete(f => f.HasName("deleteemployees")
            //                           .Parameter(n => n.ID, "EmployeeID" ))
            //    );
            base.OnModelCreating(modelBuilder);
        }

    }
}