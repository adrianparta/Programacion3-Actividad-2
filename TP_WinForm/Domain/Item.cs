using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain
{
    public class Item
    {
        private string code;
        private string name;
        private string description;
        private Money price;

        [DisplayName("Id")]
        public int Id { get; set; }
        
        [DisplayName("Código")]
        public string Code
        {
            get { return code; }
            set 
            {
                if (value.Length < 50 && value.Length > 0) code = value;
                else code = "error";
                /*Regex regex = new Regex("^[a-zA-Z]\\d{2}$");
                if (regex.IsMatch(value)) { code = value; }
                else { code = ""; }
                */
            }
        }
        [DisplayName("Nombre")]
        public string Name 
        { 
            get { return name; }
            set { if(value.Length < 50 && value.Length > 0) name = value;
                else name = "error"; 
            }
        }
        [DisplayName("Descripción")]
        public string Description
        {
            get { return description; }
            set
            {
                if (value.Length < 50 && value.Length > 0) description = value;
                else description = "error";
            }
        }
        [DisplayName("Marca")]
        public Brand Brand { get; set; }
        [DisplayName("Categoría")]
        public Category Category { get; set; }
        [DisplayName("Precio")]
        public Money Price
        {
            get { return price; }
            set
            {
                if (value > 0) price = value;
                else price = -1;
            }
        }
    }
}

