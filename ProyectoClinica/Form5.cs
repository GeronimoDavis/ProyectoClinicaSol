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

            }catch (Exception ex)
            {
                MessageBox.Show("Antes debes elegir un profesional");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            

        }

        private void horarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
