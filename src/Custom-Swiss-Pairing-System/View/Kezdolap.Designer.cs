namespace Custom_Swiss_Pairing_System.View
{
    partial class Kezdolap
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fájlToolStripMenuItem = new ToolStripMenuItem();
            beolvasásToolStripMenuItem = new ToolStripMenuItem();
            sqliteAdatbázsToolStripMenuItem = new ToolStripMenuItem();
            ListDataGridView = new ToolStripMenuItem();
            játékosToolStripMenuItem = new ToolStripMenuItem();
            hozzáadásToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            jatekosBindingSource = new BindingSource(components);
            jatekosBindingSource1 = new BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jatekosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jatekosBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fájlToolStripMenuItem, ListDataGridView, játékosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            fájlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { beolvasásToolStripMenuItem });
            fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            fájlToolStripMenuItem.Size = new Size(41, 23);
            fájlToolStripMenuItem.Text = "Fájl";
            // 
            // beolvasásToolStripMenuItem
            // 
            beolvasásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sqliteAdatbázsToolStripMenuItem });
            beolvasásToolStripMenuItem.Name = "beolvasásToolStripMenuItem";
            beolvasásToolStripMenuItem.Size = new Size(137, 24);
            beolvasásToolStripMenuItem.Text = "Beolvasás";
            // 
            // sqliteAdatbázsToolStripMenuItem
            // 
            sqliteAdatbázsToolStripMenuItem.Name = "sqliteAdatbázsToolStripMenuItem";
            sqliteAdatbázsToolStripMenuItem.Size = new Size(169, 24);
            sqliteAdatbázsToolStripMenuItem.Text = "Sqlite adatbázs";
            sqliteAdatbázsToolStripMenuItem.Click += sqliteAdatbázsToolStripMenuItem_Click;
            // 
            // ListDataGridView
            // 
            ListDataGridView.Name = "ListDataGridView";
            ListDataGridView.Size = new Size(68, 23);
            ListDataGridView.Text = "Listázás";
            ListDataGridView.Click += listázásToolStripMenuItem_Click_1;
            // 
            // játékosToolStripMenuItem
            // 
            játékosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hozzáadásToolStripMenuItem });
            játékosToolStripMenuItem.Name = "játékosToolStripMenuItem";
            játékosToolStripMenuItem.Size = new Size(66, 23);
            játékosToolStripMenuItem.Text = "Játékos";
            // 
            // hozzáadásToolStripMenuItem
            // 
            hozzáadásToolStripMenuItem.Name = "hozzáadásToolStripMenuItem";
            hozzáadásToolStripMenuItem.Size = new Size(143, 24);
            hozzáadásToolStripMenuItem.Text = "Hozzáadás";
            hozzáadásToolStripMenuItem.Click += hozzáadásToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 423);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // jatekosBindingSource
            // 
            jatekosBindingSource.DataSource = typeof(Model.Jatekos);
            // 
            // jatekosBindingSource1
            // 
            jatekosBindingSource1.DataSource = typeof(Model.Jatekos);
            // 
            // Kezdolap
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Kezdolap";
            Text = "Custom swiss pairing software";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)jatekosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)jatekosBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fájlToolStripMenuItem;
        private ToolStripMenuItem beolvasásToolStripMenuItem;
        private ToolStripMenuItem sqliteAdatbázsToolStripMenuItem;
        private ToolStripMenuItem ListDataGridView;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn szuletisiIdoDataGridViewTextBoxColumn;
        private BindingSource jatekosBindingSource;
        private BindingSource jatekosBindingSource1;
        private ToolStripMenuItem játékosToolStripMenuItem;
        private ToolStripMenuItem hozzáadásToolStripMenuItem;
    }
}