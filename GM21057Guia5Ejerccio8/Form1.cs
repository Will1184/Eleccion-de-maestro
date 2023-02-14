namespace GM21057Guia5Ejerccio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Persona> maestro1 = new List<Persona>();
        private List<Persona> maestro2 = new List<Persona>();
        private List<Persona> maestro3 = new List<Persona>();
        private List<Persona> maestro4 = new List<Persona>();
        private List<Persona> maestro5 = new List<Persona>();
        private int indiceEdit = -1;
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonMaestro1_Click(object sender, EventArgs e)
        {
            Persona alumno = new Persona(textBoxNombre.Text, textBoxApellidos.Text);

            if (indiceEdit > -1)
            {
                maestro1[indiceEdit] = alumno;
                indiceEdit = -1;
            }
            else
            {
                maestro1.Add(alumno);
            }

        }

        private void buttonMaestro2_Click(object sender, EventArgs e)
        {
            Persona alumno = new Persona(textBoxNombre.Text, textBoxApellidos.Text);
            if (indiceEdit > -1)
            {
                maestro2[indiceEdit] = alumno;
                indiceEdit = -1;
            }
            else
            {
                maestro2.Add(alumno);
            }
        }

        private void buttonMaestro3_Click(object sender, EventArgs e)
        {
            Persona alumno = new Persona(textBoxNombre.Text, textBoxApellidos.Text);
            if (indiceEdit > -1)
            {
                maestro3[indiceEdit] = alumno;
                indiceEdit = -1;
            }
            else
            {
                maestro3.Add(alumno);
            }
        }

        private void buttonMaestro4_Click(object sender, EventArgs e)
        {
            Persona alumno = new Persona(textBoxNombre.Text, textBoxApellidos.Text);
            if (indiceEdit > -1)
            {
                maestro4[indiceEdit] = alumno;
                indiceEdit = -1;
            }
            else
            {
                maestro4.Add(alumno);
            }
        }

        private void buttonMaestro5_Click(object sender, EventArgs e)
        {
            Persona alumno = new Persona(textBoxNombre.Text, textBoxApellidos.Text);
            if (indiceEdit > -1)
            {
                maestro5[indiceEdit] = alumno;
                indiceEdit = -1;
            }
            else
            {
                maestro5.Add(alumno);
            }

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            int[] docente = { maestro1.Count, maestro2.Count, maestro3.Count, maestro4.Count, maestro5.Count };

            label16.Text = maestro1.Count.ToString();
            label17.Text = maestro2.Count.ToString();
            label18.Text = maestro3.Count.ToString();
            label19.Text = maestro4.Count.ToString();
            label20.Text = maestro5.Count.ToString();

            Persona maestros = new Persona();
            maestros.DocentesConMasAlumnos(maestro1.Count, maestro2.Count, maestro3.Count, maestro4.Count, maestro5.Count, docente, labelPrimerDocente, textBoxMasAlumno, labelSegundoDocente, labelTercerDocente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}