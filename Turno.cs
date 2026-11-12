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
    public partial class Turno : Form
    {
        string conexionString = "server=gateway01.us-west-2.prod.aws.tidbcloud.com; " +
                    "port=4000; " +
                    "database=test; " +
                    "uid=hei8zHSzhSzae8C.root; " +
                    "pwd=eQqE7Cvm7XK7g1W6; " +
                    "SslMode=Required; " +
                    "SslCa=G:/Download/isrgrootx1.pem;";

        private void Limpiar()
        {
            txt_Info.Text = "";
            txt_Dueno.Text = "";
            cmb_Animal.SelectedIndex = 0;
            cmb_Especialista.SelectedIndex = 0;
            cmb_Reportes.SelectedIndex = 0;
        }

        public Turno()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void cargarDatos()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string queryAnimales = "SELECT id, nombre FROM animales";

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(queryAnimales, conexion))
                    {
                        DataTable dtAnimal = new DataTable();
                        adaptador.Fill(dtAnimal);

                        cmb_Animal.DataSource = dtAnimal;

                        cmb_Animal.DisplayMember = "nombre";
                        cmb_Animal.ValueMember = "id";
                    }

                    string queryEspecialistas = "SELECT id, nombre, especializacion FROM especialistas";

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(queryEspecialistas, conexion))
                    {
                        DataTable dtEspecialistas = new DataTable();
                        adaptador.Fill(dtEspecialistas);

                        cmb_Especialista.DataSource = dtEspecialistas;

                        cmb_Especialista.DisplayMember = "nombre";
                        cmb_Especialista.ValueMember = "id";
                    }

                    string queryReportes = @"SELECT r.id, CONCAT(a.nombre, ' - ', r.fecha_reporte) AS detalle_reporte 
                         FROM Reportes r 
                         INNER JOIN animales a ON r.animal_id = a.id";

                    using (MySqlDataAdapter adaptadorReportes = new MySqlDataAdapter(queryReportes, conexion))
                    {
                        DataTable dtReportes = new DataTable();
                        adaptadorReportes.Fill(dtReportes);

                        cmb_Reportes.DataSource = dtReportes;
                        cmb_Reportes.DisplayMember = "detalle_reporte";
                        cmb_Reportes.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los dueños en el combo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void cmb_Animal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Animal.SelectedValue != null && cmb_Animal.SelectedValue is int animalId)
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
                                txt_Dueno.Text = resultado.ToString();
                            }
                            else
                            {
                                txt_Dueno.Text = string.Empty;
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

        private void btn_AñadirTurno_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO turnos_animales (fecha_turno, animal_id, dueno, especialista_id, observaciones, reporte_id) VALUES (@fecha_turno, @animal_id, @dueno, @especialista_id, @observaciones, @reporte_id)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@fecha_turno", dtp_FechaTurno.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@animal_id", cmb_Animal.SelectedValue);
                        cmd.Parameters.AddWithValue("@dueno", txt_Dueno.Text);
                        cmd.Parameters.AddWithValue("@especialista_id", cmb_Especialista.SelectedValue);
                        cmd.Parameters.AddWithValue("@observaciones", txt_Info.Text);
                        cmd.Parameters.AddWithValue("@reporte_id", cmb_Reportes.SelectedValue);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("¡Turno guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
