using System;
using System.Web;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Models
{
    public class util
    {

        public static IList<T> GetAll<T>(DataSet ds)
        {
            IList<T> result = new List<T>();
            for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
            {
                T _t = (T)Activator.CreateInstance(typeof(T));
                PropertyInfo[] propertys = _t.GetType().GetProperties();

                foreach (PropertyInfo pi in propertys)
                {
                    for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                    {
                        // 属性与字段名称一致的进行赋值 
                        if (pi.Name.Equals(ds.Tables[0].Columns[i].ColumnName))
                        {
                            // 数据库NULL值单独处理 
                            if (ds.Tables[0].Rows[j][i] != DBNull.Value)
                                pi.SetValue(_t, ds.Tables[0].Rows[j][i], null);
                            else
                                pi.SetValue(_t, null, null);
                            break;
                        }
                    }
                }
                result.Add(_t);
            }
            return result;
        }

    }

}