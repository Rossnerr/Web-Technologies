using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic.DBModel
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Something has gone wrong!")]
        public string Name { get; set; }

        /*[Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Something has gone wrong!")]
        public string Brand { get; set; }*/

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Something has gone wrong!")]
        public string Picture { get; set; }

        [Required(ErrorMessage = "Somenthing has gone wrong!")]
        public int Price { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
