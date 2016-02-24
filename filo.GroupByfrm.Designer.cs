namespace filoGroupByB
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.txSeparatore = new System.Windows.Forms.TextBox();
            this.cbIntestazioni = new System.Windows.Forms.CheckBox();
            this.rbSep = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSep2 = new System.Windows.Forms.RadioButton();
            this.rbSep3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbInfo
            // 
            this.pbInfo.Image = global::filoGroupByB.Properties.Resources.question;
            this.pbInfo.Location = new System.Drawing.Point(408, 0);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(46, 45);
            this.pbInfo.TabIndex = 0;
            this.pbInfo.TabStop = false;
            // 
            // ttInfo
            // 
            this.ttInfo.IsBalloon = true;
            // 
            // openFile
            // 
            this.openFile.FileName = "*.*";
            this.openFile.Multiselect = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "c:\\windows\\system32";
            // 
            // btOpenFile
            // 
            this.btOpenFile.Location = new System.Drawing.Point(310, 22);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(38, 23);
            this.btOpenFile.TabIndex = 2;
            this.btOpenFile.Text = "...";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // txSeparatore
            // 
            this.txSeparatore.Location = new System.Drawing.Point(200, 16);
            this.txSeparatore.MaxLength = 1;
            this.txSeparatore.Name = "txSeparatore";
            this.txSeparatore.Size = new System.Drawing.Size(24, 20);
            this.txSeparatore.TabIndex = 3;
            this.txSeparatore.Text = " ";
            this.ttInfo.SetToolTip(this.txSeparatore, "Inserire il carattere che separa i \r\ndati della colonna A dalla colonna B");
            // 
            // cbIntestazioni
            // 
            this.cbIntestazioni.AutoSize = true;
            this.cbIntestazioni.Checked = true;
            this.cbIntestazioni.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIntestazioni.Location = new System.Drawing.Point(310, 67);
            this.cbIntestazioni.Name = "cbIntestazioni";
            this.cbIntestazioni.Size = new System.Drawing.Size(110, 17);
            this.cbIntestazioni.TabIndex = 4;
            this.cbIntestazioni.Text = "ignora intestazioni";
            this.cbIntestazioni.UseVisualStyleBackColor = true;
            // 
            // rbSep
            // 
            this.rbSep.AutoSize = true;
            this.rbSep.Checked = true;
            this.rbSep.Location = new System.Drawing.Point(13, 19);
            this.rbSep.Name = "rbSep";
            this.rbSep.Size = new System.Drawing.Size(44, 17);
            this.rbSep.TabIndex = 5;
            this.rbSep.TabStop = true;
            this.rbSep.Tag = "sep";
            this.rbSep.Text = "Tab";
            this.rbSep.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSep3);
            this.groupBox1.Controls.Add(this.rbSep2);
            this.groupBox1.Controls.Add(this.rbSep);
            this.groupBox1.Controls.Add(this.txSeparatore);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 41);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Separatore";
            // 
            // rbSep2
            // 
            this.rbSep2.AutoSize = true;
            this.rbSep2.Location = new System.Drawing.Point(63, 19);
            this.rbSep2.Name = "rbSep2";
            this.rbSep2.Size = new System.Drawing.Size(57, 17);
            this.rbSep2.TabIndex = 5;
            this.rbSep2.TabStop = true;
            this.rbSep2.Tag = "sep";
            this.rbSep2.Text = "Spazio";
            this.rbSep2.UseVisualStyleBackColor = true;
            // 
            // rbSep3
            // 
            this.rbSep3.AutoSize = true;
            this.rbSep3.Location = new System.Drawing.Point(126, 19);
            this.rbSep3.Name = "rbSep3";
            this.rbSep3.Size = new System.Drawing.Size(68, 17);
            this.rbSep3.TabIndex = 5;
            this.rbSep3.TabStop = true;
            this.rbSep3.Tag = "sep";
            this.rbSep3.Text = "Carattere";
            this.rbSep3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(455, 123);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbIntestazioni);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInfo;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.TextBox txSeparatore;
        private System.Windows.Forms.CheckBox cbIntestazioni;
        private System.Windows.Forms.RadioButton rbSep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSep3;
        private System.Windows.Forms.RadioButton rbSep2;

    }
}

