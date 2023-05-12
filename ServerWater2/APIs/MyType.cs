﻿using ServerWater2.Models;

namespace ServerWater2.APIs
{
    public class MyType
    {
        public MyType()
        {

        }
        public async Task initAsync()
        {
            using (DataContext context = new DataContext())
            {
                SqlType? type = context.types!.Where(s => s.code.CompareTo("type1") == 0).FirstOrDefault();
                if (type == null)
                {
                    SqlType item = new SqlType();
                    item.ID = DateTime.Now.Ticks;
                    item.code = "type1";
                    item.name = "Nước sinh hoạt hộ gia đình";
                    item.des = "Nước sinh hoạt hộ gia đình";
                    item.isdeleted = false;
                    context.types!.Add(item);
                }
                int rows = await context.SaveChangesAsync();
            }
        }

        public async Task<bool> createAsync(string code, string name, string des)
        {
            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(name))
            {
                return false;
            }
            using (DataContext context = new DataContext())
            {
                SqlType? type = context.types!.Where(s => s.isdeleted == false && (s.code.CompareTo(code) == 0)).FirstOrDefault();
                if (type != null)
                {
                    return false;
                }

                SqlType item = new SqlType();
                item.ID = DateTime.Now.Ticks;
                item.code = code;
                item.name = name;
                item.des = des;
                context.types!.Add(item);

                int rows = await context.SaveChangesAsync();
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<bool> editAsync(string code, string name, string des)
        {
            using (DataContext context = new DataContext())
            {
                SqlType? type = context.types!.Where(s => s.isdeleted == false && (s.code.CompareTo(code) == 0)).FirstOrDefault();
                if (type == null)
                {
                    return false;
                }
                if (!string.IsNullOrEmpty(des))
                {
                    type.des = des;
                }
                if (!string.IsNullOrEmpty(name))
                {
                    type.name = name;
                }
               

                int rows = await context.SaveChangesAsync();
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<bool> deleteAsync(string code)
        {
            using (DataContext context = new DataContext())
            {
                SqlType? type = context.types!.Where(s => s.isdeleted == false && (s.code.CompareTo(code) == 0)).FirstOrDefault();
                if (type == null)
                {
                    return false;
                }

                type.isdeleted = true;

                int rows = await context.SaveChangesAsync();
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public class ItemType
        {
            public string code { get; set; } = "";
            public string name { get; set; } = "";
            public string des { get; set; } = "";
        }

        public List<ItemType> getListType()
        {
            List<ItemType> list = new List<ItemType>();
            using (DataContext context = new DataContext())
            {
                List<SqlType>? types = context.types!.Where(s => s.isdeleted == false).ToList();
                if (types.Count > 0)
                {
                    foreach (SqlType item in types)
                    {
                        ItemType tmp = new ItemType();
                        tmp.code = item.code;
                        tmp.name = item.name;
                        tmp.des = item.des;

                        list.Add(tmp);
                    }
                }
                return list;
            }
        }

    }
}