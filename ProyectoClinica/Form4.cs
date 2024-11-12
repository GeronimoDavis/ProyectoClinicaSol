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
using DataLayer;

namespace ProyectoClinica
{
    public partial class Form4 : Form
    {
        Patient Patient { get; set; }

        public Form4(Patient patientToEdit)
        {
            InitializeComponent();
            Patient = patientToEdit;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBoxNombre.Text = Patient.firstName;
            textBoxApellido.Text = Patient.lastName;
            textBoxDNI.Text = Patient.dni;
            textBoxHistoriaClinica.Text = Convert.ToString(Patient.medicalRecordNumber);
            textBoxTelefono.Text = Patient.phone;
            textBoxCelular.Text = Patient.mobilePhone;
            dateTimePicker1.Value = Patient.birthDate;
            textBoxNotas.Text = Patient.notes;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Patient editedPatient = new Patient();

            editedPatient.patientId = Patient.patientId;
            editedPatient.firstName = textBoxNombre.Text;
            editedPatient.lastName = textBoxApellido.Text;
            editedPatient.dni = textBoxDNI.Text;
            editedPatient.medicalRecordNumber = Convert.ToInt32(textBoxHistoriaClinica.Text);
            editedPatient.phone = textBoxTelefono.Text;
            editedPatient.mobilePhone = textBoxCelular.Text;
            editedPatient.notes = textBoxNotas.Text;
            editedPatient.birthDate = Convert.ToDateTime(dateTimePicker1.Text);

            DataLayer.Patients.EditPatient(editedPatient);
            MessageBox.Show("Paciente Editado");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
