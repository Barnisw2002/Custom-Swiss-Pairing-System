
namespace Custom_Swiss_Pairing_System.View
{
    partial class JatekosAdatlap
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
            jatekos = new Label();
            nev = new TextBox();
            Hozzáadás = new Button();
            Név = new Label();
            Nem = new Label();
            identitas = new TextBox();
            SzuletesiIdo = new Label();
            szulido = new TextBox();
            Rang = new Label();
            rangja = new TextBox();
            Regio = new Label();
            regioja = new TextBox();
            Elkerules = new Label();
            elker = new TextBox();
            Törlés = new Button();
            SuspendLayout();
            // 
            // jatekos
            // 
            jatekos.AutoSize = true;
            jatekos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            jatekos.Location = new Point(46, 26);
            jatekos.Name = "jatekos";
            jatekos.Size = new Size(219, 37);
            jatekos.TabIndex = 0;
            jatekos.Text = "Játékos adatlap";
            // 
            // nev
            // 
            nev.Location = new Point(147, 93);
            nev.Name = "nev";
            nev.Size = new Size(118, 26);
            nev.TabIndex = 1;
            // 
            // Hozzáadás
            // 
            Hozzáadás.DialogResult = DialogResult.OK;
            Hozzáadás.Location = new Point(180, 307);
            Hozzáadás.Name = "Hozzáadás";
            Hozzáadás.Size = new Size(75, 27);
            Hozzáadás.TabIndex = 2;
            Hozzáadás.Text = "Hozzáadás";
            Hozzáadás.UseVisualStyleBackColor = true;
            Hozzáadás.Click += hozzad_click;
            // 
            // Név
            // 
            Név.AutoSize = true;
            Név.Location = new Point(46, 96);
            Név.Name = "Név";
            Név.Size = new Size(33, 19);
            Név.TabIndex = 5;
            Név.Text = "Név";
            // 
            // Nem
            // 
            Nem.AutoSize = true;
            Nem.Location = new Point(46, 125);
            Nem.Name = "Nem";
            Nem.Size = new Size(38, 19);
            Nem.TabIndex = 7;
            Nem.Text = "Nem";
            // 
            // identitas
            // 
            identitas.Location = new Point(147, 125);
            identitas.Name = "identitas";
            identitas.Size = new Size(118, 26);
            identitas.TabIndex = 6;
            // 
            // SzuletesiIdo
            // 
            SzuletesiIdo.AutoSize = true;
            SzuletesiIdo.Location = new Point(46, 160);
            SzuletesiIdo.Name = "SzuletesiIdo";
            SzuletesiIdo.Size = new Size(84, 19);
            SzuletesiIdo.TabIndex = 9;
            SzuletesiIdo.Text = "Szuletesi idő";
            // 
            // szulido
            // 
            szulido.Location = new Point(147, 157);
            szulido.Name = "szulido";
            szulido.Size = new Size(118, 26);
            szulido.TabIndex = 8;
            // 
            // Rang
            // 
            Rang.AutoSize = true;
            Rang.Location = new Point(46, 192);
            Rang.Name = "Rang";
            Rang.Size = new Size(40, 19);
            Rang.TabIndex = 11;
            Rang.Text = "Rang";
            // 
            // rangja
            // 
            rangja.Location = new Point(147, 189);
            rangja.Name = "rangja";
            rangja.Size = new Size(118, 26);
            rangja.TabIndex = 10;
            // 
            // Regio
            // 
            Regio.AutoSize = true;
            Regio.Location = new Point(46, 224);
            Regio.Name = "Regio";
            Regio.Size = new Size(43, 19);
            Regio.TabIndex = 13;
            Regio.Text = "Régió";
            // 
            // regioja
            // 
            regioja.Location = new Point(147, 221);
            regioja.Name = "regioja";
            regioja.Size = new Size(118, 26);
            regioja.TabIndex = 12;
            // 
            // Elkerules
            // 
            Elkerules.AutoSize = true;
            Elkerules.Location = new Point(46, 256);
            Elkerules.Name = "Elkerules";
            Elkerules.Size = new Size(62, 19);
            Elkerules.TabIndex = 15;
            Elkerules.Text = "Elkerülés";
            // 
            // elker
            // 
            elker.Location = new Point(147, 253);
            elker.Name = "elker";
            elker.Size = new Size(118, 26);
            elker.TabIndex = 14;
            // 
            // Törlés
            // 
            Törlés.DialogResult = DialogResult.OK;
            Törlés.Location = new Point(56, 307);
            Törlés.Name = "Törlés";
            Törlés.Size = new Size(75, 27);
            Törlés.TabIndex = 16;
            Törlés.Text = "Törlés";
            Törlés.UseVisualStyleBackColor = true;
            Törlés.Click += torles_Click;
            // 
            // JatekosAdatlap
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 374);
            Controls.Add(Törlés);
            Controls.Add(Elkerules);
            Controls.Add(elker);
            Controls.Add(Regio);
            Controls.Add(regioja);
            Controls.Add(Rang);
            Controls.Add(rangja);
            Controls.Add(SzuletesiIdo);
            Controls.Add(szulido);
            Controls.Add(Nem);
            Controls.Add(identitas);
            Controls.Add(Név);
            Controls.Add(Hozzáadás);
            Controls.Add(nev);
            Controls.Add(jatekos);
            Name = "JatekosAdatlap";
            Text = "Játékos adatlap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label jatekos;
        private TextBox nev;
        private Button Hozzáadás;
        private Label Név;
        private Label Nem;
        private TextBox identitas;
        private Label SzuletesiIdo;
        private TextBox szulido;
        private Label Rang;
        private TextBox rangja;
        private Label Regio;
        private TextBox regioja;
        private Label Elkerules;
        private TextBox elker;
        private Button Törlés;
    }
}