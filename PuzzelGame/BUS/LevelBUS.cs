using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAO;

namespace BUS
{
    public class LevelBUS
    {
        public DataTable getLevel()
        {
            LevelDAO levelDAO = new LevelDAO();
            return levelDAO.getLevel();
        }
    }
}
