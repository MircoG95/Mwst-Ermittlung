using System.Text;

namespace Mehrwertsteuerermittlung
{
    public partial class Form1 : Form
    {
        private string csvFilePath = ""; //Pfad zur ausgewählten CSV-Datei
        public Form1()
        {
            InitializeComponent();
        }


        //Event-Handler für den "Berechnen"-Button
        private void btn_berechnen_Click(object sender, EventArgs e)
        {
            string inputText = txt_BetragInput.Text;
            decimal mwst7 = 1.07m;
            decimal mwst19 = 1.19m;

            if (decimal.TryParse(inputText, out decimal betrag))
            {
                // Berechne Mehrwertsteuer und Nettobetrag basierend auf dem ausgewählten Radiobutton
                if (rBtn_Seven.Checked)
                {
                    decimal ergebnis = betrag / mwst7;
                    txt_BetragOutput.Text = Math.Round(ergebnis, 2).ToString();
                }
                else
                {
                    decimal ergebnis = betrag / mwst19;
                    txt_BetragOutput.Text = Math.Round(ergebnis, 2).ToString();
                }
            }
            else
            {
                MessageBox.Show("Ungültige Eingabe! Bitte geben Sie eine Zahl ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Event-Handler für den "Datei auswählen"-Button
        private void btn_SelectAndSaveInCSV_Click(object sender, EventArgs e) // Name ändern dieser Methode
        {
            // Öffnet einen Dateiauswahldialog zum Auswählen der CSV-Datei
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSV Datei (*.csv)|*.csv";
                dialog.OverwritePrompt = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Überprüfe, ob die ausgewählte Datei eine CSV-Datei ist
                    if (Path.GetExtension(dialog.FileName).Equals(".csv", StringComparison.OrdinalIgnoreCase))
                    {
                        csvFilePath = dialog.FileName; // Speichere den ausgewählten Pfad in der Klassenvariable
                        txt_dateiName.Text = Path.GetFileName(csvFilePath); // Zeige den Dateinamen in der TextBox an
                    }
                }
            }
        }

        // Speichert die Daten in der ausgewählten CSV-Datei
        private void SaveInCSV(DateTime date, decimal bruttobetrag, string mwstRate, decimal nettobetrag)
        {
            try
            {
                nettobetrag = Math.Round(nettobetrag, 2); // Runde den Nettobetrag auf 2 Nachkommastellen

                bool isFileEmpty = new FileInfo(csvFilePath).Length == 0;
                using (StreamWriter writer = new StreamWriter(csvFilePath, true, Encoding.UTF8))
                {
                    // Wenn die Datei leer ist, schreibe eine Überschrift
                    if (isFileEmpty)
                    {
                        writer.WriteLine("Datum // Bruttobetrag // Mwst // Nettobetrag");
                    }
                    string formatedBrutto = bruttobetrag.ToString("C2");// Formatierter Bruttobetrag als Euro
                    string formatedNetto = nettobetrag.ToString("C2");// Formatierter Nettobetrag als Euro

                    string formattedDate = date.ToString("dd.MM.yyyy"); // Formatiertes Datum (nur Tag/Monat/Jahr)
                    string formattedTime = date.ToString("HH:mm"); // Formatierte Uhrzeit (Stunden:Minuten)

                    // Schreibe die Daten in die CSV-Datei
                    writer.WriteLine($"{formattedDate} {formattedTime} // {formatedBrutto} // {mwstRate} // {formatedNetto}");
                }


                MessageBox.Show("Daten wurden erfolgreich in die CSV-Datei hinzugefügt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern in die CSV- Datei: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_BetragInput.Clear();
            txt_BetragOutput.Clear();
        }
        // Event-Handler für den "CSV-Datei erstellen"-Button
        private void btn_CreateCSVFile_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Öffne Form2 (neues Fenster) für die Erstellung einer CSV-Datei
            form2.ShowDialog();
        }

        // Event-Handler für den "Schließen"-Button
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (csvFilePath == "")
            {
                MessageBox.Show("Bitte Wählen Sie eine Datei aus, um die Daten zu Speichern.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string bruttoBetrag = txt_BetragInput.Text;

            if (decimal.TryParse(bruttoBetrag, out decimal betrag))
            {
                string mwstRate = rBtn_Seven.Checked ? "7%" : "19%";
                decimal nettoBetrag = decimal.Parse(txt_BetragOutput.Text);


                SaveInCSV(DateTime.Now, betrag, mwstRate, nettoBetrag); // Speichere die Daten in der ausgewählten CSV-Date
            }
            else
            {
                MessageBox.Show("Fehler", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


