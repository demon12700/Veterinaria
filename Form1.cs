using MySql.Data.MySqlClient;

namespace Veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarBaseDeDatos();
        }

        private void InicializarBaseDeDatos()
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

                    string queryDuenos = @"CREATE TABLE IF NOT EXISTS duenos (
                                    id INT AUTO_INCREMENT PRIMARY KEY,
                                    nombre VARCHAR(100) NOT NULL,
                                    telefono VARCHAR(20),
                                    correo VARCHAR(100)
                                  );";

                    using (MySqlCommand cmdDuenos = new MySqlCommand(queryDuenos, conexion))
                    {
                        cmdDuenos.ExecuteNonQuery();
                    }

                    string queryAnimales = @"CREATE TABLE IF NOT EXISTS animales (
                                      id INT AUTO_INCREMENT PRIMARY KEY,
                                      nombre VARCHAR(50),
                                      tipo VARCHAR(50),
                                      edad INT,
                                      dueno_id INT,
                                      FOREIGN KEY (dueno_id) REFERENCES duenos(id)
                                    );";

                    using (MySqlCommand cmdAnimales = new MySqlCommand(queryAnimales, conexion))
                    {
                        cmdAnimales.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al inicializar las tablas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Animal frmAnimal = new Animal();
            frmAnimal.Show();
        }

        private void dueñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dueno frmDueño = new Dueno();
            frmDueño.Show();
        }

        private void reporteDeAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteAnimal frmReporte = new reporteAnimal();
            frmReporte.Show();
        }

        private void reporteDeSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
