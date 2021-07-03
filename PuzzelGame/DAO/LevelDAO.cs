using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAO
{
    public class LevelDAO
    {
        public DataTable getLevel()
        {
            DataProvider dataProvider = new DataProvider();
            return dataProvider.executeQuery("SELECT level FROM Level");
        }
    }
}
