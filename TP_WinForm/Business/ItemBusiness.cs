using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Reflection;

namespace Business
{
    public class ItemBusiness
    {
        public static List<Item> List()
        {
            List<Item> itemList = new List<Item>();
            AccessData data = new AccessData();
            try
            {
                data.SetQuery(@"SELECT 
                                    a.Id
                                    , ISNULL(a.Codigo, 'Sin Asignar') as Codigo
                                    , ISNULL(a.Nombre, 'Sin Asignar') as Nombre
                                    , ISNULL(a.Descripcion, 'Sin Asignar') as Descripcion
                                    , ISNULL(m.Id,-1) as MarcaId
                                    , ISNULL(m.Descripcion,'Sin Asignar') as Marca
                                    , ISNULL(c.Id,-1) as CategoriaId
                                    , ISNULL(c.Descripcion,'Sin Asignar') as Categoria
                                    , ISNULL(a.Precio, 0) as Precio
                                FROM ARTICULOS a
                                LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id
                                LEFT JOIN MARCAS m ON a.IdMarca = m.Id ");
                data.ExecuteQuery();

                while (data.Reader.Read())
                {
                    Item itemAux = new Item
                    {
                        Id = (int)data.Reader["Id"],
                        Code = data.Reader["Codigo"].ToString(),
                        Name = data.Reader["Nombre"].ToString(),
                        Description = (string)data.Reader["Descripcion"],
                        Brand = new Brand
                        {
                            Id = (int)data.Reader["MarcaId"],
                            Description = data.Reader["Marca"].ToString()
                        },
                        Category = new Category
                        {
                            Id = (int)data.Reader["CategoriaId"],
                            Description = data.Reader["Categoria"].ToString()
                        },
                        Price = Convert.ToDecimal(data.Reader["Precio"]),
                        Images = ImageBusiness.List((int)data.Reader["Id"])
                    };

                    itemList.Add(itemAux);
                }

                return itemList;
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
        public static int Add(Item item)
        {
            AccessData data = new AccessData();
            List<SqlParameter> parameters = new List<SqlParameter>();
            try
            {
                string columns, values;
                columns = values = "";
                if (item.Code != null && item.Code != "")
                {
                    columns += "Codigo,";
                    values += $"@Codigo,";
                    parameters.Add(new SqlParameter("@Codigo", item.Code));
                }
                if (item.Name != null && item.Name != "")
                {
                    columns += "Nombre,";
                    values += $"@Nombre,";
                    parameters.Add(new SqlParameter("@Nombre", item.Name));
                }
                if (item.Description != null && item.Description != "")
                {
                    columns += "Descripcion,";
                    values += $"@Descripcion,";
                    parameters.Add(new SqlParameter("@Descripcion", item.Description));
                }
                if (!(item.Price is null))
                {
                    columns += "Precio,";
                    values += $"@Precio,";
                    parameters.Add(new SqlParameter("@Precio", item.Price.Price));
                }
                string query = $@"
                    DECLARE @IdGenerado int

                    INSERT INTO ARTICULOS 
                        ({columns}IdMarca,IdCategoria)
                    VALUES
                        ({values}@BrandId,@CategoryId)
                    SET @IdGenerado = SCOPE_IDENTITY()
                    ";

                parameters.Add(new SqlParameter("@BrandId", item.Brand.Id));
                parameters.Add(new SqlParameter("@CategoryId", item.Category.Id));

                int imagesCount = item.Images is null ? 0 : item.Images.Count;
                if (imagesCount > 0)
                {
                    query += @"
                        INSERT INTO IMAGENES
                            (IdArticulo,ImagenUrl)
                        VALUES 
                        ";
                    for (int i = 0; i < imagesCount; i++)
                    {
                        query += $" (@IdGenerado, @ImagenUrl{i}),";
                        parameters.Add(new SqlParameter($"@ImagenUrl{i}", item.Images[i].Url));
                    }
                    query = query.Remove(query.Length - 1);
                }

                data.SetQuery(query, parameters);

                return data.ExecuteNonQuery();
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
        public static int Remove(Item item)
        {
            AccessData data = new AccessData();
            List<SqlParameter> parameters = new List<SqlParameter>();
            try
            {
                string query = "DELETE FROM ARTICULOS WHERE Id = @Id";
                parameters.Add(new SqlParameter("@Id", item.Id));

                if (item.Images.Count > 0)
                {
                    query += " DELETE FROM IMAGENES WHERE IdArticulo = @Id";
                }

                data.SetQuery(query, parameters);

                return data.ExecuteNonQuery();
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
        public static int Update(Item oldItem, Item updatedItem)
        {          
            AccessData data = new AccessData();
            List<SqlParameter> parameters = new List<SqlParameter>();
            try
            {
                string query = "UPDATE ARTICULOS SET";
                parameters.Add(new SqlParameter("@Id", oldItem.Id));
                if (oldItem.Name != updatedItem.Name)
                {
                    query += " Nombre = @Name,";
                    parameters.Add(new SqlParameter("@Name", updatedItem.Name));
                }
                if (oldItem.Description != updatedItem.Description)
                {
                    query += " Descripcion = @Description,";
                    parameters.Add(new SqlParameter("@Description", updatedItem.Description));
                }
                if (oldItem.Code != updatedItem.Code)
                {
                    query += " Codigo = @Code,";
                    parameters.Add(new SqlParameter("@Code", updatedItem.Code));
                }
                if (oldItem.Category != updatedItem.Category)
                {
                    query += " IdCategoria = @Category,";
                    parameters.Add(new SqlParameter("@Category", updatedItem.Category.Id));
                }
                if (oldItem.Brand != updatedItem.Brand)
                {
                    query += " IdMarca = @Brand,";
                    parameters.Add(new SqlParameter("@Brand", updatedItem.Brand.Id));
                }
                if (oldItem.Price != updatedItem.Price)
                {
                    query += " Precio = @Price,";
                    parameters.Add(new SqlParameter("@Price", updatedItem.Price.Price));
                }
                int imageUpdate = ImageBusiness.UpdateList(oldItem.Images, updatedItem.Images);
                Console.WriteLine(imageUpdate);
                if (query[query.Length - 1] == ',')
                {
                    query = query.Remove(query.Length - 1, 1);               
                }
                else
                {
                    return -1;
                }

                query += " WHERE Id = @Id";                            

                data.SetQuery(query, parameters);

                return data.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return -1;
                throw ex;
            }
            finally
            {
                data.Close();
            }
        }
        public static int GetMaxID()
        {
            AccessData data = new AccessData();
            try
            {
                data.SetQuery(@"SELECT MAX(Id) FROM ARTICULOS");
                data.ExecuteQuery();
                data.Reader.Read();
                return (int)data.Reader.GetInt32(0);
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                data.Close();
            }
        }
    }
}
