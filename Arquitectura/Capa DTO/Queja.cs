using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Arquitectura.Capa_DTO
{
    class Queja
    {
        Arquitectura.Capa_CONN.Conexion c = new Arquitectura.Capa_CONN.Conexion();
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=jonhDosCuartos;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public string insertarQueja(string quejaId, string quejaTxt)
        {

            string salida = "Pedido exitoso";
            try
            {
                
                conn.Open();
                cmd = new SqlCommand("Insert into queja(quejaId, quejaTxt) values(" + quejaId + ",'" + quejaTxt + "' )", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se pudo realizar el pedido: " + ex.ToString();
                conn.Close();
            }

            return salida;



        }



    }
}
