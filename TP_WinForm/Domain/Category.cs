using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain
{
    public class Category
    {
        private string description;
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Descripción")]
        public string Description { get; set; }
        public override string ToString()
        {
            return Description;
        }
        public static bool operator ==(Category left, Category right)
        {
            if (left is null && right is null) return true;
            if (left is null || right is null) return false;
            return left.Id == right.Id;
        }
        public static bool operator !=(Category left, Category right)
        {
            return !(left == right);
        }
    }
}
