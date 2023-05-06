using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CategoryBusiness
    {
        public static List<Category> List()
        {
            List<Category> categoryList = new List<Category>();
            AccessData data = new AccessData();
            try
            {
                data.SetQuery(@"SELECT Id, Descripcion FROM CATEGORIAS");
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
        public static int Add(Category category)
        {
            AccessData data = new AccessData();
            try
            {
                string query =
                    @"IF NOT EXISTS (SELECT 1 FROM CATEGORIAS WHERE Descripcion = @Description)
                    BEGIN
                        INSERT INTO CATEGORIAS (Descripcion) VALUES (@Description)
                    END";

                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@Description", category.Description)
                };

                data.SetQuery(query, parameters);

                if(data.ExecuteNonQuery() > 0)
                {
                    return data.GetLastId("CATEGORIAS");
                }
                else
                {
                    return -1;
                }            
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
        public static int Remove(Category category)
        {
            AccessData data = new AccessData();
            try
            {
                string query = "DELETE FROM CATEGORIAS WHERE id = @Id";
                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@Id", category.Id)
                };
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
        public static int Update(Category category)
        {
            AccessData data = new AccessData();
            try
            {
                string query = "UPDATE CATEGORIAS SET Descripcion = @Description WHERE id = @Id";
                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@Description", category.Description),
                    new SqlParameter("@Id", category.Id)
                };
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
                data.SetQuery(@"SELECT MAX(Id) FROM CATEGORIAS");
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
