using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Autocomplete
{
    public static class AutoCompleClass
    {
        //metodo para cargar los datos de la bd
        public static DataTable Datos()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());//cadena conexion

            string consulta = "SELECT * FROM PAISES"; //consulta a la tabla paises
            SqlCommand comando = new SqlCommand(consulta,conexion);

            SqlDataAdapter adap = new SqlDataAdapter(comando);

            adap.Fill(dt);
            return dt;
        }

        //metodo para cargar la coleccion de datos para el autocomplete
        public static AutoCompleteStringCollection Autocomplete()
        {
            DataTable dt = Datos();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["pais"]));
            }

            return coleccion;
        }
    }
}
