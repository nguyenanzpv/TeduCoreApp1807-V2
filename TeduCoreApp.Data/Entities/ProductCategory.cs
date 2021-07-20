using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TeduCoreApp.Data.Enums;
using TeduCoreApp.Data.Interfaces;
using TeduCoreApp.Infrastructure.SharedKernel;

namespace TeduCoreApp.Data.Entities
{
    [Table("ProductCategories")]
    public class ProductCategory : DomainEntity<int>, IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        //dam bao Products ko bi null
        public ProductCategory()
        {
            Products = new List<Product>();
        }

        public ProductCategory(string name, string description, int? parentId, int? homeOrder,
            string image, bool? homeFlag, int sortOrder, Status status, string seoPageTitle, string seoAlias,
            string seoKeywords, string seoDescription)
        {
            Name = name;
            Description = description;
            ParentId = parentId;
            HomeOrder = homeOrder;
            Image = image;
            HomeFlag = homeFlag;
            SortOrder = sortOrder;
            Status = status;
            SeoPageTitle = seoPageTitle;
            SeoAlias = seoAlias;
            SeoKeywords = seoKeywords;
            SeoDescription = seoDescription;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
        public string SeoPageTitle { get ; set ; }
        public string SeoAlias { get ; set ; }
        public string SeoKeywords { get ; set ; }
        public string SeoDescription { get ; set ; }
        public Status Status { get ; set ; }
        public int SortOrder { get ; set ; }
        public DateTime DateCreated { get ; set ; }
        public DateTime DateModified { get ; set ; }

        //khoa ngoai tham chieu toi Product
        //1 product category co nhieu product
        //IEnumerable chi doc
        //ICollection co the chinh sua
        public virtual ICollection<Product> Products { get; set; }
    }
}
