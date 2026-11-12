using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{


    public partial class ReporteSistema : Form
    {
        string conexionString = "server=gateway01.us-west-2.prod.aws.tidbcloud.com; " +
                    "port=4000; " +
                    "database=test; " +
                    "uid=hei8zHSzhSzae8C.root; " +
                    "pwd=eQqE7Cvm7XK7g1W6; " +
                    "SslMode=Required; " +
                    "SslCa=G:/Download/isrgrootx1.pem;";

        public ReporteSistema()
        {
            InitializeComponent();
            CargarDatosSistema();
        }

        private void CargarDatosSistema()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string queryDuenos = "SELECT COUNT(*) FROM duenos";
                    using (MySqlCommand cmdDuenos = new MySqlCommand(queryDuenos, conexion))
                    {
                        object resultado = cmdDuenos.ExecuteScalar();
                        txt_dueñosCantidad.Text = resultado != null ? resultado.ToString() : "0";
                    }

                    string queryAnimales = "SELECT COUNT(*) FROM animales";
                    using (MySqlCommand cmdAnimales = new MySqlCommand(queryAnimales, conexion))
                    {
                        object resultado = cmdAnimales.ExecuteScalar();
                        txt_animalesCantidad.Text = resultado != null ? resultado.ToString() : "0";
                    }

                    string queryReportes = "SELECT COUNT(*) FROM Reportes";
                    using (MySqlCommand cmdReportes = new MySqlCommand(queryReportes, conexion))
                    {
                        object resultado = cmdReportes.ExecuteScalar();
                        txt_reportesCantidad.Text = resultado != null ? resultado.ToString() : "0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las métricas del sistema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
