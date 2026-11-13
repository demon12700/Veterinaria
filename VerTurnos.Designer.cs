namespace Veterinaria
{
    partial class VerTurnos
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
            dtgv_Turnos = new DataGridView();
            btn_Eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv_Turnos).BeginInit();
            SuspendLayout();
            // 
            // dtgv_Turnos
            // 
            dtgv_Turnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgv_Turnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_Turnos.Location = new Point(12, 12);
            dtgv_Turnos.Name = "dtgv_Turnos";
            dtgv_Turnos.Size = new Size(387, 406);
            dtgv_Turnos.TabIndex = 0;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Eliminar.Font = new Font("Segoe UI", 14F);
            btn_Eliminar.Location = new Point(441, 12);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(135, 72);
            btn_Eliminar.TabIndex = 1;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // VerTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(btn_Eliminar);
            Controls.Add(dtgv_Turnos);
            Name = "VerTurnos";
            Text = "VerTurnos";
            ((System.ComponentModel.ISupportInitialize)dtgv_Turnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgv_Turnos;
        private Button btn_Eliminar;
    }
}