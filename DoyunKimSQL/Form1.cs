using System.Data;

namespace DoyunKimSQL
{
    public partial class Form1 : Form, IView
    {
        public IModel Model { get; set; }
        public IController Controller { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public void SetGridData()
        {
            dataGridViewKlasse.DataSource = null;
            dataGridViewSchueler.DataSource = null;
            dataGridViewWorkshop.DataSource = null;
            dataGridViewKlasse.DataSource = Controller.LadenKlasse();
            dataGridViewSchueler.DataSource = Controller.LadenSchueler();
            dataGridViewWorkshop.DataSource = Controller.LadenWorkshop();
        }

        private void buttonLadenKlasse_Click(object sender, EventArgs e)
        {
            SetGridData();
        }

        private void buttonLadenSchueler_Click(object sender, EventArgs e)
        {
            SetGridData();
        }

        private void buttonLadenWorkshop_Click(object sender, EventArgs e)
        {
            SetGridData();
        }

        private void buttonAendernKlasse_Click(object sender, EventArgs e)
        {
            DataTable currentData = dataGridViewKlasse.DataSource as DataTable;

            if (currentData != null)
            {
                DataTable changedData = currentData.GetChanges();

                if (changedData != null && changedData.Rows.Count > 0)
                {
                    List<Klasse> changedKlassen = new List<Klasse>();

                    foreach (DataRow row in changedData.Rows)
                    {
                        Klasse klasse = new Klasse();
                        klasse.KlasseID = Convert.ToInt32(row["KlasseID"]);
                        klasse.Bezeichnung = row["Bezeichnung"].ToString();

                        changedKlassen.Add(klasse);
                    }

                    Controller.AendernKlasse(changedKlassen);
                }
            }
            Controller.LadenKlasse();
            SetGridData();
        }
    }
}
