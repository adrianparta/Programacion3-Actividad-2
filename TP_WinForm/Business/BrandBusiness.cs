using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BrandBusiness
    {
        public static List<Brand> List()
        {
            List<Brand> brandList = new List<Brand>();
            AccessData data = new AccessData();
            try
            {
                data.SetQuery(@"SELECT Id, Descripcion FROM MARCAS");
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
        public static int Add(Brand brand)
        {
            AccessData data = new AccessData();
            try
            {
                string query =
                    @"IF NOT EXISTS (SELECT 1 FROM MARCAS WHERE Descripcion = @Description)
                    BEGIN
                        INSERT INTO MARCAS (Descripcion) VALUES (@Description)
                    END";

                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@Description", brand.Description)
                };

                data.SetQuery(query, parameters);

                if (data.ExecuteNonQuery() > 0)
                {
                    return data.GetLastId("MARCAS");
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
        public static int Remove(Brand brand)
        {
            AccessData data = new AccessData();
            try
            {
                string query = "DELETE FROM MARCAS WHERE id = @Id";
                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@Id", brand.Id)
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
        public static int Update(Brand brand)
        {
            AccessData data = new AccessData();
            try
            {
                string query = "UPDATE MARCAS SET Descripcion = @Description WHERE id = @Id";
                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@Description", brand.Description),
                    new SqlParameter("@Id", brand.Id)
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
                data.SetQuery(@"SELECT MAX(Id) FROM MARCAS");
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
