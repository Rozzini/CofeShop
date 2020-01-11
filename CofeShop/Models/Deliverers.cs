using System;
using System.Collections.Generic;
using System.Text;

namespace CofeShop.Models
{
    class Deliverers
    {
        public int id { get; set; }
        public string name { get; set; }

        public Deliverers(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

    }

    
}
