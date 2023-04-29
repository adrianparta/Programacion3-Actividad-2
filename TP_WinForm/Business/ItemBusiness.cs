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
        public List<Item> list()
        {
            List<Item> list = new List<Item>();
            AccessData data = new AccessData();
            try
            {

                data.SetQuery("select a.Id, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion as Marca, c.Descripcion as Categoria, a.Precio from articulos a, CATEGORIAS c, MARCAS m WHERE a.IdMarca = m.Id and a.IdCategoria = c.Id");
                data.ExecuteQuery();

                while (data.Reader.Read())
                {
                    Item aux = new Item();
                    aux.Id = (int)data.Reader["Id"];
                    aux.Code = (string)data.Reader["Codigo"];
                    aux.Name = (string)data.Reader["Nombre"];
                    aux.Description = (string)data.Reader["Descripcion"];
                    aux.Brand = new Brand();
                    aux.Brand.Description = data.Reader["Marca"].ToString();
                    aux.Category = new Category();
                    aux.Category.Description = data.Reader["Categoria"].ToString();
                    aux.Price = Convert.ToDecimal(data.Reader["Precio"]);

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
