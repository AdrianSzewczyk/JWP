using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadB
{
    [Table("Studenci")]
    public class Class1
    {
        [Key]
        public int StudentID {  get; set; }
        [MaxLength(15)]
        [Column("Imie")]
        public string Imię   { get; set; }
        [MaxLength(20)]
        public string Nazwisko { get; set; }
        [Column(TypeName ="NUMERIC(2,1)")]
        public double? Ocena {  get; set; }
        public byte Wiek {  get; set; }

        public override string ToString()
        {
            return $"{Imię} {Nazwisko}";
        }
    }
}
