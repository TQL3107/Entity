using System;
using System.Collections.Generic;

namespace Entity.A_DAL.Models
{
    public partial class Car
    {
        public int Id { get; set; }
        public string Carname { get; set; } = null!;
        public string Manufactories { get; set; } = null!;
        public int Price { get; set; }
        public int Amount { get; set; }
    }
}
