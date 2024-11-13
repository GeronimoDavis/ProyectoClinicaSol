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
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxApellido.Text) ||
                string.IsNullOrWhiteSpace(textBoxDNI.Text) ||
                string.IsNullOrWhiteSpace(textBoxTelefono.Text) ||
                string.IsNullOrWhiteSpace(textBoxCelular.Text) ||
                string.IsNullOrWhiteSpace(textBoxHistoriaClinica.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.");
                return;
            }

            if (textBoxDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 caracteres.");
                return;
            }

            if (!int.TryParse(textBoxDNI.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número válido.");
                return;
            }

            if (textBoxCelular.Text.Length < 8 || textBoxCelular.Text.Length > 20)
            {
                MessageBox.Show("El celular debe ser un número válido.");
                return;
            }


            if (textBoxTelefono.Text.Length < 8 || textBoxTelefono.Text.Length > 20)
            {
                MessageBox.Show("El telefono debe ser un número válido.");
                return;
            }

            DateTime birthDate;
            DateTime minDate = new DateTime(1900, 1, 1); // Límite inferior para la fecha

            if (!DateTime.TryParse(dateTimePicker1.Text, out birthDate))
            {
                MessageBox.Show("La fecha de nacimiento no es válida.");
                return;
            }
            else if (birthDate > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no es real.");
                return;
            }
            else if (birthDate < minDate)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser anterior al 1 de enero de 1900.");
                return;
            }

            if (!int.TryParse(textBoxHistoriaClinica.Text, out int medicalRecordNumber))
            {
                MessageBox.Show("El número de historial clínico debe ser un número válido.");
                return;
            }

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

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
