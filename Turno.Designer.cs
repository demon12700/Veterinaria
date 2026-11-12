namespace Veterinaria
{
    partial class Turno
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
            lbl_Titulo = new Label();
            cmb_Animal = new ComboBox();
            txt_Dueno = new TextBox();
            lbl_Animal = new Label();
            lbl_Dueño = new Label();
            dtp_FechaTurno = new DateTimePicker();
            lbl_Tiempo = new Label();
            cmb_Especialista = new ComboBox();
            lbl_Especialista = new Label();
            txt_Info = new TextBox();
            lbl_Info = new Label();
            btn_AñadirTurno = new Button();
            cmb_Reportes = new ComboBox();
            lbl_Reporte = new Label();
            SuspendLayout();
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Location = new Point(12, 9);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(77, 15);
            lbl_Titulo.TabIndex = 0;
            lbl_Titulo.Text = "Añadir Turno";
            // 
            // cmb_Animal
            // 
            cmb_Animal.FormattingEnabled = true;
            cmb_Animal.Location = new Point(41, 72);
            cmb_Animal.Name = "cmb_Animal";
            cmb_Animal.Size = new Size(100, 23);
            cmb_Animal.TabIndex = 1;
            cmb_Animal.SelectedIndexChanged += cmb_Animal_SelectedIndexChanged;
            // 
            // txt_Dueno
            // 
            txt_Dueno.BackColor = SystemColors.ButtonHighlight;
            txt_Dueno.Enabled = false;
            txt_Dueno.Location = new Point(41, 129);
            txt_Dueno.Name = "txt_Dueno";
            txt_Dueno.ReadOnly = true;
            txt_Dueno.Size = new Size(100, 23);
            txt_Dueno.TabIndex = 2;
            // 
            // lbl_Animal
            // 
            lbl_Animal.AutoSize = true;
            lbl_Animal.Location = new Point(32, 54);
            lbl_Animal.Name = "lbl_Animal";
            lbl_Animal.Size = new Size(104, 15);
            lbl_Animal.TabIndex = 3;
            lbl_Animal.Text = "Seleccione Animal";
            // 
            // lbl_Dueño
            // 
            lbl_Dueño.AutoSize = true;
            lbl_Dueño.Location = new Point(32, 111);
            lbl_Dueño.Name = "lbl_Dueño";
            lbl_Dueño.Size = new Size(99, 15);
            lbl_Dueño.TabIndex = 4;
            lbl_Dueño.Text = "Dueño de Animal";
            // 
            // dtp_FechaTurno
            // 
            dtp_FechaTurno.Format = DateTimePickerFormat.Short;
            dtp_FechaTurno.Location = new Point(41, 186);
            dtp_FechaTurno.Name = "dtp_FechaTurno";
            dtp_FechaTurno.Size = new Size(100, 23);
            dtp_FechaTurno.TabIndex = 5;
            // 
            // lbl_Tiempo
            // 
            lbl_Tiempo.AutoSize = true;
            lbl_Tiempo.Location = new Point(32, 168);
            lbl_Tiempo.Name = "lbl_Tiempo";
            lbl_Tiempo.Size = new Size(89, 15);
            lbl_Tiempo.TabIndex = 6;
            lbl_Tiempo.Text = "Fecha de Turno";
            // 
            // cmb_Especialista
            // 
            cmb_Especialista.FormattingEnabled = true;
            cmb_Especialista.Location = new Point(41, 235);
            cmb_Especialista.Name = "cmb_Especialista";
            cmb_Especialista.Size = new Size(100, 23);
            cmb_Especialista.TabIndex = 7;
            // 
            // lbl_Especialista
            // 
            lbl_Especialista.AutoSize = true;
            lbl_Especialista.Location = new Point(32, 217);
            lbl_Especialista.Name = "lbl_Especialista";
            lbl_Especialista.Size = new Size(99, 15);
            lbl_Especialista.TabIndex = 8;
            lbl_Especialista.Text = "Elegir Especialista";
            // 
            // txt_Info
            // 
            txt_Info.Location = new Point(41, 291);
            txt_Info.Name = "txt_Info";
            txt_Info.Size = new Size(188, 23);
            txt_Info.TabIndex = 9;
            // 
            // lbl_Info
            // 
            lbl_Info.AutoSize = true;
            lbl_Info.Location = new Point(32, 273);
            lbl_Info.Name = "lbl_Info";
            lbl_Info.Size = new Size(162, 15);
            lbl_Info.TabIndex = 10;
            lbl_Info.Text = "Añadir Informacion necesaria";
            // 
            // btn_AñadirTurno
            // 
            btn_AñadirTurno.Location = new Point(196, 71);
            btn_AñadirTurno.Name = "btn_AñadirTurno";
            btn_AñadirTurno.Size = new Size(75, 23);
            btn_AñadirTurno.TabIndex = 11;
            btn_AñadirTurno.Text = "Añadir";
            btn_AñadirTurno.UseVisualStyleBackColor = true;
            btn_AñadirTurno.Click += btn_AñadirTurno_Click;
            // 
            // cmb_Reportes
            // 
            cmb_Reportes.FormattingEnabled = true;
            cmb_Reportes.Location = new Point(41, 344);
            cmb_Reportes.Name = "cmb_Reportes";
            cmb_Reportes.Size = new Size(121, 23);
            cmb_Reportes.TabIndex = 12;
            // 
            // lbl_Reporte
            // 
            lbl_Reporte.AutoSize = true;
            lbl_Reporte.Location = new Point(32, 326);
            lbl_Reporte.Name = "lbl_Reporte";
            lbl_Reporte.Size = new Size(91, 15);
            lbl_Reporte.TabIndex = 13;
            lbl_Reporte.Text = "Asignar Reporte";
            // 
            // Turno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 427);
            Controls.Add(lbl_Reporte);
            Controls.Add(cmb_Reportes);
            Controls.Add(btn_AñadirTurno);
            Controls.Add(lbl_Info);
            Controls.Add(txt_Info);
            Controls.Add(lbl_Especialista);
            Controls.Add(cmb_Especialista);
            Controls.Add(lbl_Tiempo);
            Controls.Add(dtp_FechaTurno);
            Controls.Add(lbl_Dueño);
            Controls.Add(lbl_Animal);
            Controls.Add(txt_Dueno);
            Controls.Add(cmb_Animal);
            Controls.Add(lbl_Titulo);
            MinimumSize = new Size(317, 373);
            Name = "Turno";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Titulo;
        private ComboBox cmb_Animal;
        private TextBox txt_Dueno;
        private Label lbl_Animal;
        private Label lbl_Dueño;
        private DateTimePicker dtp_FechaTurno;
        private Label lbl_Tiempo;
        private ComboBox cmb_Especialista;
        private Label lbl_Especialista;
        private TextBox txt_Info;
        private Label lbl_Info;
        private Button btn_AñadirTurno;
        private ComboBox cmb_Reportes;
        private Label lbl_Reporte;
    }
}