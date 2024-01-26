using Entidades;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Persona _persona;
        List<Persona> listaPersonas = new List<Persona>();

        private void Crearbutton_Click(object sender, EventArgs e)
        {
             _persona = new Persona();

            _persona.Nombre = txtnombre.Text;
            _persona.Estatura = Convert.ToDecimal(txtestatura.Text);
            _persona.Edad = DevolverEdad(dateTimePicker1.Value);
            _persona.Genero = txtgenero.Text;
            _persona.FechaNacimiento = dateTimePicker1.Value;
            txtedad.Text= _persona.Edad.ToString();
            
            listaPersonas.Add( _persona );
            PersonasbindingSource.DataSource = null;
            PersonasbindingSource.DataSource = listaPersonas;
            Limpiar();
            txtnombre.Focus();

            //PersonasdataGridView.DataSource = null;
            //PersonasdataGridView.DataSource = listaPersonas;
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_persona.DevolverDatosDeLaPersona());
        }

        private int DevolverEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = 0;

            if (fechaNacimiento>=fechaActual) 
            {
                return 0;
            }
            else 
            {
                edad = fechaActual.Year - fechaNacimiento.Year;
                if(fechaNacimiento.Month>fechaActual.Month)
                {
                    edad--;
                }
                return edad;
            }
        }

        private void Limpiar()
        {
            _persona = null;
            txtnombre.Clear();
            txtestatura.Clear();
            txtgenero.Clear();
            txtedad.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
