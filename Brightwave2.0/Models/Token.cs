using System;
using SQLite;

namespace Brightwave2.Models
{
    public class Token
    {
        [PrimaryKey]
        public int id { get; set; }
        public string accessToken { get; set; }
        public string errorDescription { get; set; }
        public DateTime expireDate { get; set; }

        public Token() { }
    }
}