using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoyunKimSQL
{
    internal class Controller: IController
    {
        public IModel Model { get; set; }
        public IView View { get; set; }

        public List<Klasse> LadenKlasse()
        {
            return Model.GetKlasse();
        }
        public List<Schueler> LadenSchueler()
        {
            return Model.GetSchueler();
        }
        public List<Workshop> LadenWorkshop()
        {
            return Model.GetWorkshop();
        }
        public void AendernKlasse(List<Klasse> klassen)
        {
            Model.AendernKlasse(klassen);
        }
    }
}
