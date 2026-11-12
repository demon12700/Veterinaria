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
            turnoToolStripMenuItem = new ToolStripMenuItem();
            dueñoToolStripMenuItem = new ToolStripMenuItem();
            reporteDeAnimalToolStripMenuItem = new ToolStripMenuItem();
            reporteDeSistemaToolStripMenuItem = new ToolStripMenuItem();
            especialistaToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            reporteDeAnimalToolStripMenuItem1 = new ToolStripMenuItem();
            tscmb_ReporteAnimal = new ToolStripComboBox();
            reporteDeSistemaToolStripMenuItem1 = new ToolStripMenuItem();
            tscmb_ReporteSistema = new ToolStripComboBox();
            verEspecialistasToolStripMenuItem = new ToolStripMenuItem();
            tscmb_Especialistas = new ToolStripComboBox();
            turnoToolStripMenuItem1 = new ToolStripMenuItem();
            tscmb_Turnos = new ToolStripComboBox();
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
            agregarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { especialistaToolStripMenuItem, animalToolStripMenuItem, dueñoToolStripMenuItem, reporteDeAnimalToolStripMenuItem, reporteDeSistemaToolStripMenuItem, turnoToolStripMenuItem });
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
            // turnoToolStripMenuItem
            // 
            turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
            turnoToolStripMenuItem.Size = new Size(193, 22);
            turnoToolStripMenuItem.Text = "Turno";
            turnoToolStripMenuItem.Click += turnoToolStripMenuItem_Click;
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
            // especialistaToolStripMenuItem
            // 
            especialistaToolStripMenuItem.Name = "especialistaToolStripMenuItem";
            especialistaToolStripMenuItem.Size = new Size(193, 22);
            especialistaToolStripMenuItem.Text = "Especialista";
            especialistaToolStripMenuItem.Click += especialistaToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reporteDeAnimalToolStripMenuItem1, reporteDeSistemaToolStripMenuItem1, verEspecialistasToolStripMenuItem, turnoToolStripMenuItem1 });
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(39, 20);
            abrirToolStripMenuItem.Text = "Ver";
            // 
            // reporteDeAnimalToolStripMenuItem1
            // 
            reporteDeAnimalToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { tscmb_ReporteAnimal });
            reporteDeAnimalToolStripMenuItem1.Name = "reporteDeAnimalToolStripMenuItem1";
            reporteDeAnimalToolStripMenuItem1.Size = new Size(193, 22);
            reporteDeAnimalToolStripMenuItem1.Text = "Reporte de Animal";
            // 
            // tscmb_ReporteAnimal
            // 
            tscmb_ReporteAnimal.Name = "tscmb_ReporteAnimal";
            tscmb_ReporteAnimal.Size = new Size(121, 23);
            // 
            // reporteDeSistemaToolStripMenuItem1
            // 
            reporteDeSistemaToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { tscmb_ReporteSistema });
            reporteDeSistemaToolStripMenuItem1.Name = "reporteDeSistemaToolStripMenuItem1";
            reporteDeSistemaToolStripMenuItem1.Size = new Size(193, 22);
            reporteDeSistemaToolStripMenuItem1.Text = "Reporte de Sistema";
            // 
            // tscmb_ReporteSistema
            // 
            tscmb_ReporteSistema.Name = "tscmb_ReporteSistema";
            tscmb_ReporteSistema.Size = new Size(121, 23);
            // 
            // verEspecialistasToolStripMenuItem
            // 
            verEspecialistasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tscmb_Especialistas });
            verEspecialistasToolStripMenuItem.Name = "verEspecialistasToolStripMenuItem";
            verEspecialistasToolStripMenuItem.Size = new Size(193, 22);
            verEspecialistasToolStripMenuItem.Text = "ver Especialistas";
            // 
            // tscmb_Especialistas
            // 
            tscmb_Especialistas.Name = "tscmb_Especialistas";
            tscmb_Especialistas.Size = new Size(121, 23);
            // 
            // turnoToolStripMenuItem1
            // 
            turnoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { tscmb_Turnos });
            turnoToolStripMenuItem1.Name = "turnoToolStripMenuItem1";
            turnoToolStripMenuItem1.Size = new Size(193, 22);
            turnoToolStripMenuItem1.Text = "Turno";
            // 
            // tscmb_Turnos
            // 
            tscmb_Turnos.Name = "tscmb_Turnos";
            tscmb_Turnos.Size = new Size(121, 23);
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
        private ToolStripMenuItem turnoToolStripMenuItem;
        private ToolStripMenuItem reporteDeAnimalToolStripMenuItem1;
        private ToolStripMenuItem reporteDeSistemaToolStripMenuItem1;
        private ToolStripMenuItem turnoToolStripMenuItem1;
        private ToolStripMenuItem especialistaToolStripMenuItem;
        private ToolStripMenuItem verEspecialistasToolStripMenuItem;
        private ToolStripComboBox tscmb_ReporteAnimal;
        private ToolStripComboBox tscmb_ReporteSistema;
        private ToolStripComboBox tscmb_Especialistas;
        private ToolStripComboBox tscmb_Turnos;
    }
}
