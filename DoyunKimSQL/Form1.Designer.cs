namespace DoyunKimSQL
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
            tabControlMain = new TabControl();
            tabPageKlasse = new TabPage();
            textBoxBezeichnung = new TextBox();
            labelBezeichnung = new Label();
            buttonEinfuegenKlasse = new Button();
            buttonLoeschenKlasse = new Button();
            buttonAendernKlasse = new Button();
            buttonLadenKlasse = new Button();
            dataGridViewKlasse = new DataGridView();
            tabPageSchueler = new TabPage();
            comboBoxKlasse = new ComboBox();
            labelKlasse = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxNachname = new TextBox();
            labelNachname = new Label();
            textBoxVorname = new TextBox();
            labelVorname = new Label();
            buttonEinfuegenSchueler = new Button();
            buttonLoeschenSchueler = new Button();
            buttonAendernSchueler = new Button();
            buttonLadenSchueler = new Button();
            dataGridViewSchueler = new DataGridView();
            tabPageWorkshop = new TabPage();
            textBoxSchwerpunkt = new TextBox();
            label8 = new Label();
            numericUpDownTeilnehmerMax = new NumericUpDown();
            label7 = new Label();
            numericUpDownTeilnehmerMin = new NumericUpDown();
            label6 = new Label();
            textBoxVoraussetzung = new TextBox();
            label5 = new Label();
            textBoxBeschreibung = new TextBox();
            label4 = new Label();
            numericUpDownKosten = new NumericUpDown();
            label3 = new Label();
            numericUpDownNr = new NumericUpDown();
            textBoxTitel = new TextBox();
            label2 = new Label();
            label1 = new Label();
            buttonEinfuegenWorkshop = new Button();
            buttonLoeschenWorkshop = new Button();
            buttonAendernWorkshop = new Button();
            buttonLadenWorkshop = new Button();
            dataGridViewWorkshop = new DataGridView();
            tabControlMain.SuspendLayout();
            tabPageKlasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKlasse).BeginInit();
            tabPageSchueler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchueler).BeginInit();
            tabPageWorkshop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTeilnehmerMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTeilnehmerMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKosten).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkshop).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageKlasse);
            tabControlMain.Controls.Add(tabPageSchueler);
            tabControlMain.Controls.Add(tabPageWorkshop);
            tabControlMain.Location = new Point(12, 12);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1279, 711);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageKlasse
            // 
            tabPageKlasse.Controls.Add(textBoxBezeichnung);
            tabPageKlasse.Controls.Add(labelBezeichnung);
            tabPageKlasse.Controls.Add(buttonEinfuegenKlasse);
            tabPageKlasse.Controls.Add(buttonLoeschenKlasse);
            tabPageKlasse.Controls.Add(buttonAendernKlasse);
            tabPageKlasse.Controls.Add(buttonLadenKlasse);
            tabPageKlasse.Controls.Add(dataGridViewKlasse);
            tabPageKlasse.Location = new Point(4, 24);
            tabPageKlasse.Name = "tabPageKlasse";
            tabPageKlasse.Padding = new Padding(3);
            tabPageKlasse.Size = new Size(1271, 683);
            tabPageKlasse.TabIndex = 0;
            tabPageKlasse.Text = "Klasse";
            tabPageKlasse.UseVisualStyleBackColor = true;
            // 
            // textBoxBezeichnung
            // 
            textBoxBezeichnung.Location = new Point(1061, 126);
            textBoxBezeichnung.Margin = new Padding(3, 2, 3, 2);
            textBoxBezeichnung.Name = "textBoxBezeichnung";
            textBoxBezeichnung.Size = new Size(110, 23);
            textBoxBezeichnung.TabIndex = 6;
            // 
            // labelBezeichnung
            // 
            labelBezeichnung.AutoSize = true;
            labelBezeichnung.Location = new Point(1061, 109);
            labelBezeichnung.Name = "labelBezeichnung";
            labelBezeichnung.Size = new Size(76, 15);
            labelBezeichnung.TabIndex = 5;
            labelBezeichnung.Text = "Bezeichnung";
            // 
            // buttonEinfuegenKlasse
            // 
            buttonEinfuegenKlasse.Location = new Point(1061, 85);
            buttonEinfuegenKlasse.Margin = new Padding(3, 2, 3, 2);
            buttonEinfuegenKlasse.Name = "buttonEinfuegenKlasse";
            buttonEinfuegenKlasse.Size = new Size(82, 22);
            buttonEinfuegenKlasse.TabIndex = 4;
            buttonEinfuegenKlasse.Text = "Einfügen";
            buttonEinfuegenKlasse.UseVisualStyleBackColor = true;
            // 
            // buttonLoeschenKlasse
            // 
            buttonLoeschenKlasse.Location = new Point(1061, 58);
            buttonLoeschenKlasse.Margin = new Padding(3, 2, 3, 2);
            buttonLoeschenKlasse.Name = "buttonLoeschenKlasse";
            buttonLoeschenKlasse.Size = new Size(82, 22);
            buttonLoeschenKlasse.TabIndex = 3;
            buttonLoeschenKlasse.Text = "Löschen";
            buttonLoeschenKlasse.UseVisualStyleBackColor = true;
            // 
            // buttonAendernKlasse
            // 
            buttonAendernKlasse.Location = new Point(1061, 32);
            buttonAendernKlasse.Margin = new Padding(3, 2, 3, 2);
            buttonAendernKlasse.Name = "buttonAendernKlasse";
            buttonAendernKlasse.Size = new Size(82, 22);
            buttonAendernKlasse.TabIndex = 2;
            buttonAendernKlasse.Text = "Ändern";
            buttonAendernKlasse.UseVisualStyleBackColor = true;
            buttonAendernKlasse.Click += buttonAendernKlasse_Click;
            // 
            // buttonLadenKlasse
            // 
            buttonLadenKlasse.Location = new Point(1061, 6);
            buttonLadenKlasse.Margin = new Padding(3, 2, 3, 2);
            buttonLadenKlasse.Name = "buttonLadenKlasse";
            buttonLadenKlasse.Size = new Size(82, 22);
            buttonLadenKlasse.TabIndex = 1;
            buttonLadenKlasse.Text = "Laden";
            buttonLadenKlasse.UseVisualStyleBackColor = true;
            buttonLadenKlasse.Click += buttonLadenKlasse_Click;
            // 
            // dataGridViewKlasse
            // 
            dataGridViewKlasse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKlasse.Location = new Point(6, 6);
            dataGridViewKlasse.Name = "dataGridViewKlasse";
            dataGridViewKlasse.RowHeadersWidth = 51;
            dataGridViewKlasse.Size = new Size(1050, 671);
            dataGridViewKlasse.TabIndex = 0;
            // 
            // tabPageSchueler
            // 
            tabPageSchueler.Controls.Add(comboBoxKlasse);
            tabPageSchueler.Controls.Add(labelKlasse);
            tabPageSchueler.Controls.Add(textBoxEmail);
            tabPageSchueler.Controls.Add(labelEmail);
            tabPageSchueler.Controls.Add(textBoxNachname);
            tabPageSchueler.Controls.Add(labelNachname);
            tabPageSchueler.Controls.Add(textBoxVorname);
            tabPageSchueler.Controls.Add(labelVorname);
            tabPageSchueler.Controls.Add(buttonEinfuegenSchueler);
            tabPageSchueler.Controls.Add(buttonLoeschenSchueler);
            tabPageSchueler.Controls.Add(buttonAendernSchueler);
            tabPageSchueler.Controls.Add(buttonLadenSchueler);
            tabPageSchueler.Controls.Add(dataGridViewSchueler);
            tabPageSchueler.Location = new Point(4, 24);
            tabPageSchueler.Name = "tabPageSchueler";
            tabPageSchueler.Padding = new Padding(3);
            tabPageSchueler.Size = new Size(1271, 683);
            tabPageSchueler.TabIndex = 1;
            tabPageSchueler.Text = "Schueler";
            tabPageSchueler.UseVisualStyleBackColor = true;
            // 
            // comboBoxKlasse
            // 
            comboBoxKlasse.FormattingEnabled = true;
            comboBoxKlasse.Location = new Point(1061, 252);
            comboBoxKlasse.Margin = new Padding(3, 2, 3, 2);
            comboBoxKlasse.Name = "comboBoxKlasse";
            comboBoxKlasse.Size = new Size(133, 23);
            comboBoxKlasse.TabIndex = 16;
            // 
            // labelKlasse
            // 
            labelKlasse.AutoSize = true;
            labelKlasse.Location = new Point(1061, 235);
            labelKlasse.Name = "labelKlasse";
            labelKlasse.Size = new Size(39, 15);
            labelKlasse.TabIndex = 15;
            labelKlasse.Text = "Klasse";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(1061, 210);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(110, 23);
            textBoxEmail.TabIndex = 14;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(1061, 193);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 13;
            labelEmail.Text = "Email";
            // 
            // textBoxNachname
            // 
            textBoxNachname.Location = new Point(1061, 168);
            textBoxNachname.Margin = new Padding(3, 2, 3, 2);
            textBoxNachname.Name = "textBoxNachname";
            textBoxNachname.Size = new Size(110, 23);
            textBoxNachname.TabIndex = 12;
            // 
            // labelNachname
            // 
            labelNachname.AutoSize = true;
            labelNachname.Location = new Point(1061, 151);
            labelNachname.Name = "labelNachname";
            labelNachname.Size = new Size(65, 15);
            labelNachname.TabIndex = 11;
            labelNachname.Text = "Nachname";
            // 
            // textBoxVorname
            // 
            textBoxVorname.Location = new Point(1061, 126);
            textBoxVorname.Margin = new Padding(3, 2, 3, 2);
            textBoxVorname.Name = "textBoxVorname";
            textBoxVorname.Size = new Size(110, 23);
            textBoxVorname.TabIndex = 10;
            // 
            // labelVorname
            // 
            labelVorname.AutoSize = true;
            labelVorname.Location = new Point(1061, 109);
            labelVorname.Name = "labelVorname";
            labelVorname.Size = new Size(56, 15);
            labelVorname.TabIndex = 9;
            labelVorname.Text = "Vorname";
            // 
            // buttonEinfuegenSchueler
            // 
            buttonEinfuegenSchueler.Location = new Point(1061, 85);
            buttonEinfuegenSchueler.Margin = new Padding(3, 2, 3, 2);
            buttonEinfuegenSchueler.Name = "buttonEinfuegenSchueler";
            buttonEinfuegenSchueler.Size = new Size(82, 22);
            buttonEinfuegenSchueler.TabIndex = 8;
            buttonEinfuegenSchueler.Text = "Einfügen";
            buttonEinfuegenSchueler.UseVisualStyleBackColor = true;
            // 
            // buttonLoeschenSchueler
            // 
            buttonLoeschenSchueler.Location = new Point(1061, 58);
            buttonLoeschenSchueler.Margin = new Padding(3, 2, 3, 2);
            buttonLoeschenSchueler.Name = "buttonLoeschenSchueler";
            buttonLoeschenSchueler.Size = new Size(82, 22);
            buttonLoeschenSchueler.TabIndex = 7;
            buttonLoeschenSchueler.Text = "Löschen";
            buttonLoeschenSchueler.UseVisualStyleBackColor = true;
            // 
            // buttonAendernSchueler
            // 
            buttonAendernSchueler.Location = new Point(1061, 32);
            buttonAendernSchueler.Margin = new Padding(3, 2, 3, 2);
            buttonAendernSchueler.Name = "buttonAendernSchueler";
            buttonAendernSchueler.Size = new Size(82, 22);
            buttonAendernSchueler.TabIndex = 6;
            buttonAendernSchueler.Text = "Ändern";
            buttonAendernSchueler.UseVisualStyleBackColor = true;
            // 
            // buttonLadenSchueler
            // 
            buttonLadenSchueler.Location = new Point(1061, 6);
            buttonLadenSchueler.Margin = new Padding(3, 2, 3, 2);
            buttonLadenSchueler.Name = "buttonLadenSchueler";
            buttonLadenSchueler.Size = new Size(82, 22);
            buttonLadenSchueler.TabIndex = 5;
            buttonLadenSchueler.Text = "Laden";
            buttonLadenSchueler.UseVisualStyleBackColor = true;
            buttonLadenSchueler.Click += buttonLadenSchueler_Click;
            // 
            // dataGridViewSchueler
            // 
            dataGridViewSchueler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchueler.Location = new Point(6, 6);
            dataGridViewSchueler.Name = "dataGridViewSchueler";
            dataGridViewSchueler.RowHeadersWidth = 51;
            dataGridViewSchueler.Size = new Size(1050, 671);
            dataGridViewSchueler.TabIndex = 1;
            // 
            // tabPageWorkshop
            // 
            tabPageWorkshop.Controls.Add(textBoxSchwerpunkt);
            tabPageWorkshop.Controls.Add(label8);
            tabPageWorkshop.Controls.Add(numericUpDownTeilnehmerMax);
            tabPageWorkshop.Controls.Add(label7);
            tabPageWorkshop.Controls.Add(numericUpDownTeilnehmerMin);
            tabPageWorkshop.Controls.Add(label6);
            tabPageWorkshop.Controls.Add(textBoxVoraussetzung);
            tabPageWorkshop.Controls.Add(label5);
            tabPageWorkshop.Controls.Add(textBoxBeschreibung);
            tabPageWorkshop.Controls.Add(label4);
            tabPageWorkshop.Controls.Add(numericUpDownKosten);
            tabPageWorkshop.Controls.Add(label3);
            tabPageWorkshop.Controls.Add(numericUpDownNr);
            tabPageWorkshop.Controls.Add(textBoxTitel);
            tabPageWorkshop.Controls.Add(label2);
            tabPageWorkshop.Controls.Add(label1);
            tabPageWorkshop.Controls.Add(buttonEinfuegenWorkshop);
            tabPageWorkshop.Controls.Add(buttonLoeschenWorkshop);
            tabPageWorkshop.Controls.Add(buttonAendernWorkshop);
            tabPageWorkshop.Controls.Add(buttonLadenWorkshop);
            tabPageWorkshop.Controls.Add(dataGridViewWorkshop);
            tabPageWorkshop.Location = new Point(4, 24);
            tabPageWorkshop.Name = "tabPageWorkshop";
            tabPageWorkshop.Padding = new Padding(3);
            tabPageWorkshop.Size = new Size(1271, 683);
            tabPageWorkshop.TabIndex = 2;
            tabPageWorkshop.Text = "Workshop";
            tabPageWorkshop.UseVisualStyleBackColor = true;
            // 
            // textBoxSchwerpunkt
            // 
            textBoxSchwerpunkt.Location = new Point(1061, 428);
            textBoxSchwerpunkt.Margin = new Padding(3, 2, 3, 2);
            textBoxSchwerpunkt.Name = "textBoxSchwerpunkt";
            textBoxSchwerpunkt.Size = new Size(110, 23);
            textBoxSchwerpunkt.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1062, 411);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 24;
            label8.Text = "Schwerpunkt";
            // 
            // numericUpDownTeilnehmerMax
            // 
            numericUpDownTeilnehmerMax.Location = new Point(1062, 385);
            numericUpDownTeilnehmerMax.Name = "numericUpDownTeilnehmerMax";
            numericUpDownTeilnehmerMax.Size = new Size(120, 23);
            numericUpDownTeilnehmerMax.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1062, 367);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 22;
            label7.Text = "TeilnehmerMax";
            // 
            // numericUpDownTeilnehmerMin
            // 
            numericUpDownTeilnehmerMin.Location = new Point(1060, 341);
            numericUpDownTeilnehmerMin.Name = "numericUpDownTeilnehmerMin";
            numericUpDownTeilnehmerMin.Size = new Size(120, 23);
            numericUpDownTeilnehmerMin.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1060, 323);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 20;
            label6.Text = "TeilnehmerMin";
            // 
            // textBoxVoraussetzung
            // 
            textBoxVoraussetzung.Location = new Point(1060, 298);
            textBoxVoraussetzung.Margin = new Padding(3, 2, 3, 2);
            textBoxVoraussetzung.Name = "textBoxVoraussetzung";
            textBoxVoraussetzung.Size = new Size(110, 23);
            textBoxVoraussetzung.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1061, 281);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 18;
            label5.Text = "Voraussetzung";
            // 
            // textBoxBeschreibung
            // 
            textBoxBeschreibung.Location = new Point(1060, 256);
            textBoxBeschreibung.Margin = new Padding(3, 2, 3, 2);
            textBoxBeschreibung.Name = "textBoxBeschreibung";
            textBoxBeschreibung.Size = new Size(110, 23);
            textBoxBeschreibung.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1061, 239);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 16;
            label4.Text = "Beschreibung";
            // 
            // numericUpDownKosten
            // 
            numericUpDownKosten.Location = new Point(1061, 213);
            numericUpDownKosten.Name = "numericUpDownKosten";
            numericUpDownKosten.Size = new Size(120, 23);
            numericUpDownKosten.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1062, 195);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 14;
            label3.Text = "Kosten";
            // 
            // numericUpDownNr
            // 
            numericUpDownNr.Location = new Point(1061, 127);
            numericUpDownNr.Name = "numericUpDownNr";
            numericUpDownNr.Size = new Size(120, 23);
            numericUpDownNr.TabIndex = 13;
            // 
            // textBoxTitel
            // 
            textBoxTitel.Location = new Point(1061, 170);
            textBoxTitel.Margin = new Padding(3, 2, 3, 2);
            textBoxTitel.Name = "textBoxTitel";
            textBoxTitel.Size = new Size(110, 23);
            textBoxTitel.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1062, 153);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 11;
            label2.Text = "Titel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1061, 109);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 9;
            label1.Text = "Nr";
            // 
            // buttonEinfuegenWorkshop
            // 
            buttonEinfuegenWorkshop.Location = new Point(1061, 85);
            buttonEinfuegenWorkshop.Margin = new Padding(3, 2, 3, 2);
            buttonEinfuegenWorkshop.Name = "buttonEinfuegenWorkshop";
            buttonEinfuegenWorkshop.Size = new Size(82, 22);
            buttonEinfuegenWorkshop.TabIndex = 8;
            buttonEinfuegenWorkshop.Text = "Einfügen";
            buttonEinfuegenWorkshop.UseVisualStyleBackColor = true;
            // 
            // buttonLoeschenWorkshop
            // 
            buttonLoeschenWorkshop.Location = new Point(1061, 58);
            buttonLoeschenWorkshop.Margin = new Padding(3, 2, 3, 2);
            buttonLoeschenWorkshop.Name = "buttonLoeschenWorkshop";
            buttonLoeschenWorkshop.Size = new Size(82, 22);
            buttonLoeschenWorkshop.TabIndex = 7;
            buttonLoeschenWorkshop.Text = "Löschen";
            buttonLoeschenWorkshop.UseVisualStyleBackColor = true;
            // 
            // buttonAendernWorkshop
            // 
            buttonAendernWorkshop.Location = new Point(1061, 32);
            buttonAendernWorkshop.Margin = new Padding(3, 2, 3, 2);
            buttonAendernWorkshop.Name = "buttonAendernWorkshop";
            buttonAendernWorkshop.Size = new Size(82, 22);
            buttonAendernWorkshop.TabIndex = 6;
            buttonAendernWorkshop.Text = "Ändern";
            buttonAendernWorkshop.UseVisualStyleBackColor = true;
            // 
            // buttonLadenWorkshop
            // 
            buttonLadenWorkshop.Location = new Point(1061, 6);
            buttonLadenWorkshop.Margin = new Padding(3, 2, 3, 2);
            buttonLadenWorkshop.Name = "buttonLadenWorkshop";
            buttonLadenWorkshop.Size = new Size(82, 22);
            buttonLadenWorkshop.TabIndex = 5;
            buttonLadenWorkshop.Text = "Laden";
            buttonLadenWorkshop.UseVisualStyleBackColor = true;
            buttonLadenWorkshop.Click += buttonLadenWorkshop_Click;
            // 
            // dataGridViewWorkshop
            // 
            dataGridViewWorkshop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorkshop.Location = new Point(6, 6);
            dataGridViewWorkshop.Name = "dataGridViewWorkshop";
            dataGridViewWorkshop.RowHeadersWidth = 51;
            dataGridViewWorkshop.Size = new Size(1050, 671);
            dataGridViewWorkshop.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 735);
            Controls.Add(tabControlMain);
            Name = "Form1";
            Text = "Form1";
            tabControlMain.ResumeLayout(false);
            tabPageKlasse.ResumeLayout(false);
            tabPageKlasse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKlasse).EndInit();
            tabPageSchueler.ResumeLayout(false);
            tabPageSchueler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchueler).EndInit();
            tabPageWorkshop.ResumeLayout(false);
            tabPageWorkshop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTeilnehmerMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTeilnehmerMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKosten).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNr).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkshop).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageKlasse;
        private TabPage tabPageSchueler;
        private TabPage tabPageWorkshop;
        private DataGridView dataGridViewKlasse;
        private DataGridView dataGridViewSchueler;
        private DataGridView dataGridViewWorkshop;
        private Button buttonLoeschenKlasse;
        private Button buttonAendernKlasse;
        private Button buttonLadenKlasse;
        private Button buttonEinfuegenKlasse;
        private Button buttonEinfuegenSchueler;
        private Button buttonLoeschenSchueler;
        private Button buttonAendernSchueler;
        private Button buttonLadenSchueler;
        private Button buttonEinfuegenWorkshop;
        private Button buttonLoeschenWorkshop;
        private Button buttonAendernWorkshop;
        private Button buttonLadenWorkshop;
        private Label labelBezeichnung;
        private TextBox textBoxBezeichnung;
        private ComboBox comboBoxKlasse;
        private Label labelKlasse;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxNachname;
        private Label labelNachname;
        private TextBox textBoxVorname;
        private Label labelVorname;
        private TextBox textBoxTitel;
        private Label label2;
        private Label label1;
        private TextBox textBoxSchwerpunkt;
        private Label label8;
        private NumericUpDown numericUpDownTeilnehmerMax;
        private Label label7;
        private NumericUpDown numericUpDownTeilnehmerMin;
        private Label label6;
        private TextBox textBoxVoraussetzung;
        private Label label5;
        private TextBox textBoxBeschreibung;
        private Label label4;
        private NumericUpDown numericUpDownKosten;
        private Label label3;
        private NumericUpDown numericUpDownNr;
    }
}
