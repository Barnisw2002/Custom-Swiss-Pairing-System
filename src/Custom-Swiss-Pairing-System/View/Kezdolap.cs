using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Custom_Swiss_Pairing_System.Controller;
using Custom_Swiss_Pairing_System.DAO;
using Custom_Swiss_Pairing_System.Model;

namespace Custom_Swiss_Pairing_System.View
{
    public partial class Kezdolap : Form
    {
        private JatekosController jatekosController;
        private SQLiteConnection conn;
        private bool dbconnection = false;

        public Kezdolap()
        {
            InitializeComponent();
        }
        private string adatbazis()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "SQLite3 Database files (*.sqlite3;*.db)|*.sqlite3;*.db|All files (*.*)|*.*";
                openFileDialog.Title = "Válassza ki az SQLite adatbázist";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        // Tesztkapcsolat létrehozása és táblák lekérdezése
                        using (var testConnection = new SQLiteConnection($"Data Source={filePath};Version=3;"))
                        {
                            testConnection.Open(); // Kapcsolódási teszt

                            // Lekérdezzük az adatbázis tábláinak nevét
                            string query = "SELECT name FROM sqlite_master WHERE type='table';";
                            using (var command = new SQLiteCommand(query, testConnection))
                            using (var reader = command.ExecuteReader())
                            {
                                // Ellenőrizzük, van-e legalább egy tábla az adatbázisban
                                if (reader.HasRows)
                                {
                                    //MessageBox.Show("Adatbázis sikeresen kiválasztva és táblák elérhetők!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    testConnection.Close();
                                    dbconnection = true;
                                    return filePath;
                                }
                                else
                                {
                                    dbconnection = false;
                                    MessageBox.Show("Az adatbázis üres (nincsenek táblák).", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba történt az adatbázis csatlakoztatása közben: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return null;
        }

        private void sqliteAdatbázsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jatekosController = new JatekosController(new JatekosSqliteDao($"Data Source={adatbazis()}"));
        }

        private void listázásToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var items = jatekosController.getJatekosok().ToList();

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = items;

            // Elrejtjük az Id oszlopot
            //dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Visible = true;
        }

        private void hozzáadásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var jatekossdatlap = new JatekosAdatlap(jatekosController);
            jatekossdatlap.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null &&
            e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Jatekos jatekos = (Jatekos)dataGridView1.CurrentRow.DataBoundItem;
                using var jatekModif = new JatekosAdatlap(jatekosController, jatekos);
                DialogResult res = jatekModif.ShowDialog();
            }
        }
    }
}
