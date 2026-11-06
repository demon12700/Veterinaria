namespace Veterinaria
{
    partial class reporteAnimal
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
            txt_Dueño = new TextBox();
            txt_contenidoReporte = new TextBox();
            dia_Reporte = new DateTimePicker();
            lbl_Animal = new Label();
            lbl_Dueño = new Label();
            cmBox_Animal = new ComboBox();
            lbl_Reporte = new Label();
            btn_Agregar = new Button();
            SuspendLayout();
            // 
            // txt_Dueño
            // 
            txt_Dueño.BackColor = SystemColors.ControlLightLight;
            txt_Dueño.Enabled = false;
            txt_Dueño.Location = new Point(37, 99);
            txt_Dueño.Name = "txt_Dueño";
            txt_Dueño.ReadOnly = true;
            txt_Dueño.Size = new Size(100, 23);
            txt_Dueño.TabIndex = 1;
            // 
            // txt_contenidoReporte
            // 
            txt_contenidoReporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_contenidoReporte.BackColor = SystemColors.HotTrack;
            txt_contenidoReporte.ForeColor = SystemColors.WindowText;
            txt_contenidoReporte.Location = new Point(37, 172);
            txt_contenidoReporte.Margin = new Padding(0);
            txt_contenidoReporte.Multiline = true;
            txt_contenidoReporte.Name = "txt_contenidoReporte";
            txt_contenidoReporte.Size = new Size(540, 80);
            txt_contenidoReporte.TabIndex = 2;
            // 
            // dia_Reporte
            // 
            dia_Reporte.Format = DateTimePickerFormat.Short;
            dia_Reporte.Location = new Point(37, 143);
            dia_Reporte.Name = "dia_Reporte";
            dia_Reporte.Size = new Size(100, 23);
            dia_Reporte.TabIndex = 3;
            // 
            // lbl_Animal
            // 
            lbl_Animal.AutoSize = true;
            lbl_Animal.Location = new Point(37, 37);
            lbl_Animal.Name = "lbl_Animal";
            lbl_Animal.Size = new Size(45, 15);
            lbl_Animal.TabIndex = 4;
            lbl_Animal.Text = "Animal";
            // 
            // lbl_Dueño
            // 
            lbl_Dueño.AutoSize = true;
            lbl_Dueño.Location = new Point(37, 81);
            lbl_Dueño.Name = "lbl_Dueño";
            lbl_Dueño.Size = new Size(42, 15);
            lbl_Dueño.TabIndex = 5;
            lbl_Dueño.Text = "Dueño";
            // 
            // cmBox_Animal
            // 
            cmBox_Animal.FormattingEnabled = true;
            cmBox_Animal.Location = new Point(37, 55);
            cmBox_Animal.Name = "cmBox_Animal";
            cmBox_Animal.Size = new Size(100, 23);
            cmBox_Animal.TabIndex = 6;
            cmBox_Animal.SelectedIndexChanged += cmBox_Animal_SelectedIndexChanged;
            // 
            // lbl_Reporte
            // 
            lbl_Reporte.AutoSize = true;
            lbl_Reporte.Location = new Point(37, 125);
            lbl_Reporte.Name = "lbl_Reporte";
            lbl_Reporte.Size = new Size(87, 15);
            lbl_Reporte.TabIndex = 7;
            lbl_Reporte.Text = "Dia del Reporte";
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(180, 54);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(115, 23);
            btn_Agregar.TabIndex = 8;
            btn_Agregar.Text = "Agregar Reporte";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // reporteAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(589, 264);
            Controls.Add(btn_Agregar);
            Controls.Add(lbl_Reporte);
            Controls.Add(cmBox_Animal);
            Controls.Add(lbl_Dueño);
            Controls.Add(lbl_Animal);
            Controls.Add(dia_Reporte);
            Controls.Add(txt_contenidoReporte);
            Controls.Add(txt_Dueño);
            MaximumSize = new Size(605, 500);
            MinimumSize = new Size(605, 303);
            Name = "reporteAnimal";
            Text = "reporteAnimal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Dueño;
        private TextBox txt_contenidoReporte;
        private DateTimePicker dia_Reporte;
        private Label lbl_Animal;
        private Label lbl_Dueño;
        private ComboBox cmBox_Animal;
        private Label lbl_Reporte;
        private Button btn_Agregar;
    }
}