using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        [MaxLength(256)]
        public String MetaKeyword { get; set; }

        [MaxLength(256)]
        public String MetaDescription { get; set; }

        public DateTime? CreatedDate { get; set; }

        [MaxLength(256)]
        public String CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength(256)]
        public String UpdateBy { get; set; }

        public bool Status { get; set; }

    }
}