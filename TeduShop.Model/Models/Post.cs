using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [MaxLength(250)]
        [Required]
        public string Name { set; get; }
        [MaxLength(250)]
        [Required]
        public string Alias { set; get; }
        [Required]
        public int CateGoryID { set; get; }
        [MaxLength(10)]
        public string Image { set; get; }
        public decimal Promotion { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        public virtual IEnumerable<PostTag> PostTags { set; get; }
        [ForeignKey("CateGoryID")]
        public virtual PostCategory PostCategory { set; get; }

    }
}
