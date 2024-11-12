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
            int specialtyId = comboBoxEspecialidades.SelectedIndex; // O el specialtyId si quieres usar el valor de la especialidad seleccionada
            List<Professional> professionals = DataLayer.Professionals.GetProfessionalsBySpecialty(specialtyId);

            comboBox2.Items.Clear(); // Limpiar los elementos actuales
            foreach (Professional professional in professionals)
            {
                comboBox2.Items.Add(professional.professionalId + " " + professional.firstName + " " + professional.lastName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox2.Items.Clear();
            List<Professional> professionals = DataLayer.Professionals.GetProfessionals();
            foreach (Professional professional in professionals)
            {
                comboBox2.Items.Add(professional.professionalId + " " + professional.firstName + " " + professional.lastName);
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
            int idProfesional = Convert.ToInt32(comboBox2.SelectedItem.ToString().Split(" ")[0]);
            Professional professional = DataLayer.Professionals.GetProfessional(idProfesional);

            listView1.Items.Clear(); // Limpiar los elementos previos

            ListViewItem item = new ListViewItem("Nombre: " + professional.firstName);
            item.SubItems.Add("Apellido: " + professional.lastName);
            item.SubItems.Add("DNI: " + professional.dni);
            item.SubItems.Add("Celular: " + professional.mobilePhone);
            item.SubItems.Add("Email: " + professional.email);

            listView1.Items.Add(item);
        }
    }
}
