using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Descripción")]
        public string Description { get; set; }
        public override string ToString()
        {
            return Description;
        }
    }
}
