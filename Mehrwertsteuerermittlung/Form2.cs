using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehrwertsteuerermittlung
{
    public partial class Form2 : Form
    {
        // Eigenschaften für den Dateinamen und Dateipfad, die von Form1 verwendet werden können
        public string? FileName { get; private set; }
        public string? FilePath { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        // Event-Handler für den "Durchsuchen"-Button
        private void button1_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Wählen sie den Speicherort für die CSV-Datei aus.";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_SavePath.Text = folderBrowserDialog.SelectedPath;  // Zeige den ausgewählten Speicherort in der TextBox an
                }
            }
        }

        // Event-Handler für den "CSV-Datei erstellen"-Button
        private void btn_Create_Click(object sender, EventArgs e)
        {
            string fileName = txt_CSVFileName.Text.Trim();

            if (!string.IsNullOrEmpty(fileName))
            {

                string savePath = txt_SavePath.Text.Trim();
                if (!string.IsNullOrEmpty(savePath))
                {
                    FileName = fileName;
                    FilePath = savePath;
                    string fullPath = Path.Combine(savePath, fileName + ".csv");// Erstelle den vollständigen Pfad zur CSV-Datei


                    try
                    {

                        using (StreamWriter writer = new StreamWriter(fullPath, true))
                        {
                            writer.WriteLine("Datum // Bruttobetrag // Mwst // Nettobetrag");
                        }

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler beim Erstellen der CSV-Datei: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Bitte wählen Sie einen Speicherort aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Dateinamen ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Event-Handler für den "Abbrechen"-Button
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
