using Entities;
using DataLayer;


namespace ProyectoClinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxEspecialidades.Items.Clear();
            List<Specialty> especialidades = DataLayer.Specialties.GetSpecialties();
            foreach (Specialty especialidad in especialidades)
            {
                comboBoxEspecialidades.Items.Add(especialidad);
            }
        }
    }
}
