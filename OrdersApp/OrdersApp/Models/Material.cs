using System;
using SQLite;

namespace OrdersApp.Models
{
    [Table("Materials")]
    public class Material
    {
        [PrimaryKey, AutoIncrement]
        public int Code { get; set; }
        public string Name { get; set; }
        public string AdditionalInformation { get; set; }
        public string Category { get; set; }
    }
}