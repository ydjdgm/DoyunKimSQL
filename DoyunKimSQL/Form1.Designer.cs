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
            tabControlMain.SuspendLayout();
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
            tabPageWorkshop.Location = new Point(4, 24);
            tabPageWorkshop.Name = "tabPageWorkshop";
            tabPageWorkshop.Padding = new Padding(3);
            tabPageWorkshop.Size = new Size(1271, 683);
            tabPageWorkshop.TabIndex = 2;
            tabPageWorkshop.Text = "Workshop";
            tabPageWorkshop.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageKlasse;
        private TabPage tabPageSchueler;
        private TabPage tabPageWorkshop;
    }
}
