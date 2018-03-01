using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Dm
{
    class conexion
    {
        SqlConnection cm;
        SqlCommand cmd;
        SqlDataReader dr;

        public conexion()
        {
            try
            {
                cn = new SqlConnection(Data Source = 192.168.100.250; Initial Catalog = Inventario; Persist Security Info = True; User ID = sa; Password = ***********; MultipleActiveResultSets = True)
                cn.open();
                MessageBox.Show("exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no hay" + ex.ToString();
            }

        }
    }
}
