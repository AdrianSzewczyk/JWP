using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Klasy
{
    [Serializable]
    public class Student
    {
        public string Nazwisko { get; set; } = "";
        public int Ocena { get; set; }
        public override string ToString()
        {
            return $"{Nazwisko} {Ocena}";
        }
    }
    public class Grupa
    {
        public string Nazwa { get; set; } = "";
        public int LiczbaStudentów{get;}
        public List<Student> Studenci { get; set; }
        public int ŚredniaOcen { get; }
        public void Wyświetl(ListBox l)
        {
            l.Items.Add($"Grupa:{Nazwa}");
            foreach (var s in Studenci)
            {
                l.Items.Add(s);
            }
            l.Items.Add($"Liczba Studentów:{LiczbaStudentów}");
            l.Items.Add($"Średnia Ocen:{ŚredniaOcen}");
        }

    }
}
