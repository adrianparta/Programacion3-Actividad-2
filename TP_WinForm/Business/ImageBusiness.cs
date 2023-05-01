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
    public class ImageBusiness
    {
        public static List<Image> List()
        {
            List<Image> imageList = new List<Image>();
            AccessData data = new AccessData();
            try
            {
                data.SetQuery(@"SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES");
                data.ExecuteQuery();

                while (data.Reader.Read())
                {
                    Image imageAux = new Image()
                    {
                        Id = (int)data.Reader["Id"],
                        IdItem = (int)data.Reader["IdArticulo"],
                        Url = (string)data.Reader["ImagenUrl"],
                    };
                    imageList.Add(imageAux);
                }

                return imageList;
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

        public static List<Image> List(int idItem)
        {
            List<Image> imageList = new List<Image>();
            AccessData data = new AccessData();
            try
            {
                string query = "SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = @IdItem";
                List<SqlParameter> parameters = new List<SqlParameter>() { new SqlParameter("@IdItem", idItem) };
                data.SetQuery(query, parameters);
                data.ExecuteQuery();

                while (data.Reader.Read())
                {
                    Image imageAux = new Image()
                    {
                        Id = (int)data.Reader["Id"],
                        IdItem = (int)data.Reader["IdArticulo"],
                        Url = (string)data.Reader["ImagenUrl"],
                    };
                    imageList.Add(imageAux);
                }

                return imageList;
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