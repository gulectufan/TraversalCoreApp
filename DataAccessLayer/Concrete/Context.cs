using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        // SQL bağlantı adresi oluşturma
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-UJ16HNFH\\SQLEXPRESS; database=TraversalDB; integrated security=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> About2s { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Feature2> Feature2s { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }


        // entity'leri DBSET formatında çağırma
        // veri tipi DbSet<entity_name> olmalı. Biz About kullanacaz.
        // <About> yazdıktan sonra CTRL + . (Nokta) basılarak bulunduğu konum eklenir.
        // yani -> using EntityLayer.Concrete eklenir.
        // Property ismi entity_name'e -s takılmış hali (Abouts) olur!!
        // bu EntityLayer'daki tüm class'lar için yapılır.
    }
}
