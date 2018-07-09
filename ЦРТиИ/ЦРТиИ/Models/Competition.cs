using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ЦРТиИ.Models
{
    public class Competition
    {
        public string Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string DescriptionFull { get; set; }
        public string Category { get; set; }
        public string DescriptionShort { get; set; }
        public float Price { get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime EndDate { get; set; }
        public List<string> AgeСategories { get; set; }
        public List<Nomination> Nominations { get; set; }
        public File AttachedFiles { get; set; }
    }

    public class File
    {
        public string Name { get; set; }
        public string Uri { get; set; }
    }
}
