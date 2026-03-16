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
            buttonEinfuegenKlasse = new Button();
            buttonLoeschenKlasse = new Button();
            buttonAendernKlasse = new Button();
            buttonLadenKlasse = new Button();
            dataGridViewKlasse = new DataGridView();
            tabPageSchueler = new TabPage();
            buttonEinfuegenSchueler = new Button();
            buttonLoeschenSchueler = new Button();
            buttonAendernSchueler = new Button();
            buttonLadenSchueler = new Button();
            dataGridViewSchueler = new DataGridView();
            tabPageWorkshop = new TabPage();
            buttonEinfuegenWorkshop = new Button();
            buttonLoeschenWorkshop = new Button();
            buttonAendernWorkshop = new Button();
            buttonLadenWorkshop = new Button();
            dataGridViewWorkshop = new DataGridView();
            labelBezeichnung = new Label();
            textBoxBezeichnung = new TextBox();
            labelVorname = new Label();
            textBoxVorname = new TextBox();
            textBoxNachname = new TextBox();
            labelNachname = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelKlasse = new Label();
            comboBoxKlasse = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            tabControlMain.SuspendLayout();
            tabPageKlasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKlasse).BeginInit();
            tabPageSchueler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchueler).BeginInit();
            tabPageWorkshop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWorkshop).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageKlasse);
            tabControlMain.Controls.Add(tabPageSchueler);
            tabControlMain.Controls.Add(tabPageWorkshop);
            tabControlMain.Location = new Point(14, 16);
            tabControlMain.Margin = new Padding(3, 4, 3, 4);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1462, 948);
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
            tabPageKlasse.Location = new Point(4, 29);
            tabPageKlasse.Margin = new Padding(3, 4, 3, 4);
            tabPageKlasse.Name = "tabPageKlasse";
            tabPageKlasse.Padding = new Padding(3, 4, 3, 4);
            tabPageKlasse.Size = new Size(1454, 915);
            tabPageKlasse.TabIndex = 0;
            tabPageKlasse.Text = "Klasse";
            tabPageKlasse.UseVisualStyleBackColor = true;
            // 
            // buttonEinfuegenKlasse
            // 
            buttonEinfuegenKlasse.Location = new Point(1213, 113);
            buttonEinfuegenKlasse.Name = "buttonEinfuegenKlasse";
            buttonEinfuegenKlasse.Size = new Size(94, 29);
            buttonEinfuegenKlasse.TabIndex = 4;
            buttonEinfuegenKlasse.Text = "Einfügen";
            buttonEinfuegenKlasse.UseVisualStyleBackColor = true;
            // 
            // buttonLoeschenKlasse
            // 
            buttonLoeschenKlasse.Location = new Point(1213, 78);
            buttonLoeschenKlasse.Name = "buttonLoeschenKlasse";
            buttonLoeschenKlasse.Size = new Size(94, 29);
            buttonLoeschenKlasse.TabIndex = 3;
            buttonLoeschenKlasse.Text = "Löschen";
            buttonLoeschenKlasse.UseVisualStyleBackColor = true;
            // 
            // buttonAendernKlasse
            // 
            buttonAendernKlasse.Location = new Point(1213, 43);
            buttonAendernKlasse.Name = "buttonAendernKlasse";
            buttonAendernKlasse.Size = new Size(94, 29);
            buttonAendernKlasse.TabIndex = 2;
            buttonAendernKlasse.Text = "Ändern";
            buttonAendernKlasse.UseVisualStyleBackColor = true;
            // 
            // buttonLadenKlasse
            // 
            buttonLadenKlasse.Location = new Point(1213, 8);
            buttonLadenKlasse.Name = "buttonLadenKlasse";
            buttonLadenKlasse.Size = new Size(94, 29);
            buttonLadenKlasse.TabIndex = 1;
            buttonLadenKlasse.Text = "Laden";
            buttonLadenKlasse.UseVisualStyleBackColor = true;
            // 
            // dataGridViewKlasse
            // 
            dataGridViewKlasse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKlasse.Location = new Point(7, 8);
            dataGridViewKlasse.Margin = new Padding(3, 4, 3, 4);
            dataGridViewKlasse.Name = "dataGridViewKlasse";
            dataGridViewKlasse.RowHeadersWidth = 51;
            dataGridViewKlasse.Size = new Size(1200, 895);
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
            tabPageSchueler.Location = new Point(4, 29);
            tabPageSchueler.Margin = new Padding(3, 4, 3, 4);
            tabPageSchueler.Name = "tabPageSchueler";
            tabPageSchueler.Padding = new Padding(3, 4, 3, 4);
            tabPageSchueler.Size = new Size(1454, 915);
            tabPageSchueler.TabIndex = 1;
            tabPageSchueler.Text = "Schueler";
            tabPageSchueler.UseVisualStyleBackColor = true;
            // 
            // buttonEinfuegenSchueler
            // 
            buttonEinfuegenSchueler.Location = new Point(1213, 113);
            buttonEinfuegenSchueler.Name = "buttonEinfuegenSchueler";
            buttonEinfuegenSchueler.Size = new Size(94, 29);
            buttonEinfuegenSchueler.TabIndex = 8;
            buttonEinfuegenSchueler.Text = "Einfügen";
            buttonEinfuegenSchueler.UseVisualStyleBackColor = true;
            // 
            // buttonLoeschenSchueler
            // 
            buttonLoeschenSchueler.Location = new Point(1213, 78);
            buttonLoeschenSchueler.Name = "buttonLoeschenSchueler";
            buttonLoeschenSchueler.Size = new Size(94, 29);
            buttonLoeschenSchueler.TabIndex = 7;
            buttonLoeschenSchueler.Text = "Löschen";
            buttonLoeschenSchueler.UseVisualStyleBackColor = true;
            // 
            // buttonAendernSchueler
            // 
            buttonAendernSchueler.Location = new Point(1213, 43);
            buttonAendernSchueler.Name = "buttonAendernSchueler";
            buttonAendernSchueler.Size = new Size(94, 29);
            buttonAendernSchueler.TabIndex = 6;
            buttonAendernSchueler.Text = "Ändern";
            buttonAendernSchueler.UseVisualStyleBackColor = true;
            // 
            // buttonLadenSchueler
            // 
            buttonLadenSchueler.Location = new Point(1213, 8);
            buttonLadenSchueler.Name = "buttonLadenSchueler";
            buttonLadenSchueler.Size = new Size(94, 29);
            buttonLadenSchueler.TabIndex = 5;
            buttonLadenSchueler.Text = "Laden";
            buttonLadenSchueler.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSchueler
            // 
            dataGridViewSchueler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchueler.Location = new Point(7, 8);
            dataGridViewSchueler.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSchueler.Name = "dataGridViewSchueler";
            dataGridViewSchueler.RowHeadersWidth = 51;
            dataGridViewSchueler.Size = new Size(1200, 895);
            dataGridViewSchueler.TabIndex = 1;
            // 
            // tabPageWorkshop
            // 
            tabPageWorkshop.Controls.Add(textBox2);
            tabPageWorkshop.Controls.Add(label2);
            tabPageWorkshop.Controls.Add(textBox1);
            tabPageWorkshop.Controls.Add(label1);
            tabPageWorkshop.Controls.Add(buttonEinfuegenWorkshop);
            tabPageWorkshop.Controls.Add(buttonLoeschenWorkshop);
            tabPageWorkshop.Controls.Add(buttonAendernWorkshop);
            tabPageWorkshop.Controls.Add(buttonLadenWorkshop);
            tabPageWorkshop.Controls.Add(dataGridViewWorkshop);
            tabPageWorkshop.Location = new Point(4, 29);
            tabPageWorkshop.Margin = new Padding(3, 4, 3, 4);
            tabPageWorkshop.Name = "tabPageWorkshop";
            tabPageWorkshop.Padding = new Padding(3, 4, 3, 4);
            tabPageWorkshop.Size = new Size(1454, 915);
            tabPageWorkshop.TabIndex = 2;
            tabPageWorkshop.Text = "Workshop";
            tabPageWorkshop.UseVisualStyleBackColor = true;
            // 
            // buttonEinfuegenWorkshop
            // 
            buttonEinfuegenWorkshop.Location = new Point(1213, 113);
            buttonEinfuegenWorkshop.Name = "buttonEinfuegenWorkshop";
            buttonEinfuegenWorkshop.Size = new Size(94, 29);
            buttonEinfuegenWorkshop.TabIndex = 8;
            buttonEinfuegenWorkshop.Text = "Einfügen";
            buttonEinfuegenWorkshop.UseVisualStyleBackColor = true;
            // 
            // buttonLoeschenWorkshop
            // 
            buttonLoeschenWorkshop.Location = new Point(1213, 78);
            buttonLoeschenWorkshop.Name = "buttonLoeschenWorkshop";
            buttonLoeschenWorkshop.Size = new Size(94, 29);
            buttonLoeschenWorkshop.TabIndex = 7;
            buttonLoeschenWorkshop.Text = "Löschen";
            buttonLoeschenWorkshop.UseVisualStyleBackColor = true;
            // 
            // buttonAendernWorkshop
            // 
            buttonAendernWorkshop.Location = new Point(1213, 43);
            buttonAendernWorkshop.Name = "buttonAendernWorkshop";
            buttonAendernWorkshop.Size = new Size(94, 29);
            buttonAendernWorkshop.TabIndex = 6;
            buttonAendernWorkshop.Text = "Ändern";
            buttonAendernWorkshop.UseVisualStyleBackColor = true;
            // 
            // buttonLadenWorkshop
            // 
            buttonLadenWorkshop.Location = new Point(1213, 8);
            buttonLadenWorkshop.Name = "buttonLadenWorkshop";
            buttonLadenWorkshop.Size = new Size(94, 29);
            buttonLadenWorkshop.TabIndex = 5;
            buttonLadenWorkshop.Text = "Laden";
            buttonLadenWorkshop.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWorkshop
            // 
            dataGridViewWorkshop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorkshop.Location = new Point(7, 8);
            dataGridViewWorkshop.Margin = new Padding(3, 4, 3, 4);
            dataGridViewWorkshop.Name = "dataGridViewWorkshop";
            dataGridViewWorkshop.RowHeadersWidth = 51;
            dataGridViewWorkshop.Size = new Size(1200, 895);
            dataGridViewWorkshop.TabIndex = 1;
            // 
            // labelBezeichnung
            // 
            labelBezeichnung.AutoSize = true;
            labelBezeichnung.Location = new Point(1213, 145);
            labelBezeichnung.Name = "labelBezeichnung";
            labelBezeichnung.Size = new Size(93, 20);
            labelBezeichnung.TabIndex = 5;
            labelBezeichnung.Text = "Bezeichnung";
            // 
            // textBoxBezeichnung
            // 
            textBoxBezeichnung.Location = new Point(1213, 168);
            textBoxBezeichnung.Name = "textBoxBezeichnung";
            textBoxBezeichnung.Size = new Size(125, 27);
            textBoxBezeichnung.TabIndex = 6;
            // 
            // labelVorname
            // 
            labelVorname.AutoSize = true;
            labelVorname.Location = new Point(1213, 145);
            labelVorname.Name = "labelVorname";
            labelVorname.Size = new Size(68, 20);
            labelVorname.TabIndex = 9;
            labelVorname.Text = "Vorname";
            // 
            // textBoxVorname
            // 
            textBoxVorname.Location = new Point(1213, 168);
            textBoxVorname.Name = "textBoxVorname";
            textBoxVorname.Size = new Size(125, 27);
            textBoxVorname.TabIndex = 10;
            // 
            // textBoxNachname
            // 
            textBoxNachname.Location = new Point(1213, 221);
            textBoxNachname.Name = "textBoxNachname";
            textBoxNachname.Size = new Size(125, 27);
            textBoxNachname.TabIndex = 12;
            // 
            // labelNachname
            // 
            labelNachname.AutoSize = true;
            labelNachname.Location = new Point(1213, 198);
            labelNachname.Name = "labelNachname";
            labelNachname.Size = new Size(80, 20);
            labelNachname.TabIndex = 11;
            labelNachname.Text = "Nachname";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(1213, 274);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 14;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(1213, 251);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 13;
            labelEmail.Text = "Email";
            // 
            // labelKlasse
            // 
            labelKlasse.AutoSize = true;
            labelKlasse.Location = new Point(1213, 304);
            labelKlasse.Name = "labelKlasse";
            labelKlasse.Size = new Size(50, 20);
            labelKlasse.TabIndex = 15;
            labelKlasse.Text = "Klasse";
            // 
            // comboBoxKlasse
            // 
            comboBoxKlasse.FormattingEnabled = true;
            comboBoxKlasse.Location = new Point(1213, 327);
            comboBoxKlasse.Name = "comboBoxKlasse";
            comboBoxKlasse.Size = new Size(151, 28);
            comboBoxKlasse.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1213, 145);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1213, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1213, 221);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1213, 198);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 11;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 980);
            Controls.Add(tabControlMain);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}
