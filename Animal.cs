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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veterinaria
{
    public partial class Animal : Form
    {
        string conexionString = "server=gateway01.us-west-2.prod.aws.tidbcloud.com; " +
                            "port=4000; " +
                            "database=test; " +
                            "uid=hei8zHSzhSzae8C.root; " +
                            "pwd=eQqE7Cvm7XK7g1W6; " +
                            "SslMode=Required; " +
                            "SslCa=G:/Download/isrgrootx1.pem;";
        public Animal()
        {
            InitializeComponent();
            CargarDatosAnimales();
            CargarDuenos();
        }

        private void Limpiar()
        {
            txt_Nombre.Clear();
            txt_Tipo.Clear();
            txt_Edad.Clear();
        }

        private void CargarDuenos()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT id, nombre FROM duenos";

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion))
                    {
                        DataTable dtDuenos = new DataTable();
                        adaptador.Fill(dtDuenos);

                        cmBox_Dueño.DataSource = dtDuenos;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los dueños en el combo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarDatosAnimales()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT id, nombre, tipo, edad, dueno_id FROM animales";
                    dgv_Animales.DataSource = null;

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion))
                    {
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);

                        dgv_Animales.DataSource = dt;
                        cmBox_Dueño.DisplayMember = "nombre"; 
                        cmBox_Dueño.ValueMember = "id";      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos en la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_agregarAnimal_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO animales (nombre, tipo, edad, dueno_id) VALUES (@nombre, @tipo, @edad, @dueno_id)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txt_Nombre.Text);
                        cmd.Parameters.AddWithValue("@tipo", txt_Tipo.Text);
                        cmd.Parameters.AddWithValue("@edad", int.Parse(txt_Edad.Text));
                        cmd.Parameters.AddWithValue("@dueno_id", cmBox_Dueño.SelectedValue);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("¡Animal y dueño relacionados correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatosAnimales();
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_eliminarAnimal_Click(object sender, EventArgs e)
        {
            if (dgv_Animales.SelectedRows.Count > 0)
            {
                int idDueno = Convert.ToInt32(dgv_Animales.SelectedRows[0].Cells["id"].Value);

                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este Animal?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    using (MySqlConnection conexion = new MySqlConnection(conexionString))
                    {
                        try
                        {
                            conexion.Open();
                            string query = "DELETE FROM animales WHERE id = @id";

                            using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                            {
                                cmd.Parameters.AddWithValue("@id", idDueno);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Animal eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                CargarDatosAnimales();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar un Animal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila de la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Animal_Load(object sender, EventArgs e)
        {
            CargarDatosAnimales();
            CargarDuenos();
        }
    }
}
