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
    //annotations are use to assist EntityFramework in the mapping of your class to the sql table
    //annotations for properties are placed BEFORE the property!!!
    [Table("Products")]
    public class Product
    {
        //private data member
        private string _QuantityPerUnit;

        //if you use the same name as the sql attribute for your property name, order of the properties does not matter
        //if your name are different then ORDER is required

        //[Key] single attribute primary identity key
        //[Key, Column(Order=n)] : compout primary key,
        //      required in front of each property of the key 
        //      n represents the PHYSICAL order as found on the sql table
        //[Key, DatabseGenerated(DatabaseGeneratedOption.xxxx)]
        //      where .xxxx -> Identity: primary key on sql is an Identity key (default)
        //                  -> None: primary key is NOT Identity, user entered
        [Key]
        public int ProductID { get; set; }

        //validation annotations (sql constraints and null)

        [Required(ErrorMessage ="Product Name is required")]
        [StringLength(40, ErrorMessage ="Product Name is limited to 40 characters")]
        public string ProductName { get; set; }

        //Foreignkeys
        //these foreign keys are nullable on the sql table (don't forget the ?)
        //you may be temped to use the [ForeignKey] annotation
        //      !!! BUT DONT !!!
        //THE [ForeignKey] annotation is ONLY required if the sql table doesn't use the same name for it's foreign key as it's parent primary key
        //OR
        //if your proterty names do not match the sql attribute name
        public int? SuplierID { get; set; }
        public int? CategoryID { get; set; }

        //you can use fully implemented properties in mapping
        [StringLength(20, ErrorMessage="Quantity per unit is limited to 20 characters")]
        public string QuantityPerUnit
        {
            get { return _QuantityPerUnit; }
            set { _QuantityPerUnit = string.IsNullOrEmpty(value)?null:value; } 
        }
        
        //money requires decimal, if it complains use double
        //UnitPrice is nullable
        //nullable numerics DO NOT need to be fully implemented
        [Range(0.0, double.MaxValue, ErrorMessage ="Unit Price must be (or more) 0.00")]
        public decimal? UnitPrice { get; set; }
        [Range(0, 32767, ErrorMessage = "Unit In Stock must be (or more) 0")]
        public Int16? UnitsInStock { get; set; }
        [Range(0, 32767, ErrorMessage = "Unit On Order must be (or more) 0")]
        public Int16? UnitsOnOrder { get; set; }
        public Int16? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
