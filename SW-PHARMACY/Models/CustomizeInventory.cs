using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace SW_PHARMACY.Models { 

    [MetadataType(typeof(InventoryMetaDate))]
    public partial class Inventory
    {
        //add method or add new properties
    }
    public class InventoryMetaDate
    {
        [Display(Name = "ID")]
        public int inventory_id { get; set; }
        [Display(Name = "Name")]
        public string inventory_name { get; set; }
        public Nullable<int> Quantity { get; set; }

    }
}

