using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace filoGroupByB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var fvi = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
            this.Text = fvi.ProductName;
            this.ttInfo.SetToolTip(pbInfo
                , "Crea un file per ciascuno dei selezionati, in cui i dati nella colonna A " + System.Environment.NewLine +
                "sono da raggruppare per la colonna B." + System.Environment.NewLine +                
                "Nella colonna B del file risultato vengono riportati i dati della colonna A" + System.Environment.NewLine +
                "(del file originale), separati da virgola.");
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFile.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.OK && openFile.FileNames.Length == 0)
            {
                MessageBox.Show("Nessun file selezionato.");
                return;
            }

            label1.Text = openFile.FileNames[0];
            foreach (var fileName in openFile.FileNames)
            {
                Dictionary<string, string> data = new Dictionary<string, string>();
                string[] separator = null;

                using (StreamReader sr = File.OpenText(fileName))
                {
                    string fileMemory = sr.ReadToEnd();
                    //abbiamo le linee
                    string[] lines = fileMemory.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                    int idxStart = cbIntestazioni.Checked ? 1 : 0;

                    if (rbSep.Checked)
                        separator = new string[] { "\t" };
                    else if (rbSep2.Checked)
                        separator = new string[] { " " };
                    else if (rbSep3.Checked)
                        separator = new string[] { txSeparatore.Text };
                    
                    for (int i = idxStart; i < lines.Length; i++)			
                    {
                        string[] riga = lines[i].Split(separator, StringSplitOptions.None);
                        if (riga.Length > 1)
                        {
                            if (!data.ContainsKey(riga[1]))
                                data.Add(riga[1], riga[0]);
                            else
                                data[riga[1]] += "," + riga[0];
                        }
                        
                    }


                }

                if (data.Keys.Count > 0)
                {
                    writeFile(fileName + ".filo", separator[0], data);
                }
            }

            MessageBox.Show("Elaborazione terminata");
        }

        private void writeFile(string fileName, string separator, Dictionary<string, string> dati)
        {
            if(File.Exists(fileName))
                File.Delete(fileName);

            File.WriteAllLines(fileName,
                dati.Select(x => x.Key + separator + x.Value));
        }
    }
}
