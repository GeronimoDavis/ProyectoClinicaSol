﻿namespace ProyectoClinica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxEspecialidades = new ComboBox();
            comboBox2 = new ComboBox();
            listView1 = new ListView();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 0;
            label1.Text = "Clinica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 86);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 2;
            label2.Text = "Especialidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 86);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 3;
            label3.Text = "Profesional";
            // 
            // comboBoxEspecialidades
            // 
            comboBoxEspecialidades.FormattingEnabled = true;
            comboBoxEspecialidades.Location = new Point(142, 83);
            comboBoxEspecialidades.Name = "comboBoxEspecialidades";
            comboBoxEspecialidades.Size = new Size(176, 33);
            comboBoxEspecialidades.TabIndex = 4;
            comboBoxEspecialidades.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(471, 83);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(177, 33);
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // listView1
            // 
            listView1.Location = new Point(322, 168);
            listView1.Name = "listView1";
            listView1.Size = new Size(356, 195);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(23, 227);
            button1.Name = "button1";
            button1.Size = new Size(222, 63);
            button1.TabIndex = 7;
            button1.Text = "Buscar paciente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(739, 461);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(comboBox2);
            Controls.Add(comboBoxEspecialidades);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Clinic";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxEspecialidades;
        private ComboBox comboBox2;
        private ListView listView1;
        private Button button1;
    }
}
