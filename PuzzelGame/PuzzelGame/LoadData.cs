using BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuzzelGame
{
    public class LoadData
    {
        internal void loadLevel(ComboBox boxLevel)
        {
            LevelBUS levelbus = new LevelBUS();
            DataTable datatable = levelbus.getLevel();
            foreach (DataRow item in datatable.Rows)
            {
                boxLevel.Items.Add(item["level"].ToString());
            }
        }

        internal void loadCountScore(Label labelCount, Label labelTime, int level, string imgPath)
        {
            
            ScoreBUS bus = new ScoreBUS();
            DataTable dataTable = bus.getCountScore(imgPath, level);
            labelCount.Text = dataTable.Rows[0]["SCOREBYCOUNT"].ToString();
            labelTime.Text = dataTable.Rows[0]["SCOREBYTIME"].ToString();
        }

        internal void loadTimeScore(Label labelCount, Label labelTime, int level, string imgPath)
        {
            ScoreBUS bus = new ScoreBUS();
            DataTable dataTable = bus.getTimeScore(imgPath, level);
            labelCount.Text = dataTable.Rows[0]["SCOREBYCOUNT"].ToString();
            labelTime.Text = dataTable.Rows[0]["SCOREBYTIME"].ToString();
        }

        internal void updateScore(string time, string count, int typeid, int level, string scoreType)
        {
            ScoreBUS bus = new ScoreBUS();
            String sql = "update score set scorebycount = '" + count + "', scorebytime = '" + time + "' where typeid = '" + typeid + "' and levelid = '" + level + "'and scoretype = '" + scoreType + "'";
            bus.updateScore(sql);
        }

       
    }
}
