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
            // Validación de campos
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

            // Si todas las validaciones pasan, crea el objeto Patient
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
