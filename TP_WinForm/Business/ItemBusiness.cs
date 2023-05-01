using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

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
                                    , a.Codigo
                                    , a.Nombre
                                    , a.Descripcion
                                    , ISNULL(m.Descripcion,'Sin Asignar') as Marca
                                    , ISNULL(c.Descripcion,'Sin Asignar') as Categoria
                                    , a.Precio 
                                FROM ARTICULOS a
                                LEFT JOIN CATEGORIAS c ON a.IdCategoria = c.Id
                                LEFT JOIN MARCAS m ON a.IdMarca = m.Id ");
                data.ExecuteQuery();

                while (data.Reader.Read())
                {
                    Item itemAux = new Item
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
                string query = @"
                    DECLARE @IdGenerado int

                    INSERT INTO ARTICULOS
                        (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio)
                    VALUES
                        (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@Precio)

                    SET @IdGenerado = SCOPE_IDENTITY()
                    ";
                parameters.Add(new SqlParameter("@Codigo",item.Code));
                parameters.Add(new SqlParameter("@Nombre", item.Name));
                parameters.Add(new SqlParameter("@Descripcion", item.Description));
                parameters.Add(new SqlParameter("@IdMarca", item.Brand.Id));
                parameters.Add(new SqlParameter("@IdCategoria", item.Category.Id));
                parameters.Add(new SqlParameter("@Precio", item.Price));

                int imagesCount = item.Images.Count;
                if(imagesCount > 0)
                {
                    query += @"                    
                        INSERT INTO IMAGENES
                            (IdArticulo,ImagenUrl)
                        VALUES
                        ";
                    for (int i = 0; i < imagesCount; i++)
                    {
                        query += $"(@IdGenerado, @ImagenUrl{i}) ";
                        parameters.Add(new SqlParameter($"@ImagenUrl{i}", item.Images[i].Url));
                    }
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
                string query = "DELETE FROM ARTICULOS WHERE Id = @id";
                parameters.Add(new SqlParameter("@Id", item.Id));

                if (item.Images.Count > 0)
                {
                    query += " DELETE FROM IMAGENES WHERE IdArticulo = @id";
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
        public static int Update(Item itemOld, Item itemUpdated)
        {
            if(itemOld == itemUpdated)    
                return -1;
            
            AccessData data = new AccessData();
            List<SqlParameter> parameters = new List<SqlParameter>();
            try
            {
                string query = "UPDATE ARTICULOS SET";
                if (itemOld.Name != itemUpdated.Name)
                {
                    query += " Nombre = @Name,";
                    parameters.Add(new SqlParameter("@Name", itemUpdated.Name));
                }
                if (itemOld.Description != itemUpdated.Description)
                {
                    query += " Descripcion = @Description,";
                    parameters.Add(new SqlParameter("@Description", itemUpdated.Description));
                }
                if (itemOld.Code != itemUpdated.Code)
                {
                    query += " Codigo = @Code,";
                    parameters.Add(new SqlParameter("@Code", itemUpdated.Code));
                }
                if (itemOld.Category != itemUpdated.Category)
                {
                    query += " IdCategoria = @Category,";
                    parameters.Add(new SqlParameter("@Category", itemUpdated.Category.Id));
                }
                if (itemOld.Brand != itemUpdated.Brand)
                {
                    query += " IdMarca = @Brand,";
                    parameters.Add(new SqlParameter("@Brand", itemUpdated.Brand.Id));
                }
                if (itemOld.Price != itemUpdated.Price)
                {
                    query += " Precio = @Price,";
                    parameters.Add(new SqlParameter("@Price", itemUpdated.Price));
                }

                query = query.Remove(query.Length - 1, 1);               

                query += " WHERE IdArticulo = @id";                            

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
    }
}
