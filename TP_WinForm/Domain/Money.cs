using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Money
    {
        public decimal Price { get; set; }
        public Money(decimal price)
        {
            Price = price;
        }

        public static bool operator ==(Money money, object obj)
        {
            try
            {
                decimal num = Convert.ToDecimal(obj);
                return money == num;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool operator !=(Money money, object obj)
        {
            return !(money == obj);
        }
        public static implicit operator Money(string numStr)
        {
            numStr = numStr.Replace("$","").Replace(".","").Trim();
            decimal.TryParse(numStr, out decimal num);
            return new Money(num);
        }
        public static implicit operator Money(int num)
        {       
            return new Money(num);        
        }
        public static implicit operator Money(decimal num)
        {
            return new Money(num);
        }
        public static implicit operator Money(float num)
        {
            return new Money(Convert.ToDecimal(num));
        }
        public static implicit operator decimal(Money money)
        {
            return money.Price;
        }
        public override string ToString()
        {
            return Price.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"));
        }
        public override bool Equals(object obj)
        {
            return this == obj;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
