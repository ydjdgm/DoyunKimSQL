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
            tabPageSchueler = new TabPage();
            tabPageWorkshop = new TabPage();
            dataGridViewKlasse = new DataGridView();
            dataGridViewSchueler = new DataGridView();
            dataGridViewWorkshop = new DataGridView();
            tabControlMain.SuspendLayout();
            tabPageKlasse.SuspendLayout();
            tabPageSchueler.SuspendLayout();
            tabPageWorkshop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKlasse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchueler).BeginInit();
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
            tabPageKlasse.Controls.Add(dataGridViewKlasse);
            tabPageKlasse.Location = new Point(4, 24);
            tabPageKlasse.Name = "tabPageKlasse";
            tabPageKlasse.Padding = new Padding(3);
            tabPageKlasse.Size = new Size(1271, 683);
            tabPageKlasse.TabIndex = 0;
            tabPageKlasse.Text = "Klasse";
            tabPageKlasse.UseVisualStyleBackColor = true;
            // 
            // tabPageSchueler
            // 
            tabPageSchueler.Controls.Add(dataGridViewSchueler);
            tabPageSchueler.Location = new Point(4, 24);
            tabPageSchueler.Name = "tabPageSchueler";
            tabPageSchueler.Padding = new Padding(3);
            tabPageSchueler.Size = new Size(1271, 683);
            tabPageSchueler.TabIndex = 1;
            tabPageSchueler.Text = "Schueler";
            tabPageSchueler.UseVisualStyleBackColor = true;
            // 
            // tabPageWorkshop
            // 
            tabPageWorkshop.Controls.Add(dataGridViewWorkshop);
            tabPageWorkshop.Location = new Point(4, 24);
            tabPageWorkshop.Name = "tabPageWorkshop";
            tabPageWorkshop.Padding = new Padding(3);
            tabPageWorkshop.Size = new Size(1271, 683);
            tabPageWorkshop.TabIndex = 2;
            tabPageWorkshop.Text = "Workshop";
            tabPageWorkshop.UseVisualStyleBackColor = true;
            // 
            // dataGridViewKlasse
            // 
            dataGridViewKlasse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKlasse.Location = new Point(6, 6);
            dataGridViewKlasse.Name = "dataGridViewKlasse";
            dataGridViewKlasse.Size = new Size(595, 671);
            dataGridViewKlasse.TabIndex = 0;
            // 
            // dataGridViewSchueler
            // 
            dataGridViewSchueler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchueler.Location = new Point(6, 6);
            dataGridViewSchueler.Name = "dataGridViewSchueler";
            dataGridViewSchueler.Size = new Size(595, 671);
            dataGridViewSchueler.TabIndex = 1;
            // 
            // dataGridViewWorkshop
            // 
            dataGridViewWorkshop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWorkshop.Location = new Point(6, 6);
            dataGridViewWorkshop.Name = "dataGridViewWorkshop";
            dataGridViewWorkshop.Size = new Size(595, 671);
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
            tabPageSchueler.ResumeLayout(false);
            tabPageWorkshop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKlasse).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchueler).EndInit();
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
    }
}
