using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BrandBusiness
    {
        public List<Brand> List()
        {
            List<Brand> brandList = new List<Brand>();
            AccessData data = new AccessData();
            try
            {
                data.SetQuery(@"SELECT * FROM MARCAS");
                data.ExecuteQuery();

                while (data.Reader.Read())
                {
                    Brand brandAux = new Brand()
                    {
                        Id = (int)data.Reader["Id"],
                        Description = (string)data.Reader["Descripcion"],
                    };
                    brandList.Add(brandAux);
                }

                return brandList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.Close();
            }
        }
    }
}
