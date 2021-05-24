using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Additional {
    public class Func
    {

        public void ClearDataGrid(DataGridView datagridview)
        {

            int rowsCount = datagridview.Rows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                datagridview.Rows.Remove(datagridview.Rows[0]);
            }
        }
        public void DeleteColumnsAtHeader(DataGridView datagridview)
        {

           
            for (int i = 0; i < datagridview.Columns.Count; i++)
            {
                datagridview.Columns.RemoveAt(0);
            }
        }

    }

}
