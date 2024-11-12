using Entities;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoClinica
{
    public partial class Form2 : Form
    {
        public Patient patientToEdit { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private ComboBox pacientes;
        private Button borrarPaciente;
        private Button EditarPaciente;
        private Button crearPaciente;
        private Button button1;
        private ListView infoPaciente;

        private void InitializeComponent()
        {
            pacientes = new ComboBox();
            infoPaciente = new ListView();
            borrarPaciente = new Button();
            EditarPaciente = new Button();
            crearPaciente = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // pacientes
            // 
            pacientes.FormattingEnabled = true;
            pacientes.Location = new Point(198, 49);
            pacientes.Name = "pacientes";
            pacientes.Size = new Size(263, 23);
            pacientes.TabIndex = 0;
            pacientes.SelectedIndexChanged += pacientes_SelectedIndexChanged;
            pacientes.Click += pacientes_Click;
            // 
            // infoPaciente
            // 
            infoPaciente.Location = new Point(187, 91);
            infoPaciente.Name = "infoPaciente";
            infoPaciente.Size = new Size(296, 172);
            infoPaciente.TabIndex = 1;
            infoPaciente.UseCompatibleStateImageBehavior = false;
            infoPaciente.View = View.List;
            infoPaciente.SelectedIndexChanged += infoPaciente_SelectedIndexChanged;
            // 
            // borrarPaciente
            // 
            borrarPaciente.Location = new Point(34, 285);
            borrarPaciente.Name = "borrarPaciente";
            borrarPaciente.Size = new Size(195, 43);
            borrarPaciente.TabIndex = 2;
            borrarPaciente.Text = "borrar paciente";
            borrarPaciente.UseVisualStyleBackColor = true;
            // 
            // EditarPaciente
            // 
            EditarPaciente.Location = new Point(270, 285);
            EditarPaciente.Name = "EditarPaciente";
            EditarPaciente.Size = new Size(191, 43);
            EditarPaciente.TabIndex = 3;
            EditarPaciente.Text = "Editar paciente";
            EditarPaciente.UseVisualStyleBackColor = true;
            EditarPaciente.Click += EditarPaciente_Click;
            // 
            // crearPaciente
            // 
            crearPaciente.Location = new Point(482, 287);
            crearPaciente.Name = "crearPaciente";
            crearPaciente.Size = new Size(162, 41);
            crearPaciente.TabIndex = 4;
            crearPaciente.Text = "Crear paciente";
            crearPaciente.UseVisualStyleBackColor = true;
            crearPaciente.Click += crearPaciente_Click;
            // 
            // button1
            // 
            button1.Location = new Point(34, 145);
            button1.Name = "button1";
            button1.Size = new Size(130, 32);
            button1.TabIndex = 5;
            button1.Text = "Turnos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            ClientSize = new Size(678, 350);
            Controls.Add(button1);
            Controls.Add(crearPaciente);
            Controls.Add(EditarPaciente);
            Controls.Add(borrarPaciente);
            Controls.Add(infoPaciente);
            Controls.Add(pacientes);
            Name = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        private void pacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dniPaciente = pacientes.SelectedItem.ToString().Split(' ')[0];
            Patient paciente = DataLayer.Patients.getPatient(dniPaciente);

            infoPaciente.Items.Clear();

            infoPaciente.Items.Add("Nombre: " + paciente.firstName);
            infoPaciente.Items.Add("Apellido: " + paciente.lastName);
            infoPaciente.Items.Add("DNI: " + paciente.dni);
            infoPaciente.Items.Add("Telefono: " + paciente.phone);
            infoPaciente.Items.Add("Celular: " + paciente.mobilePhone);
            infoPaciente.Items.Add("Historial medico: " + paciente.medicalRecordNumber);
            infoPaciente.Items.Add("Fecha de nacimiento: " + paciente.birthDate);
            infoPaciente.Items.Add("Notas: " + paciente.notes);
            infoPaciente.Items.Add("Estado: " + paciente.status);

            patientToEdit = paciente;
        }

        private void pacientes_Click(object sender, EventArgs e)
        {
            pacientes.Items.Clear();
            List<Patient> paciente = DataLayer.Patients.GetPatients();
            foreach (Patient pa in paciente)
            {
                pacientes.Items.Add(pa.dni + " " + pa.firstName + " " + pa.lastName);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void infoPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void crearPaciente_Click(object sender, EventArgs e)
        {
            Form3 nuevoFormulario = new Form3();
            nuevoFormulario.ShowDialog();
        }

        private void EditarPaciente_Click(object sender, EventArgs e)
        {

            Form4 nuevoFormulario = new Form4(patientToEdit);
            nuevoFormulario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 nuevoFormulario = new Form5();
            nuevoFormulario.ShowDialog();
        }
    }
}
