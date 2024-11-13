using Entities;
using DataLayer;


namespace ProyectoClinica
{
    public partial class Form1 : Form
    {
        public Professional professionalEle { get; set; }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEspecialidades.SelectedItem is Specialty specialty)
            {
                int specialtyId = specialty.specialtyId; 
                List<Professional> professionals = DataLayer.Professionals.GetProfessionalsBySpecialty(specialtyId);//obtiene la lista de profesionales que pertenecen a la especialidad

                comboBox2.Items.Clear(); // Limpiar los elementos actuales
                foreach (Professional professional in professionals)
                {
                    comboBox2.Items.Add(professional.professionalId + " " + professional.firstName + " " + professional.lastName);
                }
                // Habilitar comboBox2 solo si hay profesionales para mostrar
                comboBox2.Enabled = professionals.Any();

                // Deshabilitar comboBoxespecialidades para evitar que se cambien la especialidad
                comboBoxEspecialidades.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;

            comboBox2.Items.Clear();

            comboBoxEspecialidades.Items.Clear();
            List<Specialty> especialidades = DataLayer.Specialties.GetSpecialties();
            foreach (Specialty especialidad in especialidades)
            {
                comboBoxEspecialidades.Items.Add(especialidad);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nuevoFormulario = new Form2(professionalEle);
            nuevoFormulario.ShowDialog();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si hay una selección válida de profesional
            if (comboBox2.SelectedItem != null) 
            {
                int idProfesional = Convert.ToInt32(comboBox2.SelectedItem.ToString().Split(" ")[0]);
                professionalEle = DataLayer.Professionals.GetProfessional(idProfesional);

                listView1.Items.Clear(); // Limpiar los elementos previos

                listView1.Items.Add("Nombre: " + professionalEle.firstName);
                listView1.Items.Add("Apellido: " + professionalEle.lastName);
                listView1.Items.Add("DNI: " + professionalEle.dni);
                listView1.Items.Add("Celular: " + professionalEle.mobilePhone);
                listView1.Items.Add("Email: " + professionalEle.email);

            }
            

            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
