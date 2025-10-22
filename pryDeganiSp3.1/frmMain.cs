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
        public TURNO[] turnos;
        //Variable para el control de elementos cargados en el arreglo
        int indice = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //creacion del arreglo de Turnos
            turnos = new TURNO[MAX];
            //inicializacion del indice
            indice = 0;
            //establecer estado inicial de componentes graficos
            InicializarInterface();
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
        }

        private bool validarDatosIngresados()
        {
            bool resultado = false; //suponemos que los datos son incorrectos
            if (txtNumTurno.Text != "" && txtDominio.Text != "" && txtTitular.Text != "")
            {
                if (txtDominio.Text.Length >= 6)
                {
                    if (!buscarTurno(int.Parse(txtNumTurno.Text)))
                    {
                        resultado = true; //los datos son correctos
                    }
                    else
                    {
                        MessageBox.Show("El numero de turno ya existe", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNumTurno.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("El dominio debe tener 6 caracteres", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDominio.Focus();
                }

            }
            else
            {
                MessageBox.Show("Faltan ingresar datos obligatorios", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
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
            if (validarDatosIngresados())
            {
                //cargar los datos en el arreglo
                turnos[indice].numTurno = int.Parse(txtNumTurno.Text);
                turnos[indice].Dominio = txtDominio.Text;
                turnos[indice].anioFabricacion = int.Parse(numAnioFabricacion.Value.ToString());
                turnos[indice].Titular = txtTitular.Text;
                //incrementar el indice
                indice++;
                //informar exito de la operacion
                if (indice == MAX)
                {
                    MessageBox.Show("Se ha alcanzado la cantidad maxima de turnos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                MessageBox.Show("Turno registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //limpiar controles para nuevo ingreso
                LimpiarControles();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // primer consulta: cantidad de turnos registrados
            // se obtiene directamente de la variable 'Cantidad'
            txtCantidadTurnos.Text = indice.ToString();

            // segunda consulta: se debe recorrer el arreglo y determinar
            // el menor valor del campo 'AnioFabricacion'
            int menor = int.MaxValue; // mayor valor posible
            int pos;
            // recorrer el arreglo hasta la posición con datos
            for (pos = 0; pos < indice; pos++)
            {
                // comparar el valor del elemento en el arreglo
                if (turnos[pos].anioFabricacion < menor)
                {
                    menor = turnos[pos].anioFabricacion; // guarda el menor valor
                }
            }
            // mostrar el resultado
            txtCantidadCaracter.Text = menor.ToString();

            // tercera consulta: cantidad de vehículos con dominio de 6 caracteres
            int contador = 0; // contador en cero
                              // recorrer el arreglo hasta la posición con datos
            for (pos = 0; pos < indice; pos++)
            {
                // controlar si la longitud del dominio es 6
                if (turnos[pos].Dominio.Length == 6)
                {
                    contador++; // incrementar el contador
                }
            }
            // mostrar el resultado
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

