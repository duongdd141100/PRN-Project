using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
    public class ScoreDAO
    {
        public DataTable getCountScore(string sql)
        {
            DataProvider data = new DataProvider();
            return data.executeQuery(sql);
        }

        public DataTable getTimeScore(string sql)
        {
            DataProvider data = new DataProvider();
            return data.executeQuery(sql);
        }

        public void updateScore(string sql)
        {
            DataProvider data = new DataProvider();
            data.executeNonQuery(sql);
        }
    }
}
