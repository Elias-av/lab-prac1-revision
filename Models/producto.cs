using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace lab_prac1.Models
{
   [Table("t_producto")]
    public class producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("categoria")]
        public string Categoria { get; set; }
        [Column("precio")]
        public double Precio {get; set;}
        [Column("descuento")]
        public double Descuento {get; set; }     
        
}
}