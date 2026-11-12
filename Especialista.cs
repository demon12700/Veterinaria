using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veterinaria
{
    public partial class Especialista : Form
    {
        public Especialista()
        {
            InitializeComponent();

            cmb_Estado.Items.Add("ACCESIBLE");
            cmb_Estado.Items.Add("INACCESIBLE");

            if (cmb_Estado.Items.Count > 0)
            {
                cmb_Estado.SelectedIndex = 0;
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string conexionString = "server=gateway01.us-west-2.prod.aws.tidbcloud.com; " +
                                    "port=4000; " +
                                    "database=test; " +
                                    "uid=hei8zHSzhSzae8C.root; " +
                                    "pwd=eQqE7Cvm7XK7g1W6; " +
                                    "SslMode=Required; " +
                                    "SslCa=G:/Download/isrgrootx1.pem;";

            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO especialistas (Nombre, especializacion, telefono, Estado) VALUES (@nombre, @especializacion, @telefono, @estado)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txt_Nombre.Text);
                        cmd.Parameters.AddWithValue("@especializacion", txt_Espicializacion.Text);
                        cmd.Parameters.AddWithValue("@telefono", txt_Telefono.Text);
                        cmd.Parameters.AddWithValue("@estado", cmb_Estado.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Especialista agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el especialista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}