using System;
namespace Brightwave2.Models
{
    public class SiteTableItem
    {
        public string Site { get; set; }
        public string Coordinates { get; set; }
        public string HS { get; set; }
        public string SHS { get; set; }
        public SiteTableItem(string Site, string Coordinates, string HS, string SHS)
        {
            this.Site = Site;
            this.Coordinates = Coordinates;
            this.HS = HS;
            this.SHS = SHS;
        }
    }
}
