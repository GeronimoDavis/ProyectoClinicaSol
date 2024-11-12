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

            comboBox2.Items.Clear();
            List<Professional> professionals = DataLayer.Professionals.GetProfessionals();
            foreach (Professional professional in professionals)
            {
                comboBox2.Items.Add(professional);
            }

            comboBoxEspecialidades.Items.Clear();
            List<Specialty> especialidades = DataLayer.Specialties.GetSpecialties();
            foreach (Specialty especialidad in especialidades)
            {
                comboBoxEspecialidades.Items.Add(especialidad);
            }

            


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nuevoFormulario = new Form2();
            nuevoFormulario.ShowDialog();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
