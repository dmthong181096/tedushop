using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public abstract class Auditable :IAuditabe
    {
        public DateTime? CreatedDate { set; get; }
        [MaxLength(250)]
        public string CreatedBy { set; get; }

        public DateTime? UpdateDate { set; get; }
        [MaxLength(250)]
        public string UpdateBy { set; get; }
        [MaxLength(250)]
        public string MetaKeyword { set; get; }
        [MaxLength(250)]
        public string MetaDescription { set; get; }
        public bool Status { set; get; }

    }
}
