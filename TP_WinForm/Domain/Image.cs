using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Image
    {
        public int Id;
        public int IdItem;
        public string Url;

        public static bool operator ==(Image left, Image right)
        {
            return left.Id == right.Id;
        }
        public static bool operator !=(Image left, Image right)
        {
            return !(left == right);
        }
        public override bool Equals(object obj)
        {
            if(obj != null)
            {
                return this == (Image)obj;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
