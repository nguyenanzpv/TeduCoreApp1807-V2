using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TeduCoreApp.Data.Entities;
using TeduCoreApp.DataEF.Extensions;

namespace TeduCoreApp.DataEF.Configurations
{
    //Dependecncies cua Data cai Microsoft.EntityFrameworkCore.SqlServer
    //Microsoft.EntityFrameworkCore
    //Microsoft.EntityFrameworkCore.Tools
    //Microsoft.Extension.Configurations
    public class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50).IsRequired().HasColumnType("varchar(50)");
        }
    }
}
