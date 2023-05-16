using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationID { get; set; } // Gidilecek şehrin ID 'si
        public string City { get; set; } // Gidilecek şehir
        public string DayNight { get; set; } // kaç gün kaç gece
        public double Price { get; set; }   // tur ücreti
        public string Image { get; set; } // gidilece kşehrin görseli
        public string Description { get; set; } // turun açıklaması 
        public int Capacity { get; set; }  // tur kaç kişilik
        public bool Status { get; set; }  // 
    }
}
