﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data;
using System.Text.RegularExpressions;


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
                        Price = Convert.ToDecimal(data.Reader["Precio"])
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
    }
}
