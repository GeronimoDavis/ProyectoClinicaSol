namespace ProyectoClinica
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxDNI = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBoxTelefono = new TextBox();
            textBoxCelular = new TextBox();
            textBoxHistoriaClinica = new TextBox();
            textBoxNotas = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 124);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 153);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 180);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "DNI";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 207);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 239);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 268);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 5;
            label6.Text = "Celular";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(106, 294);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 6;
            label7.Text = "Historia clinica";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(106, 323);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 7;
            label8.Text = "Notas";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(236, 116);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(99, 23);
            textBoxNombre.TabIndex = 8;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(236, 145);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.PlaceholderText = "Apellido";
            textBoxApellido.Size = new Size(99, 23);
            textBoxApellido.TabIndex = 9;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(236, 174);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.PlaceholderText = "DNI";
            textBoxDNI.Size = new Size(99, 23);
            textBoxDNI.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(236, 201);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(99, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(236, 231);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.PlaceholderText = "Telefono";
            textBoxTelefono.Size = new Size(99, 23);
            textBoxTelefono.TabIndex = 12;
            // 
            // textBoxCelular
            // 
            textBoxCelular.Location = new Point(236, 260);
            textBoxCelular.Name = "textBoxCelular";
            textBoxCelular.PlaceholderText = "Celular";
            textBoxCelular.Size = new Size(99, 23);
            textBoxCelular.TabIndex = 13;
            // 
            // textBoxHistoriaClinica
            // 
            textBoxHistoriaClinica.Location = new Point(236, 291);
            textBoxHistoriaClinica.Name = "textBoxHistoriaClinica";
            textBoxHistoriaClinica.PlaceholderText = "Historia clinica";
            textBoxHistoriaClinica.Size = new Size(99, 23);
            textBoxHistoriaClinica.TabIndex = 14;
            // 
            // textBoxNotas
            // 
            textBoxNotas.Location = new Point(236, 320);
            textBoxNotas.Name = "textBoxNotas";
            textBoxNotas.PlaceholderText = "Notas";
            textBoxNotas.Size = new Size(99, 23);
            textBoxNotas.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(166, 366);
            button1.Name = "button1";
            button1.Size = new Size(128, 24);
            button1.TabIndex = 16;
            button1.Text = "Editar paciente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxNotas);
            Controls.Add(textBoxHistoriaClinica);
            Controls.Add(textBoxCelular);
            Controls.Add(textBoxTelefono);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxDNI);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxDNI;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxTelefono;
        private TextBox textBoxCelular;
        private TextBox textBoxHistoriaClinica;
        private TextBox textBoxNotas;
        private Button button1;
    }
}