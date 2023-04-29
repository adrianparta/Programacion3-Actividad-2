using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.SqlClient;

namespace Business
{
    class ItemBusiness
    {
        public List<Item> list()
        {
			List<Item>list = new List<Item>();
			AccessData data = new AccessData();
			try
			{

                data.SetQuery("select a.Id, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion as Marca, c.Descripcion as Categoria, a.Precio from articulos a, CATEGORIAS c, MARCAS m WHERE a.IdMarca = m.Id and a.IdCategoria = c.Id",);
				data.ExecuteQuery();

				while (data.Reader.Read())
				{
					Item aux = new Item();
					aux.Id = (int)data.Reader["a.Id"];
					aux.Code = (string)data.Reader["a.Codigo"];
					aux.Name = (string)data.Reader["a.Nombre"];
					aux.Description = (string)data.Reader["a.Description"];
					aux.Brand = new Brand();
					aux.Brand.Description = (string)data.Reader["m.Descripcion"];
					aux.Category = new Category();
					aux.Category.Description = (string)data.Reader["c.Descripcion"];

					list.Add(aux);
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
