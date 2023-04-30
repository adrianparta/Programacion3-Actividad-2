using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CategoryBusiness
    {
        public List<Category> List()
        {
            List<Category> categoryList = new List<Category>();
            AccessData data = new AccessData();
            try
            {
                data.SetQuery(@"SELECT * FROM CATEGORIAS");
                data.ExecuteQuery();

                while (data.Reader.Read())
                {
                    Category categoryAux = new Category()
                    {
                        Id = (int)data.Reader["Id"],
                        Description = (string)data.Reader["Descripcion"],
                    };
                    categoryList.Add(categoryAux);
                }

                return categoryList;
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
