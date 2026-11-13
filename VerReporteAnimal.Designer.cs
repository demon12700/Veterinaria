namespace Veterinaria
{
    partial class VerReporteAnimal
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
            dtgv_Reportes = new DataGridView();
            btn_Eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv_Reportes).BeginInit();
            SuspendLayout();
            // 
            // dtgv_Reportes
            // 
            dtgv_Reportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgv_Reportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_Reportes.Location = new Point(12, 12);
            dtgv_Reportes.Name = "dtgv_Reportes";
            dtgv_Reportes.Size = new Size(518, 426);
            dtgv_Reportes.TabIndex = 0;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Eliminar.Font = new Font("Segoe UI", 14F);
            btn_Eliminar.Location = new Point(554, 12);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(128, 70);
            btn_Eliminar.TabIndex = 1;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // VerReporteAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 450);
            Controls.Add(btn_Eliminar);
            Controls.Add(dtgv_Reportes);
            Name = "VerReporteAnimal";
            Text = "VerReporteAnimal";
            ((System.ComponentModel.ISupportInitialize)dtgv_Reportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgv_Reportes;
        private Button btn_Eliminar;
    }
}