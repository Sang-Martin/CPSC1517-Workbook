using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace NorthWindSystem.Entities
{
    //anytime create a table, you need to have a look at database to see the details of properties
    [Table("Region")]
    public class Region
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegionID { get; set; }
        //if your sql is a char or varchar type the nuse string as your datatype
        [Required(ErrorMessage ="Region desription is required")]
        [StringLength(50, ErrorMessage ="Region Description is limited to 50")]
        public string RegionDescription { get; set; }


    }
}
