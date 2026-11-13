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
    public partial class VerReporteAnimal : Form
    {
        public VerReporteAnimal()
        {
            InitializeComponent();
            CargarDatosReportes();
        }

        string conexionString = "server=gateway01.us-west-2.prod.aws.tidbcloud.com; " +
                            "port=4000; " +
                            "database=test; " +
                            "uid=hei8zHSzhSzae8C.root; " +
                            "pwd=eQqE7Cvm7XK7g1W6; " +
                            "SslMode=Required; " +
                            "SslCa=G:/Download/isrgrootx1.pem;";

        private void CargarDatosReportes()
        {
            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();
                    string queryReportes = "SELECT r.id, a.nombre AS animal, r.dueno, r.observaciones AS contenido, r.fecha_reporte AS createdAt " +
                                           "FROM Reportes r " +
                                           "JOIN animales a ON r.animal_id = a.id";

                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(queryReportes, conexion))
                    {
                        DataTable dtReportes = new DataTable();
                        adaptador.Fill(dtReportes);
                        dtgv_Reportes.DataSource = dtReportes;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los reportes en la grilla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dtgv_Reportes.SelectedRows.Count > 0)
            {
                int idDueno = Convert.ToInt32(dtgv_Reportes.SelectedRows[0].Cells["id"].Value);

                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este reporte?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    using (MySqlConnection conexion = new MySqlConnection(conexionString))
                    {
                        try
                        {
                            conexion.Open();
                            string query = "DELETE FROM Reportes WHERE id = @id";

                            using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                            {
                                cmd.Parameters.AddWithValue("@id", idDueno);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Dueño eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                CargarDatosReportes();
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
    }
}
