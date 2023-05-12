﻿using ServerWater2.Models;

namespace ServerWater2.APIs
{
    public class MyAction
    {
        public async Task initAsync()
        {
            using (DataContext context = new DataContext())
            {
                SqlAction? action = context.actions!.Where(s => s.code.CompareTo("action1") == 0 && s.isdeleted == false).FirstOrDefault();
                if (action == null)
                {
                    SqlAction item = new SqlAction();
                    item.ID = DateTime.Now.Ticks;
                    item.code = "action1";
                    item.name = "Xác nhận";
                    item.des = "Xác nhận";
                    item.isdeleted = false;
                    context.actions!.Add(item);
                }
                action = context.actions!.Where(s => s.code.CompareTo("action2") == 0 && s.isdeleted == false).FirstOrDefault();
                if (action == null)
                {
                    SqlAction item = new SqlAction();
                    item.ID = DateTime.Now.Ticks;
                    item.code = "action2";
                    item.name = "Đã phân công";
                    item.des = "Đã phân công";
                    item.isdeleted = false;
                    context.actions!.Add(item);
                }
                action = context.actions!.Where(s => s.code.CompareTo("action3") == 0 && s.isdeleted == false).FirstOrDefault();
                if (action == null)
                {
                    SqlAction item = new SqlAction();
                    item.ID = DateTime.Now.Ticks;
                    item.code = "action3";
                    item.name = "Đang thực hiện";
                    item.des = "Đang thực hiện";
                    item.isdeleted = false;
                    context.actions!.Add(item);
                }
                action = context.actions!.Where(s => s.code.CompareTo("action4") == 0 && s.isdeleted == false).FirstOrDefault();
                if (action == null)
                {
                    SqlAction item = new SqlAction();
                    item.ID = DateTime.Now.Ticks;
                    item.code = "action4";
                    item.name = "Đã hoàn thành";
                    item.des = "Đã hoàn thành";
                    item.isdeleted = false;
                    context.actions!.Add(item);
                }
                action = context.actions!.Where(s => s.code.CompareTo("action5") == 0 && s.isdeleted == false).FirstOrDefault();
                if (action == null)
                {
                    SqlAction item = new SqlAction();
                    item.ID = DateTime.Now.Ticks;
                    item.code = "action5";
                    item.name = "Đã hủy";
                    item.des = "Đã hủy";
                    item.isdeleted = false;
                    context.actions!.Add(item);
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
                SqlAction? action = context.actions!.Where(s => s.code.CompareTo(code) == 0 && s.isdeleted == false).FirstOrDefault();
                if (action != null)
                {
                    return false;
                }

                SqlAction item = new SqlAction();
                item.ID = DateTime.Now.Ticks;
                item.code = code;
                item.name = name;
                item.des = des;
                context.actions!.Add(item);

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
                SqlAction? action = context.actions!.Where(s => s.code.CompareTo(code) == 0 && s.isdeleted == false).FirstOrDefault();
                if (action == null)
                {
                    return false;
                }
                if (!string.IsNullOrEmpty(des))
                {
                    action.des = des;
                }
                if (!string.IsNullOrEmpty(name))
                {
                    action.name = name;
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
                SqlAction? action = context.actions!.Where(s => s.code.CompareTo(code) == 0 && s.isdeleted == false).FirstOrDefault();
                if (action == null)
                {
                    return false;
                }

                action.isdeleted = true;

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
        public class ItemAction
        {
            public string code { get; set; } = "";
            public string name { get; set; } = "";
            public string des { get; set; } = "";
        }

        public List<ItemAction> getListAction()
        {
            List<ItemAction> list = new List<ItemAction>();
            using (DataContext context = new DataContext())
            {
                List<SqlAction>? actions = context.actions!.Where(s => s.isdeleted == false).ToList();
                if (actions.Count > 0)
                {
                    foreach (SqlAction item in actions)
                    {
                        ItemAction tmp = new ItemAction();
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