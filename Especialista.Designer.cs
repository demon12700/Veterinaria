namespace Veterinaria
{
    partial class Especialista
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
            txt_Nombre = new TextBox();
            txt_Espicializacion = new TextBox();
            cmb_Estado = new ComboBox();
            btn_Agregar = new Button();
            txt_Telefono = new TextBox();
            lbl_Nombre = new Label();
            lbl_Especialisacion = new Label();
            lbl_Telefono = new Label();
            lbl_Estado = new Label();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(34, 32);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 0;
            // 
            // txt_Espicializacion
            // 
            txt_Espicializacion.Location = new Point(34, 78);
            txt_Espicializacion.Name = "txt_Espicializacion";
            txt_Espicializacion.Size = new Size(100, 23);
            txt_Espicializacion.TabIndex = 1;
            // 
            // cmb_Estado
            // 
            cmb_Estado.FormattingEnabled = true;
            cmb_Estado.Location = new Point(34, 166);
            cmb_Estado.Name = "cmb_Estado";
            cmb_Estado.Size = new Size(100, 23);
            cmb_Estado.TabIndex = 2;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(196, 31);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(75, 23);
            btn_Agregar.TabIndex = 3;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(34, 122);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(100, 23);
            txt_Telefono.TabIndex = 4;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.BackColor = SystemColors.ScrollBar;
            lbl_Nombre.Location = new Point(12, 14);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(51, 15);
            lbl_Nombre.TabIndex = 5;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Especialisacion
            // 
            lbl_Especialisacion.AutoSize = true;
            lbl_Especialisacion.BackColor = SystemColors.ScrollBar;
            lbl_Especialisacion.Location = new Point(12, 60);
            lbl_Especialisacion.Name = "lbl_Especialisacion";
            lbl_Especialisacion.Size = new Size(86, 15);
            lbl_Especialisacion.TabIndex = 6;
            lbl_Especialisacion.Text = "Especializacion";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.BackColor = SystemColors.ScrollBar;
            lbl_Telefono.Location = new Point(12, 104);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(53, 15);
            lbl_Telefono.TabIndex = 7;
            lbl_Telefono.Text = "Telefono";
            // 
            // lbl_Estado
            // 
            lbl_Estado.AutoSize = true;
            lbl_Estado.BackColor = SystemColors.ScrollBar;
            lbl_Estado.Location = new Point(12, 148);
            lbl_Estado.Name = "lbl_Estado";
            lbl_Estado.Size = new Size(42, 15);
            lbl_Estado.TabIndex = 8;
            lbl_Estado.Text = "Estado";
            // 
            // Especialista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(344, 201);
            Controls.Add(lbl_Estado);
            Controls.Add(lbl_Telefono);
            Controls.Add(lbl_Especialisacion);
            Controls.Add(lbl_Nombre);
            Controls.Add(txt_Telefono);
            Controls.Add(btn_Agregar);
            Controls.Add(cmb_Estado);
            Controls.Add(txt_Espicializacion);
            Controls.Add(txt_Nombre);
            Name = "Especialista";
            Text = "Especialista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Nombre;
        private TextBox txt_Espicializacion;
        private ComboBox cmb_Estado;
        private Button btn_Agregar;
        private TextBox txt_Telefono;
        private Label lbl_Nombre;
        private Label lbl_Especialisacion;
        private Label lbl_Telefono;
        private Label lbl_Estado;
    }
}