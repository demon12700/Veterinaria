namespace Veterinaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            animalToolStripMenuItem = new ToolStripMenuItem();
            dueñoToolStripMenuItem = new ToolStripMenuItem();
            reporteDeAnimalToolStripMenuItem = new ToolStripMenuItem();
            reporteDeSistemaToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            reporteDeAnimalToolStripMenuItem1 = new ToolStripMenuItem();
            reporteDeSistemaToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Highlight;
            menuStrip1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, abrirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { animalToolStripMenuItem, dueñoToolStripMenuItem, reporteDeAnimalToolStripMenuItem, reporteDeSistemaToolStripMenuItem });
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Padding = new Padding(10, 0, 4, 0);
            agregarToolStripMenuItem.Size = new Size(74, 20);
            agregarToolStripMenuItem.Text = "Agregar";
            // 
            // animalToolStripMenuItem
            // 
            animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            animalToolStripMenuItem.Size = new Size(193, 22);
            animalToolStripMenuItem.Text = "Animal";
            animalToolStripMenuItem.Click += animalToolStripMenuItem_Click;
            // 
            // dueñoToolStripMenuItem
            // 
            dueñoToolStripMenuItem.Name = "dueñoToolStripMenuItem";
            dueñoToolStripMenuItem.Size = new Size(193, 22);
            dueñoToolStripMenuItem.Text = "Dueño";
            dueñoToolStripMenuItem.Click += dueñoToolStripMenuItem_Click;
            // 
            // reporteDeAnimalToolStripMenuItem
            // 
            reporteDeAnimalToolStripMenuItem.Name = "reporteDeAnimalToolStripMenuItem";
            reporteDeAnimalToolStripMenuItem.Size = new Size(193, 22);
            reporteDeAnimalToolStripMenuItem.Text = "Reporte de Animal";
            reporteDeAnimalToolStripMenuItem.Click += reporteDeAnimalToolStripMenuItem_Click;
            // 
            // reporteDeSistemaToolStripMenuItem
            // 
            reporteDeSistemaToolStripMenuItem.Name = "reporteDeSistemaToolStripMenuItem";
            reporteDeSistemaToolStripMenuItem.Size = new Size(193, 22);
            reporteDeSistemaToolStripMenuItem.Text = "Reporte de Sistema";
            reporteDeSistemaToolStripMenuItem.Click += reporteDeSistemaToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reporteDeAnimalToolStripMenuItem1, reporteDeSistemaToolStripMenuItem1 });
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(50, 20);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // reporteDeAnimalToolStripMenuItem1
            // 
            reporteDeAnimalToolStripMenuItem1.Name = "reporteDeAnimalToolStripMenuItem1";
            reporteDeAnimalToolStripMenuItem1.Size = new Size(193, 22);
            reporteDeAnimalToolStripMenuItem1.Text = "Reporte de Animal";
            // 
            // reporteDeSistemaToolStripMenuItem1
            // 
            reporteDeSistemaToolStripMenuItem1.Name = "reporteDeSistemaToolStripMenuItem1";
            reporteDeSistemaToolStripMenuItem1.Size = new Size(193, 22);
            reporteDeSistemaToolStripMenuItem1.Text = "Reporte de Sistema";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 195);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(816, 234);
            MinimumSize = new Size(816, 234);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem animalToolStripMenuItem;
        private ToolStripMenuItem dueñoToolStripMenuItem;
        private ToolStripMenuItem reporteDeAnimalToolStripMenuItem;
        private ToolStripMenuItem reporteDeSistemaToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem reporteDeAnimalToolStripMenuItem1;
        private ToolStripMenuItem reporteDeSistemaToolStripMenuItem1;
    }
}
