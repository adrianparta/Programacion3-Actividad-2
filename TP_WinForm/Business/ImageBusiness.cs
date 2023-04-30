using Data;
using Domain;
using System;
using System.Collections.Generic;
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
                data.SetQuery(@"SELECT * FROM IMAGENES");
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