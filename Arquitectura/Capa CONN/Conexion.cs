using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Arquitectura.Capa_CONN
{
    public class Conexion
    {

        SqlConnection cn;

        public void ProbarConexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=jonhDosCuartos;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conexion exitosa");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Algo fallo con la conexion de la base de datos: " + ex.ToString());

            }
        }


        public void Conectar()
        {

            cn = new SqlConnection("Data Source=.;Initial Catalog=onBreak;Integrated Security=True");
            cn.Open();
        }

        public void Desconectar()
        {
            cn.Close();
            MessageBox.Show("Conexion cerrada");
        }

    }
}
