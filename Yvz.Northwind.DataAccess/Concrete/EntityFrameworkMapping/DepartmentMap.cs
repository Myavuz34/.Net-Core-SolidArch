using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Yvz.Northwind.Entities.Concrete;

namespace Yvz.Northwind.DataAccess.Concrete.EntityFrameworkMapping
{
    public class DepartmentMap
    {
        public DepartmentMap(EntityTypeBuilder<Department> dp)
        {
            dp.HasKey(o => o.ID);
            dp.Property(o => o.Name).HasMaxLength(50);
            dp.Property(o=>o.Description).HasMaxLength(250);
        }
    }
}
