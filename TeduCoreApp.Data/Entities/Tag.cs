using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TeduCoreApp.Infrastructure.SharedKernel;

namespace TeduCoreApp.Data.Entities
{
    //dung Fluent API de chinh TagId cung la varchar50 giong nhu ben ProductTag
    //Dung chung DomainEntity generic nen ko the chinh truc tiep trong DomainEntity
    public class Tag:DomainEntity<string>
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Type { get; set; }
    }
}
