using Entities;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();

            patient.firstName = textBoxNombre.Text;
            patient.lastName = textBoxApellido.Text;
            patient.dni = textBoxDNI.Text;
            patient.phone = textBoxTelefono.Text;
            patient.notes = textBoxNotas.Text;
            patient.mobilePhone = textBoxCelular.Text;
            patient.birthDate = Convert.ToDateTime(dateTimePicker1.Text);
            patient.medicalRecordNumber = Convert.ToInt32(textBoxHistoriaClinica.Text);
            patient.status = true;

            DataLayer.Patients.CreatePatient(patient);

            MessageBox.Show("Paciente Creado");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
