using MySql.Data.MySqlClient;
using System.Data;

namespace Veterinaria
{
    public partial class Dueno : Form
    {
        string conexionString = "server=gateway01.us-west-2.prod.aws.tidbcloud.com; " +
                            "port=4000; " +
                            "database=test; " +
                            "uid=hei8zHSzhSzae8C.root; " +
                            "pwd=eQqE7Cvm7XK7g1W6; " +
                            "SslMode=Required; " +
                            "SslCa=G:/Download/isrgrootx1.pem;";

        public Dueno()
        {
            InitializeComponent();
            CargarDatosDuenos();
        }

        private void CargarDatosDuenos()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    dtgv_Duenos.DataSource = null;

                    string query = "SELECT id, nombre, telefono, correo FROM duenos";

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conexion))
                    {
                        DataTable dt = new DataTable();
                        adaptador.Fill(dt);

                        dtgv_Duenos.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los dueños: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Limpiar()
        {
            txt_Nombre.Clear();
            txt_Telefono.Clear();
            txt_Correo.Clear();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO duenos (nombre, telefono, correo) VALUES (@nombre, @telefono, @correo)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txt_Nombre.Text);
                        cmd.Parameters.AddWithValue("@telefono", txt_Telefono.Text);
                        cmd.Parameters.AddWithValue("@correo", txt_Correo.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("¡Dueño registrado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();
                        CargarDatosDuenos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dtgv_Duenos.SelectedRows.Count > 0)
            {
                int idDueno = Convert.ToInt32(dtgv_Duenos.SelectedRows[0].Cells["id"].Value);

                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este dueño?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    using (MySqlConnection conexion = new MySqlConnection(conexionString))
                    {
                        try
                        {
                            conexion.Open();
                            string query = "DELETE FROM duenos WHERE id = @id";

                            using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                            {
                                cmd.Parameters.AddWithValue("@id", idDueno);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Dueño eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                CargarDatosDuenos();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar (es posible que tenga animales registrados): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila de la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Dueno_Load(object sender, EventArgs e)
        {
            dtgv_Duenos.DataSource = null;
            CargarDatosDuenos();
        }
    }
}