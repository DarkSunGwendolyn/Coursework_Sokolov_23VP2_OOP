using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    [Table("Лекарства")]
    public class Medicine
    {
        [Key]
        [Column("Препарат")]
        public string Name { get; set; }
        [Column("Цена")]
        public decimal Price { get; set; }
        [Column("Болезнь")]
        public string Disease { get; set; }
        [Column("Количество")]
        public int Quantity { get; set; }
        [Column("Производитель")]
        public string Manufacturer { get; set; }


        public Medicine() { }
        public Medicine(string name, decimal price, string disease, int quantity, string manufacturer)
        {
            this.Name = name;
            this.Price = price;
            this.Disease = disease;
            this.Quantity = quantity;
            this.Manufacturer = manufacturer;
        }
    }
}
