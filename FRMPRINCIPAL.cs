namespace ProyectoACAbiblioteca
{
    public partial class FRMPRINCIPAL : Form
    {
        public FRMPRINCIPAL()
        {
            InitializeComponent();
            // Especificar la ruta completa del espacio de nombres DATOS
            ProyectoACAbiblioteca.DATOS.Conexion conexion = new ProyectoACAbiblioteca.DATOS.Conexion();
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    MessageBox.Show("Conexión a la base de datos establecida correctamente.",
                        "AcaBiblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message,
                    "AcaBiblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        

        AbrirFormulario(new frmINICIO());
        }
        private void AbrirFormulario(Form formulario)
        {
            PNLCONTENIDO.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            PNLCONTENIDO.Controls.Add(formulario);
            formulario.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LBLSUBTITULO_Click(object sender, EventArgs e)
        {

        }

        private void BTNINICIO_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmINICIO());
        }
        // 2. Botón Libros
        private void BTNLIBROS_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmLIBROS());
        }

        // 3. Botón Autores
        private void BTNAUTORES_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAUTORES());
        }

        // 4. Botón Editoriales
        private void BTNEDITORIALES_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEDITORIALES());
        }

        // 5. Botón Usuarios
        private void BTNUSUARIOS_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmUSUARIOS());
        }

        // 6. Botón Préstamos
        private void BTNPRESTAMOS_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPRESTAMOS());
        }

        // 7. Botón Devoluciones
        private void BTNDEVOLUCIONES_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDEVOLUCIONES());
        }

        // 8. Botón Reportes
        private void BTNREPORTES_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmREPORTES());
        }
        // 9. Botón Salir
        private void BTNSALIDA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
