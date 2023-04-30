using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data;


namespace Business
{
    public class ItemBusiness
    {
        public List<Item> List()
        {
            List<Item> list = new List<Item>();
            AccessData data = new AccessData();
            try
            {
                data.SetQuery(@"SELECT 
                                    a.Id
                                    , a.Codigo
                                    , a.Nombre
                                    , a.Descripcion
                                    , m.Descripcion as Marca
                                    , c.Descripcion as Categoria
                                    , a.Precio 
                                FROM ARTICULOS a
                                INNER JOIN CATEGORIAS c ON  a.IdCategoria = c.Id
                                INNER JOIN MARCAS m ON a.IdMarca = m.Id ");
                data.ExecuteQuery();

                while (data.Reader.Read())
                {
                    Item aux = new Item
                    {
                        Id = (int)data.Reader["Id"],
                        Code = (string)data.Reader["Codigo"],
                        Name = (string)data.Reader["Nombre"],
                        Description = (string)data.Reader["Descripcion"],
                        Brand = new Brand
                        {
                            Description = data.Reader["Marca"].ToString()
                        },
                        Category = new Category
                        {
                            Description = data.Reader["Categoria"].ToString()
                        },
                        Price = Convert.ToDecimal(data.Reader["Precio"])
                    };
                }

                return list;        
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
