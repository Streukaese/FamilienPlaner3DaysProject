namespace FamilienPlaner3DaysProject
{
    partial class Hauptfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUeberschrift = new System.Windows.Forms.Label();
            this.labelNotizen = new System.Windows.Forms.Label();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.buttonAendern = new System.Windows.Forms.Button();
            this.buttonEntfernen = new System.Windows.Forms.Button();
            this.listBoxToDo = new System.Windows.Forms.ListBox();
            this.labelToDo = new System.Windows.Forms.Label();
            this.labelEndDatum = new System.Windows.Forms.Label();
            this.dateTimePickerEndDatum = new System.Windows.Forms.DateTimePicker();
            this.textBoxUeberschrift = new System.Windows.Forms.TextBox();
            this.textBoxNotizen = new System.Windows.Forms.TextBox();
            this.labelWichtigkeit = new System.Windows.Forms.Label();
            this.comboBoxWichtigkeit = new System.Windows.Forms.ComboBox();
            this.buttonExportieren = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(503, 73);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(245, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(447, 79);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelUeberschrift
            // 
            this.labelUeberschrift.AutoSize = true;
            this.labelUeberschrift.Location = new System.Drawing.Point(420, 104);
            this.labelUeberschrift.Name = "labelUeberschrift";
            this.labelUeberschrift.Size = new System.Drawing.Size(71, 16);
            this.labelUeberschrift.TabIndex = 2;
            this.labelUeberschrift.Text = "Überschrift";
            // 
            // labelNotizen
            // 
            this.labelNotizen.AutoSize = true;
            this.labelNotizen.Location = new System.Drawing.Point(440, 135);
            this.labelNotizen.Name = "labelNotizen";
            this.labelNotizen.Size = new System.Drawing.Size(52, 16);
            this.labelNotizen.TabIndex = 3;
            this.labelNotizen.Text = "Notizen";
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(423, 277);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(148, 23);
            this.buttonSpeichern.TabIndex = 4;
            this.buttonSpeichern.Text = "Hinzufügen";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // buttonAendern
            // 
            this.buttonAendern.Location = new System.Drawing.Point(577, 277);
            this.buttonAendern.Name = "buttonAendern";
            this.buttonAendern.Size = new System.Drawing.Size(171, 23);
            this.buttonAendern.TabIndex = 5;
            this.buttonAendern.Text = "Ändern";
            this.buttonAendern.UseVisualStyleBackColor = true;
            this.buttonAendern.Click += new System.EventHandler(this.buttonAendern_Click);
            // 
            // buttonEntfernen
            // 
            this.buttonEntfernen.Location = new System.Drawing.Point(421, 415);
            this.buttonEntfernen.Name = "buttonEntfernen";
            this.buttonEntfernen.Size = new System.Drawing.Size(150, 23);
            this.buttonEntfernen.TabIndex = 6;
            this.buttonEntfernen.Text = "Entfernen";
            this.buttonEntfernen.UseVisualStyleBackColor = true;
            this.buttonEntfernen.Click += new System.EventHandler(this.buttonEntfernen_Click);
            // 
            // listBoxToDo
            // 
            this.listBoxToDo.FormattingEnabled = true;
            this.listBoxToDo.ItemHeight = 16;
            this.listBoxToDo.Location = new System.Drawing.Point(16, 73);
            this.listBoxToDo.Name = "listBoxToDo";
            this.listBoxToDo.Size = new System.Drawing.Size(379, 356);
            this.listBoxToDo.TabIndex = 7;
            this.listBoxToDo.DoubleClick += new System.EventHandler(this.listBoxToDo_DoubleClick);
            // 
            // labelToDo
            // 
            this.labelToDo.AutoSize = true;
            this.labelToDo.Location = new System.Drawing.Point(13, 31);
            this.labelToDo.Name = "labelToDo";
            this.labelToDo.Size = new System.Drawing.Size(48, 16);
            this.labelToDo.TabIndex = 8;
            this.labelToDo.Text = "To Do:";
            // 
            // labelEndDatum
            // 
            this.labelEndDatum.AutoSize = true;
            this.labelEndDatum.Location = new System.Drawing.Point(418, 225);
            this.labelEndDatum.Name = "labelEndDatum";
            this.labelEndDatum.Size = new System.Drawing.Size(73, 16);
            this.labelEndDatum.TabIndex = 11;
            this.labelEndDatum.Text = "End Datum";
            // 
            // dateTimePickerEndDatum
            // 
            this.dateTimePickerEndDatum.Location = new System.Drawing.Point(503, 219);
            this.dateTimePickerEndDatum.Name = "dateTimePickerEndDatum";
            this.dateTimePickerEndDatum.Size = new System.Drawing.Size(245, 22);
            this.dateTimePickerEndDatum.TabIndex = 12;
            // 
            // textBoxUeberschrift
            // 
            this.textBoxUeberschrift.Location = new System.Drawing.Point(503, 101);
            this.textBoxUeberschrift.Name = "textBoxUeberschrift";
            this.textBoxUeberschrift.Size = new System.Drawing.Size(245, 22);
            this.textBoxUeberschrift.TabIndex = 13;
            // 
            // textBoxNotizen
            // 
            this.textBoxNotizen.Location = new System.Drawing.Point(503, 129);
            this.textBoxNotizen.Multiline = true;
            this.textBoxNotizen.Name = "textBoxNotizen";
            this.textBoxNotizen.Size = new System.Drawing.Size(245, 84);
            this.textBoxNotizen.TabIndex = 14;
            // 
            // labelWichtigkeit
            // 
            this.labelWichtigkeit.AutoSize = true;
            this.labelWichtigkeit.Location = new System.Drawing.Point(420, 250);
            this.labelWichtigkeit.Name = "labelWichtigkeit";
            this.labelWichtigkeit.Size = new System.Drawing.Size(72, 16);
            this.labelWichtigkeit.TabIndex = 15;
            this.labelWichtigkeit.Text = "Wichtigkeit";
            // 
            // comboBoxWichtigkeit
            // 
            this.comboBoxWichtigkeit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWichtigkeit.FormattingEnabled = true;
            this.comboBoxWichtigkeit.Items.AddRange(new object[] {
            "Hat zeit.",
            "Zeitnahe erledigen.",
            "Run Forrest, RUN!"});
            this.comboBoxWichtigkeit.Location = new System.Drawing.Point(503, 247);
            this.comboBoxWichtigkeit.Name = "comboBoxWichtigkeit";
            this.comboBoxWichtigkeit.Size = new System.Drawing.Size(245, 24);
            this.comboBoxWichtigkeit.TabIndex = 16;
            // 
            // buttonExportieren
            // 
            this.buttonExportieren.Location = new System.Drawing.Point(587, 415);
            this.buttonExportieren.Name = "buttonExportieren";
            this.buttonExportieren.Size = new System.Drawing.Size(201, 23);
            this.buttonExportieren.TabIndex = 17;
            this.buttonExportieren.Text = "CSV Export";
            this.buttonExportieren.UseVisualStyleBackColor = true;
            this.buttonExportieren.Click += new System.EventHandler(this.buttonExportieren_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(503, 306);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(133, 23);
            this.buttonAbbrechen.TabIndex = 18;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonExportieren);
            this.Controls.Add(this.comboBoxWichtigkeit);
            this.Controls.Add(this.labelWichtigkeit);
            this.Controls.Add(this.textBoxNotizen);
            this.Controls.Add(this.textBoxUeberschrift);
            this.Controls.Add(this.dateTimePickerEndDatum);
            this.Controls.Add(this.labelEndDatum);
            this.Controls.Add(this.labelToDo);
            this.Controls.Add(this.listBoxToDo);
            this.Controls.Add(this.buttonEntfernen);
            this.Controls.Add(this.buttonAendern);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.labelNotizen);
            this.Controls.Add(this.labelUeberschrift);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "Hauptfenster";
            this.Text = "Hauptfenster";
            this.Load += new System.EventHandler(this.Hauptfenster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUeberschrift;
        private System.Windows.Forms.Label labelNotizen;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Button buttonAendern;
        private System.Windows.Forms.Button buttonEntfernen;
        private System.Windows.Forms.ListBox listBoxToDo;
        private System.Windows.Forms.Label labelToDo;
        private System.Windows.Forms.Label labelEndDatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDatum;
        private System.Windows.Forms.TextBox textBoxUeberschrift;
        private System.Windows.Forms.TextBox textBoxNotizen;
        private System.Windows.Forms.Label labelWichtigkeit;
        private System.Windows.Forms.ComboBox comboBoxWichtigkeit;
        private System.Windows.Forms.Button buttonExportieren;
        private System.Windows.Forms.Button buttonAbbrechen;
    }
}

