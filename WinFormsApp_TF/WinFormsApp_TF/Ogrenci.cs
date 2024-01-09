using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_TF
{
    internal class Ogrenci
    {
        [Key]
        public int id {  get; set; }
        public int OkulNo { get; set; }
        public string Ad { get; set;}
        public string Soyad {  get; set; }

    }
}
