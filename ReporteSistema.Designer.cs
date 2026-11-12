namespace Veterinaria
{
    partial class ReporteSistema
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
            txt_dueñosCantidad = new TextBox();
            txt_animalesCantidad = new TextBox();
            txt_reportesCantidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_Observaciones = new TextBox();
            btn_Guardar = new Button();
            SuspendLayout();
            // 
            // txt_dueñosCantidad
            // 
            txt_dueñosCantidad.Enabled = false;
            txt_dueñosCantidad.Location = new Point(12, 72);
            txt_dueñosCantidad.Name = "txt_dueñosCantidad";
            txt_dueñosCantidad.ReadOnly = true;
            txt_dueñosCantidad.Size = new Size(140, 23);
            txt_dueñosCantidad.TabIndex = 0;
            txt_dueñosCantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_animalesCantidad
            // 
            txt_animalesCantidad.Enabled = false;
            txt_animalesCantidad.Location = new Point(12, 131);
            txt_animalesCantidad.Name = "txt_animalesCantidad";
            txt_animalesCantidad.ReadOnly = true;
            txt_animalesCantidad.Size = new Size(140, 23);
            txt_animalesCantidad.TabIndex = 1;
            txt_animalesCantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_reportesCantidad
            // 
            txt_reportesCantidad.Enabled = false;
            txt_reportesCantidad.Location = new Point(12, 190);
            txt_reportesCantidad.Name = "txt_reportesCantidad";
            txt_reportesCantidad.ReadOnly = true;
            txt_reportesCantidad.Size = new Size(140, 23);
            txt_reportesCantidad.TabIndex = 2;
            txt_reportesCantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 3;
            label1.Text = "Cantidad de Dueños";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 4;
            label2.Text = "Cantidad de Animales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 5;
            label3.Text = "Cantidad de Reportes";
            // 
            // txt_Observaciones
            // 
            txt_Observaciones.Location = new Point(12, 241);
            txt_Observaciones.Name = "txt_Observaciones";
            txt_Observaciones.Size = new Size(298, 23);
            txt_Observaciones.TabIndex = 6;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(235, 71);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(75, 23);
            btn_Guardar.TabIndex = 7;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // ReporteSistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(346, 450);
            Controls.Add(btn_Guardar);
            Controls.Add(txt_Observaciones);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_reportesCantidad);
            Controls.Add(txt_animalesCantidad);
            Controls.Add(txt_dueñosCantidad);
            MaximumSize = new Size(771, 489);
            MinimumSize = new Size(362, 489);
            Name = "ReporteSistema";
            Text = "ReporteSistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_dueñosCantidad;
        private TextBox txt_animalesCantidad;
        private TextBox txt_reportesCantidad;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_Observaciones;
        private Button btn_Guardar;
    }
}