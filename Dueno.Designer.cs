namespace Veterinaria
{
    partial class Dueno
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
            txt_Telefono = new TextBox();
            txt_Correo = new TextBox();
            lbl_Nombre = new Label();
            Telefono = new Label();
            lbl_Correo = new Label();
            dtgv_Duenos = new DataGridView();
            btn_Agregar = new Button();
            btn_Eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv_Duenos).BeginInit();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(36, 43);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 0;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(36, 101);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(100, 23);
            txt_Telefono.TabIndex = 1;
            // 
            // txt_Correo
            // 
            txt_Correo.Location = new Point(36, 154);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(100, 23);
            txt_Correo.TabIndex = 2;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(36, 25);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(51, 15);
            lbl_Nombre.TabIndex = 3;
            lbl_Nombre.Text = "Nombre";
            // 
            // Telefono
            // 
            Telefono.AutoSize = true;
            Telefono.Location = new Point(36, 83);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(53, 15);
            Telefono.TabIndex = 4;
            Telefono.Text = "Telefono";
            // 
            // lbl_Correo
            // 
            lbl_Correo.AutoSize = true;
            lbl_Correo.Location = new Point(36, 136);
            lbl_Correo.Name = "lbl_Correo";
            lbl_Correo.Size = new Size(43, 15);
            lbl_Correo.TabIndex = 5;
            lbl_Correo.Text = "Correo";
            // 
            // dtgv_Duenos
            // 
            dtgv_Duenos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_Duenos.Location = new Point(306, 43);
            dtgv_Duenos.Name = "dtgv_Duenos";
            dtgv_Duenos.Size = new Size(461, 395);
            dtgv_Duenos.TabIndex = 6;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(225, 43);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(75, 23);
            btn_Agregar.TabIndex = 7;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(225, 75);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(75, 23);
            btn_Eliminar.TabIndex = 8;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // Dueno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Agregar);
            Controls.Add(dtgv_Duenos);
            Controls.Add(lbl_Correo);
            Controls.Add(Telefono);
            Controls.Add(lbl_Nombre);
            Controls.Add(txt_Correo);
            Controls.Add(txt_Telefono);
            Controls.Add(txt_Nombre);
            Name = "Dueno";
            Text = "Dueno";
            ((System.ComponentModel.ISupportInitialize)dtgv_Duenos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Nombre;
        private TextBox txt_Telefono;
        private TextBox txt_Correo;
        private Label lbl_Nombre;
        private Label Telefono;
        private Label lbl_Correo;
        private DataGridView dtgv_Duenos;
        private Button btn_Agregar;
        private Button btn_Eliminar;
    }
}