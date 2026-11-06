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
    public partial class reporteAnimal : Form
    {
        string conexionString = "server=gateway01.us-west-2.prod.aws.tidbcloud.com; " +
                            "port=4000; " +
                            "database=test; " +
                            "uid=hei8zHSzhSzae8C.root; " +
                            "pwd=eQqE7Cvm7XK7g1W6; " +
                            "SslMode=Required; " +
                            "SslCa=G:/Download/isrgrootx1.pem;";
        public reporteAnimal()
        {
            InitializeComponent();
            CargarAnimales();
        }

        private void Limpiar()
        {
            txt_contenidoReporte.Clear();
        }

        private void CargarAnimales()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT id, nombre FROM animales";

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion))
                    {
                        DataTable dtAnimal = new DataTable();
                        adaptador.Fill(dtAnimal);

                        cmBox_Animal.DataSource = dtAnimal;

                        cmBox_Animal.DisplayMember = "nombre";
                        cmBox_Animal.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los dueños en el combo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO Reportes (animal_id, dueno, fecha_reporte, observaciones) VALUES (@animal_id, @dueno, @fecha_reporte, @observaciones)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        // Asignamos todos los parámetros correspondientes
                        cmd.Parameters.AddWithValue("@animal_id", cmBox_Animal.SelectedValue);
                        cmd.Parameters.AddWithValue("@dueno", txt_Dueño.Text);
                        cmd.Parameters.AddWithValue("@fecha_reporte", dia_Reporte.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@observaciones", txt_contenidoReporte.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("¡Reporte guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmBox_Animal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBox_Animal.SelectedValue != null && cmBox_Animal.SelectedValue is int animalId)
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    try
                    {
                        conexion.Open();

                        string query = "SELECT duenos.nombre FROM animales INNER JOIN duenos ON animales.dueno_id = duenos.id WHERE animales.id = @idAnimal";

                        using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                        {
                            cmd.Parameters.AddWithValue("@idAnimal", animalId);

                            object resultado = cmd.ExecuteScalar();

                            if (resultado != null)
                            {
                                txt_Dueño.Text = resultado.ToString();
                            }
                            else
                            {
                                txt_Dueño.Text = string.Empty;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar el dueño: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
