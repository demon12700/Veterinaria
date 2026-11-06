namespace Veterinaria
{
    partial class Animal
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
            txt_Tipo = new TextBox();
            txt_Edad = new TextBox();
            lbl_Nombre = new Label();
            lbl_Tipo = new Label();
            lbl_Edad = new Label();
            dgv_Animales = new DataGridView();
            btn_agregarAnimal = new Button();
            btn_eliminarAnimal = new Button();
            cmBox_Dueño = new ComboBox();
            lbl_Dueño = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Animales).BeginInit();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(43, 43);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 0;
            // 
            // txt_Tipo
            // 
            txt_Tipo.Location = new Point(43, 106);
            txt_Tipo.Name = "txt_Tipo";
            txt_Tipo.Size = new Size(100, 23);
            txt_Tipo.TabIndex = 1;
            // 
            // txt_Edad
            // 
            txt_Edad.Location = new Point(43, 163);
            txt_Edad.Name = "txt_Edad";
            txt_Edad.Size = new Size(100, 23);
            txt_Edad.TabIndex = 2;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(43, 25);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(51, 15);
            lbl_Nombre.TabIndex = 3;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Tipo
            // 
            lbl_Tipo.AutoSize = true;
            lbl_Tipo.Location = new Point(43, 88);
            lbl_Tipo.Name = "lbl_Tipo";
            lbl_Tipo.Size = new Size(31, 15);
            lbl_Tipo.TabIndex = 4;
            lbl_Tipo.Text = "Tipo";
            // 
            // lbl_Edad
            // 
            lbl_Edad.AutoSize = true;
            lbl_Edad.Location = new Point(43, 145);
            lbl_Edad.Name = "lbl_Edad";
            lbl_Edad.Size = new Size(33, 15);
            lbl_Edad.TabIndex = 5;
            lbl_Edad.Text = "Edad";
            // 
            // dgv_Animales
            // 
            dgv_Animales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Animales.BackgroundColor = SystemColors.HotTrack;
            dgv_Animales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Animales.Location = new Point(326, 43);
            dgv_Animales.Name = "dgv_Animales";
            dgv_Animales.Size = new Size(403, 395);
            dgv_Animales.TabIndex = 6;
            // 
            // btn_agregarAnimal
            // 
            btn_agregarAnimal.Location = new Point(242, 42);
            btn_agregarAnimal.Name = "btn_agregarAnimal";
            btn_agregarAnimal.Size = new Size(75, 23);
            btn_agregarAnimal.TabIndex = 7;
            btn_agregarAnimal.Text = "Agregar";
            btn_agregarAnimal.UseVisualStyleBackColor = true;
            btn_agregarAnimal.Click += btn_agregarAnimal_Click;
            // 
            // btn_eliminarAnimal
            // 
            btn_eliminarAnimal.Location = new Point(242, 71);
            btn_eliminarAnimal.Name = "btn_eliminarAnimal";
            btn_eliminarAnimal.Size = new Size(75, 23);
            btn_eliminarAnimal.TabIndex = 8;
            btn_eliminarAnimal.Text = "Eliminar";
            btn_eliminarAnimal.UseVisualStyleBackColor = true;
            btn_eliminarAnimal.Click += btn_eliminarAnimal_Click;
            // 
            // cmBox_Dueño
            // 
            cmBox_Dueño.FormattingEnabled = true;
            cmBox_Dueño.Location = new Point(43, 215);
            cmBox_Dueño.Name = "cmBox_Dueño";
            cmBox_Dueño.Size = new Size(100, 23);
            cmBox_Dueño.TabIndex = 9;
            // 
            // lbl_Dueño
            // 
            lbl_Dueño.AutoSize = true;
            lbl_Dueño.Location = new Point(43, 197);
            lbl_Dueño.Name = "lbl_Dueño";
            lbl_Dueño.Size = new Size(42, 15);
            lbl_Dueño.TabIndex = 10;
            lbl_Dueño.Text = "Dueño";
            // 
            // Animal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(741, 450);
            Controls.Add(lbl_Dueño);
            Controls.Add(cmBox_Dueño);
            Controls.Add(btn_eliminarAnimal);
            Controls.Add(btn_agregarAnimal);
            Controls.Add(dgv_Animales);
            Controls.Add(lbl_Edad);
            Controls.Add(lbl_Tipo);
            Controls.Add(lbl_Nombre);
            Controls.Add(txt_Edad);
            Controls.Add(txt_Tipo);
            Controls.Add(txt_Nombre);
            MaximumSize = new Size(757, 489);
            MinimumSize = new Size(584, 489);
            Name = "Animal";
            Text = "Animal";
            ((System.ComponentModel.ISupportInitialize)dgv_Animales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Nombre;
        private TextBox txt_Tipo;
        private TextBox txt_Edad;
        private Label lbl_Nombre;
        private Label lbl_Tipo;
        private Label lbl_Edad;
        private DataGridView dgv_Animales;
        private Button btn_agregarAnimal;
        private Button btn_eliminarAnimal;
        private ComboBox cmBox_Dueño;
        private Label lbl_Dueño;
    }
}