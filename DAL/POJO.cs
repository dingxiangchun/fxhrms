using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;



namespace DAL
{
    public abstract class POJO<T>
    {
        public abstract DataSet GetList(string strWhere);

        public IList<T> GetListAll(string strWhere)
        {
            DataSet ds = GetList(strWhere);
            IList<T> list = util.GetAll<T>(ds);
            return list;
        }
    }
}
