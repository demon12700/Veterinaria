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
    public partial class VerTurnos : Form
    {
        public VerTurnos()
        {
            InitializeComponent();
            CargarDatosTurnos();
        }

        string conexionString = "server=gateway01.us-west-2.prod.aws.tidbcloud.com; " +
                            "port=4000; " +
                            "database=test; " +
                            "uid=hei8zHSzhSzae8C.root; " +
                            "pwd=eQqE7Cvm7XK7g1W6; " +
                            "SslMode=Required; " +
                            "SslCa=G:/Download/isrgrootx1.pem;";

        private void CargarDatosTurnos()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string queryTurnos = "SELECT t.id, t.fecha_turno AS fechaTurno, a.nombre AS animal, t.dueno, " +
                                         "CONCAT(e.nombre, ' - ', e.especializacion) AS especialista, t.observaciones " +
                                         "FROM turnos_animales t " +
                                         "JOIN animales a ON t.animal_id = a.id " +
                                         "JOIN especialistas e ON t.especialista_id = e.id";

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(queryTurnos, conexion))
                    {
                        DataTable dtTurnos = new DataTable();
                        adaptador.Fill(dtTurnos);
                        dtgv_Turnos.DataSource = dtTurnos;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los turnos en la grilla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dtgv_Turnos.SelectedRows.Count > 0)
            {
                int idTurno = Convert.ToInt32(dtgv_Turnos.SelectedRows[0].Cells["id"].Value);
                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este turno?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (MySqlConnection conexion = new MySqlConnection(conexionString))
                    {
                        try
                        {
                            conexion.Open();
                            string query = "DELETE FROM turnos_animales WHERE id = @id";

                            using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                            {
                                cmd.Parameters.AddWithValue("@id", idTurno);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Turno eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                CargarDatosTurnos();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un turno completo para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
