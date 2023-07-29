using System.Text;

namespace Mehrwertsteuerermittlung
{
    public partial class Form1 : Form
    {
        private string csvFilePath = ""; //Pfad zur ausgew�hlten CSV-Datei
        public Form1()
        {
            InitializeComponent();
        }


        //Event-Handler f�r den "Berechnen"-Button
        private void btn_berechnen_Click(object sender, EventArgs e)
        {
            string inputText = txt_BetragInput.Text;
            decimal mwst7 = 1.07m;
            decimal mwst19 = 1.19m;

            if (decimal.TryParse(inputText, out decimal betrag))
            {
                // Berechne Mehrwertsteuer und Nettobetrag basierend auf dem ausgew�hlten Radiobutton
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
                MessageBox.Show("Ung�ltige Eingabe! Bitte geben Sie eine Zahl ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Event-Handler f�r den "Datei ausw�hlen"-Button
        private void btn_SelectAndSaveInCSV_Click(object sender, EventArgs e) // Name �ndern dieser Methode
        {
            // �ffnet einen Dateiauswahldialog zum Ausw�hlen der CSV-Datei
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSV Datei (*.csv)|*.csv";
                dialog.OverwritePrompt = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // �berpr�fe, ob die ausgew�hlte Datei eine CSV-Datei ist
                    if (Path.GetExtension(dialog.FileName).Equals(".csv", StringComparison.OrdinalIgnoreCase))
                    {
                        csvFilePath = dialog.FileName; // Speichere den ausgew�hlten Pfad in der Klassenvariable
                        txt_dateiName.Text = Path.GetFileName(csvFilePath); // Zeige den Dateinamen in der TextBox an
                    }
                }
            }
        }

        // Speichert die Daten in der ausgew�hlten CSV-Datei
        private void SaveInCSV(DateTime date, decimal bruttobetrag, string mwstRate, decimal nettobetrag)
        {
            try
            {
                nettobetrag = Math.Round(nettobetrag, 2); // Runde den Nettobetrag auf 2 Nachkommastellen

                bool isFileEmpty = new FileInfo(csvFilePath).Length == 0;
                using (StreamWriter writer = new StreamWriter(csvFilePath, true, Encoding.UTF8))
                {
                    // Wenn die Datei leer ist, schreibe eine �berschrift
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


                MessageBox.Show("Daten wurden erfolgreich in die CSV-Datei hinzugef�gt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Speichern in die CSV- Datei: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_BetragInput.Clear();
            txt_BetragOutput.Clear();
        }
        // Event-Handler f�r den "CSV-Datei erstellen"-Button
        private void btn_CreateCSVFile_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // �ffne Form2 (neues Fenster) f�r die Erstellung einer CSV-Datei
            form2.ShowDialog();
        }

        // Event-Handler f�r den "Schlie�en"-Button
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (csvFilePath == "")
            {
                MessageBox.Show("Bitte W�hlen Sie eine Datei aus, um die Daten zu Speichern.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string bruttoBetrag = txt_BetragInput.Text;

            if (decimal.TryParse(bruttoBetrag, out decimal betrag))
            {
                string mwstRate = rBtn_Seven.Checked ? "7%" : "19%";
                decimal nettoBetrag = decimal.Parse(txt_BetragOutput.Text);


                SaveInCSV(DateTime.Now, betrag, mwstRate, nettoBetrag); // Speichere die Daten in der ausgew�hlten CSV-Date
            }
            else
            {
                MessageBox.Show("Fehler", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


