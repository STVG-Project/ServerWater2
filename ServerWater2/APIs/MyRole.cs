﻿using ServerWater2.Models;
using Microsoft.EntityFrameworkCore;
namespace ServerWater2.APIs
{
    public class MyRole
    {
        public MyRole()
        {
        }

        public async Task initAsync()
        {
            using (DataContext context = new DataContext())
            {
                List<SqlRole> roles = context.roles!.Where(s => s.code.CompareTo("admin") == 0 && s.isdeleted == false).ToList();
                if (roles.Count <= 0)
                {
                    SqlRole role = new SqlRole();
                    role.ID = DateTime.Now.Ticks;
                    role.code = "admin";
                    role.name = "admin";
                    role.des = "admin";
                    role.isdeleted = false;
                    role.note = "admin";
                    context.roles!.Add(role);
                }

                roles = context.roles!.Where(s => s.code.CompareTo("manager") == 0 && s.isdeleted == false).ToList();
                if (roles.Count <= 0)
                {
                    SqlRole role = new SqlRole();
                    role.ID = DateTime.Now.Ticks;
                    role.code = "manager";
                    role.name = "manager";
                    role.des = "manager";
                    role.isdeleted = false;
                    role.note = "manager";
                    context.roles!.Add(role);
                }

				roles = context.roles!.Where(s => s.code.CompareTo("survey") == 0 && s.isdeleted == false).ToList();
				if (roles.Count <= 0)
				{
					SqlRole role = new SqlRole();
					role.ID = DateTime.Now.Ticks;
					role.code = "survey";
					role.name = "survey";
					role.des = "survey";
					role.isdeleted = false;
					role.note = "survey";
					context.roles!.Add(role);
				}

				roles = context.roles!.Where(s => s.code.CompareTo("receiver") == 0 && s.isdeleted == false).ToList();
				if (roles.Count <= 0)
				{
					SqlRole role = new SqlRole();
					role.ID = DateTime.Now.Ticks;
					role.code = "receiver";
					role.name = "receiver";
					role.des = "receiver";
					role.isdeleted = false;
					role.note = "receiver";
					context.roles!.Add(role);
				}

				roles = context.roles!.Where(s => s.code.CompareTo("staff") == 0 && s.isdeleted == false).ToList();
                if (roles.Count <= 0)
                {
                    SqlRole role = new SqlRole();
                    role.ID = DateTime.Now.Ticks;
                    role.code = "staff";
                    role.name = "staff";
                    role.des = "staff";
                    role.isdeleted = false;
                    role.note = "staff";
                    context.roles!.Add(role);
                }
                int rows = await context.SaveChangesAsync();
            }
        }

		public async Task<bool> createRoleAsync(string code, string name, string des, string node)
		{
			using (DataContext context = new DataContext())
			{
				List<SqlRole> roles = context.roles!.Where<SqlRole>(s => s.code.CompareTo(code) == 0 && s.isdeleted == false).ToList();
				if (roles.Count > 0)
				{
					return false;
				}
				SqlRole mrole = new SqlRole();
				mrole.ID = DateTime.Now.Ticks;
				mrole.code = code;
				mrole.name = name;
				mrole.des = des;
				mrole.isdeleted = false;
				mrole.note = node;
				context.roles!.Add(mrole);

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

		public async Task<bool> editRoleAsync(string code, string name, string des, string node)
		{
			using (DataContext context = new DataContext())
			{
				List<SqlRole> roles = context.roles!.Where<SqlRole>(s => s.code.CompareTo(code) == 0 && s.isdeleted == false).ToList();
				if (roles.Count <= 0)
				{
					return false;
				}
				foreach (SqlRole mrole in roles)
				{
					mrole.name = name;
					mrole.des = des;
					mrole.isdeleted = false;
					mrole.note = node;
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

		public async Task<bool> deleteRoleAsync(string code)
		{
			using (DataContext context = new DataContext())
			{
				List<SqlRole> roles = context.roles!.Where<SqlRole>(s => s.code.CompareTo(code) == 0 && s.isdeleted == false).ToList();
				if (roles.Count <= 0)
				{
					return false;
				}
				foreach (SqlRole mrole in roles)
				{
					mrole.isdeleted = true;
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

		public class ItemRole
		{
			public string code { get; set; } = "";
			public string name { get; set; } = "";
			public string des { get; set; } = "";
			public string note { get; set; } = "";
		}

		public List<ItemRole> getListRole()
		{
			using (DataContext context = new DataContext())
			{
				List<SqlRole> roles = context.roles!.Where<SqlRole>(s => s.isdeleted == false).ToList();
				List<ItemRole> items = new List<ItemRole>();
				foreach (SqlRole role in roles)
				{
					ItemRole item = new ItemRole();
					item.code = role.code;
					item.name = role.name;
					item.des = role.des;
					item.note = role.note;
					items.Add(item);
				}
				return items;
			}
		}

	}
}