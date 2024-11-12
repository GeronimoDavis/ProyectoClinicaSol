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
        public Form2()
        {
            InitializeComponent();
        }

        private ComboBox pacientes;
        private Button borrarPaciente;
        private Button EditarPaciente;
        private Button crearPaciente;
        private ListView infoPaciente;

        private void InitializeComponent()
        {
            pacientes = new ComboBox();
            infoPaciente = new ListView();
            borrarPaciente = new Button();
            EditarPaciente = new Button();
            crearPaciente = new Button();
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
            // 
            // infoPaciente
            // 
            infoPaciente.Location = new Point(187, 109);
            infoPaciente.Name = "infoPaciente";
            infoPaciente.Size = new Size(296, 154);
            infoPaciente.TabIndex = 1;
            infoPaciente.UseCompatibleStateImageBehavior = false;
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
            // 
            // crearPaciente
            // 
            crearPaciente.Location = new Point(482, 287);
            crearPaciente.Name = "crearPaciente";
            crearPaciente.Size = new Size(162, 41);
            crearPaciente.TabIndex = 4;
            crearPaciente.Text = "Crear paciente";
            crearPaciente.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            ClientSize = new Size(678, 350);
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

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pacientes.Items.Clear();
            List<Patient> paciente = DataLayer.Patients.GetPatients();
            foreach (Patient pa in paciente)
            {
                pacientes.Items.Add(pa);
            }
        }

        private void infoPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
