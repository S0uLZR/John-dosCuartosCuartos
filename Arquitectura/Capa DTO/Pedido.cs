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
    class Pedido
    {
        Arquitectura.Capa_CONN.Conexion c = new Arquitectura.Capa_CONN.Conexion();
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=jonhDosCuartos;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;


        public string insertar(string plato, string precio)
        {
            
            string salida = "Pedido exitoso";
            try
            {
                string pedidoId = DateTime.Now.ToString("yyyyMMddHHmm");
                conn.Open();
                cmd = new SqlCommand("Insert into pedido(pedidoId, plato, precio) values(" + pedidoId + ",'" + plato + "','" + precio + "' )", conn);
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

        public int pedidoRegistrado(string pedidoId)
        {
            conn.Open();
            int contador = 0;

            cmd = new SqlCommand("SELECT * FROM pedido WHERE pedidoId = " + pedidoId + "  ", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                contador++;
            }
            dr.Close();

            conn.Close();
            return contador;

        }


       

    }
}
