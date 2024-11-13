namespace ProyectoClinica
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            listViewHorasDisponibles = new ListView();
            listViewHistorialTurnos = new ListView();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(34, 76);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(77, 250);
            button1.Name = "button1";
            button1.Size = new Size(163, 38);
            button1.TabIndex = 1;
            button1.Text = "Generar turno";
            button1.UseVisualStyleBackColor = true;
            // 
            // listViewHorasDisponibles
            // 
            listViewHorasDisponibles.Location = new Point(322, 76);
            listViewHorasDisponibles.Name = "listViewHorasDisponibles";
            listViewHorasDisponibles.Size = new Size(200, 225);
            listViewHorasDisponibles.TabIndex = 2;
            listViewHorasDisponibles.UseCompatibleStateImageBehavior = false;
            listViewHorasDisponibles.SelectedIndexChanged += listViewHorasDisponibles_SelectedIndexChanged;
            // 
            // listViewHistorialTurnos
            // 
            listViewHistorialTurnos.Location = new Point(563, 76);
            listViewHistorialTurnos.Name = "listViewHistorialTurnos";
            listViewHistorialTurnos.Size = new Size(200, 225);
            listViewHistorialTurnos.TabIndex = 3;
            listViewHistorialTurnos.UseCompatibleStateImageBehavior = false;
            listViewHistorialTurnos.SelectedIndexChanged += listViewHistorialTurnos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 37);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 4;
            label1.Text = "Horarios disponibles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(575, 37);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 5;
            label2.Text = "Historial de turnos";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listViewHistorialTurnos);
            Controls.Add(listViewHorasDisponibles);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button button1;
        private ListView listViewHorasDisponibles;
        private ListView listViewHistorialTurnos;
        private Label label1;
        private Label label2;
    }
}