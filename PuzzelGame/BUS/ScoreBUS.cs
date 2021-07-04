using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS
{
    public class ScoreBUS
    {
        public DataTable getCountScore(string imgPath, int level)
        {
            String sql = "SELECT * FROM SCORE\n" +
                             "INNER JOIN LEVEL\n" +
                             "ON LEVELID = LEVEL.ID\n" +
                             "INNER JOIN TYPE\n" +
                             "ON TYPEID = TYPE.ID\n" +
                             "WHERE LEVEL.ID = '"+level+"'\n" +
                             "AND SCORETYPE = 'Count'";
            if (String.IsNullOrEmpty(imgPath))
            {
                sql += "\n AND TYPEID = 1";
            }
            else
            {
                sql += "\n AND TYPEID = 2";
            }
            ScoreDAO dao = new ScoreDAO();
            return dao.getCountScore(sql);
        }

        public DataTable getTimeScore(string imgPath, int level)
        {
            String sql = "SELECT * FROM SCORE\n" +
                             "INNER JOIN LEVEL\n" +
                             "ON LEVELID = LEVEL.ID\n" +
                             "INNER JOIN TYPE\n" +
                             "ON TYPEID = TYPE.ID\n" +
                             "WHERE LEVEL.ID = '" + level + "'\n" +
                             "AND SCORETYPE = 'Time'";
            if (String.IsNullOrEmpty(imgPath))
            {
                sql += "\n AND TYPEID = 1";
            }
            else
            {
                sql += "\n AND TYPEID = 2";
            }
            ScoreDAO dao = new ScoreDAO();
            return dao.getTimeScore(sql);
        }

        public void updateScore(string sql)
        {
            ScoreDAO dao = new ScoreDAO();
            dao.updateScore(sql);
        }
    }
}
