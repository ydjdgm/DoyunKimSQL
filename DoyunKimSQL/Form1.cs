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
    }
}
