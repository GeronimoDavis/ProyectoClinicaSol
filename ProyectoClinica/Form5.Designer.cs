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
            label1 = new Label();
            horarios = new ComboBox();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(395, 76);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 4;
            label1.Text = "Horarios disponibles";
            // 
            // horarios
            // 
            horarios.FormattingEnabled = true;
            horarios.Location = new Point(359, 116);
            horarios.Name = "horarios";
            horarios.Size = new Size(267, 23);
            horarios.TabIndex = 5;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(horarios);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button button1;
        private Label label1;
        private ComboBox horarios;
    }
}