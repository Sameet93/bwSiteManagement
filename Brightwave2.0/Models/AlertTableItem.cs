using System;
namespace Brightwave2.Models
{
    public class AlertTableItem
    {
        public string Site { get; set; }
        public string Coordinates { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public AlertTableItem(string Site, string Coordinates, string Type, string Status)
        {
            this.Site = Site;
            this.Coordinates = Coordinates;
            this.Type = Type;
            this.Status = Status;
        }
    }
}
