using DataLayer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProyectoClinica
{
    public partial class Form5 : Form
    {
        public Professional professionalEle { get; set; }
        public Patient patientEle { get; set; }
        public Form5(Patient patientToEdit, Professional professional)
        {
            InitializeComponent();
            professionalEle = professional;
            patientEle = patientToEdit;
            button1.Enabled = false; // Inicialmente deshabilitamos el botón
        }

        private void listViewHorasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewHistorialTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                horarios.Items.Clear();
                List<Schedules> schedules = dataSchedules.GetSchedules(professionalEle.professionalId);

                foreach (Schedules schedule in schedules)
                {
                    horarios.Items.Add(schedule.Time.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Antes debes elegir un profesional");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }


        }

        private void horarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarSelecciones();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén la fecha seleccionada del calendario y la hora del combobox
                DateTime fechaSeleccionada = monthCalendar1.SelectionRange.Start;
                TimeSpan horaSeleccionada = TimeSpan.Parse(horarios.SelectedItem.ToString());

                //combinamos la fecha y la hora en un solo objeto dateTime
                DateTime fechaHoraTurno = fechaSeleccionada.Date.Add(horaSeleccionada);

               
                Appointment nuevoTurno = new Appointment
                {
                    
                    PatientId = patientEle.patientId,
                    ProfessionalId = professionalEle.professionalId,
                    Time = fechaHoraTurno,
                    Canceled = false,
                    Status = "Activo"
                };

               
                Appointments.CreateAppointment(nuevoTurno);

                MessageBox.Show("Turno creado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear el turno: " + ex.Message);
            }
        }

        private void VerificarSelecciones()
        {
            
            button1.Enabled = monthCalendar1.SelectionRange.Start != null && horarios.SelectedIndex != -1;
        }
        private bool fechaErrorMostrada = false; // Variable de control

        public void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaMinima = DateTime.Now.Date;

            
            if (monthCalendar1.SelectionRange.Start.Date < fechaMinima)
            {
                // Solo mostramos el mensaje si no se ha mostrado ya
                if (!fechaErrorMostrada)
                {
                    MessageBox.Show("La fecha seleccionada no puede ser anterior.");
                    fechaErrorMostrada = true;  
                }

                monthCalendar1.SetDate(fechaMinima);  // Establecemos la fecha mínima
            }
            else
            {
               
                fechaErrorMostrada = false;
            }


            VerificarSelecciones();
        }
    }
       
    
}
