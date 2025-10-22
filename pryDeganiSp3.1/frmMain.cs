namespace pryDeganiSp3._1
{
    public partial class frmMain : Form
    {

        //Declaracion de estructura de Turnos
        public struct TURNO
        {
            public int numTurno;
            public string Dominio;
            public int anioFabricacion;
            public string Titular;

        }

        //Constante para la cantidad de elementos del arreglo
        const int MAX = 50;
        //Declaracion del arreglo de Turnos
        public TURNO[] turnos = new TURNO[MAX];
        //Variable para el control de elementos cargados en el arreglo
        int indice = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            turnos = new TURNO[MAX];
            indice = 0;
            InicializarInterface();

            numAnioFabricacion.Minimum = 1950;
            numAnioFabricacion.Maximum = DateTime.Now.Year;
            numAnioFabricacion.Value = DateTime.Now.Year;

            txtDominio.MaxLength = 7;
            txtTitular.MaxLength = 30;
            txtNumTurno.MaxLength = 5;
        }
        private void InicializarInterface()
        {
            LimpiarControles();
            txtCantidadTurnos.Clear();
            txtAnioAntiguo.Clear();
            txtCantidadCaracter.Clear();
        }

        private void LimpiarControles()
        {
            txtDominio.Clear();
            numAnioFabricacion.Value = 2021;
            txtTitular.Clear();
            txtNumTurno.Clear();
            txtDominio.CharacterCasing = CharacterCasing.Upper;
        }

        private bool validarDatosIngresados()
        {
            // N° turno requerido y entero hasta 5 dígitos, y no repetido
            if (!int.TryParse(txtNumTurno.Text, out int nroTurno))
            {
                MessageBox.Show("El número de turno debe ser entero.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumTurno.Focus();
                return false;
            }
            if (nroTurno < 0 || nroTurno > 99999)
            {
                MessageBox.Show("El número de turno debe tener hasta 5 dígitos.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumTurno.Focus();
                return false;
            }
            if (buscarTurno(nroTurno))
            {
                MessageBox.Show("El número de turno ya existe.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumTurno.Focus();
                return false;
            }

            // Dominio: 6 o 7, solo A-Z y 0-9
            string dominio = (txtDominio.Text ?? "").Trim().ToUpperInvariant();
            if (dominio.Length < 6 || dominio.Length > 7)
            {
                MessageBox.Show("El dominio debe tener 6 o 7 caracteres.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDominio.Focus();
                return false;
            }
            foreach (char c in dominio)
            {
                if (!char.IsLetterOrDigit(c) || (char.IsLetter(c) && !char.IsUpper(c)))
                {
                    MessageBox.Show("El dominio solo admite MAYÚSCULAS y números.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDominio.Focus();
                    return false;
                }
            }

            // Año: 1950..año actual (usás NumericUpDown: perfecto)
            int anio = (int)numAnioFabricacion.Value;
            int actual = DateTime.Now.Year;
            if (anio < 1950 || anio > actual)
            {
                MessageBox.Show($"El año de fabricación debe estar entre 1950 y {actual}.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                numAnioFabricacion.Focus();
                return false;
            }

            // Titular: min 2 caracteres
            string titular = (txtTitular.Text ?? "").Trim();
            if (titular.Length < 2 || titular.Length > 30)
            {
                MessageBox.Show("El titular debe tener entre 2 y 30 caracteres.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitular.Focus();
                return false;
            }

            return true;
        }

        private bool buscarTurno(int nroTurno)
        {
            bool existe = false; //suponemos que no existe
            int pos = 0;
            while (pos < indice && !existe)
            {
                if (turnos[pos].numTurno == nroTurno)
                {
                    existe = true;
                    break;
                }
                pos++;
            }
            return existe;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1) tope de capacidad
            if (indice >= MAX)
            {
                MessageBox.Show("Se ha alcanzado la cantidad maxima de turnos", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) validar datos (ver versión corregida abajo)
            if (validarDatosIngresados())
            {
                // 3) convertir seguro
                if (!int.TryParse(txtNumTurno.Text, out int nroTurno))
                {
                    MessageBox.Show("El número de turno debe ser un entero.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumTurno.Focus();
                    return;
                }

                // 4) cargar
                turnos[indice].numTurno = nroTurno;
                turnos[indice].Dominio = txtDominio.Text.Trim().ToUpperInvariant();
                turnos[indice].anioFabricacion = (int)numAnioFabricacion.Value;
                turnos[indice].Titular = txtTitular.Text.Trim();

                indice++;

                if (indice == MAX)
                {
                    MessageBox.Show("Se ha alcanzado la cantidad maxima de turnos", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                MessageBox.Show("Turno registrado correctamente", "Registro Exitoso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            txtCantidadTurnos.Text = indice.ToString();

            if (indice == 0)
            {
                txtAnioAntiguo.Clear();
                txtCantidadCaracter.Clear();
                return;
            }

            int menor = int.MaxValue;
            for (int pos = 0; pos < indice; pos++)
            {
                if (turnos[pos].anioFabricacion < menor)
                {
                    menor = turnos[pos].anioFabricacion;
                }
            }
            txtAnioAntiguo.Text = menor.ToString();   // <<< CORREGIDO

            int contador = 0;
            for (int pos = 0; pos < indice; pos++)
            {
                if ((turnos[pos].Dominio ?? "").Length == 6)
                {
                    contador++;
                }
            }
            txtCantidadCaracter.Text = contador.ToString();  // <<< CORREGIDO
        }

        private void txtNumTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //si No es un digito y No es tecla de control (borrar)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //no permitir el ingreso del caracter
            }
        }

        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Convertir a mayuscula el caracter ingresado y no permitir caracteres especiales
            if (char.IsLower(e.KeyChar)) //es una minuscula
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else
            {
                //no es ni letra ni numero
                if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; //no permitir el ingreso del caracter
                }
            }

        }
    }
}

