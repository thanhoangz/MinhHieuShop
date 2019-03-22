using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhHieuShop.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(250)]
        public string Code { set; get; }


        [MaxLength(250)]
        public string ValueString { set; get; }

        public int? ValueInt { set; get; }
    }
}
