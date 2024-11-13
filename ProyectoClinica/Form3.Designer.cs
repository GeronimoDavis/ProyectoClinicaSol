namespace ProyectoClinica
{
    partial class Form3
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
            textBoxNombre = new TextBox();
            label1 = new Label();
            textBoxApellido = new TextBox();
            textBoxDNI = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxCelular = new TextBox();
            textBoxHistoriaClinica = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            button1 = new Button();
            textBoxNotas = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(198, 31);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(154, 23);
            textBoxNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 39);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(198, 60);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.PlaceholderText = "Apellido";
            textBoxApellido.Size = new Size(154, 23);
            textBoxApellido.TabIndex = 2;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(198, 89);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.PlaceholderText = "DNI";
            textBoxDNI.Size = new Size(154, 23);
            textBoxDNI.TabIndex = 3;
            textBoxDNI.TextChanged += textBox3_TextChanged;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(198, 118);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.PlaceholderText = "Telefono fijo";
            textBoxTelefono.Size = new Size(154, 23);
            textBoxTelefono.TabIndex = 4;
            // 
            // textBoxCelular
            // 
            textBoxCelular.Location = new Point(198, 147);
            textBoxCelular.Name = "textBoxCelular";
            textBoxCelular.PlaceholderText = "Celular";
            textBoxCelular.Size = new Size(154, 23);
            textBoxCelular.TabIndex = 5;
            // 
            // textBoxHistoriaClinica
            // 
            textBoxHistoriaClinica.Location = new Point(198, 205);
            textBoxHistoriaClinica.Name = "textBoxHistoriaClinica";
            textBoxHistoriaClinica.PlaceholderText = "Historia clinica";
            textBoxHistoriaClinica.Size = new Size(154, 23);
            textBoxHistoriaClinica.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 68);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 97);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 9;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 126);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 10;
            label4.Text = "Telefono";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 155);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 11;
            label5.Text = "Celular";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 213);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 12;
            label6.Text = "Historia Clinica";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(198, 176);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 184);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 14;
            label7.Text = "Fecha de nacimiento";
            // 
            // button1
            // 
            button1.Location = new Point(182, 263);
            button1.Name = "button1";
            button1.Size = new Size(158, 29);
            button1.TabIndex = 15;
            button1.Text = "Crear paciente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxNotas
            // 
            textBoxNotas.Location = new Point(198, 234);
            textBoxNotas.Name = "textBoxNotas";
            textBoxNotas.PlaceholderText = "Notas";
            textBoxNotas.Size = new Size(154, 23);
            textBoxNotas.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(134, 242);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 17;
            label8.Text = "Notas";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(textBoxNotas);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxHistoriaClinica);
            Controls.Add(textBoxCelular);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxDNI);
            Controls.Add(textBoxApellido);
            Controls.Add(label1);
            Controls.Add(textBoxNombre);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private Label label1;
        private TextBox textBoxApellido;
        private TextBox textBoxDNI;
        private TextBox textBoxTelefono;
        private TextBox textBoxCelular;
        private TextBox textBoxHistoriaClinica;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Button button1;
        private TextBox textBoxNotas;
        private Label label8;
    }
}