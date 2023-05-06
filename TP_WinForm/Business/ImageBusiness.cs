using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

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
                string query = @"SELECT Id, IdArticulo, ImagenUrl 
                                FROM IMAGENES 
                                WHERE IdArticulo = @IdItem";
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

        public static int UpdateList(List<Image> oldImages, List<Image> updatedImages)
        {
            if(oldImages == updatedImages) { return 0; }
            AccessData data = new AccessData();
            List<SqlParameter> parameters = new List<SqlParameter>();
            try
            {
                string query = "";
                bool flagDeleteIteration = true;
                List<Image> lstToAdd = new List<Image>();
                List<Image> lstToDelete = new List<Image>();
                for (int i = 0; i < updatedImages.Count; i++)
                {
                    bool flagExist = false;
                    foreach (Image imageOld in  oldImages)
                    {
                        if (updatedImages[i].Id == imageOld.Id)
                        {
                            flagExist = true;
                            if (updatedImages[i].Url != imageOld.Url)
                            {
                                query += $"UPDATE IMAGES SET ImagenUrl = @UrlUpdate{i} WHERE Id = @Id{i} ";
                                parameters.Add(new SqlParameter($"@UrlUpdate{i}", updatedImages[i].Url));
                                parameters.Add(new SqlParameter($"@Id{i}", updatedImages[i].Id));
                            }
                            break;
                        }
                        if (flagDeleteIteration)
                        {
                            if (!updatedImages.Contains(imageOld))
                            {
                                lstToDelete.Add(imageOld);
                            }
                        }
                    }
                    if (!flagExist)
                    {
                        lstToAdd.Add(updatedImages[i]);
                    }
                    flagDeleteIteration = false;
                }
                if (lstToAdd.Count > 0)
                {
                    query += " INSERT INTO IMAGES (IdArticulo, ImagenUrl) VALUES ";
                    for (int i = 0; i < lstToAdd.Count; i++)
                    {
                        query += $" (@IdArticulo, @UrlInsert{i}),";
                        parameters.Add(new SqlParameter($"@IdArticulo", lstToAdd[i].IdItem));
                        parameters.Add(new SqlParameter($"@UrlInsert{i}", lstToAdd[i].Url));
                    }
                    query = query.Remove(query.Length - 1);
                }

                if (lstToDelete.Count > 0)
                {
                    query += " DELETE FROM IMAGES WHERE ";
                    for (int i = 0; i < lstToDelete.Count; i++)
                    {
                        query += $@"Id = @Id{i} OR ";
                        parameters.Add(new SqlParameter($"@Id{i}", lstToDelete[i].Id));
                    }
                    query = query.Remove(query.Length - 3,3);
                }

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

        public static int UpdateOne(Image image)
        {
            AccessData data = new AccessData();
            try
            {
                string query = @"UPDATE IMAGES SET ImagenUrl = @Url, IdArticulo = @IdItem WHERE Id = @Id";
                List<SqlParameter> parameters = new List<SqlParameter>() { 
                    new SqlParameter("@Id", image.Id),
                    new SqlParameter("@IdItem", image.IdItem),
                    new SqlParameter("@Url", image.Url)
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
        public static int RemoveOne(Image image)
        {
            AccessData data = new AccessData();
            try
            {
                string query = @"DELETE FROM IMAGES WHERE Id = @Id";
                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@Id", image.Id)
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
        public static int RemoveList(int idItem)
        {
            AccessData data = new AccessData();
            try
            {
                string query = @"DELETE FROM IMAGES WHERE IdArticulo = @IdItem";
                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@IdItem", idItem)
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
        public static int AddOne(Image image)
        {
            AccessData data = new AccessData();
            try
            {
                string query = "INSERT INTO IMAGES (IdArticulo, ImagenUrl) VALUES (@IdItem, @Url)";
                List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@IdItem", image.IdItem),
                    new SqlParameter("@Url", image.Url)
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
        public static int AddList(List<Image> images)
        {
            if (images == null) return -1;
            AccessData data = new AccessData();
            try
            {
                string query = "INSERT INTO IMAGES (IdArticulo, ImagenUrl) VALUES ";
                List<SqlParameter> parameters = new List<SqlParameter>();
                if(images.Count > 0)
                {
                    for(int i = 0; i < images.Count; i++)
                    {
                        query += $" (@IdArticulo, @UrlInsert{i}),";
                        parameters.Add(new SqlParameter($"@IdArticulo{i}", images[i].IdItem));
                        parameters.Add(new SqlParameter($"@UrlInsert{i}", images[i].Url));
                    }

                    query = query.Remove(query.Length - 1);
                }
                else
                {
                    return -1;
                }
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
                data.SetQuery(@"SELECT MAX(Id) FROM IMAGENES");
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